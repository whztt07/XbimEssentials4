// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		16.09.2015 10:12:21
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
	[EntityName("IFCSCHEDULETIMECONTROL", 402)]
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
		[EntityAttribute(5, EntityAttributeState.Optional)]
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
	
		[EntityAttribute(6, EntityAttributeState.Optional)]
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
	
		[EntityAttribute(7, EntityAttributeState.Optional)]
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
	
		[EntityAttribute(8, EntityAttributeState.Optional)]
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
	
		[EntityAttribute(9, EntityAttributeState.Optional)]
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
	
		[EntityAttribute(10, EntityAttributeState.Optional)]
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
	
		[EntityAttribute(11, EntityAttributeState.Optional)]
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
	
		[EntityAttribute(12, EntityAttributeState.Optional)]
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
	
		[EntityAttribute(13, EntityAttributeState.Optional)]
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
	
		[EntityAttribute(14, EntityAttributeState.Optional)]
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
	
		[EntityAttribute(15, EntityAttributeState.Optional)]
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
	
		[EntityAttribute(16, EntityAttributeState.Optional)]
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
	
		[EntityAttribute(17, EntityAttributeState.Optional)]
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
	
		[EntityAttribute(18, EntityAttributeState.Optional)]
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
	
		[EntityAttribute(19, EntityAttributeState.Optional)]
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
	
		[EntityAttribute(20, EntityAttributeState.Optional)]
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
	
		[EntityAttribute(21, EntityAttributeState.Optional)]
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
	
		[EntityAttribute(22, EntityAttributeState.Optional)]
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
		public IEnumerable<IfcRelAssignsTasks> @ScheduleTimeControlAssigned 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelAssignsTasks>(e => e.TimeForTask == this);
			} 
		}
	

		#endregion

		#region Index access
		private static readonly List<string> AttributeNames = new List<string>
		{
			"GlobalId",
			"OwnerHistory",
			"Name",
			"Description",
			"ObjectType",
			"ActualStart",
			"EarlyStart",
			"LateStart",
			"ScheduleStart",
			"ActualFinish",
			"EarlyFinish",
			"LateFinish",
			"ScheduleFinish",
			"ScheduleDuration",
			"ActualDuration",
			"RemainingTime",
			"FreeFloat",
			"TotalFloat",
			"IsCritical",
			"StatusTime",
			"StartFloat",
			"FinishFloat",
			"Completion",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return AttributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @GlobalId;
				case 1: 
					return @OwnerHistory;
				case 2: 
					return @Name;
				case 3: 
					return @Description;
				case 4: 
					return @ObjectType;
				case 5: 
					return @ActualStart;
				case 6: 
					return @EarlyStart;
				case 7: 
					return @LateStart;
				case 8: 
					return @ScheduleStart;
				case 9: 
					return @ActualFinish;
				case 10: 
					return @EarlyFinish;
				case 11: 
					return @LateFinish;
				case 12: 
					return @ScheduleFinish;
				case 13: 
					return @ScheduleDuration;
				case 14: 
					return @ActualDuration;
				case 15: 
					return @RemainingTime;
				case 16: 
					return @FreeFloat;
				case 17: 
					return @TotalFloat;
				case 18: 
					return @IsCritical;
				case 19: 
					return @StatusTime;
				case 20: 
					return @StartFloat;
				case 21: 
					return @FinishFloat;
				case 22: 
					return @Completion;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "GlobalId":  
					return @GlobalId;
				case "OwnerHistory":  
					return @OwnerHistory;
				case "Name":  
					return @Name;
				case "Description":  
					return @Description;
				case "ObjectType":  
					return @ObjectType;
				case "ActualStart":  
					return @ActualStart;
				case "EarlyStart":  
					return @EarlyStart;
				case "LateStart":  
					return @LateStart;
				case "ScheduleStart":  
					return @ScheduleStart;
				case "ActualFinish":  
					return @ActualFinish;
				case "EarlyFinish":  
					return @EarlyFinish;
				case "LateFinish":  
					return @LateFinish;
				case "ScheduleFinish":  
					return @ScheduleFinish;
				case "ScheduleDuration":  
					return @ScheduleDuration;
				case "ActualDuration":  
					return @ActualDuration;
				case "RemainingTime":  
					return @RemainingTime;
				case "FreeFloat":  
					return @FreeFloat;
				case "TotalFloat":  
					return @TotalFloat;
				case "IsCritical":  
					return @IsCritical;
				case "StatusTime":  
					return @StatusTime;
				case "StartFloat":  
					return @StartFloat;
				case "FinishFloat":  
					return @FinishFloat;
				case "Completion":  
					return @Completion;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 if (value != null) @GlobalId = (IfcGloballyUniqueId)value;
					 break;
				case 1:
					 @OwnerHistory = (IfcOwnerHistory)value;
					 break;
				case 2:
					 @Name = (IfcLabel?)value;
					 break;
				case 3:
					 @Description = (IfcText?)value;
					 break;
				case 4:
					 @ObjectType = (IfcLabel?)value;
					 break;
				case 5:
					 @ActualStart = (IfcDateTimeSelect)value;
					 break;
				case 6:
					 @EarlyStart = (IfcDateTimeSelect)value;
					 break;
				case 7:
					 @LateStart = (IfcDateTimeSelect)value;
					 break;
				case 8:
					 @ScheduleStart = (IfcDateTimeSelect)value;
					 break;
				case 9:
					 @ActualFinish = (IfcDateTimeSelect)value;
					 break;
				case 10:
					 @EarlyFinish = (IfcDateTimeSelect)value;
					 break;
				case 11:
					 @LateFinish = (IfcDateTimeSelect)value;
					 break;
				case 12:
					 @ScheduleFinish = (IfcDateTimeSelect)value;
					 break;
				case 13:
					 @ScheduleDuration = (IfcTimeMeasure?)value;
					 break;
				case 14:
					 @ActualDuration = (IfcTimeMeasure?)value;
					 break;
				case 15:
					 @RemainingTime = (IfcTimeMeasure?)value;
					 break;
				case 16:
					 @FreeFloat = (IfcTimeMeasure?)value;
					 break;
				case 17:
					 @TotalFloat = (IfcTimeMeasure?)value;
					 break;
				case 18:
					 @IsCritical = (bool?)value;
					 break;
				case 19:
					 @StatusTime = (IfcDateTimeSelect)value;
					 break;
				case 20:
					 @StartFloat = (IfcTimeMeasure?)value;
					 break;
				case 21:
					 @FinishFloat = (IfcTimeMeasure?)value;
					 break;
				case 22:
					 @Completion = (IfcPositiveRatioMeasure?)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "GlobalId":
					 if (value != null) @GlobalId = (IfcGloballyUniqueId)value;
					 break;
				case "OwnerHistory":
					 @OwnerHistory = (IfcOwnerHistory)value;
					 break;
				case "Name":
					 @Name = (IfcLabel?)value;
					 break;
				case "Description":
					 @Description = (IfcText?)value;
					 break;
				case "ObjectType":
					 @ObjectType = (IfcLabel?)value;
					 break;
				case "ActualStart":
					 @ActualStart = (IfcDateTimeSelect)value;
					 break;
				case "EarlyStart":
					 @EarlyStart = (IfcDateTimeSelect)value;
					 break;
				case "LateStart":
					 @LateStart = (IfcDateTimeSelect)value;
					 break;
				case "ScheduleStart":
					 @ScheduleStart = (IfcDateTimeSelect)value;
					 break;
				case "ActualFinish":
					 @ActualFinish = (IfcDateTimeSelect)value;
					 break;
				case "EarlyFinish":
					 @EarlyFinish = (IfcDateTimeSelect)value;
					 break;
				case "LateFinish":
					 @LateFinish = (IfcDateTimeSelect)value;
					 break;
				case "ScheduleFinish":
					 @ScheduleFinish = (IfcDateTimeSelect)value;
					 break;
				case "ScheduleDuration":
					 @ScheduleDuration = (IfcTimeMeasure?)value;
					 break;
				case "ActualDuration":
					 @ActualDuration = (IfcTimeMeasure?)value;
					 break;
				case "RemainingTime":
					 @RemainingTime = (IfcTimeMeasure?)value;
					 break;
				case "FreeFloat":
					 @FreeFloat = (IfcTimeMeasure?)value;
					 break;
				case "TotalFloat":
					 @TotalFloat = (IfcTimeMeasure?)value;
					 break;
				case "IsCritical":
					 @IsCritical = (bool?)value;
					 break;
				case "StatusTime":
					 @StatusTime = (IfcDateTimeSelect)value;
					 break;
				case "StartFloat":
					 @StartFloat = (IfcTimeMeasure?)value;
					 break;
				case "FinishFloat":
					 @FinishFloat = (IfcTimeMeasure?)value;
					 break;
				case "Completion":
					 @Completion = (IfcPositiveRatioMeasure?)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
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