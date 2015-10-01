// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.QuantityResource
{
	[ExpressType("IFCQUANTITYAREA", 871)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcQuantityArea : IfcPhysicalSimpleQuantity, IInstantiableEntity, System.Collections.Generic.IEqualityComparer<@IfcQuantityArea>, System.IEquatable<@IfcQuantityArea>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcQuantityArea(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcAreaMeasure _areaValue;
		private IfcLabel? _formula;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcAreaMeasure @AreaValue 
		{ 
			get 
			{
				if(Activated) return _areaValue;
				
				Model.Activate(this, true);
				Activated = true;
				return _areaValue;
			} 
			set
			{
				SetValue( v =>  _areaValue = v, _areaValue, value,  "AreaValue");
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel? @Formula 
		{ 
			get 
			{
				if(Activated) return _formula;
				
				Model.Activate(this, true);
				Activated = true;
				return _formula;
			} 
			set
			{
				SetValue( v =>  _formula = v, _formula, value,  "Formula");
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
					base.Parse(propIndex, value); 
					return;
				case 3: 
					_areaValue = value.RealVal;
					return;
				case 4: 
					_formula = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR21:                (SELF\IfcPhysicalSimpleQuantity.Unit.UnitType = IfcUnitEnum.AREAUNIT);*/
		/*WR22:	WR22 : AreaValue >= 0.;*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcQuantityArea other)
	    {
	        return this == other;
	    }


        public static bool operator ==(@IfcQuantityArea left, @IfcQuantityArea right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcQuantityArea left, @IfcQuantityArea right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcQuantityArea x, @IfcQuantityArea y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcQuantityArea obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}