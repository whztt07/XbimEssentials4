// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 02:29:15
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.UtilityResource;
using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.DateTimeResource;
using Xbim.Ifc2x3.ActorResource;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc2x3.ProcessExtension
{
	[EntityName("IFCWORKPLAN", 649)]
	public  partial class @IfcWorkPlan : IfcWorkControl, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcWorkPlan(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		#endregion
	
		#region Explicit attribute properties
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
			"Identifier",
			"CreationDate",
			"Creators",
			"Purpose",
			"Duration",
			"TotalFloat",
			"StartTime",
			"FinishTime",
			"WorkControlType",
			"UserDefinedControlType",
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
					return @Identifier;
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
					return @WorkControlType;
				case 14: 
					return @UserDefinedControlType;
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
				case "Identifier":  
					return @Identifier;
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
				case "WorkControlType":  
					return @WorkControlType;
				case "UserDefinedControlType":  
					return @UserDefinedControlType;
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
					 if (value != null) @Identifier = (IfcIdentifier)value;
					 break;
				case 6:
					 @CreationDate = (IfcDateTimeSelect)value;
					 break;
				case 7:
					 @Creators.Add((IfcPerson)value);
					 break;
				case 8:
					 @Purpose = (IfcLabel?)value;
					 break;
				case 9:
					 @Duration = (IfcTimeMeasure?)value;
					 break;
				case 10:
					 @TotalFloat = (IfcTimeMeasure?)value;
					 break;
				case 11:
					 @StartTime = (IfcDateTimeSelect)value;
					 break;
				case 12:
					 @FinishTime = (IfcDateTimeSelect)value;
					 break;
				case 13:
					 @WorkControlType = (IfcWorkControlTypeEnum)value;
					 break;
				case 14:
					 @UserDefinedControlType = (IfcLabel?)value;
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
				case "Identifier":
					 if (value != null) @Identifier = (IfcIdentifier)value;
					 break;
				case "CreationDate":
					 @CreationDate = (IfcDateTimeSelect)value;
					 break;
				case "Creators":
					 @Creators.Add((IfcPerson)value);
					 break;
				case "Purpose":
					 @Purpose = (IfcLabel?)value;
					 break;
				case "Duration":
					 @Duration = (IfcTimeMeasure?)value;
					 break;
				case "TotalFloat":
					 @TotalFloat = (IfcTimeMeasure?)value;
					 break;
				case "StartTime":
					 @StartTime = (IfcDateTimeSelect)value;
					 break;
				case "FinishTime":
					 @FinishTime = (IfcDateTimeSelect)value;
					 break;
				case "WorkControlType":
					 @WorkControlType = (IfcWorkControlTypeEnum)value;
					 break;
				case "UserDefinedControlType":
					 @UserDefinedControlType = (IfcLabel?)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion


		#region IPersist implementation
		void IPersist.Set(int propIndex, IPropertyValue value)
		{
            throw new System.NotImplementedException();
		}
		#endregion

	}
}