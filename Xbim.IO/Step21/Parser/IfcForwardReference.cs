using System;
using System.Collections.Concurrent;
using Xbim.Common;


namespace Xbim.IO.Parser
{
    public struct IfcForwardReference
    {
        public readonly int ReferenceEntityLabel;
        private readonly short ReferencingPropertyId;
        private readonly IInstantiableEntity ReferencingEntity;

        public IfcForwardReference(int referenceEntityLabel,
            short referencingProperty,
            IInstantiableEntity referencingEntity)
        {
            ReferenceEntityLabel = referenceEntityLabel;
            ReferencingPropertyId = referencingProperty;
            ReferencingEntity = referencingEntity;
        }

        public bool Resolve(ConcurrentDictionary<int, IInstantiableEntity> references)
        {
            IInstantiableEntity entity;
            if (references.TryGetValue(ReferenceEntityLabel, out entity))
            {
                var pv = new PropertyValue();
                pv.Init(entity);
                try
                {
                    ReferencingEntity.Set(ReferencingPropertyId, pv);
                    return true;
                }
                catch (Exception)
                {
                    var ifcType = IfcMetaData.IfcType(ReferencingEntity);
                    
                    XbimModel.Logger.ErrorFormat("Data Error. Cannot set the property = {0} of entity #{1} = {2} to entity #{3}, schema violation. Ignored", 
                        ifcType.IfcProperties[ReferencingPropertyId+1].PropertyInfo.Name, 
                        ReferencingEntity.EntityLabel,
                        ReferencingEntity.GetType().Name,
                        ReferenceEntityLabel);
                    return false;
                }
            }
            else
                return false;
        }
    }
}
