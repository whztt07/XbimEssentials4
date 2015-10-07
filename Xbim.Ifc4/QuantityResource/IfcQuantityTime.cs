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
	[ExpressType("IFCQUANTITYTIME", 875)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcQuantityTime : IfcPhysicalSimpleQuantity, IInstantiableEntity, IEqualityComparer<@IfcQuantityTime>, IEquatable<@IfcQuantityTime>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcQuantityTime(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcTimeMeasure _timeValue;
		private IfcLabel? _formula;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcTimeMeasure @TimeValue 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _timeValue;
				((IPersistEntity)this).Activate(false);
				return _timeValue;
			} 
			set
			{
				SetValue( v =>  _timeValue = v, _timeValue, value,  "TimeValue");
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
					_timeValue = value.RealVal;
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
		/*WR21:                (SELF\IfcPhysicalSimpleQuantity.Unit.UnitType = IfcUnitEnum.TIMEUNIT);*/
		/*WR22:	WR22 : TimeValue >= 0.;*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcQuantityTime other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcQuantityTime
            var root = (@IfcQuantityTime)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcQuantityTime left, @IfcQuantityTime right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcQuantityTime left, @IfcQuantityTime right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcQuantityTime x, @IfcQuantityTime y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcQuantityTime obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}