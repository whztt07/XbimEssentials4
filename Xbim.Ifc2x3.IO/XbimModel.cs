﻿using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Common.Geometry;
using Xbim.Ifc2x3.ActorResource;
using Xbim.Ifc2x3.ExternalReferenceResource;
using Xbim.Ifc2x3.GeometryResource;
using Xbim.Ifc2x3.Kernel;
using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.RepresentationResource;
using Xbim.Ifc2x3.UtilityResource;
using Xbim.IO.Esent;
using Xbim.XbimExtensions;
using XbimGeometry.Interfaces;

namespace Xbim.Ifc2x3.IO
{
    public class XbimModel: EsentModel
    {
        private const string RefDocument = "XbimReferencedModel";

        public XbimModel()
        {
            var factory = new EntityFactory();
            Init(factory);
        }

        public IfcAxis2Placement WorldCoordinateSystem { get; private set; }

        private void GetModelFactors()
        {
            double angleToRadiansConversionFactor = 1; //assume radians
            double lengthToMetresConversionFactor = 1; //assume metres
            var instOfType = Instances.OfType<IfcUnitAssignment>();
            var ua = instOfType.FirstOrDefault();
            if (ua != null)
            {
                foreach (var unit in ua.Units)
                {
                    var value = 1.0;
                    var cbUnit = unit as IfcConversionBasedUnit;
                    var siUnit = unit as IfcSIUnit;
                    if (cbUnit != null)
                    {
                        var mu = cbUnit.ConversionFactor;
                        var component = mu.UnitComponent as IfcSIUnit;
                        if (component != null)
                            siUnit = component;
                        var et = ((IExpressValueType)mu.ValueComponent);

                        if (et.UnderlyingSystemType == typeof(double))
                            value *= (double)et.Value;
                        else if (et.UnderlyingSystemType == typeof(int))
                            value *= (int)et.Value;
                        else if (et.UnderlyingSystemType == typeof(long))
                            value *= (long)et.Value;
                    }
                    if (siUnit == null) continue;

                    value *= siUnit.Power;
                    switch (siUnit.UnitType)
                    {
                        case IfcUnitEnum.LENGTHUNIT:
                            lengthToMetresConversionFactor = value;
                            break;
                        case IfcUnitEnum.PLANEANGLEUNIT:
                            angleToRadiansConversionFactor = value;
                            break;
                    }
                }
            }
            var gcs =
                Instances.OfType<IfcGeometricRepresentationContext>();
            double? defaultPrecision = null;
            //get the Model precision if it is correctly defined
            foreach (var gc in gcs.Where(g => !(g is IfcGeometricRepresentationSubContext)))
            {
                if (!gc.ContextType.HasValue || string.Compare(gc.ContextType.Value, "model", true) != 0) continue;
                if (!gc.Precision.HasValue) continue;
                defaultPrecision = gc.Precision.Value;
                break;
            }
            //get the world coordinate system
            XbimMatrix3D? wcs = null;
            var context = Instances.OfType<IfcGeometricRepresentationContext>().FirstOrDefault(c =>
                c.GetType() == typeof(IfcGeometricRepresentationContext) && string.Compare(c.ContextType, "model", true) == 0 || string.Compare(c.ContextType, "design", true) == 0); //allow for incorrect older models
            if (context != null)
            {
                WorldCoordinateSystem = context.WorldCoordinateSystem;
                wcs = WorldCoordinateSystem.ToMatrix3D();
                if (!wcs.Value.IsIdentity)
                {
                    wcs.Value.Invert();
                }
                else
                {
                    wcs = null; //just ignore it
                }

            }
            //check if angle units are incorrectly defined, this happens in some old models
            if (Math.Abs(angleToRadiansConversionFactor - 1) < 1e-10)
            {
                foreach (var trimmedCurve in Instances.Where<IfcTrimmedCurve>(trimmedCurve => 
                    trimmedCurve.MasterRepresentation == IfcTrimmingPreference.PARAMETER &&
                    trimmedCurve.BasisCurve is IfcConic))
                {
                    if (
                        !trimmedCurve.Trim1.Concat(trimmedCurve.Trim2)
                            .OfType<IfcParameterValue>()
                            .Select(trim => (double)trim.Value)
                            .Any(val => val > Math.PI * 2)) continue;
                    angleToRadiansConversionFactor = Math.PI / 180;
                    break;
                }
            }
            ModelFactors = new XbimModelFactors(angleToRadiansConversionFactor, lengthToMetresConversionFactor,
                defaultPrecision, wcs);
        }

        /// <summary>
        /// Reloads the model factors if any units or precisions are changed
        /// </summary>
        public IModelFactors ReloadModelFactors()
        {
            GetModelFactors(); 
            return ModelFactors;
        }

        public override bool Open(string fileName, XbimDBAccess accessMode = XbimDBAccess.Read, ReportProgressDelegate progDelegate = null)
        {
            try
            {
                var result = base.Open(fileName, accessMode, progDelegate);
                GetModelFactors();
                LoadReferenceModels();
                return result;
            }
            catch (Exception e)
            {
                throw new XbimException(string.Format("Error opening file {0}\n{1}", fileName, e.Message), e);
            }
        }

        public override bool CreateFrom(string importFrom, string xbimDbName = null, ReportProgressDelegate progDelegate = null,
            bool keepOpen = false, bool cacheEntities = false)
        {
            var result = base.CreateFrom(importFrom, xbimDbName, progDelegate, keepOpen, cacheEntities);
            if (!keepOpen) return result;
            
            LoadReferenceModels();
            GetModelFactors();
            return result;

        }

        public IfcProject IfcProject
        {
            get
            {
                return InstancesLocal == null ? null : InstancesLocal.OfType<IfcProject>().FirstOrDefault();
            }
        }
        /// <summary>
        /// Returns all products in the model, including federated products
        /// </summary>
        public IEnumerable<IPersistEntity> IfcProducts
        {
            get { return InstancesLocal == null ? null : Instances.OfType<IfcProduct>(); }
        }

        public IEnumerable<XbimGeometryData> GetGeometryData(IfcProduct product, XbimGeometryType geomType)
        {
            return _cache.GetGeometry(ExpressMetaData.ExpressTypeId(product), product.EntityLabel, geomType);
        }


        #region Reference Model functions

        /// <summary>
        /// Adds a model as a reference or federated model, do not call inside a transaction
        /// </summary>
        /// <param name="refModelPath"></param>
        /// <param name="organisationName"></param>
        /// <param name="organisationRole"></param>
        /// <returns></returns>
        public XbimReferencedModel AddModelReference(string refModelPath, string organisationName, string organisationRole)
        {
            using (var txn = BeginTransaction())
            {
                var role = Instances.New<IfcActorRole>();
                role.RoleString = organisationRole; // the string is converted appropriately by the IfcActorRoleClass

                var org = Instances.New<IfcOrganization>();
                org.Name = organisationName;
                org.AddRole(role);

                var retVal = AddModelReference(refModelPath, org);
                txn.Commit();
                return retVal;
            }
        }

        public XbimReferencedModel AddModelReference(string refModelPath, string organisationName, IfcRoleEnum organisationRole)
        {
            using (var txn = BeginTransaction())
            {
                var docInfo = Instances.New<IfcDocumentInformation>();
                docInfo.DocumentId = NextReferenceIdentifier();
                //create an author of the referenced model

                var role = Instances.New<IfcActorRole>();
                role.Role = organisationRole;

                var org = Instances.New<IfcOrganization>();
                org.Name = organisationName;

                org.AddRole(role);

                var retVal = AddModelReference(refModelPath, org);
                txn.Commit();
                return retVal;
            }
        }


        /// <summary>
        /// adds a model as a reference model can be called inside a transaction
        /// </summary>
        /// <param name="refModelPath">the file path of the xbim model to reference, this must be an xbim file</param>
        /// <param name="owner">the actor who supplied the model</param>
        /// <returns></returns>
        public XbimReferencedModel AddModelReference(string refModelPath, IfcActorSelect owner)
        {
            XbimReferencedModel retVal;
            if (!IsTransacting)
            {
                using (var txn = BeginTransaction())
                {
                    var docInfo = Instances.New<IfcDocumentInformation>();
                    docInfo.DocumentId = NextReferenceIdentifier();
                    docInfo.Name = refModelPath;
                    docInfo.DocumentOwner = owner;
                    docInfo.IntendedUse = RefDocument;
                    retVal = new XbimReferencedModel(docInfo);
                    AddModelReference(retVal);
                    txn.Commit();
                }
            }
            else
            {
                var docInfo = Instances.New<IfcDocumentInformation>();
                docInfo.DocumentId = NextReferenceIdentifier();
                docInfo.Name = refModelPath;
                docInfo.DocumentOwner = owner;
                docInfo.IntendedUse = RefDocument;
                retVal = new XbimReferencedModel(docInfo);
                AddModelReference(retVal);
            }
            return retVal;
        }

        /// <summary>
        /// All reference models are opened in a readonly mode.
        /// Their children reference models is invoked iteratively.
        /// 
        /// Loading referenced models defaults to avoiding Exception on file not found; in this way the federated model can still be opened and the error rectified.
        /// </summary>
        /// <param name="throwReferenceModelExceptions"></param>
        private void LoadReferenceModels(bool throwReferenceModelExceptions = false)
        {
            var docInfos = Instances.OfType<IfcDocumentInformation>().Where(d => d.IntendedUse == RefDocument);
            foreach (var docInfo in docInfos)
            {
                if (throwReferenceModelExceptions)
                {
                    // throw exception on referenceModel Creation
                    AddModelReference(new XbimReferencedModel(docInfo));
                }
                else
                {
                    // do not throw exception on referenceModel Creation
                    try
                    {
                        AddModelReference(new XbimReferencedModel(docInfo));
                    }
                    catch (Exception)
                    {
                        // drop exception in this case
                    }
                }
            }
        }

        public void EnsureUniqueUserDefinedId()
        {
            short iId = 0;
            foreach (var model in AllEsentModels)
            {
                model.UserDefinedId = iId++;
            }
        }

        

       

        #endregion

        #region Initialization of the model
        public void Initialise(string userName = "User 1", string organisationName = "Organisation X", string applicationName = "Application 1.0", string developerName = "Developer 1", string version = "2.0.1")
        {
            //Begin a transaction as all changes to a model are transacted
            using (var txn = BeginTransaction("Initialise Model"))
            {
                //do once only initialisation of model application and editor values
                DefaultOwningUser.ThePerson.FamilyName = userName;
                DefaultOwningUser.TheOrganization.Name = organisationName;
                DefaultOwningApplication.ApplicationIdentifier = applicationName;
                DefaultOwningApplication.ApplicationDeveloper.Name = developerName;
                DefaultOwningApplication.ApplicationFullName = applicationName;
                DefaultOwningApplication.Version = version;

                //set up a project and initialise the defaults

                var project = Instances.New<IfcProject>();
                project.Initialize(ProjectUnits.SIUnitsUK);
                project.Name = "Empty Project";
                project.OwnerHistory.OwningUser = DefaultOwningUser;
                project.OwnerHistory.OwningApplication = DefaultOwningApplication;
                txn.Commit();
            }
            ReloadModelFactors();
        }
        #endregion

        #region Ifc Schema Validation Methods

        public string WhereRule()
        {
            if (IfcProject == null)
                return "WR1 Model: A Model must have a valid Project attribute";
            return "";
        }

        #endregion


        #region OwnerHistory Fields
        public void IfcRootInit(IPersistEntity entity)
        {
            var root = entity as IfcRoot;
            if (root != null)
            {
                root.OwnerHistory = OwnerHistoryAddObject;
            }
        }

        [NonSerialized]
        private IfcOwnerHistory _ownerHistoryDeleteObject;

        [NonSerialized]
        private IfcOwnerHistory _ownerHistoryAddObject;

        [NonSerialized]
        private IfcOwnerHistory _ownerHistoryModifyObject;

        [NonSerialized]
        private IfcPersonAndOrganization _defaultOwningUser;

        [NonSerialized]
        private IfcApplication _defaultOwningApplication;

        internal IfcOwnerHistory OwnerHistoryModifyObject
        {
            get
            {
                if (_ownerHistoryModifyObject == null)
                {
                    _ownerHistoryModifyObject = Instances.New<IfcOwnerHistory>();
                    _ownerHistoryModifyObject.OwningUser = DefaultOwningUser;
                    _ownerHistoryModifyObject.OwningApplication = DefaultOwningApplication;
                    _ownerHistoryModifyObject.ChangeAction = IfcChangeActionEnum.MODIFIED;
                }
                return _ownerHistoryModifyObject;
            }
        }

        internal IfcOwnerHistory OwnerHistoryAddObject
        {
            get
            {
                if (_ownerHistoryAddObject == null)
                {
                    _ownerHistoryAddObject = Instances.New<IfcOwnerHistory>();
                    _ownerHistoryAddObject.OwningUser = DefaultOwningUser;
                    _ownerHistoryAddObject.OwningApplication = DefaultOwningApplication;
                    _ownerHistoryAddObject.ChangeAction = IfcChangeActionEnum.ADDED;
                }
                return _ownerHistoryAddObject;
            }
            set //required for creation of COBie data from xls to a ifc new file
            {
                _ownerHistoryAddObject = value;
            }
        }

        internal IfcOwnerHistory OwnerHistoryDeleteObject
        {
            get
            {
                if (_ownerHistoryDeleteObject == null)
                {
                    _ownerHistoryDeleteObject = Instances.New<IfcOwnerHistory>();
                    _ownerHistoryDeleteObject.OwningUser = DefaultOwningUser;
                    _ownerHistoryDeleteObject.OwningApplication = DefaultOwningApplication;
                    _ownerHistoryDeleteObject.ChangeAction = IfcChangeActionEnum.DELETED;
                }
                return _ownerHistoryDeleteObject;
            }
        }



        internal IfcApplication DefaultOwningApplication
        {
            get
            {
                return _defaultOwningApplication ??
                       (_defaultOwningApplication =
                           Instances.New<IfcApplication>(a => a.ApplicationDeveloper = Instances.New<IfcOrganization>()));
            }
        }

        internal IfcPersonAndOrganization DefaultOwningUser
        {
            get
            {
                if (_defaultOwningUser == null)
                {
                    var existing = Instances.OfType<IfcPersonAndOrganization>().ToArray();
                    if (!existing.Any())
                    {
                        var person = Instances.New<IfcPerson>();
                        var organization = Instances.New<IfcOrganization>();
                        _defaultOwningUser = Instances.New<IfcPersonAndOrganization>(po =>
                        {
                            po.TheOrganization = organization;
                            po.ThePerson = person;
                        });
                    }
                    else
                        _defaultOwningUser = existing.FirstOrDefault();
                }
                return _defaultOwningUser;
            }
        }
        #endregion
    }
}
