// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 09:16:38
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.ProcessExtension;
using Xbim.Ifc2x3.UtilityResource;
using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.ProductExtension;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc2x3.FacilitiesMgmtDomain
{
	[EntityName("IFCMOVE")]
	public  partial class @IfcMove : IfcTask, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcMove(IModel model) : base(model) 		{ 
			Model = model; 
			_punchList = new ItemSet<IfcText>( model );
		}

		#region Explicit attribute fields
		private IfcSpatialStructureElement _moveFrom;
		private IfcSpatialStructureElement _moveTo;
		private ItemSet<IfcText> _punchList;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(10, EntityAttributeState.Mandatory)]
		public IfcSpatialStructureElement @MoveFrom 
		{ 
			get 
			{
				if(IsActivated) return _moveFrom;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _moveFrom;
			} 
			set
			{
				SetValue( v =>  _moveFrom = v, _moveFrom, value,  "MoveFrom");
			} 
		}
	
		[EntityAttribute(11, EntityAttributeState.Mandatory)]
		public IfcSpatialStructureElement @MoveTo 
		{ 
			get 
			{
				if(IsActivated) return _moveTo;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _moveTo;
			} 
			set
			{
				SetValue( v =>  _moveTo = v, _moveTo, value,  "MoveTo");
			} 
		}
	
		[EntityAttribute(12, EntityAttributeState.Optional)]
		public ItemSet<IfcText> @PunchList 
		{ 
			get 
			{
				if(IsActivated) return _punchList;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _punchList;
			} 
			set
			{
				SetValue( v =>  _punchList = v, _punchList, value,  "PunchList");
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
			"MoveFrom",
			"MoveTo",
			"PunchList",
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
				case 10: 
					return @MoveFrom;
				case 11: 
					return @MoveTo;
				case 12: 
					return @PunchList;
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
				case "MoveFrom":  
					return @MoveFrom;
				case "MoveTo":  
					return @MoveTo;
				case "PunchList":  
					return @PunchList;
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
					 @Priority = (int?)value;
					 break;
				case 10:
					 @MoveFrom = (IfcSpatialStructureElement)value;
					 break;
				case 11:
					 @MoveTo = (IfcSpatialStructureElement)value;
					 break;
				case 12:
					 @PunchList = (ItemSet<IfcText>)value;
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
					 @Priority = (int?)value;
					 break;
				case "MoveFrom":
					 @MoveFrom = (IfcSpatialStructureElement)value;
					 break;
				case "MoveTo":
					 @MoveTo = (IfcSpatialStructureElement)value;
					 break;
				case "PunchList":
					 @PunchList = (ItemSet<IfcText>)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion

		#region Where rules
		/*WR1:	WR1 : SIZEOF(SELF\IfcProcess.OperatesOn) >= 1;*/
		/*WR2:              )) >= 1;*/
		/*WR3:	WR3 : EXISTS(SELF\IfcRoot.Name);*/
		#endregion

		#region IPersist implementation
		public void Set(int propIndex, IPropertyValue value)
		{
            throw new System.NotImplementedException();
		}
		#endregion

	}
}