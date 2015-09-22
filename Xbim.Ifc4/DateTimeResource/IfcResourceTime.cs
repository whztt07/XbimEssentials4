// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		22.09.2015 04:44:14
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.DateTimeResource
{
	[IndexedClass]
	[ExpressType("IFCRESOURCETIME", 958)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcResourceTime : IfcSchedulingTime, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcResourceTime(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcDuration? _scheduleWork;
		private IfcPositiveRatioMeasure? _scheduleUsage;
		private IfcDateTime? _scheduleStart;
		private IfcDateTime? _scheduleFinish;
		private IfcLabel? _scheduleContour;
		private IfcDuration? _levelingDelay;
		private bool? _isOverAllocated;
		private IfcDateTime? _statusTime;
		private IfcDuration? _actualWork;
		private IfcPositiveRatioMeasure? _actualUsage;
		private IfcDateTime? _actualStart;
		private IfcDateTime? _actualFinish;
		private IfcDuration? _remainingWork;
		private IfcPositiveRatioMeasure? _remainingUsage;
		private IfcPositiveRatioMeasure? _completion;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcDuration? @ScheduleWork 
		{ 
			get 
			{
				if(Activated) return _scheduleWork;
				
				Model.Activate(this, true);
				Activated = true;
				return _scheduleWork;
			} 
			set
			{
				SetValue( v =>  _scheduleWork = v, _scheduleWork, value,  "ScheduleWork");
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveRatioMeasure? @ScheduleUsage 
		{ 
			get 
			{
				if(Activated) return _scheduleUsage;
				
				Model.Activate(this, true);
				Activated = true;
				return _scheduleUsage;
			} 
			set
			{
				SetValue( v =>  _scheduleUsage = v, _scheduleUsage, value,  "ScheduleUsage");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcDateTime? @ScheduleStart 
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
	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcDateTime? @ScheduleFinish 
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
	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel? @ScheduleContour 
		{ 
			get 
			{
				if(Activated) return _scheduleContour;
				
				Model.Activate(this, true);
				Activated = true;
				return _scheduleContour;
			} 
			set
			{
				SetValue( v =>  _scheduleContour = v, _scheduleContour, value,  "ScheduleContour");
			} 
		}
	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcDuration? @LevelingDelay 
		{ 
			get 
			{
				if(Activated) return _levelingDelay;
				
				Model.Activate(this, true);
				Activated = true;
				return _levelingDelay;
			} 
			set
			{
				SetValue( v =>  _levelingDelay = v, _levelingDelay, value,  "LevelingDelay");
			} 
		}
	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public bool? @IsOverAllocated 
		{ 
			get 
			{
				if(Activated) return _isOverAllocated;
				
				Model.Activate(this, true);
				Activated = true;
				return _isOverAllocated;
			} 
			set
			{
				SetValue( v =>  _isOverAllocated = v, _isOverAllocated, value,  "IsOverAllocated");
			} 
		}
	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcDateTime? @StatusTime 
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
	
		[EntityAttribute(12, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcDuration? @ActualWork 
		{ 
			get 
			{
				if(Activated) return _actualWork;
				
				Model.Activate(this, true);
				Activated = true;
				return _actualWork;
			} 
			set
			{
				SetValue( v =>  _actualWork = v, _actualWork, value,  "ActualWork");
			} 
		}
	
		[EntityAttribute(13, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveRatioMeasure? @ActualUsage 
		{ 
			get 
			{
				if(Activated) return _actualUsage;
				
				Model.Activate(this, true);
				Activated = true;
				return _actualUsage;
			} 
			set
			{
				SetValue( v =>  _actualUsage = v, _actualUsage, value,  "ActualUsage");
			} 
		}
	
		[EntityAttribute(14, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcDateTime? @ActualStart 
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
	
		[EntityAttribute(15, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcDateTime? @ActualFinish 
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
	
		[EntityAttribute(16, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcDuration? @RemainingWork 
		{ 
			get 
			{
				if(Activated) return _remainingWork;
				
				Model.Activate(this, true);
				Activated = true;
				return _remainingWork;
			} 
			set
			{
				SetValue( v =>  _remainingWork = v, _remainingWork, value,  "RemainingWork");
			} 
		}
	
		[EntityAttribute(17, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveRatioMeasure? @RemainingUsage 
		{ 
			get 
			{
				if(Activated) return _remainingUsage;
				
				Model.Activate(this, true);
				Activated = true;
				return _remainingUsage;
			} 
			set
			{
				SetValue( v =>  _remainingUsage = v, _remainingUsage, value,  "RemainingUsage");
			} 
		}
	
		[EntityAttribute(18, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
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
					_scheduleWork = value.StringVal;
					return;
				case 4: 
					_scheduleUsage = value.RealVal;
					return;
				case 5: 
					_scheduleStart = value.StringVal;
					return;
				case 6: 
					_scheduleFinish = value.StringVal;
					return;
				case 7: 
					_scheduleContour = value.StringVal;
					return;
				case 8: 
					_levelingDelay = value.StringVal;
					return;
				case 9: 
					_isOverAllocated = value.BooleanVal;
					return;
				case 10: 
					_statusTime = value.StringVal;
					return;
				case 11: 
					_actualWork = value.StringVal;
					return;
				case 12: 
					_actualUsage = value.RealVal;
					return;
				case 13: 
					_actualStart = value.StringVal;
					return;
				case 14: 
					_actualFinish = value.StringVal;
					return;
				case 15: 
					_remainingWork = value.StringVal;
					return;
				case 16: 
					_remainingUsage = value.RealVal;
					return;
				case 17: 
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