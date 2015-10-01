// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.Kernel
{
	[ExpressType("IFCOBJECTDEFINITION", 775)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcObjectDefinition : IfcRoot, IfcDefinitionSelect, System.Collections.Generic.IEqualityComparer<@IfcObjectDefinition>, System.IEquatable<@IfcObjectDefinition>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcObjectDefinition(IModel model) : base(model) 		{ 
			Model = model; 
		}


		#region Inverse attributes
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcRelAssigns> @HasAssignments 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelAssigns>(e => e.RelatedObjects != null &&  e.RelatedObjects.Contains(this));
			} 
		}
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcRelNests> @Nests 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelNests>(e => e.RelatedObjects != null &&  e.RelatedObjects.Contains(this));
			} 
		}
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcRelNests> @IsNestedBy 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelNests>(e => e.RelatingObject == this);
			} 
		}
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcRelDeclares> @HasContext 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelDeclares>(e => e.RelatedDefinitions != null &&  e.RelatedDefinitions.Contains(this));
			} 
		}
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcRelAggregates> @IsDecomposedBy 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelAggregates>(e => e.RelatingObject == this);
			} 
		}
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcRelAggregates> @Decomposes 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelAggregates>(e => e.RelatedObjects != null &&  e.RelatedObjects.Contains(this));
			} 
		}
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcRelAssociates> @HasAssociations 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelAssociates>(e => e.RelatedObjects != null &&  e.RelatedObjects.Contains(this));
			} 
		}
		#endregion


		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
				case 3: 
					base.Parse(propIndex, value); 
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
			return "";
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcObjectDefinition other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcObjectDefinition
            var root = (@IfcObjectDefinition)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcObjectDefinition left, @IfcObjectDefinition right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcObjectDefinition left, @IfcObjectDefinition right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcObjectDefinition x, @IfcObjectDefinition y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcObjectDefinition obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}