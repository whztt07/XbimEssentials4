// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		15.09.2015 07:03:42
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc4.DateTimeResource
{
	[EntityName("IFCTASKTIMERECURRING", 692)]
	public  partial class @IfcTaskTimeRecurring : IfcTaskTime, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTaskTimeRecurring(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcRecurrencePattern _recurrance;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(20, EntityAttributeState.Mandatory)]
		public IfcRecurrencePattern @Recurrance 
		{ 
			get 
			{
				if(Activated) return _recurrance;
				
				Model.Activate(this, true);
				Activated = true;
				return _recurrance;
			} 
			set
			{
				SetValue( v =>  _recurrance = v, _recurrance, value,  "Recurrance");
			} 
		}
	
		#endregion

		#region Inverse attributes

		#endregion

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"Name",
			"DataOrigin",
			"UserDefinedDataOrigin",
			"DurationType",
			"ScheduleDuration",
			"ScheduleStart",
			"ScheduleFinish",
			"EarlyStart",
			"EarlyFinish",
			"LateStart",
			"LateFinish",
			"FreeFloat",
			"TotalFloat",
			"IsCritical",
			"StatusTime",
			"ActualDuration",
			"ActualStart",
			"ActualFinish",
			"RemainingTime",
			"Completion",
			"Recurrance",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @Name;
				case 1: 
					return @DataOrigin;
				case 2: 
					return @UserDefinedDataOrigin;
				case 3: 
					return @DurationType;
				case 4: 
					return @ScheduleDuration;
				case 5: 
					return @ScheduleStart;
				case 6: 
					return @ScheduleFinish;
				case 7: 
					return @EarlyStart;
				case 8: 
					return @EarlyFinish;
				case 9: 
					return @LateStart;
				case 10: 
					return @LateFinish;
				case 11: 
					return @FreeFloat;
				case 12: 
					return @TotalFloat;
				case 13: 
					return @IsCritical;
				case 14: 
					return @StatusTime;
				case 15: 
					return @ActualDuration;
				case 16: 
					return @ActualStart;
				case 17: 
					return @ActualFinish;
				case 18: 
					return @RemainingTime;
				case 19: 
					return @Completion;
				case 20: 
					return @Recurrance;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "Name":  
					return @Name;
				case "DataOrigin":  
					return @DataOrigin;
				case "UserDefinedDataOrigin":  
					return @UserDefinedDataOrigin;
				case "DurationType":  
					return @DurationType;
				case "ScheduleDuration":  
					return @ScheduleDuration;
				case "ScheduleStart":  
					return @ScheduleStart;
				case "ScheduleFinish":  
					return @ScheduleFinish;
				case "EarlyStart":  
					return @EarlyStart;
				case "EarlyFinish":  
					return @EarlyFinish;
				case "LateStart":  
					return @LateStart;
				case "LateFinish":  
					return @LateFinish;
				case "FreeFloat":  
					return @FreeFloat;
				case "TotalFloat":  
					return @TotalFloat;
				case "IsCritical":  
					return @IsCritical;
				case "StatusTime":  
					return @StatusTime;
				case "ActualDuration":  
					return @ActualDuration;
				case "ActualStart":  
					return @ActualStart;
				case "ActualFinish":  
					return @ActualFinish;
				case "RemainingTime":  
					return @RemainingTime;
				case "Completion":  
					return @Completion;
				case "Recurrance":  
					return @Recurrance;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 @Name = (IfcLabel?)value;
					 break;
				case 1:
					 @DataOrigin = (IfcDataOriginEnum?)value;
					 break;
				case 2:
					 @UserDefinedDataOrigin = (IfcLabel?)value;
					 break;
				case 3:
					 @DurationType = (IfcTaskDurationEnum?)value;
					 break;
				case 4:
					 @ScheduleDuration = (IfcDuration?)value;
					 break;
				case 5:
					 @ScheduleStart = (IfcDateTime?)value;
					 break;
				case 6:
					 @ScheduleFinish = (IfcDateTime?)value;
					 break;
				case 7:
					 @EarlyStart = (IfcDateTime?)value;
					 break;
				case 8:
					 @EarlyFinish = (IfcDateTime?)value;
					 break;
				case 9:
					 @LateStart = (IfcDateTime?)value;
					 break;
				case 10:
					 @LateFinish = (IfcDateTime?)value;
					 break;
				case 11:
					 @FreeFloat = (IfcDuration?)value;
					 break;
				case 12:
					 @TotalFloat = (IfcDuration?)value;
					 break;
				case 13:
					 @IsCritical = (bool?)value;
					 break;
				case 14:
					 @StatusTime = (IfcDateTime?)value;
					 break;
				case 15:
					 @ActualDuration = (IfcDuration?)value;
					 break;
				case 16:
					 @ActualStart = (IfcDateTime?)value;
					 break;
				case 17:
					 @ActualFinish = (IfcDateTime?)value;
					 break;
				case 18:
					 @RemainingTime = (IfcDuration?)value;
					 break;
				case 19:
					 @Completion = (IfcPositiveRatioMeasure?)value;
					 break;
				case 20:
					 @Recurrance = (IfcRecurrencePattern)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "Name":
					 @Name = (IfcLabel?)value;
					 break;
				case "DataOrigin":
					 @DataOrigin = (IfcDataOriginEnum?)value;
					 break;
				case "UserDefinedDataOrigin":
					 @UserDefinedDataOrigin = (IfcLabel?)value;
					 break;
				case "DurationType":
					 @DurationType = (IfcTaskDurationEnum?)value;
					 break;
				case "ScheduleDuration":
					 @ScheduleDuration = (IfcDuration?)value;
					 break;
				case "ScheduleStart":
					 @ScheduleStart = (IfcDateTime?)value;
					 break;
				case "ScheduleFinish":
					 @ScheduleFinish = (IfcDateTime?)value;
					 break;
				case "EarlyStart":
					 @EarlyStart = (IfcDateTime?)value;
					 break;
				case "EarlyFinish":
					 @EarlyFinish = (IfcDateTime?)value;
					 break;
				case "LateStart":
					 @LateStart = (IfcDateTime?)value;
					 break;
				case "LateFinish":
					 @LateFinish = (IfcDateTime?)value;
					 break;
				case "FreeFloat":
					 @FreeFloat = (IfcDuration?)value;
					 break;
				case "TotalFloat":
					 @TotalFloat = (IfcDuration?)value;
					 break;
				case "IsCritical":
					 @IsCritical = (bool?)value;
					 break;
				case "StatusTime":
					 @StatusTime = (IfcDateTime?)value;
					 break;
				case "ActualDuration":
					 @ActualDuration = (IfcDuration?)value;
					 break;
				case "ActualStart":
					 @ActualStart = (IfcDateTime?)value;
					 break;
				case "ActualFinish":
					 @ActualFinish = (IfcDateTime?)value;
					 break;
				case "RemainingTime":
					 @RemainingTime = (IfcDuration?)value;
					 break;
				case "Completion":
					 @Completion = (IfcPositiveRatioMeasure?)value;
					 break;
				case "Recurrance":
					 @Recurrance = (IfcRecurrencePattern)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion


		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
            throw new System.NotImplementedException();
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		}
		#endregion

		
	}
}