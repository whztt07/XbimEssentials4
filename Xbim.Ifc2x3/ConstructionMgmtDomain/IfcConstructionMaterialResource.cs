// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.UtilityResource;
using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.ActorResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.ConstructionMgmtDomain
{
	[ExpressType("IFCCONSTRUCTIONMATERIALRESOURCE", 243)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcConstructionMaterialResource : IfcConstructionResource, IInstantiableEntity, System.Collections.Generic.IEqualityComparer<@IfcConstructionMaterialResource>, System.IEquatable<@IfcConstructionMaterialResource>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcConstructionMaterialResource(IModel model) : base(model) 		{ 
			Model = model; 
			_suppliers = new OptionalItemSet<IfcActorSelect>( this );
		}

		#region Explicit attribute fields
		private OptionalItemSet<IfcActorSelect> _suppliers;
		private IfcRatioMeasure? _usageRatio;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1)]
		public OptionalItemSet<IfcActorSelect> @Suppliers 
		{ 
			get 
			{
				if(Activated) return _suppliers;
				
				Model.Activate(this, true);
				Activated = true;
				return _suppliers;
			} 
		}
	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcRatioMeasure? @UsageRatio 
		{ 
			get 
			{
				if(Activated) return _usageRatio;
				
				Model.Activate(this, true);
				Activated = true;
				return _usageRatio;
			} 
			set
			{
				SetValue( v =>  _usageRatio = v, _usageRatio, value,  "UsageRatio");
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
				case 4: 
				case 5: 
				case 6: 
				case 7: 
				case 8: 
					base.Parse(propIndex, value); 
					return;
				case 9: 
					if (_suppliers == null) _suppliers = new OptionalItemSet<IfcActorSelect>( this );
					_suppliers.InternalAdd((IfcActorSelect)value.EntityVal);
					return;
				case 10: 
					_usageRatio = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR1:	WR1 : SIZEOF(SELF\IfcResource.ResourceOf) <=1;*/
		/*WR2:            (SELF\IfcResource.ResourceOf[1].RelatedObjectsType = IfcObjectTypeEnum.PRODUCT);*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcConstructionMaterialResource other)
	    {
	        return this == other;
	    }


        public static bool operator ==(@IfcConstructionMaterialResource left, @IfcConstructionMaterialResource right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcConstructionMaterialResource left, @IfcConstructionMaterialResource right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcConstructionMaterialResource x, @IfcConstructionMaterialResource y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcConstructionMaterialResource obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}