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

namespace Xbim.Ifc4.DateTimeResource
{
	[ExpressType("IFCTASKTIME", 1082)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcTaskTime : IfcSchedulingTime, IInstantiableEntity, IEqualityComparer<@IfcTaskTime>, IEquatable<@IfcTaskTime>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTaskTime(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcTaskDurationEnum? _durationType;
		private IfcDuration? _scheduleDuration;
		private IfcDateTime? _scheduleStart;
		private IfcDateTime? _scheduleFinish;
		private IfcDateTime? _earlyStart;
		private IfcDateTime? _earlyFinish;
		private IfcDateTime? _lateStart;
		private IfcDateTime? _lateFinish;
		private IfcDuration? _freeFloat;
		private IfcDuration? _totalFloat;
		private bool? _isCritical;
		private IfcDateTime? _statusTime;
		private IfcDuration? _actualDuration;
		private IfcDateTime? _actualStart;
		private IfcDateTime? _actualFinish;
		private IfcDuration? _remainingTime;
		private IfcPositiveRatioMeasure? _completion;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcTaskDurationEnum? @DurationType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _durationType;
				((IPersistEntity)this).Activate(false);
				return _durationType;
			} 
			set
			{
				SetValue( v =>  _durationType = v, _durationType, value,  "DurationType");
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcDuration? @ScheduleDuration 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _scheduleDuration;
				((IPersistEntity)this).Activate(false);
				return _scheduleDuration;
			} 
			set
			{
				SetValue( v =>  _scheduleDuration = v, _scheduleDuration, value,  "ScheduleDuration");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcDateTime? @ScheduleStart 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _scheduleStart;
				((IPersistEntity)this).Activate(false);
				return _scheduleStart;
			} 
			set
			{
				SetValue( v =>  _scheduleStart = v, _scheduleStart, value,  "ScheduleStart");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcDateTime? @ScheduleFinish 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _scheduleFinish;
				((IPersistEntity)this).Activate(false);
				return _scheduleFinish;
			} 
			set
			{
				SetValue( v =>  _scheduleFinish = v, _scheduleFinish, value,  "ScheduleFinish");
			} 
		}
	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcDateTime? @EarlyStart 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _earlyStart;
				((IPersistEntity)this).Activate(false);
				return _earlyStart;
			} 
			set
			{
				SetValue( v =>  _earlyStart = v, _earlyStart, value,  "EarlyStart");
			} 
		}
	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcDateTime? @EarlyFinish 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _earlyFinish;
				((IPersistEntity)this).Activate(false);
				return _earlyFinish;
			} 
			set
			{
				SetValue( v =>  _earlyFinish = v, _earlyFinish, value,  "EarlyFinish");
			} 
		}
	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcDateTime? @LateStart 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _lateStart;
				((IPersistEntity)this).Activate(false);
				return _lateStart;
			} 
			set
			{
				SetValue( v =>  _lateStart = v, _lateStart, value,  "LateStart");
			} 
		}
	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcDateTime? @LateFinish 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _lateFinish;
				((IPersistEntity)this).Activate(false);
				return _lateFinish;
			} 
			set
			{
				SetValue( v =>  _lateFinish = v, _lateFinish, value,  "LateFinish");
			} 
		}
	
		[EntityAttribute(12, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcDuration? @FreeFloat 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _freeFloat;
				((IPersistEntity)this).Activate(false);
				return _freeFloat;
			} 
			set
			{
				SetValue( v =>  _freeFloat = v, _freeFloat, value,  "FreeFloat");
			} 
		}
	
		[EntityAttribute(13, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcDuration? @TotalFloat 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _totalFloat;
				((IPersistEntity)this).Activate(false);
				return _totalFloat;
			} 
			set
			{
				SetValue( v =>  _totalFloat = v, _totalFloat, value,  "TotalFloat");
			} 
		}
	
		[EntityAttribute(14, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public bool? @IsCritical 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _isCritical;
				((IPersistEntity)this).Activate(false);
				return _isCritical;
			} 
			set
			{
				SetValue( v =>  _isCritical = v, _isCritical, value,  "IsCritical");
			} 
		}
	
		[EntityAttribute(15, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcDateTime? @StatusTime 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _statusTime;
				((IPersistEntity)this).Activate(false);
				return _statusTime;
			} 
			set
			{
				SetValue( v =>  _statusTime = v, _statusTime, value,  "StatusTime");
			} 
		}
	
		[EntityAttribute(16, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcDuration? @ActualDuration 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _actualDuration;
				((IPersistEntity)this).Activate(false);
				return _actualDuration;
			} 
			set
			{
				SetValue( v =>  _actualDuration = v, _actualDuration, value,  "ActualDuration");
			} 
		}
	
		[EntityAttribute(17, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcDateTime? @ActualStart 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _actualStart;
				((IPersistEntity)this).Activate(false);
				return _actualStart;
			} 
			set
			{
				SetValue( v =>  _actualStart = v, _actualStart, value,  "ActualStart");
			} 
		}
	
		[EntityAttribute(18, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcDateTime? @ActualFinish 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _actualFinish;
				((IPersistEntity)this).Activate(false);
				return _actualFinish;
			} 
			set
			{
				SetValue( v =>  _actualFinish = v, _actualFinish, value,  "ActualFinish");
			} 
		}
	
		[EntityAttribute(19, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcDuration? @RemainingTime 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _remainingTime;
				((IPersistEntity)this).Activate(false);
				return _remainingTime;
			} 
			set
			{
				SetValue( v =>  _remainingTime = v, _remainingTime, value,  "RemainingTime");
			} 
		}
	
		[EntityAttribute(20, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveRatioMeasure? @Completion 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _completion;
				((IPersistEntity)this).Activate(false);
				return _completion;
			} 
			set
			{
				SetValue( v =>  _completion = v, _completion, value,  "Completion");
			} 
		}
	
		#endregion



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 3: 
                    _durationType = (IfcTaskDurationEnum) System.Enum.Parse(typeof (IfcTaskDurationEnum), value.EnumVal, true);
					return;
				case 4: 
					_scheduleDuration = value.StringVal;
					return;
				case 5: 
					_scheduleStart = value.StringVal;
					return;
				case 6: 
					_scheduleFinish = value.StringVal;
					return;
				case 7: 
					_earlyStart = value.StringVal;
					return;
				case 8: 
					_earlyFinish = value.StringVal;
					return;
				case 9: 
					_lateStart = value.StringVal;
					return;
				case 10: 
					_lateFinish = value.StringVal;
					return;
				case 11: 
					_freeFloat = value.StringVal;
					return;
				case 12: 
					_totalFloat = value.StringVal;
					return;
				case 13: 
					_isCritical = value.BooleanVal;
					return;
				case 14: 
					_statusTime = value.StringVal;
					return;
				case 15: 
					_actualDuration = value.StringVal;
					return;
				case 16: 
					_actualStart = value.StringVal;
					return;
				case 17: 
					_actualFinish = value.StringVal;
					return;
				case 18: 
					_remainingTime = value.StringVal;
					return;
				case 19: 
					_completion = value.RealVal;
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
        public bool Equals(@IfcTaskTime other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcTaskTime
            var root = (@IfcTaskTime)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcTaskTime left, @IfcTaskTime right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcTaskTime left, @IfcTaskTime right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcTaskTime x, @IfcTaskTime y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcTaskTime obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}