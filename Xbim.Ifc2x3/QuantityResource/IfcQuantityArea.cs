// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.QuantityResource
{
	[ExpressType("IFCQUANTITYAREA", 495)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcQuantityArea : IfcPhysicalSimpleQuantity, IInstantiableEntity, IEqualityComparer<@IfcQuantityArea>, IEquatable<@IfcQuantityArea>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcQuantityArea(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcAreaMeasure _areaValue;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcAreaMeasure @AreaValue 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _areaValue;
				((IPersistEntity)this).Activate(false);
				return _areaValue;
			} 
			set
			{
				SetValue( v =>  _areaValue = v, _areaValue, value,  "AreaValue");
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

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcQuantityArea
            var root = (@IfcQuantityArea)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
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