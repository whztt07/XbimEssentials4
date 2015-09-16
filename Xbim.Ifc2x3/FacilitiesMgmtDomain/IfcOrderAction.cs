// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		16.09.2015 10:12:19
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.ProcessExtension;
using Xbim.Ifc2x3.UtilityResource;
using Xbim.Ifc2x3.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.FacilitiesMgmtDomain
{
	[EntityName("IFCORDERACTION", 591)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcOrderAction : IfcTask, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcOrderAction(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcIdentifier _actionID;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(10, EntityAttributeState.Mandatory)]
		public IfcIdentifier @ActionID 
		{ 
			get 
			{
				if(Activated) return _actionID;
				
				Model.Activate(this, true);
				Activated = true;
				return _actionID;
			} 
			set
			{
				SetValue( v =>  _actionID = v, _actionID, value,  "ActionID");
			} 
		}
	
		#endregion

		#region Inverse attributes

		#endregion

		#region Index access
		private static readonly List<string> AttributeNames = new List<string>
		{
			"GlobalId",
			"OwnerHistory",
			"Name",
			"Description",
			"ObjectType",
			"TaskId",
			"Status",
			"WorkMethod",
			"IsMilestone",
			"Priority",
			"ActionID",
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
					return @TaskId;
				case 6: 
					return @Status;
				case 7: 
					return @WorkMethod;
				case 8: 
					return @IsMilestone;
				case 9: 
					return @Priority;
				case 10: 
					return @ActionID;
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
				case "TaskId":  
					return @TaskId;
				case "Status":  
					return @Status;
				case "WorkMethod":  
					return @WorkMethod;
				case "IsMilestone":  
					return @IsMilestone;
				case "Priority":  
					return @Priority;
				case "ActionID":  
					return @ActionID;
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
					 if (value != null) @TaskId = (IfcIdentifier)value;
					 break;
				case 6:
					 @Status = (IfcLabel?)value;
					 break;
				case 7:
					 @WorkMethod = (IfcLabel?)value;
					 break;
				case 8:
					 if (value != null) @IsMilestone = (bool)value;
					 break;
				case 9:
					 @Priority = (long?)value;
					 break;
				case 10:
					 if (value != null) @ActionID = (IfcIdentifier)value;
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
				case "TaskId":
					 if (value != null) @TaskId = (IfcIdentifier)value;
					 break;
				case "Status":
					 @Status = (IfcLabel?)value;
					 break;
				case "WorkMethod":
					 @WorkMethod = (IfcLabel?)value;
					 break;
				case "IsMilestone":
					 if (value != null) @IsMilestone = (bool)value;
					 break;
				case "Priority":
					 @Priority = (long?)value;
					 break;
				case "ActionID":
					 if (value != null) @ActionID = (IfcIdentifier)value;
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
				case 5: 
				case 6: 
				case 7: 
				case 8: 
				case 9: 
					base.Parse(propIndex, value); 
					return;
				case 10: 
					_actionID = value.StringVal;
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