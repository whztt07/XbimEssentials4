// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		15.09.2015 07:03:37
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Kernel;
using Xbim.Ifc4.UtilityResource;
using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.DateTimeResource;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc4.SharedMgmtElements
{
	[EntityName("IFCCOSTSCHEDULE", 148)]
	public  partial class @IfcCostSchedule : IfcControl, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcCostSchedule(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcCostScheduleTypeEnum? _predefinedType;
		private IfcLabel? _status;
		private IfcDateTime? _submittedOn;
		private IfcDateTime? _updateDate;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(6, EntityAttributeState.Optional)]
		public IfcCostScheduleTypeEnum? @PredefinedType 
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
	
		[EntityAttribute(7, EntityAttributeState.Optional)]
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
	
		[EntityAttribute(8, EntityAttributeState.Optional)]
		public IfcDateTime? @SubmittedOn 
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
	
		[EntityAttribute(9, EntityAttributeState.Optional)]
		public IfcDateTime? @UpdateDate 
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
			"PredefinedType",
			"Status",
			"SubmittedOn",
			"UpdateDate",
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
					return @PredefinedType;
				case 7: 
					return @Status;
				case 8: 
					return @SubmittedOn;
				case 9: 
					return @UpdateDate;
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
				case "PredefinedType":  
					return @PredefinedType;
				case "Status":  
					return @Status;
				case "SubmittedOn":  
					return @SubmittedOn;
				case "UpdateDate":  
					return @UpdateDate;
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
					 @PredefinedType = (IfcCostScheduleTypeEnum?)value;
					 break;
				case 7:
					 @Status = (IfcLabel?)value;
					 break;
				case 8:
					 @SubmittedOn = (IfcDateTime?)value;
					 break;
				case 9:
					 @UpdateDate = (IfcDateTime?)value;
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
				case "PredefinedType":
					 @PredefinedType = (IfcCostScheduleTypeEnum?)value;
					 break;
				case "Status":
					 @Status = (IfcLabel?)value;
					 break;
				case "SubmittedOn":
					 @SubmittedOn = (IfcDateTime?)value;
					 break;
				case "UpdateDate":
					 @UpdateDate = (IfcDateTime?)value;
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