// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.Kernel;
using Xbim.Ifc2x3.UtilityResource;
using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.DateTimeResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.ProcessExtension
{
	[ExpressType("IFCSCHEDULETIMECONTROL", 402)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcScheduleTimeControl : IfcControl, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcScheduleTimeControl(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcDateTimeSelect _actualStart;
		private IfcDateTimeSelect _earlyStart;
		private IfcDateTimeSelect _lateStart;
		private IfcDateTimeSelect _scheduleStart;
		private IfcDateTimeSelect _actualFinish;
		private IfcDateTimeSelect _earlyFinish;
		private IfcDateTimeSelect _lateFinish;
		private IfcDateTimeSelect _scheduleFinish;
		private IfcTimeMeasure? _scheduleDuration;
		private IfcTimeMeasure? _actualDuration;
		private IfcTimeMeasure? _remainingTime;
		private IfcTimeMeasure? _freeFloat;
		private IfcTimeMeasure? _totalFloat;
		private bool? _isCritical;
		private IfcDateTimeSelect _statusTime;
		private IfcTimeMeasure? _startFloat;
		private IfcTimeMeasure? _finishFloat;
		private IfcPositiveRatioMeasure? _completion;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcDateTimeSelect @ActualStart 
		{ 
			get 
			{
				if(Activated) return _actualStart;
				
				Model.Activate(this, true);
				Activated = true;
				return _actualStart;
			} 
			set
			{
				SetValue( v =>  _actualStart = v, _actualStart, value,  "ActualStart");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcDateTimeSelect @EarlyStart 
		{ 
			get 
			{
				if(Activated) return _earlyStart;
				
				Model.Activate(this, true);
				Activated = true;
				return _earlyStart;
			} 
			set
			{
				SetValue( v =>  _earlyStart = v, _earlyStart, value,  "EarlyStart");
			} 
		}
	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcDateTimeSelect @LateStart 
		{ 
			get 
			{
				if(Activated) return _lateStart;
				
				Model.Activate(this, true);
				Activated = true;
				return _lateStart;
			} 
			set
			{
				SetValue( v =>  _lateStart = v, _lateStart, value,  "LateStart");
			} 
		}
	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcDateTimeSelect @ScheduleStart 
		{ 
			get 
			{
				if(Activated) return _scheduleStart;
				
				Model.Activate(this, true);
				Activated = true;
				return _scheduleStart;
			} 
			set
			{
				SetValue( v =>  _scheduleStart = v, _scheduleStart, value,  "ScheduleStart");
			} 
		}
	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcDateTimeSelect @ActualFinish 
		{ 
			get 
			{
				if(Activated) return _actualFinish;
				
				Model.Activate(this, true);
				Activated = true;
				return _actualFinish;
			} 
			set
			{
				SetValue( v =>  _actualFinish = v, _actualFinish, value,  "ActualFinish");
			} 
		}
	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcDateTimeSelect @EarlyFinish 
		{ 
			get 
			{
				if(Activated) return _earlyFinish;
				
				Model.Activate(this, true);
				Activated = true;
				return _earlyFinish;
			} 
			set
			{
				SetValue( v =>  _earlyFinish = v, _earlyFinish, value,  "EarlyFinish");
			} 
		}
	
		[EntityAttribute(12, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcDateTimeSelect @LateFinish 
		{ 
			get 
			{
				if(Activated) return _lateFinish;
				
				Model.Activate(this, true);
				Activated = true;
				return _lateFinish;
			} 
			set
			{
				SetValue( v =>  _lateFinish = v, _lateFinish, value,  "LateFinish");
			} 
		}
	
		[EntityAttribute(13, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcDateTimeSelect @ScheduleFinish 
		{ 
			get 
			{
				if(Activated) return _scheduleFinish;
				
				Model.Activate(this, true);
				Activated = true;
				return _scheduleFinish;
			} 
			set
			{
				SetValue( v =>  _scheduleFinish = v, _scheduleFinish, value,  "ScheduleFinish");
			} 
		}
	
		[EntityAttribute(14, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcTimeMeasure? @ScheduleDuration 
		{ 
			get 
			{
				if(Activated) return _scheduleDuration;
				
				Model.Activate(this, true);
				Activated = true;
				return _scheduleDuration;
			} 
			set
			{
				SetValue( v =>  _scheduleDuration = v, _scheduleDuration, value,  "ScheduleDuration");
			} 
		}
	
		[EntityAttribute(15, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcTimeMeasure? @ActualDuration 
		{ 
			get 
			{
				if(Activated) return _actualDuration;
				
				Model.Activate(this, true);
				Activated = true;
				return _actualDuration;
			} 
			set
			{
				SetValue( v =>  _actualDuration = v, _actualDuration, value,  "ActualDuration");
			} 
		}
	
		[EntityAttribute(16, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcTimeMeasure? @RemainingTime 
		{ 
			get 
			{
				if(Activated) return _remainingTime;
				
				Model.Activate(this, true);
				Activated = true;
				return _remainingTime;
			} 
			set
			{
				SetValue( v =>  _remainingTime = v, _remainingTime, value,  "RemainingTime");
			} 
		}
	
		[EntityAttribute(17, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcTimeMeasure? @FreeFloat 
		{ 
			get 
			{
				if(Activated) return _freeFloat;
				
				Model.Activate(this, true);
				Activated = true;
				return _freeFloat;
			} 
			set
			{
				SetValue( v =>  _freeFloat = v, _freeFloat, value,  "FreeFloat");
			} 
		}
	
		[EntityAttribute(18, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcTimeMeasure? @TotalFloat 
		{ 
			get 
			{
				if(Activated) return _totalFloat;
				
				Model.Activate(this, true);
				Activated = true;
				return _totalFloat;
			} 
			set
			{
				SetValue( v =>  _totalFloat = v, _totalFloat, value,  "TotalFloat");
			} 
		}
	
		[EntityAttribute(19, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public bool? @IsCritical 
		{ 
			get 
			{
				if(Activated) return _isCritical;
				
				Model.Activate(this, true);
				Activated = true;
				return _isCritical;
			} 
			set
			{
				SetValue( v =>  _isCritical = v, _isCritical, value,  "IsCritical");
			} 
		}
	
		[EntityAttribute(20, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcDateTimeSelect @StatusTime 
		{ 
			get 
			{
				if(Activated) return _statusTime;
				
				Model.Activate(this, true);
				Activated = true;
				return _statusTime;
			} 
			set
			{
				SetValue( v =>  _statusTime = v, _statusTime, value,  "StatusTime");
			} 
		}
	
		[EntityAttribute(21, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcTimeMeasure? @StartFloat 
		{ 
			get 
			{
				if(Activated) return _startFloat;
				
				Model.Activate(this, true);
				Activated = true;
				return _startFloat;
			} 
			set
			{
				SetValue( v =>  _startFloat = v, _startFloat, value,  "StartFloat");
			} 
		}
	
		[EntityAttribute(22, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcTimeMeasure? @FinishFloat 
		{ 
			get 
			{
				if(Activated) return _finishFloat;
				
				Model.Activate(this, true);
				Activated = true;
				return _finishFloat;
			} 
			set
			{
				SetValue( v =>  _finishFloat = v, _finishFloat, value,  "FinishFloat");
			} 
		}
	
		[EntityAttribute(23, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveRatioMeasure? @Completion 
		{ 
			get 
			{
				if(Activated) return _completion;
				
				Model.Activate(this, true);
				Activated = true;
				return _completion;
			} 
			set
			{
				SetValue( v =>  _completion = v, _completion, value,  "Completion");
			} 
		}
	
		#endregion

		#region Inverse attributes
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IfcRelAssignsTasks @ScheduleTimeControlAssigned 
		{ 
			get 
			{
				return Model.Instances.FirstOrDefault<IfcRelAssignsTasks>(e => e.TimeForTask == this);
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
					base.Parse(propIndex, value); 
					return;
				case 5: 
					_actualStart = (IfcDateTimeSelect)(value.EntityVal);
					return;
				case 6: 
					_earlyStart = (IfcDateTimeSelect)(value.EntityVal);
					return;
				case 7: 
					_lateStart = (IfcDateTimeSelect)(value.EntityVal);
					return;
				case 8: 
					_scheduleStart = (IfcDateTimeSelect)(value.EntityVal);
					return;
				case 9: 
					_actualFinish = (IfcDateTimeSelect)(value.EntityVal);
					return;
				case 10: 
					_earlyFinish = (IfcDateTimeSelect)(value.EntityVal);
					return;
				case 11: 
					_lateFinish = (IfcDateTimeSelect)(value.EntityVal);
					return;
				case 12: 
					_scheduleFinish = (IfcDateTimeSelect)(value.EntityVal);
					return;
				case 13: 
					_scheduleDuration = value.RealVal;
					return;
				case 14: 
					_actualDuration = value.RealVal;
					return;
				case 15: 
					_remainingTime = value.RealVal;
					return;
				case 16: 
					_freeFloat = value.RealVal;
					return;
				case 17: 
					_totalFloat = value.RealVal;
					return;
				case 18: 
					_isCritical = value.BooleanVal;
					return;
				case 19: 
					_statusTime = (IfcDateTimeSelect)(value.EntityVal);
					return;
				case 20: 
					_startFloat = value.RealVal;
					return;
				case 21: 
					_finishFloat = value.RealVal;
					return;
				case 22: 
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
	}
}