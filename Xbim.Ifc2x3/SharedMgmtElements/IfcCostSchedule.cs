// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		16.09.2015 10:12:18
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.Kernel;
using Xbim.Ifc2x3.UtilityResource;
using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.ActorResource;
using Xbim.Ifc2x3.DateTimeResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.SharedMgmtElements
{
	[EntityName("IFCCOSTSCHEDULE", 695)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcCostSchedule : IfcControl, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcCostSchedule(IModel model) : base(model) 		{ 
			Model = model; 
			_targetUsers = new ItemSet<IfcActorSelect>( model );
		}

		#region Explicit attribute fields
		private IfcActorSelect _submittedBy;
		private IfcActorSelect _preparedBy;
		private IfcDateTimeSelect _submittedOn;
		private IfcLabel? _status;
		private ItemSet<IfcActorSelect> _targetUsers;
		private IfcDateTimeSelect _updateDate;
		private IfcIdentifier _iD;
		private IfcCostScheduleTypeEnum _predefinedType;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(5, EntityAttributeState.Optional)]
		public IfcActorSelect @SubmittedBy 
		{ 
			get 
			{
				if(Activated) return _submittedBy;
				
				Model.Activate(this, true);
				Activated = true;
				return _submittedBy;
			} 
			set
			{
				SetValue( v =>  _submittedBy = v, _submittedBy, value,  "SubmittedBy");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Optional)]
		public IfcActorSelect @PreparedBy 
		{ 
			get 
			{
				if(Activated) return _preparedBy;
				
				Model.Activate(this, true);
				Activated = true;
				return _preparedBy;
			} 
			set
			{
				SetValue( v =>  _preparedBy = v, _preparedBy, value,  "PreparedBy");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Optional)]
		public IfcDateTimeSelect @SubmittedOn 
		{ 
			get 
			{
				if(Activated) return _submittedOn;
				
				Model.Activate(this, true);
				Activated = true;
				return _submittedOn;
			} 
			set
			{
				SetValue( v =>  _submittedOn = v, _submittedOn, value,  "SubmittedOn");
			} 
		}
	
		[EntityAttribute(8, EntityAttributeState.Optional)]
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
	
		[EntityAttribute(9, EntityAttributeState.Optional)]
		public ItemSet<IfcActorSelect> @TargetUsers 
		{ 
			get 
			{
				if(Activated) return _targetUsers;
				
				Model.Activate(this, true);
				Activated = true;
				return _targetUsers;
			} 
			set
			{
				SetValue( v =>  _targetUsers = v, _targetUsers, value,  "TargetUsers");
			} 
		}
	
		[EntityAttribute(10, EntityAttributeState.Optional)]
		public IfcDateTimeSelect @UpdateDate 
		{ 
			get 
			{
				if(Activated) return _updateDate;
				
				Model.Activate(this, true);
				Activated = true;
				return _updateDate;
			} 
			set
			{
				SetValue( v =>  _updateDate = v, _updateDate, value,  "UpdateDate");
			} 
		}
	
		[EntityAttribute(11, EntityAttributeState.Mandatory)]
		public IfcIdentifier @ID 
		{ 
			get 
			{
				if(Activated) return _iD;
				
				Model.Activate(this, true);
				Activated = true;
				return _iD;
			} 
			set
			{
				SetValue( v =>  _iD = v, _iD, value,  "ID");
			} 
		}
	
		[EntityAttribute(12, EntityAttributeState.Mandatory)]
		public IfcCostScheduleTypeEnum @PredefinedType 
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
		private static readonly List<string> AttributeNames = new List<string>
		{
			"GlobalId",
			"OwnerHistory",
			"Name",
			"Description",
			"ObjectType",
			"SubmittedBy",
			"PreparedBy",
			"SubmittedOn",
			"Status",
			"TargetUsers",
			"UpdateDate",
			"ID",
			"PredefinedType",
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
					return @SubmittedBy;
				case 6: 
					return @PreparedBy;
				case 7: 
					return @SubmittedOn;
				case 8: 
					return @Status;
				case 9: 
					return @TargetUsers;
				case 10: 
					return @UpdateDate;
				case 11: 
					return @ID;
				case 12: 
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
				case "SubmittedBy":  
					return @SubmittedBy;
				case "PreparedBy":  
					return @PreparedBy;
				case "SubmittedOn":  
					return @SubmittedOn;
				case "Status":  
					return @Status;
				case "TargetUsers":  
					return @TargetUsers;
				case "UpdateDate":  
					return @UpdateDate;
				case "ID":  
					return @ID;
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
					 @SubmittedBy = (IfcActorSelect)value;
					 break;
				case 6:
					 @PreparedBy = (IfcActorSelect)value;
					 break;
				case 7:
					 @SubmittedOn = (IfcDateTimeSelect)value;
					 break;
				case 8:
					 @Status = (IfcLabel?)value;
					 break;
				case 9:
					 @TargetUsers.Add((IfcActorSelect)value);
					 break;
				case 10:
					 @UpdateDate = (IfcDateTimeSelect)value;
					 break;
				case 11:
					 if (value != null) @ID = (IfcIdentifier)value;
					 break;
				case 12:
					 if (value != null) @PredefinedType = (IfcCostScheduleTypeEnum)value;
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
				case "SubmittedBy":
					 @SubmittedBy = (IfcActorSelect)value;
					 break;
				case "PreparedBy":
					 @PreparedBy = (IfcActorSelect)value;
					 break;
				case "SubmittedOn":
					 @SubmittedOn = (IfcDateTimeSelect)value;
					 break;
				case "Status":
					 @Status = (IfcLabel?)value;
					 break;
				case "TargetUsers":
					 @TargetUsers.Add((IfcActorSelect)value);
					 break;
				case "UpdateDate":
					 @UpdateDate = (IfcDateTimeSelect)value;
					 break;
				case "ID":
					 if (value != null) @ID = (IfcIdentifier)value;
					 break;
				case "PredefinedType":
					 if (value != null) @PredefinedType = (IfcCostScheduleTypeEnum)value;
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
					_submittedBy = (IfcActorSelect)(value.EntityVal);
					return;
				case 6: 
					_preparedBy = (IfcActorSelect)(value.EntityVal);
					return;
				case 7: 
					_submittedOn = (IfcDateTimeSelect)(value.EntityVal);
					return;
				case 8: 
					_status = value.StringVal;
					return;
				case 9: 
					if (_targetUsers == null) _targetUsers = new ItemSet<IfcActorSelect>( Model );
					_targetUsers.Add((IfcActorSelect)value.EntityVal);
					return;
				case 10: 
					_updateDate = (IfcDateTimeSelect)(value.EntityVal);
					return;
				case 11: 
					_iD = value.StringVal;
					return;
				case 12: 
                    _predefinedType = (IfcCostScheduleTypeEnum) System.Enum.Parse(typeof (IfcCostScheduleTypeEnum), value.EnumVal, true);
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