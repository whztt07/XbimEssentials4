using System;
using System.Collections.Concurrent;
using Xbim.Common;
using Xbim.IO.Esent;

namespace Xbim.IO.Step21.Parser
{
    public struct StepForwardReference
    {
        public readonly int ReferenceEntityLabel;
        private readonly short ReferencingPropertyId;
        private readonly IPersistEntity ReferencingEntity;

        public StepForwardReference(int referenceEntityLabel,
            short referencingProperty,
            IPersistEntity referencingEntity)
        {
            ReferenceEntityLabel = referenceEntityLabel;
            ReferencingPropertyId = referencingProperty;
            ReferencingEntity = referencingEntity;
        }

        public bool Resolve(ConcurrentDictionary<int, IPersistEntity> references)
        {
            IPersistEntity entity;
            if (references.TryGetValue(ReferenceEntityLabel, out entity))
            {
                var pv = new PropertyValue();
                pv.Init(entity);
                try
                {
                    ReferencingEntity.Parse(ReferencingPropertyId, pv);
                    return true;
                }
                catch (Exception)
                {
                    var ifcType = ExpressMetaData.ExpressType(ReferencingEntity);
                    
                    EsentModel.Logger.ErrorFormat("Data Error. Cannot set the property = {0} of entity #{1} = {2} to entity #{3}, schema violation. Ignored", 
                        ifcType.Properties[ReferencingPropertyId+1].PropertyInfo.Name, 
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
