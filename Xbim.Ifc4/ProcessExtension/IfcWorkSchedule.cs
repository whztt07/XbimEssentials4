// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		15.09.2015 07:03:42
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.UtilityResource;
using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.DateTimeResource;
using Xbim.Ifc4.ActorResource;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc4.ProcessExtension
{
	[EntityName("IFCWORKSCHEDULE", 762)]
	public  partial class @IfcWorkSchedule : IfcWorkControl, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcWorkSchedule(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcWorkScheduleTypeEnum? _predefinedType;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(13, EntityAttributeState.Optional)]
		public IfcWorkScheduleTypeEnum? @PredefinedType 
		{ 
			get 
			{
				if(Activated) return _predefinedType;
				
				Model.Activate(this, true);
				Activated = true;
				return _predefinedType;
			} 
			set
			{
				SetValue( v =>  _predefinedType = v, _predefinedType, value,  "PredefinedType");
			} 
		}
	
		#endregion

		#region Inverse attributes

		#endregion

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"GlobalId",
			"OwnerHistory",
			"Name",
			"Description",
			"ObjectType",
			"Identification",
			"CreationDate",
			"Creators",
			"Purpose",
			"Duration",
			"TotalFloat",
			"StartTime",
			"FinishTime",
			"PredefinedType",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

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
					return @Identification;
				case 6: 
					return @CreationDate;
				case 7: 
					return @Creators;
				case 8: 
					return @Purpose;
				case 9: 
					return @Duration;
				case 10: 
					return @TotalFloat;
				case 11: 
					return @StartTime;
				case 12: 
					return @FinishTime;
				case 13: 
					return @PredefinedType;
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
				case "Identification":  
					return @Identification;
				case "CreationDate":  
					return @CreationDate;
				case "Creators":  
					return @Creators;
				case "Purpose":  
					return @Purpose;
				case "Duration":  
					return @Duration;
				case "TotalFloat":  
					return @TotalFloat;
				case "StartTime":  
					return @StartTime;
				case "FinishTime":  
					return @FinishTime;
				case "PredefinedType":  
					return @PredefinedType;
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
					 @Identification = (IfcIdentifier?)value;
					 break;
				case 6:
					 if (value != null) @CreationDate = (IfcDateTime)value;
					 break;
				case 7:
					 @Creators.Add((IfcPerson)value);
					 break;
				case 8:
					 @Purpose = (IfcLabel?)value;
					 break;
				case 9:
					 @Duration = (IfcDuration?)value;
					 break;
				case 10:
					 @TotalFloat = (IfcDuration?)value;
					 break;
				case 11:
					 if (value != null) @StartTime = (IfcDateTime)value;
					 break;
				case 12:
					 @FinishTime = (IfcDateTime?)value;
					 break;
				case 13:
					 @PredefinedType = (IfcWorkScheduleTypeEnum?)value;
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
				case "Identification":
					 @Identification = (IfcIdentifier?)value;
					 break;
				case "CreationDate":
					 if (value != null) @CreationDate = (IfcDateTime)value;
					 break;
				case "Creators":
					 @Creators.Add((IfcPerson)value);
					 break;
				case "Purpose":
					 @Purpose = (IfcLabel?)value;
					 break;
				case "Duration":
					 @Duration = (IfcDuration?)value;
					 break;
				case "TotalFloat":
					 @TotalFloat = (IfcDuration?)value;
					 break;
				case "StartTime":
					 if (value != null) @StartTime = (IfcDateTime)value;
					 break;
				case "FinishTime":
					 @FinishTime = (IfcDateTime?)value;
					 break;
				case "PredefinedType":
					 @PredefinedType = (IfcWorkScheduleTypeEnum?)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion

		#region Where rules
		/*CorrectPredefinedType:                              ((PredefinedType = IfcWorkScheduleTypeEnum.USERDEFINED) AND EXISTS(SELF\IfcObject.ObjectType));*/
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