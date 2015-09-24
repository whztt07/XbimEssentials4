using System;
using Xbim.Common;

namespace Xbim.IO.Esent
{
    /// <summary>
    /// A lightweight structure for obtaining a handle to an Ifc Instance, the instance is not loaded into memory unless the GetInstance function is called
    /// IfcInstanceHandle are specific to the model they were generated from
    /// </summary>
    public struct XbimInstanceHandle
    {
        public readonly int EntityLabel;
        public short EntityTypeId;
        public readonly IModel Model;
       
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
            return Model == ((XbimInstanceHandle)b).Model && 
                   EntityLabel  == ((XbimInstanceHandle)b).EntityLabel && 
                   EntityTypeId == ((XbimInstanceHandle)b).EntityTypeId;
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

        
        public XbimInstanceHandle(IModel model, int entityLabel, short type = 0)
        {
            Model = model;
            EntityLabel = entityLabel;
            EntityTypeId= type;
        }

        public XbimInstanceHandle(IModel model, int entityLabel, Type type)
        {
            Model = model;
            EntityLabel = entityLabel;
            EntityTypeId = ExpressMetaData.ExpressTypeId(type);
        }

        public XbimInstanceHandle(IModel model, int? label, short? type)
        {
            Model = model;
            EntityLabel = label ?? 0;
            EntityTypeId = type ?? 0;  
        }

        public XbimInstanceHandle(IPersistEntity entity)
        {
            Model = entity.Model;
            EntityLabel = entity.EntityLabel;
            EntityTypeId = ExpressMetaData.ExpressTypeId(entity);
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
