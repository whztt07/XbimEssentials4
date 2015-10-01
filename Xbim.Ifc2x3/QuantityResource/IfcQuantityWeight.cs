// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.QuantityResource
{
	[ExpressType("IFCQUANTITYWEIGHT", 603)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcQuantityWeight : IfcPhysicalSimpleQuantity, IInstantiableEntity, System.Collections.Generic.IEqualityComparer<@IfcQuantityWeight>, System.IEquatable<@IfcQuantityWeight>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcQuantityWeight(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcMassMeasure _weightValue;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcMassMeasure @WeightValue 
		{ 
			get 
			{
				if(Activated) return _weightValue;
				
				Model.Activate(this, true);
				Activated = true;
				return _weightValue;
			} 
			set
			{
				SetValue( v =>  _weightValue = v, _weightValue, value,  "WeightValue");
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
					_weightValue = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR21:                (SELF\IfcPhysicalSimpleQuantity.Unit.UnitType = IfcUnitEnum.MASSUNIT);*/
		/*WR22:	WR22 : WeightValue >= 0.;*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcQuantityWeight other)
	    {
	        return this == other;
	    }


        public static bool operator ==(@IfcQuantityWeight left, @IfcQuantityWeight right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcQuantityWeight left, @IfcQuantityWeight right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcQuantityWeight x, @IfcQuantityWeight y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcQuantityWeight obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}