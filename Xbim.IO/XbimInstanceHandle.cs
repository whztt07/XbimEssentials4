using System;
using System.Reflection;
using Xbim.Common;

namespace Xbim.IO
{
    /// <summary>
    /// A lightweight structure for obtaining a handle to an Ifc Instance, the instance is not loaded into memory unless the GetInstance function is called
    /// IfcInstanceHandle are specific to the model they were generated from
    /// </summary>
    public struct XbimInstanceHandle
    {
        public int EntityLabel;
        public short EntityTypeId;
        public XbimModel Model;
       
        public static bool operator ==(XbimInstanceHandle a, XbimInstanceHandle b)
        {
            return a.Model == b.Model && a.EntityLabel == b.EntityLabel && a.EntityTypeId == b.EntityTypeId;
        }

        public static bool operator !=(XbimInstanceHandle a, XbimInstanceHandle b)
        {
            return a.Model != b.Model || a.EntityLabel != b.EntityLabel || a.EntityTypeId == b.EntityTypeId;
        }

        public override int GetHashCode()
        {
            return EntityLabel.GetHashCode() ^ Model.GetHashCode();
        }

        public override bool Equals(object b)
        {
            return this.Model == ((XbimInstanceHandle)b).Model && 
                   this.EntityLabel  == ((XbimInstanceHandle)b).EntityLabel && 
                   this.EntityTypeId == ((XbimInstanceHandle)b).EntityTypeId;
        }

        public Type EntityType
        {
            get
            {
                return ExpressMetaData.GetType(EntityTypeId, Model.SchemaModule);
            }
        }

        public ExpressType EntityExpressType
        {
            get
            {
                return ExpressMetaData.ExpressType(EntityTypeId, Model.SchemaModule);
            }
        }
        
        public bool IsEmpty
        {
            get
            {
                return (Model == null);
            }
        }

        
        public XbimInstanceHandle(XbimModel model, int entityLabel, short type = 0)
        {
            Model = model;
            EntityLabel = entityLabel;
            EntityTypeId= type;
        }

        public XbimInstanceHandle(XbimModel model, int entityLabel, Type type)
        {
            Model = model;
            EntityLabel = entityLabel;
            EntityTypeId = ExpressMetaData.ExpressTypeId(type);
        }

        public XbimInstanceHandle(XbimModel model, int? label, short? type)
        {
            Model = model;
            this.EntityLabel = label ?? 0;
            this.EntityTypeId = type ?? 0;  
        }

        public XbimInstanceHandle(IPersistEntity entity)
        {
            Model = (XbimModel)entity.Model;
            this.EntityLabel = entity.EntityLabel;
            this.EntityTypeId = ExpressMetaData.ExpressTypeId(entity);
        }

        public IPersistEntity GetEntity()
        {
            return Model.Instances[EntityLabel];
        }
       
        internal ExpressType ExpressType()
        {
            return ExpressMetaData.ExpressType(EntityTypeId, Model.SchemaModule);
        }




       
    }
}
