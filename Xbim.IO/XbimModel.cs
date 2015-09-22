using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Xbim.XbimExtensions;
using System.CodeDom.Compiler;
using System.Collections;
using ICSharpCode.SharpZipLib.Zip;
using System.Diagnostics;
using Xbim.Common.Logging;
using Xbim.Common;
using Xbim.Common.Exceptions;
using System.Globalization;
using System.Reflection;
using Xbim.Common.Geometry;
using Xbim.Common.Step21;
using Xbim.Common.XbimExtensions;
using Xbim.Ifc2x3;
using Xbim.Ifc2x3.ActorResource;
using Xbim.Ifc2x3.ExternalReferenceResource;
using Xbim.Ifc2x3.GeometryResource;
using Xbim.Ifc2x3.Kernel;
using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.RepresentationResource;
using Xbim.Ifc2x3.UtilityResource;
using Xbim.IO.Esent;
using Xbim.IO.Step21;
using XbimGeometry.Interfaces;


namespace Xbim.IO
{
    /// <summary>
    /// General Model class for memory based model suport
    /// </summary>
   
    public class XbimModel : IModel, IDisposable
    {
        #region Fields

        #region Logging Fields

        internal readonly static ILogger Logger = LoggerFactory.GetLogger();

        #endregion

        #region Model state fields

        private readonly PersistedEntityInstanceCache _cache;
        internal PersistedEntityInstanceCache Cache
        {
            get { return _cache; }
        }

        private bool _disposed;
        private XbimModelFactors _modelFactors;

       
        private readonly XbimInstanceCollection _instances;
        private XbimEntityCursor _editTransactionEntityCursor;
        private bool _deleteOnClose;
        
        const string RefDocument = "XbimReferencedModel";
        private readonly XbimReferencedModelCollection _referencedModels = new XbimReferencedModelCollection();
        private int _codePageOverrideForIfcFiles = -1;

        /// <summary>
        /// An identifier that an application can use to identify this model uniquely
        /// </summary>
        public short UserDefinedId { get; set; }

        #endregion

        //Object that manages geometry conversion etc
        private Version _geometryVersion = new Version(2,0,0);
        private string _importFilePath;
        
        private IfcAxis2Placement _wcs;
      
        #endregion

        /// <summary>
        /// Model wide factors, precision etc
        /// </summary>
        public IModelFactors ModelFactors
        {
            get { return _modelFactors; }
        }

        public XbimModel()
        {
            _cache = new PersistedEntityInstanceCache(this, new EntityFactory());
            _instances = new XbimInstanceCollection(this);
            var r = new Random();
            UserDefinedId = (short)r.Next(short.MaxValue); // initialise value at random to reduce chance of duplicates
            SchemaModule = typeof(EntityFactory).Module;
        }
        public string DatabaseName
        {
            get { return _cache.DatabaseName; }
        }


        public IfcAxis2Placement WorldCoordinateSystem
        {
            get { return _wcs; }
        }

        //sets or gets the Geometry Manager for this model
        public IGeometryManager GeometryManager { get; set; }

        static public int ModelOpenCount
        {
            get
            {
                return PersistedEntityInstanceCache.ModelOpenCount;
            }
        }

        /// <summary>
        /// Some applications do not comply with the standard and used the Windows codepage for text. This property gives the possibility to override the character encoding when reading ifc.
        /// default value = -1 - by standart http://www.buildingsmart-tech.org/implementation/get-started/string-encoding/string-encoding-decoding-summary
        /// </summary>
        /// <example>
        /// model.CodePageOverride = Encoding.Default.WindowsCodePage;
        /// </example>
        public int CodePageOverride
        {
           get { return _codePageOverrideForIfcFiles; }
           set { _codePageOverrideForIfcFiles = value; }
        }

        public IEntityCollection InstancesLocal
        {
            get
            {
                return _instances;
            }
        }

        /// <summary>
        /// Returns a collection of all instances in the model and all federated instances 
        /// </summary>
        public IEntityCollection Instances
        {
            get
            {
                return new XbimFederatedModelInstances(this);
            }
        }

        /// <summary>
        /// Reloads the model factors if any units or precisions are changed
        /// </summary>
        public XbimModelFactors ReloadModelFactors()
        {
            GetModelFactors();
            return _modelFactors;
        }

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
                        var et = ((IExpressType) mu.ValueComponent);

                        if (et.UnderlyingSystemType == typeof (double))
                            value *= (double) et.Value;
                        else if (et.UnderlyingSystemType == typeof (int))
                            value *= (int) et.Value;
                        else if (et.UnderlyingSystemType == typeof (long))
                            value *= (long) et.Value;
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
            XbimMatrix3D? wcs=null;
            var context = Instances.OfType<IfcGeometricRepresentationContext>().FirstOrDefault(c => 
                c.GetType() == typeof(IfcGeometricRepresentationContext) && string.Compare(c.ContextType, "model", true) == 0 || string.Compare(c.ContextType, "design", true) == 0); //allow for incorrect older models
            if (context != null)
            {
                _wcs = context.WorldCoordinateSystem;
                wcs = _wcs.ToMatrix3D();
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
            if (angleToRadiansConversionFactor == 1)
            {               
                foreach (var trimmedCurve in Instances.OfType<IfcTrimmedCurve>()
                    .Where(trimmedCurve => trimmedCurve.MasterRepresentation == IfcTrimmingPreference.PARAMETER &&
                        trimmedCurve.BasisCurve is IfcConic))
                {
                    if (
                        !trimmedCurve.Trim1.Concat(trimmedCurve.Trim2)
                            .OfType<IfcParameterValue>()
                            .Select(trim => (double) trim.Value)
                            .Any(val => val > Math.PI*2)) continue;
                    angleToRadiansConversionFactor = Math.PI/180;
                    break;
                }
            }
            _modelFactors = new XbimModelFactors(angleToRadiansConversionFactor, lengthToMetresConversionFactor,
                defaultPrecision, wcs);
        }
        /// <summary>
        /// Starts a transaction to allow bulk updates on the geometry table, FreeGeometry Table should be called when no longer required
        /// </summary>
        /// <returns></returns>
        public XbimGeometryCursor GetGeometryTable()
        {
            return _cache.GetGeometryTable();
        }

        /// <summary>
        /// Returns the table to the cache for reuse
        /// </summary>
        /// <param name="table"></param>
        public void FreeTable(XbimGeometryCursor table)
        {
            _cache.FreeTable(table);
        }

        /// <summary>
        /// Returns the table to the cache for reuse
        /// </summary>
        /// <param name="table"></param>
        public void FreeTable(XbimEntityCursor table)
        {
            _cache.FreeTable(table);
        }
        /// <summary>
        /// Returns the table to the cache for reuse
        /// </summary>
        /// <param name="table"></param>
        public void FreeTable(XbimShapeGeometryCursor table)
        {
            _cache.FreeTable(table);
        }
        /// <summary>
        /// Returns the table to the cache for reuse
        /// </summary>
        /// <param name="table"></param>
        public void FreeTable(XbimShapeInstanceCursor table)
        {
            _cache.FreeTable(table);
        }
        //Loads the property data of an entity, if it is not already loaded
        int IModel.Activate(IPersistEntity entity, bool write)
        {
            if (write) //we want to activate for reading
            {
                //if (!Transaction.IsRollingBack)
                _cache.AddModified(entity);
            }
            //else //we want to read so load from db if necessary
            {
                _cache.Activate(entity);
            }
            return entity.EntityLabel;
        }

        #region Transaction support



      

        public XbimReadWriteTransaction BeginTransaction()
        {
            return BeginTransaction(null);
        }

        public bool IsTransacting
        {
            get
            {
                return _editTransactionEntityCursor != null;
            }
        }

        public XbimReadWriteTransaction BeginTransaction(string operationName)
        {
            if (_editTransactionEntityCursor != null) 
                throw new XbimException("Attempt to begin another transaction whilst one is already running");
            try
            {
                _editTransactionEntityCursor = _cache.GetEntityTable();
                _cache.BeginCaching();
                var txn = new XbimReadWriteTransaction(this, _editTransactionEntityCursor.BeginLazyTransaction(), operationName);
                CurrentTransaction = txn;
                return txn;
            }
            catch (Exception e)
            {

                throw new XbimException("Failed to create ReadWrite transaction", e);
            }

           
        }

        public IfcOwnerHistory OwnerHistoryModifyObject
        {
            get
            {
                return _instances.OwnerHistoryModifyObject;
            }
        }
        
        public IfcOwnerHistory OwnerHistoryAddObject
        {
            get
            {
                return _instances.OwnerHistoryAddObject;
            }
            set//required for creation of COBie data from xls to a ifc new file
            {
                _instances.OwnerHistoryAddObject = value;
            }
        }

        public IfcOwnerHistory OwnerHistoryDeleteObject
        {
            get
            {
                return _instances.OwnerHistoryDeleteObject;
            }
        }



        public IfcApplication DefaultOwningApplication
        {
            get { return _instances.DefaultOwningApplication; }
        }

        public IfcPersonAndOrganization DefaultOwningUser
        {
            get { return _instances.DefaultOwningUser; }
        }

        /// <summary>
        /// Performs a set of actions on a collection of entities inside a single read only transaction
        /// This improves database  performance for retrieving and accessing complex and deep objects
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <param name="source"></param>
        /// <param name="body"></param>
        public void ForEach<TSource>(IEnumerable<TSource> source, Action<TSource> body) where TSource : IPersistEntity
        {
            _cache.ForEach(source, body);
        }


        #endregion

        #region IModel interface implementation

        /// <summary>
        /// Registers an entity for deletion
        /// </summary>
        /// <param name="instance"></param>
        /// <returns></returns>
        public void Delete(IPersistEntity instance)
        {
            _cache.Delete_Reversable(instance);
        }

        /// <summary>
        /// Returns an instance from the Model with the corresponding label but does not keep a cache of it
        /// This is a dangerous call as duplicate instances of the same object could happen
        /// Ony use when interating over the whole database for export etc
        /// The properties of the object are also loaded to improve performance
        /// If the instance is in the cache it is returned
        /// </summary>
        /// <param name="label"></param>
        /// <returns></returns>
        internal IPersistEntity GetInstanceVolatile(int label)
        {
            return _cache.GetInstance(label, true, true);
        }

        /// <summary>
        /// Returns the total number of Geometry objects in the model
        /// </summary>
        public virtual long GeometriesCount
        {
            get
            {
                return _cache.GeometriesCount();
            }
        }

        /// <summary>
        /// Creates a new Model and populates with instances from the specified file, Ifc, IfcXML, IfcZip and Xbim are all supported.
        /// </summary>
        /// <param name="importFrom">Name of the file containing the instances to import</param>
        /// /// <param name="xbimDbName">Name of the xbim file that will be created. 
        /// If null the contents are loaded into memory and are not persistent
        /// </param>
        /// <param name="progDelegate"></param>
        /// <param name="keepOpen"></param>
        /// <param name="cacheEntities"></param>
        /// <returns></returns>
        public bool CreateFrom(string importFrom, string xbimDbName = null, ReportProgressDelegate progDelegate = null, bool keepOpen = false, bool cacheEntities = false)
        {
            Close();
            _importFilePath = Path.GetFullPath(importFrom);
            if (!Directory.Exists(Path.GetDirectoryName(_importFilePath) ?? ""))
                throw new DirectoryNotFoundException(Path.GetDirectoryName(importFrom) + " directory was not found");
            if (!File.Exists(_importFilePath))
                throw new FileNotFoundException(_importFilePath + " file was not found");
            if (string.IsNullOrWhiteSpace(xbimDbName))
                xbimDbName = Path.ChangeExtension(importFrom, "xBIM");
            
            var toImportStorageType = StorageType(importFrom);
            switch (toImportStorageType)
            {
                case XbimStorageType.IFCXML:
                    _cache.ImportIfcXml(xbimDbName, importFrom, progDelegate, keepOpen, cacheEntities);
                    break;
                case XbimStorageType.IFC:
                    _cache.ImportIfc(xbimDbName, importFrom, progDelegate, keepOpen, cacheEntities, _codePageOverrideForIfcFiles);
                    break;
                case XbimStorageType.IFCZIP:
                    _cache.ImportIfcZip(xbimDbName, importFrom, progDelegate, keepOpen, cacheEntities, _codePageOverrideForIfcFiles);
                    break;
                case XbimStorageType.XBIM:
                    _cache.ImportXbim(importFrom, progDelegate);
                    break;
                case XbimStorageType.INVALID:
                default:
                    return false;
            }
            if (keepOpen) 
            {
                GetModelFactors();
                LoadReferenceModels();
            }
            return true;
        }

        /// <summary>
        /// Creates an empty model using a temporary filename, the model will be deleted on close, unless SaveAs is called
        /// It will be returned open for read write operations
        /// </summary>
        /// <returns></returns>
        static public XbimModel CreateTemporaryModel()
        {
            
            var tmpFileName = Path.GetTempFileName();
            try
            {
                var model = new XbimModel();
                model.CreateDatabase(tmpFileName);  
                model.Open(tmpFileName, XbimDBAccess.ReadWrite, true);
                model.Header = new StepFileHeader(StepFileHeader.HeaderCreationMode.InitWithXbimDefaults);
                return model;
            }
            catch (Exception e)
            {

                throw new XbimException("Failed to create and open temporary xBIM file \'" + tmpFileName + "\'\n" + e.Message, e);
            }
           
        }

        private void CreateDatabase(string tmpFileName)
        {
            _cache.CreateDatabase(tmpFileName);
        }

        /// <summary>
        ///  Creates and opens a new Xbim Database
        /// </summary>
        /// <param name="dbFileName">Name of the Xbim file</param>
        /// <param name="access"></param>
        /// <returns></returns>
        static public XbimModel CreateModel(string dbFileName, XbimDBAccess access = XbimDBAccess.ReadWrite)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(Path.GetExtension(dbFileName)))
                    dbFileName += ".xBIM";
                var model = new XbimModel();
                model.CreateDatabase(dbFileName); 
                model.Open(dbFileName, access);
                model.Header = new StepFileHeader(StepFileHeader.HeaderCreationMode.InitWithXbimDefaults)
                {
                    FileName = {Name = dbFileName}
                };
                return model;
            }
            catch (Exception e)
            {
                throw new XbimException("Failed to create and open xBIM file \'" + dbFileName + "\'\n" + e.Message, e);
            }
        }

        #endregion

        public byte[] GetEntityBinaryData(IInstantiableEntity entity)
        {
            if (entity.Activated) //we have it in memory but not written to store yet
            {
                var entityStream = new MemoryStream(4096);
                var entityWriter = new BinaryWriter(entityStream);
                entity.WriteEntity(entityWriter);
                return entityStream.ToArray();
            }
            else //it is in a persisted cache but hasn't been loaded yet
            {
                return _cache.GetEntityBinaryData(entity);
            }
        }

        public IStepFileHeader Header {  get; set; }

        #region Validation

        /// <summary>
        /// Validates all entities in the model
        /// </summary>
        /// <param name="tw"></param>
        /// <param name="validateLevel"></param>
        /// <returns></returns>
        public int Validate(TextWriter tw, ValidationFlags validateLevel = ValidationFlags.Properties)
        {
            return _instances.Sum(entity => Validate(entity as IInstantiableEntity, tw, validateLevel));
        }

        public int Validate(IEnumerable<IInstantiableEntity> entities, TextWriter tw, ValidationFlags validateLevel = ValidationFlags.Properties)
        {
            return entities.Sum(entity => Validate(entity, tw, validateLevel));
        }

        public int Validate(IPersistEntity ent, TextWriter tw, ValidationFlags validateLevel = ValidationFlags.Properties)
        {
            var itw = new IndentedTextWriter(tw);
            if (validateLevel == ValidationFlags.None) return 0; //nothing to do
            var ifcType = ExpressMetaData.ExpressType(ent);
            var notIndented = true;
            var errors = 0;
            if (validateLevel == ValidationFlags.Properties || validateLevel == ValidationFlags.All)
            {
                foreach (var ifcProp in ifcType.Properties.Values)
                {
                    var err = GetSchemaError(ent as IInstantiableEntity, ifcProp);
                    if (string.IsNullOrEmpty(err)) continue;
                    if (notIndented)
                    {
                        itw.WriteLine("#{0} - {1}", ent.EntityLabel, ifcType.Type.Name);
                        itw.Indent++;
                        notIndented = false;
                    }
                    itw.WriteLine(err.Trim('\n'));
                    errors++;
                }
            }
            if (validateLevel == ValidationFlags.Inverses || validateLevel == ValidationFlags.All)
            {
                foreach (var ifcInv in ifcType.Inverses)
                {
                    var err = GetSchemaError(ent as IInstantiableEntity, ifcInv);
                    if (string.IsNullOrEmpty(err)) continue;
                    if (notIndented)
                    {
                        itw.WriteLine("#{0} - {1}", ent.EntityLabel, ifcType.Type.Name);
                        itw.Indent++;
                        notIndented = false;
                    }
                    itw.WriteLine(err.Trim('\n'));
                    errors++;
                }
            }

            string str = ent.WhereRule();
            if (!string.IsNullOrEmpty(str))
            {
                if (notIndented)
                {
                    itw.WriteLine("#{0} - {1}", ent.EntityLabel, ifcType.Type.Name);
                    itw.Indent++;
                    notIndented = false;
                }
                itw.WriteLine(str.Trim('\n'));
                errors++;
            }
            if (!notIndented) itw.Indent--;
            return errors;
        }

        private static string GetSchemaError(IPersist instance, ExpressMetaProperty prop)
        {
            //IfcAttribute ifcAttr, object instance, object propVal, string propName

            var ifcAttr = prop.EntityAttributeAttribute;
            var propVal = prop.PropertyInfo.GetValue(instance, null);
            var propName = prop.PropertyInfo.Name;

            

            if (ifcAttr.State == EntityAttributeState.Mandatory && propVal == null)
                return string.Format("{0}.{1} is not optional", instance.GetType().Name, propName);
            if (ifcAttr.State == EntityAttributeState.Optional && propVal == null)
                //if it is null and optional then it is ok
                return null;

            var expressType = propVal as IExpressType;
            if (expressType != null)
            {
                var err = ((IPersist)propVal).WhereRule();
                if (!string.IsNullOrEmpty(err)) return err;
            }

            if (ifcAttr.EntityType != EntityAttributeType.Set && ifcAttr.EntityType != EntityAttributeType.List &&
                ifcAttr.EntityType != EntityAttributeType.ListUnique) return null;

            if (ifcAttr.MinCardinality < 1 && ifcAttr.MaxCardinality < 0) //we don't care how many so don't check
                return null;
            var coll = propVal as ICollection;
            var count = 0;
            if (coll != null)
                count = coll.Count;
            else
            {
                var en = (IEnumerable)propVal;

                foreach (var item in en)
                {
                    count++;
                    if (count >= ifcAttr.MinCardinality && ifcAttr.MaxCardinality == -1)
                        //we have met the requirements
                        break;
                    if (ifcAttr.MaxCardinality > -1 && count > ifcAttr.MaxCardinality) //we are out of bounds
                        break;
                }
            }

            if (count < ifcAttr.MinCardinality)
            {
                return string.Format("{0}.{1} must have at least {2} item(s). It has {3}", instance.GetType().Name,
                    propName, ifcAttr.MinCardinality, count);
            }
            if (ifcAttr.MaxCardinality > -1 && count > ifcAttr.MaxCardinality)
            {
                return string.Format("{0}.{1} must have no more than {2} item(s). It has at least {3}",
                    instance.GetType().Name, propName, ifcAttr.MaxCardinality, count);
            }
            return null;
        }

        #endregion

        #region Part 21 parse functions


        private IPersist _part21Parser_EntityCreate(string className, long? label, bool headerEntity,
                                                     out int[] reqParams)
        {
            reqParams = null;
            if (headerEntity)
            {
                switch (className)
                {
                    case "FILE_DESCRIPTION":
                        return new StepFileDescription("");
                    case "FILE_NAME":
                        return new StepFileName();
                    case "FILE_SCHEMA":
                        return new StepFileSchema();
                    default:
                        throw new ArgumentException(string.Format("Invalid Header entity type {0}", className));
                }
            }
            else
                return CreateInstance(className, label);
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


        #region General Model operations



        /// <summary>
        /// Closes the current model and releases all resources and instances
        /// </summary>
        public void Close()
        {
            var dbName = DatabaseName;
            _modelFactors = null;          
            Header = null;
            foreach (var refModel in _referencedModels)
                refModel.Model.Dispose();
            _referencedModels.Clear();
            if (_editTransactionEntityCursor != null)
                EndTransaction();
            _cache.Close();
            try //try and tidy up if required
            {
                if (_deleteOnClose && File.Exists(dbName))
                    File.Delete(dbName);
            }
            catch (Exception)
            {                     
            }
            _deleteOnClose = false;
        }
        #endregion

        private bool Open(string fileName, XbimDBAccess accessMode, bool deleteOnClose)
        {      
            var ok =  Open(fileName, accessMode);
            _deleteOnClose = deleteOnClose;
            return ok;
        }

        /// <summary>
        /// Begins a cache of all data read from the model, improves performance where data is read many times
        /// </summary>
        public void CacheStart()
        {
            if (_editTransactionEntityCursor == null) //if we are in a transaction caching is on anyway
                 _cache.CacheStart();
        }
        /// <summary>
        /// Clears all read data in the cache
        /// </summary>
        public void CacheClear()
        {
            if (_editTransactionEntityCursor == null) //if we are in a transaction do not clear
                _cache.CacheClear();
        }

        /// <summary>
        /// Stops further caching of data and clears the current cache
        /// </summary>
        public void CacheStop()
        {
            if (_editTransactionEntityCursor == null)  //if we are in a transaction do not stop
                _cache.CacheStop();
        }

        /// <summary>
        /// Opens an Xbim model only, to open Ifc, IfcZip and IfcXML files use the CreatFrom method
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="accessMode"></param>
        /// <param name="progDelegate"></param>
        /// <returns>True if successful</returns>
        public bool Open(string fileName, XbimDBAccess accessMode = XbimDBAccess.Read, ReportProgressDelegate progDelegate = null)
        {
            try
            {
                Close();
                _cache.Open(fileName, accessMode); //opens the database
                GetModelFactors();
                LoadReferenceModels();
                return true;
            }
            catch (Exception e)
            {
                throw new XbimException(string.Format("Error opening file {0}\n{1}", fileName, e.Message), e);
            }
        }

        public bool CanEdit
        {
            get
            {
                return Cache.AccessMode == XbimDBAccess.ReadWrite || Cache.AccessMode == XbimDBAccess.Exclusive;
            }
        }

        public bool SaveAs(string outputFileName)
        {
            return SaveAs(outputFileName, null, null, null);
        }

        public bool SaveAs(string outputFileName, XbimStorageType? storageType = null)
        {
            return SaveAs(outputFileName, storageType, null, null);
        }

        public bool SaveAs(string outputFileName, XbimStorageType? storageType = null, ReportProgressDelegate progress = null)
        {
            return SaveAs(outputFileName, storageType, progress, null);
        }

        public bool SaveAs(string outputFileName, XbimStorageType? storageType = null, ReportProgressDelegate progress = null, IDictionary<int, int> map = null)
        {

            try
            {
                if (!storageType.HasValue)
                    storageType = StorageType(outputFileName);
                if (storageType.Value == XbimStorageType.INVALID)
                {
                    var ext = Path.GetExtension(outputFileName);
                    if(string.IsNullOrWhiteSpace(ext))
                        throw new XbimException("Invalid file type, no extension specified in file " + outputFileName);
                    else
                        throw new XbimException("Invalid file type ." + ext.ToUpper() + " in file " + outputFileName);
                }
                if (storageType.Value == XbimStorageType.XBIM && DatabaseName != null) //make a copy
                {
                    var srcFile = DatabaseName;
                    if(string.Compare(srcFile, outputFileName, true, CultureInfo.InvariantCulture) == 0)
                        throw new XbimException("Cannot save file to the same name, " + outputFileName);
                    var deleteOnClose = _deleteOnClose;
                    var accessMode = _cache.AccessMode;
                    try
                    {
                       
                        _deleteOnClose = false; //regardless we need to keep it to copy it
                        Close(); 
                        File.Copy(srcFile, outputFileName);
                        
                        if (deleteOnClose)
                            File.Delete(srcFile);
                        srcFile = outputFileName;
                        return true;
                    }
                    catch (Exception e)
                    {
                        throw new XbimException("Failed to save file as outputFileName" , e);
                    }
                    finally
                    {
                        Open(srcFile, accessMode);
                    }
                }
                else
                {
                    _cache.SaveAs(storageType.Value, outputFileName, progress, map);
                    return true;
                }
            }
            catch (Exception e)
            {
                throw new XbimException(string.Format("Failed to Save file as {0}\n{1}", outputFileName, e.Message), e);
            }
        }

        // Extract first ifc file from zipped file and save in the same directory
        internal string ExportZippedIfc(string inputIfcFile)
        {
            try
            {
                using (var zis = new ZipInputStream(File.OpenRead(inputIfcFile)))
                {
                    var zs = zis.GetNextEntry();
                    while (zs != null)
                    {
                        var fileName = Path.GetFileName(zs.Name);
                        if (fileName == null || !fileName.ToLower().EndsWith(".ifc")) continue;
                        using (var fs = File.Create(fileName))
                        {
                            var i = 2048;
                            var b = new byte[i];
                            while (true)
                            {
                                i = zis.Read(b, 0, b.Length);
                                if (i > 0)
                                    fs.Write(b, 0, i);
                                else
                                    break;
                            }
                        }
                        return fileName;
                    }

                }
            }
            catch (Exception e)
            {
                throw new Exception("Error creating Ifc File from ZIP = " + inputIfcFile, e);
            }
            return "";
        }



        #region Helpers

        private XbimStorageType StorageType(string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName)) return XbimStorageType.INVALID;
            var ext = Path.GetExtension(fileName).ToLower();
            if (ext == ".xbim" || ext == ".xbimf") return XbimStorageType.XBIM;
            else if (ext == ".ifc") return XbimStorageType.IFC;
            else if (ext == ".ifcxml") return XbimStorageType.IFCXML;
            else if (ext == ".zip" || ext == ".ifczip") return XbimStorageType.IFCZIP;
            else
                return XbimStorageType.INVALID;
        }

        #endregion

        /// <summary>
        ///   Creates an Ifc Persistent Instance from an entity name string and label, this is NOT an undoable operation
        /// </summary>
        /// <param name = "ifcEntityName">Ifc Entity Name i.e. IFCDOOR, IFCWALL, IFCWINDOW etc. Name must be in uppercase</param>
        /// <returns></returns>
        internal IPersist CreateInstance(string ifcEntityName, long? label)
        {
            try
            {
                var type = ExpressMetaData.ExpressType(ifcEntityName, SchemaModule);
                return CreateInstance(type.Type, label);
            }
            catch (Exception e)
            {
                throw new ArgumentException(string.Format("Error creating entity {0}, it is not a supported Xbim type, {1}", ifcEntityName, e.Message));
            }
        }
        /// <summary>
        /// Creates an Ifc Persistent Instance from an entity type and label, this is NOT an undoable operation
        /// </summary>
        /// <param name="ifcType"></param>
        /// <param name="label"></param>
        /// <returns></returns>
        internal IPersist CreateInstance(Type ifcType, long? label)
        {
            throw new NotImplementedException("To do");
            //return instances.AddNew(this,ifcType,label.Value);
        }

        public void Print()
        {
            _cache.Print();
        }

        public IfcProject IfcProject
        {
            get
            {
                return _cache == null ? null : InstancesLocal.OfType<IfcProject>().FirstOrDefault();
            }
        }
        /// <summary>
        /// Returns all products in the model, including federated products
        /// </summary>
        public IEnumerable<IPersistEntity> IfcProducts
        {
            get { return _cache == null ? null : Instances.OfType<IfcProduct>(); }
        }

        ~XbimModel()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            // Take yourself off the Finalization queue 
            // to prevent finalization code for this object
            // from executing a second time.
            GC.SuppressFinalize(this);
        }

        protected void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                try
                {
                // If disposing equals true, dispose all managed 
                // and unmanaged resources.
                if (disposing)
                {
                   //managed resources
                    Close();
                }
                //unmanaged, mostly esent related
                _cache.Dispose();
            }
                catch
                {
                    // ignored
                }
            }
            _disposed = true;
        }

        public void CheckMaps()
        {
            foreach (var mesh in GetGeometryData(XbimGeometryType.TriangulatedMesh))
            {
                Debug.WriteLine("{0}, hash = {1}", mesh.GeometryLabel, mesh.GeometryHash);
            }
        }

        public XbimGeometryHandleCollection GetGeometryHandles(XbimGeometryType geomType=XbimGeometryType.TriangulatedMesh, XbimGeometrySort sortOrder=XbimGeometrySort.OrderByIfcSurfaceStyleThenIfcType)
        {
            return _cache.GetGeometryHandles(geomType,sortOrder);
        }

        public XbimGeometryHandle GetGeometryHandle(int geometryLabel)
        {
            return _cache.GetGeometryHandle(geometryLabel);
        }

        /// <summary>
        /// Returns all the geometries for the geometry type
        /// Typically bounding box returns a single object, triangulated mesh mes may return multiple geometry meshes
        /// where an object is made of multiple materials
        /// </summary>
        /// <param name="productLabel"></param>
        /// <param name="geomType"></param>
        /// <returns></returns>
        public IEnumerable<XbimGeometryData> GetGeometryData(int productLabel, XbimGeometryType geomType)
        {
            var entity = _cache.GetInstance(productLabel, false, true);
            if (entity != null)
            {
                foreach (var item in _cache.GetGeometry(ExpressMetaData.ExpressTypeId(entity), productLabel, geomType))
                {
                    yield return item;
                }
            }

            // RefencedModels must NOT be iterated because of potential entityLabel clashes.
            // identity needs instead to be tested at the model level of children first, then call this function on the matching child.

            //else // look in referenced models
            //{
            //    foreach (XbimReferencedModel refModel in this.RefencedModels)
            //    {
            //        foreach (var item in refModel.Model.GetGeometryData(productLabel, geomType))
            //        {
            //            yield return item;
            //        }
            //    }
            //}
        }

        public IEnumerable<XbimGeometryData> GetGeometryData(IfcProduct product, XbimGeometryType geomType)
        {
            return _cache.GetGeometry(ExpressMetaData.ExpressTypeId(product), product.EntityLabel, geomType);
        }

        //public IDictionary<string, XbimViewDefinition> Views
        //{
        //    get
        //    {
        //        Dictionary<string, XbimViewDefinition> views = new Dictionary<string, XbimViewDefinition>();
        //        views.Add("Default", new XbimViewDefinition());
        //        return views;
        //    }
        //}

        /// <summary>
        /// Returns the level of geometry supported in the model
        /// 0 = No geometry has been compiled in the model
        /// 1 = Triangulated Mesh only
        /// 2 = Polygonal  geometry meshes supporting maps
        /// </summary>
        public int GeometrySupportLevel
        {
            get
            {
                if (DatabaseHasInstanceTable())
                {
                    using (var i = GetShapeInstanceTable())
                    {
                        if (i.RetrieveCount() > 0)
                            return 2;
                    }
                }
                else if (DatabaseHasGeometryTable() && GetGeometryData(XbimGeometryType.TriangulatedMesh).Any()) 
                    return 1;
                return 0;
            }
        }

        public IEnumerable<XbimGeometryData> GetGeometryData(XbimGeometryType ofType)
        {
            return _cache.GetGeometryData(ofType);
        }

        internal XbimEntityCursor GetEntityTable()
        {
            return _cache.GetEntityTable();
        }

        internal void Compact(XbimModel targetModel)
        {
          
        }

        /// <summary>
        /// Inserts a deep copy of the toCopy object into this model
        /// All property values are copied to the maximum depth
        /// Objects are not duplicated, if repeated copies are to be performed use the version with the 
        /// mapping argument to ensure objects are not duplicated
        /// </summary>
        /// <param name="toCopy"></param>
        /// <returns></returns>
        public T InsertCopy<T>(T toCopy, XbimReadWriteTransaction txn, bool includeInverses = false) where T : IPersistEntity
        {
            return InsertCopy(toCopy, new XbimInstanceHandleMap(toCopy.Model, this),txn, includeInverses);
        }

        /// <summary>
        /// Inserts a deep copy of the toCopy object into this model
        /// All property values are copied to the maximum depth
        /// Inverse properties are not copied
        /// </summary>
        /// <param name="toCopy">Instance to copy</param>
        /// <param name="mappings">Supply a dictionary of mappings if repeat copy insertions are to be made</param>
        /// <returns></returns>
        public T InsertCopy<T>(T toCopy, XbimInstanceHandleMap mappings, XbimReadWriteTransaction txn, bool includeInverses = false) where T : IPersistEntity
        {
            return _cache.InsertCopy<T>(toCopy, mappings, txn, includeInverses);
        }

        internal void EndTransaction()
        {
            FreeTable(_editTransactionEntityCursor); //release the cursor back to the pool
            _cache.EndCaching();
            _editTransactionEntityCursor = null;
        }
       
        internal void Flush()
        {
            _cache.Write(_editTransactionEntityCursor);
        }

        internal XbimEntityCursor GetTransactingCursor()
        {
            Debug.Assert(_editTransactionEntityCursor != null);
            return _editTransactionEntityCursor;
        }

        #region Model Group functions
        
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
                docInfo.DocumentId = _referencedModels.NextIdentifer();
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
            XbimReferencedModel retVal = null;
            if (!IsTransacting)
            {
                using (var txn = BeginTransaction())
                {
                    var docInfo = Instances.New<IfcDocumentInformation>();
                    docInfo.DocumentId = _referencedModels.NextIdentifer();
                    docInfo.Name = refModelPath;
                    docInfo.DocumentOwner = owner;
                    docInfo.IntendedUse = RefDocument;
                    retVal = new XbimReferencedModel(docInfo);
                    _referencedModels.Add(retVal);
                    txn.Commit();
                }
            }
            else
            {
                var docInfo = Instances.New<IfcDocumentInformation>();
                docInfo.DocumentId = _referencedModels.NextIdentifer();
                docInfo.Name = refModelPath;
                docInfo.DocumentOwner = owner;
                docInfo.IntendedUse = RefDocument;
                retVal = new XbimReferencedModel(docInfo);
                _referencedModels.Add(retVal);
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
                    _referencedModels.Add(new XbimReferencedModel(docInfo));
                }
                else
                {
                    // do not throw exception on referenceModel Creation
                    try
                    {
                        _referencedModels.Add(new XbimReferencedModel(docInfo));
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
            foreach (var model in AllModels)
            {
                model.UserDefinedId = iId++;
            }
        }

        #endregion


        public XbimReferencedModelCollection ReferencedModels
        {
            get
            {
                return _referencedModels;
            }
        }

        public XbimGeometryData GetGeometryData(XbimGeometryHandle handle)
        {
            return _cache.GetGeometryData(handle);
        }

        public XbimGeometryData GetGeometryData(int geomLabel)
        {
            return _cache.GetGeometryData(geomLabel);
        }

        public IEnumerable<XbimGeometryData> GetGeometryData(IEnumerable<XbimGeometryHandle> handles)
        {
            return _cache.GetGeometryData(handles);
        }

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

        /// <summary>
        /// Returns true if the model contains reference models or the model has extension xBIMf
        /// </summary>
        public bool IsFederation 
        {
            get
            {
                return _referencedModels.Any() || string.Compare(Path.GetExtension(_cache.DatabaseName), ".xbimf", true) == 0;
            }
        }


        /// <summary>
        /// Returns an enumerable of the handles to all entities in the model
        /// Note this includes entities that are in any federated models
        /// </summary>
        public IEnumerable<XbimInstanceHandle> AllInstancesHandles 
        {
            get
            {
                foreach (var h in _cache.InstanceHandles)
                    yield return h;
                foreach (var refModel in ReferencedModels)
                    foreach (var h in refModel.Model.InstanceHandles)
                        yield return h;
            }
        }
        /// <summary>
        /// Returns an enumerable of the handles to only the entities in this model
        /// Note this do NOT include entities that are in any federated models
        /// </summary>
        public IEnumerable<XbimInstanceHandle> InstanceHandles 
        {
            get {
                return _cache.InstanceHandles;
            }
        }

        internal IPersistEntity GetInstanceVolatile(XbimInstanceHandle item)
        {
          return item.Model.GetInstanceVolatile(item.EntityLabel);
        }

        /// <summary>
        /// Federated models can be nested.
        /// Since children models do not have a method for pointing to the parent management of their 
        /// uniqueness must be achieved top down by the topmost one. After all child models are loaded.
        /// </summary>
        public IEnumerable<XbimModel> AllModels
        {
            get
            {
                yield return this;
                foreach (var refModel in ReferencedModels)
                    foreach (var m in refModel.Model.AllModels)
                        yield return m;
            }
        }

        public object Tag { get; set; }
        
        public XbimShapeGeometryCursor GetShapeGeometryTable()
        {
            return _cache.GetShapeGeometryTable();
        }

        public XbimShapeInstanceCursor GetShapeInstanceTable()
        {
            return _cache.GetShapeInstanceTable();
        }

        /// <summary>
        /// Invoke the function before meshing to ensure database structure is available
        /// </summary>
        /// <returns></returns>
        public bool EnsureGeometryTables()
        {
            return _cache.EnsureGeometryTables();
        }

        public bool DeleteGeometryCache()
        {
            return _cache.DeleteGeometry();
        }

        public bool DatabaseHasGeometryTable()
        {
            return _cache.DatabaseHasGeometryTable();
        }

        public bool DatabaseHasInstanceTable()
        {
            return _cache.DatabaseHasInstanceTable();
        }

        bool IModel.IsTransactional
        {
            get { return true; }
        }

        ITransaction IModel.BeginTransaction(string name)
        {
            return BeginTransaction(name);
        }

        /// <summary>
        /// Weak reference allows garbage collector to collect transaction once it goes out of the scope
        /// even if it is still referenced from model. This is important for the cases where the transaction
        /// is both not commited and not rolled back either.
        /// </summary>
        private WeakReference _transactionReference;

        public ITransaction CurrentTransaction
        {
            get
            {
                if (_transactionReference == null || !_transactionReference.IsAlive)
                    return null;
                return _transactionReference.Target as ITransaction;
            }
            internal set
            {
                if (value == null)
                {
                    _transactionReference = null;
                    return;
                }
                if (_transactionReference == null)
                    _transactionReference = new WeakReference(value);
                else
                    _transactionReference.Target = value;
            }
        }

        public Module SchemaModule { get; private set; }
    }
}
