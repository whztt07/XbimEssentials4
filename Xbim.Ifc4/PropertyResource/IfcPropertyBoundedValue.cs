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

namespace Xbim.Ifc4.PropertyResource
{
	[ExpressType("IFCPROPERTYBOUNDEDVALUE", 850)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcPropertyBoundedValue : IfcSimpleProperty, IInstantiableEntity, IEqualityComparer<@IfcPropertyBoundedValue>, IEquatable<@IfcPropertyBoundedValue>
	{
		public static int LoadDepth = 1;

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPropertyBoundedValue(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcValue _upperBoundValue;
		private IfcValue _lowerBoundValue;
		private IfcUnit _unit;
		private IfcValue _setPointValue;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcValue @UpperBoundValue 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _upperBoundValue;
				((IPersistEntity)this).Activate(false);
				return _upperBoundValue;
			} 
			set
			{
				SetValue( v =>  _upperBoundValue = v, _upperBoundValue, value,  "UpperBoundValue");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcValue @LowerBoundValue 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _lowerBoundValue;
				((IPersistEntity)this).Activate(false);
				return _lowerBoundValue;
			} 
			set
			{
				SetValue( v =>  _lowerBoundValue = v, _lowerBoundValue, value,  "LowerBoundValue");
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcUnit @Unit 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _unit;
				((IPersistEntity)this).Activate(false);
				return _unit;
			} 
			set
			{
				SetValue( v =>  _unit = v, _unit, value,  "Unit");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcValue @SetPointValue 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _setPointValue;
				((IPersistEntity)this).Activate(false);
				return _setPointValue;
			} 
			set
			{
				SetValue( v =>  _setPointValue = v, _setPointValue, value,  "SetPointValue");
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
					base.Parse(propIndex, value); 
					return;
				case 2: 
					_upperBoundValue = (IfcValue)(value.EntityVal);
					return;
				case 3: 
					_lowerBoundValue = (IfcValue)(value.EntityVal);
					return;
				case 4: 
					_unit = (IfcUnit)(value.EntityVal);
					return;
				case 5: 
					_setPointValue = (IfcValue)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*SameUnitUpperLower:                           (TYPEOF(UpperBoundValue) = TYPEOF(LowerBoundValue));*/
		/*SameUnitUpperSet:                           (TYPEOF(UpperBoundValue) = TYPEOF(SetPointValue));*/
		/*SameUnitLowerSet:                           (TYPEOF(LowerBoundValue) = TYPEOF(SetPointValue));*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcPropertyBoundedValue other)
	    {
	        return this == other;
	    }


        public static bool operator ==(@IfcPropertyBoundedValue left, @IfcPropertyBoundedValue right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcPropertyBoundedValue left, @IfcPropertyBoundedValue right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcPropertyBoundedValue x, @IfcPropertyBoundedValue y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcPropertyBoundedValue obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}