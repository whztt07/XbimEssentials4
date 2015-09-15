// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		15.09.2015 07:04:19
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.Kernel;
using Xbim.Ifc2x3.UtilityResource;
using Xbim.Ifc2x3.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc2x3.ProcessExtension
{
	[EntityName("IFCTASK", 72)]
	public  partial class @IfcTask : IfcProcess, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTask(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcIdentifier _taskId;
		private IfcLabel? _status;
		private IfcLabel? _workMethod;
		private bool _isMilestone;
		private long? _priority;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(5, EntityAttributeState.Mandatory)]
		public IfcIdentifier @TaskId 
		{ 
			get 
			{
				if(Activated) return _taskId;
				
				Model.Activate(this, true);
				Activated = true;
				return _taskId;
			} 
			set
			{
				SetValue( v =>  _taskId = v, _taskId, value,  "TaskId");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Optional)]
		public IfcLabel? @Status 
		{ 
			get 
			{
				if(Activated) return _status;
				
				Model.Activate(this, true);
				Activated = true;
				return _status;
			} 
			set
			{
				SetValue( v =>  _status = v, _status, value,  "Status");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Optional)]
		public IfcLabel? @WorkMethod 
		{ 
			get 
			{
				if(Activated) return _workMethod;
				
				Model.Activate(this, true);
				Activated = true;
				return _workMethod;
			} 
			set
			{
				SetValue( v =>  _workMethod = v, _workMethod, value,  "WorkMethod");
			} 
		}
	
		[EntityAttribute(8, EntityAttributeState.Mandatory)]
		public bool @IsMilestone 
		{ 
			get 
			{
				if(Activated) return _isMilestone;
				
				Model.Activate(this, true);
				Activated = true;
				return _isMilestone;
			} 
			set
			{
				SetValue( v =>  _isMilestone = v, _isMilestone, value,  "IsMilestone");
			} 
		}
	
		[EntityAttribute(9, EntityAttributeState.Optional)]
		public long? @Priority 
		{ 
			get 
			{
				if(Activated) return _priority;
				
				Model.Activate(this, true);
				Activated = true;
				return _priority;
			} 
			set
			{
				SetValue( v =>  _priority = v, _priority, value,  "Priority");
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
			"TaskId",
			"Status",
			"WorkMethod",
			"IsMilestone",
			"Priority",
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
					return @TaskId;
				case 6: 
					return @Status;
				case 7: 
					return @WorkMethod;
				case 8: 
					return @IsMilestone;
				case 9: 
					return @Priority;
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
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion

		#region Where rules
		/*WR1:	WR1 : SIZEOF(QUERY(temp <* SELF\IfcObjectDefinition.Decomposes | NOT('IFC2X3.IFCRELNESTS' IN TYPEOF(temp)))) = 0;*/
		/*WR2:	WR2 : SIZEOF(QUERY(temp <* SELF\IfcObjectDefinition.IsDecomposedBy | NOT('IFC2X3.IFCRELNESTS' IN TYPEOF(temp)))) = 0;*/
		/*WR3:	WR3 : EXISTS(SELF\IfcRoot.Name);*/
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