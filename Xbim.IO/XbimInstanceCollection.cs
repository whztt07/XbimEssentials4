using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Linq.Expressions;
using Xbim.Common;
using Xbim.Ifc2x3.ActorResource;
using Xbim.Ifc2x3.Kernel;
using Xbim.Ifc2x3.UtilityResource;

namespace Xbim.IO
{
    /// <summary>
    /// A class providing access to a collection of in,stances in a model
    /// </summary>
    public class XbimInstanceCollection : IEntityCollection
    {
        private readonly XbimModel _xbimModel;
        private readonly IfcPersistedInstanceCache _cache;
        
        public IEnumerable<IPersistEntity> OfType(string stringType, bool activate)
        {
            return _cache.OfType(stringType, activate);
        }

        internal XbimInstanceCollection(XbimModel xbimModel)
        {
            _xbimModel = xbimModel;
            _cache = xbimModel.Cache;
        }

        /// <summary>
        /// Returns the total number of Ifc Instances in this model
        /// </summary>
        public long Count { get { return _cache.Count;  } }

        /// <summary>
        /// Returns the count of the number of instances of the specified type
        /// </summary>
        /// <typeparam name="TIfcType"></typeparam>
        /// <returns></returns>
        public long CountOf<TIfcType>() where TIfcType : IPersistEntity
        {
            return _cache.CountOf<TIfcType>(); 
        }
        /// <summary>
        /// Returns all instances in the model of IfcType, IfcType may be an abstract Type
        /// </summary>
        /// <param name="activate">if true each instance is fullly populated from the database, if false population is deferred until the entity is activated</param>
        /// <returns></returns>
        public IEnumerable<TIfc> OfType<TIfc>(bool activate) where TIfc : IPersistEntity
        {
            return _cache.OfType<TIfc>(activate).Select(item => item);
        }


        public IEnumerable<TIfc> OfType<TIfc>() where TIfc : IPersistEntity
        {
            return _cache.OfType<TIfc>().Select(item => item);
        }

        //public IEnumerable<TIfcType> OfType<TIfcType>() where TIfcType : IPersistEntity
        //{
        //    return cache.OfType<TIfcType>(false);
        //}

        /// <summary>
        ///   Filters the Ifc Instances based on their Type and the predicate
        /// </summary>
        /// <typeparam name = "TIfcType">Ifc Type to filter</typeparam>
        /// <param name = "expression">function to execute</param>
        /// <returns></returns>
        public IEnumerable<TIfcType> Where<TIfcType>(Expression<Func<TIfcType, bool>> expression) where TIfcType : IPersistEntity
        {
            
            return _cache.Where(expression);
        }

        /// <summary>
        /// Returns an enumerabale of all the instance handles in the model
        /// </summary>
        public IEnumerable<XbimInstanceHandle> Handles()
        {
            return _cache.InstanceHandles;
        }


        /// <summary>
        /// Returns an enumerable of all handles of the specified type in the model
        /// </summary>
        /// <typeparam name="T">The type of entity required</typeparam>
        /// <returns></returns>
        public IEnumerable<XbimInstanceHandle> Handles<T>()
        {
            return _cache.InstanceHandlesOfType<T>();
        }

        /// <summary>
        /// Returns an instance from the Model with the corresponding label
        /// </summary>
        /// <param name="label">entity label to retrieve</param>
        /// <returns></returns>
        public IPersistEntity this[int label]
        {
            get
            {
                return _cache.GetInstance(label, true, true);
            }
        }
       
        /// <summary>
        /// Returns the Ifc entity for a given Geometry Label
        /// </summary>
        /// <param name="geometryLabel"></param>
        /// <returns></returns>
        public IPersistEntity GetFromGeometryLabel(int geometryLabel)
        {
            var filledGeomData = _cache.GetGeometryHandle(geometryLabel);
            return _cache.GetInstance(filledGeomData.ProductLabel, true, true);
        }

        /// <summary>
        ///   Creates a new Ifc Persistent Instance, this is an undoable operation
        /// </summary>
        /// <typeparam name = "TIfcType"> The Ifc Type, this cannot be an abstract class. An exception will be thrown if the type is not a valid Ifc Type  </typeparam>
        public TIfcType New<TIfcType>() where TIfcType : IInstantiableEntity
        {
            var t = typeof(TIfcType);
            return (TIfcType)New(t);
        }
        /// <summary>
        ///   Creates and Instance of TIfcType and initializes the properties in accordance with the lambda expression
        ///   i.e. Person person = CreateInstance&gt;Person&lt;(p =&lt; { p.FamilyName = "Undefined"; p.GivenName = "Joe"; });
        /// </summary>
        /// <typeparam name = "TIfcType"></typeparam>
        /// <param name = "initPropertiesFunc"></param>
        /// <returns></returns>
        public TIfcType New<TIfcType>(Action<TIfcType> initPropertiesFunc) where TIfcType : IInstantiableEntity
        {
            var instance = New<TIfcType>();
            initPropertiesFunc(instance);
            return instance;
        }

        /// <summary>
        /// Creates and returns a new instance of Type t, sets the label to the specificed value.
        /// This is a reversabel operation
        /// 
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public IPersistEntity New(Type t)
        {
            var entity = _cache.CreateNew(t);
            
            return entity;

        }

       
        /// <summary>
        /// Returns true if the instance label is in the current model, 
        /// Use with care, does not check that the instance is in the current model, only the label exists
        /// </summary>
        /// <param name="entityLabel"></param>
        /// <returns></returns>
        public  bool Contains(int entityLabel)
        {
            return _cache.Contains(entityLabel);
        }

        /// <summary>
        /// Returns true if the instance is in the current model
        /// </summary>
        /// <param name="instance"></param>
        /// <returns></returns>
        public  bool Contains(IPersistEntity instance)
        {
            return _cache.Contains(instance);
        }

        #region OwnerHistory Fields
        //todo: Implement default initialization of IfcRoot object in a different assembly
        //public void IfcRootInit(Type t)
        //{
        //    if (typeof(IfcRoot).IsAssignableFrom(t))
        //    {
        //        if (_ownerHistoryAddObject == null) //create an owner history object if it is nor already available
        //        {
        //            _ownerHistoryAddObject = (IfcOwnerHistory)cache.CreateNew(typeof(IfcOwnerHistory));
        //            _ownerHistoryAddObject.ChangeAction = IfcChangeActionEnum.ADDED;
        //            _ownerHistoryAddObject.OwningApplication = DefaultOwningApplication;
        //            _ownerHistoryAddObject.OwningUser = DefaultOwningUser;
        //        }

        //        ((IfcRoot)entity).OwnerHistory = _ownerHistoryAddObject;
        //    }
        //}

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
                    _ownerHistoryModifyObject = this.New<IfcOwnerHistory>();
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
                    _ownerHistoryAddObject = this.New<IfcOwnerHistory>();
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
                    _ownerHistoryDeleteObject = this.New<IfcOwnerHistory>();
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
                if (_defaultOwningApplication == null)
                {
                    _defaultOwningApplication = New<IfcApplication>(a => a.ApplicationDeveloper = New<IfcOrganization>());
                }
                return _defaultOwningApplication;
            }
        }

        internal IfcPersonAndOrganization DefaultOwningUser
        {
            get
            {
                if (_defaultOwningUser == null)
                {
                    var existing = this.OfType<IfcPersonAndOrganization>();
                    if (!existing.Any())
                    {
                        var person = New<IfcPerson>();
                        var organization = New<IfcOrganization>();
                        _defaultOwningUser = New<IfcPersonAndOrganization>(po =>
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

        IEnumerator<IPersistEntity> IEnumerable<IPersistEntity>.GetEnumerator()
        {
            return new XbimInstancesEntityEnumerator(_cache);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new XbimInstancesEntityEnumerator(_cache);
        }

       
    }

}
