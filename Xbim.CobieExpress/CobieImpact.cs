// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.CobieExpress
{
	[IndexedClass]
	[ExpressType("IMPACT", 30)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @CobieImpact : CobieReferencedObject, IInstantiableEntity, IEqualityComparer<@CobieImpact>, IEquatable<@CobieImpact>
	{
		public static int LoadDepth = 1;

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal CobieImpact(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private string _name;
		private string _description;
		private CobiePickValue _impactType;
		private CobiePickValue _impactStage;
		private double _value;
		private CobiePickValue _impactUnit;
		private double _leadInTime;
		private double _duration;
		private double _leadOutTime;
		private CobiePickValue _timeUnit;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public string @Name 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _name;
				((IPersistEntity)this).Activate(false);
				return _name;
			} 
			set
			{
				SetValue( v =>  _name = v, _name, value,  "Name");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public string @Description 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _description;
				((IPersistEntity)this).Activate(false);
				return _description;
			} 
			set
			{
				SetValue( v =>  _description = v, _description, value,  "Description");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public CobiePickValue @ImpactType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _impactType;
				((IPersistEntity)this).Activate(false);
				return _impactType;
			} 
			set
			{
				SetValue( v =>  _impactType = v, _impactType, value,  "ImpactType");
			} 
		}
	
		[EntityAttribute(8, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public CobiePickValue @ImpactStage 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _impactStage;
				((IPersistEntity)this).Activate(false);
				return _impactStage;
			} 
			set
			{
				SetValue( v =>  _impactStage = v, _impactStage, value,  "ImpactStage");
			} 
		}
	
		[EntityAttribute(9, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public double @Value 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _value;
				((IPersistEntity)this).Activate(false);
				return _value;
			} 
			set
			{
				SetValue( v =>  _value = v, _value, value,  "Value");
			} 
		}
	
		[EntityAttribute(10, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public CobiePickValue @ImpactUnit 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _impactUnit;
				((IPersistEntity)this).Activate(false);
				return _impactUnit;
			} 
			set
			{
				SetValue( v =>  _impactUnit = v, _impactUnit, value,  "ImpactUnit");
			} 
		}
	
		[EntityAttribute(11, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public double @LeadInTime 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _leadInTime;
				((IPersistEntity)this).Activate(false);
				return _leadInTime;
			} 
			set
			{
				SetValue( v =>  _leadInTime = v, _leadInTime, value,  "LeadInTime");
			} 
		}
	
		[EntityAttribute(12, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public double @Duration 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _duration;
				((IPersistEntity)this).Activate(false);
				return _duration;
			} 
			set
			{
				SetValue( v =>  _duration = v, _duration, value,  "Duration");
			} 
		}
	
		[EntityAttribute(13, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public double @LeadOutTime 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _leadOutTime;
				((IPersistEntity)this).Activate(false);
				return _leadOutTime;
			} 
			set
			{
				SetValue( v =>  _leadOutTime = v, _leadOutTime, value,  "LeadOutTime");
			} 
		}
	
		[EntityAttribute(14, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public CobiePickValue @TimeUnit 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _timeUnit;
				((IPersistEntity)this).Activate(false);
				return _timeUnit;
			} 
			set
			{
				SetValue( v =>  _timeUnit = v, _timeUnit, value,  "TimeUnit");
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
				case 4: 
					_name = value.StringVal;
					return;
				case 5: 
					_description = value.StringVal;
					return;
				case 6: 
					_impactType = (CobiePickValue)(value.EntityVal);
					return;
				case 7: 
					_impactStage = (CobiePickValue)(value.EntityVal);
					return;
				case 8: 
					_value = value.RealVal;
					return;
				case 9: 
					_impactUnit = (CobiePickValue)(value.EntityVal);
					return;
				case 10: 
					_leadInTime = value.RealVal;
					return;
				case 11: 
					_duration = value.RealVal;
					return;
				case 12: 
					_leadOutTime = value.RealVal;
					return;
				case 13: 
					_timeUnit = (CobiePickValue)(value.EntityVal);
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
        public bool Equals(@CobieImpact other)
	    {
	        return this == other;
	    }


        public static bool operator ==(@CobieImpact left, @CobieImpact right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@CobieImpact left, @CobieImpact right)
        {
            return !(left == right);
        }


        public bool Equals(@CobieImpact x, @CobieImpact y)
        {
            return x == y;
        }

        public int GetHashCode(@CobieImpact obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}