// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.QuantityResource
{
	[ExpressType("IFCQUANTITYWEIGHT", 877)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcQuantityWeight : IfcPhysicalSimpleQuantity, IInstantiableEntity, IEqualityComparer<@IfcQuantityWeight>, IEquatable<@IfcQuantityWeight>
	{
		public static int LoadDepth = 1;

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcQuantityWeight(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcMassMeasure _weightValue;
		private IfcLabel? _formula;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcMassMeasure @WeightValue 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _weightValue;
				((IPersistEntity)this).Activate(false);
				return _weightValue;
			} 
			set
			{
				SetValue( v =>  _weightValue = v, _weightValue, value,  "WeightValue");
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel? @Formula 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _formula;
				((IPersistEntity)this).Activate(false);
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
					_weightValue = value.RealVal;
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