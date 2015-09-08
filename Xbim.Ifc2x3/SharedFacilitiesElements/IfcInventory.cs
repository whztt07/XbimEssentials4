// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 02:29:13
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
using Xbim.Ifc2x3.CostResource;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc2x3.SharedFacilitiesElements
{
	[EntityName("IFCINVENTORY", 280)]
	public  partial class @IfcInventory : IfcGroup, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcInventory(IModel model) : base(model) 		{ 
			Model = model; 
			_responsiblePersons = new ItemSet<IfcPerson>( model );
		}

		#region Explicit attribute fields
		private IfcInventoryTypeEnum _inventoryType;
		private IfcActorSelect _jurisdiction;
		private ItemSet<IfcPerson> _responsiblePersons;
		private IfcCalendarDate _lastUpdateDate;
		private IfcCostValue _currentValue;
		private IfcCostValue _originalValue;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(5, EntityAttributeState.Mandatory)]
		public IfcInventoryTypeEnum @InventoryType 
		{ 
			get 
			{
				if(Activated) return _inventoryType;
				
				Model.Activate(this, true);
				Activated = true;
				return _inventoryType;
			} 
			set
			{
				SetValue( v =>  _inventoryType = v, _inventoryType, value,  "InventoryType");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Mandatory)]
		public IfcActorSelect @Jurisdiction 
		{ 
			get 
			{
				if(Activated) return _jurisdiction;
				
				Model.Activate(this, true);
				Activated = true;
				return _jurisdiction;
			} 
			set
			{
				SetValue( v =>  _jurisdiction = v, _jurisdiction, value,  "Jurisdiction");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Mandatory)]
		public ItemSet<IfcPerson> @ResponsiblePersons 
		{ 
			get 
			{
				if(Activated) return _responsiblePersons;
				
				Model.Activate(this, true);
				Activated = true;
				return _responsiblePersons;
			} 
			set
			{
				SetValue( v =>  _responsiblePersons = v, _responsiblePersons, value,  "ResponsiblePersons");
			} 
		}
	
		[EntityAttribute(8, EntityAttributeState.Mandatory)]
		public IfcCalendarDate @LastUpdateDate 
		{ 
			get 
			{
				if(Activated) return _lastUpdateDate;
				
				Model.Activate(this, true);
				Activated = true;
				return _lastUpdateDate;
			} 
			set
			{
				SetValue( v =>  _lastUpdateDate = v, _lastUpdateDate, value,  "LastUpdateDate");
			} 
		}
	
		[EntityAttribute(9, EntityAttributeState.Optional)]
		public IfcCostValue @CurrentValue 
		{ 
			get 
			{
				if(Activated) return _currentValue;
				
				Model.Activate(this, true);
				Activated = true;
				return _currentValue;
			} 
			set
			{
				SetValue( v =>  _currentValue = v, _currentValue, value,  "CurrentValue");
			} 
		}
	
		[EntityAttribute(10, EntityAttributeState.Optional)]
		public IfcCostValue @OriginalValue 
		{ 
			get 
			{
				if(Activated) return _originalValue;
				
				Model.Activate(this, true);
				Activated = true;
				return _originalValue;
			} 
			set
			{
				SetValue( v =>  _originalValue = v, _originalValue, value,  "OriginalValue");
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
			"InventoryType",
			"Jurisdiction",
			"ResponsiblePersons",
			"LastUpdateDate",
			"CurrentValue",
			"OriginalValue",
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
					return @InventoryType;
				case 6: 
					return @Jurisdiction;
				case 7: 
					return @ResponsiblePersons;
				case 8: 
					return @LastUpdateDate;
				case 9: 
					return @CurrentValue;
				case 10: 
					return @OriginalValue;
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
				case "InventoryType":  
					return @InventoryType;
				case "Jurisdiction":  
					return @Jurisdiction;
				case "ResponsiblePersons":  
					return @ResponsiblePersons;
				case "LastUpdateDate":  
					return @LastUpdateDate;
				case "CurrentValue":  
					return @CurrentValue;
				case "OriginalValue":  
					return @OriginalValue;
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
					 if (value != null) @InventoryType = (IfcInventoryTypeEnum)value;
					 break;
				case 6:
					 @Jurisdiction = (IfcActorSelect)value;
					 break;
				case 7:
					 @ResponsiblePersons.Add((IfcPerson)value);
					 break;
				case 8:
					 @LastUpdateDate = (IfcCalendarDate)value;
					 break;
				case 9:
					 @CurrentValue = (IfcCostValue)value;
					 break;
				case 10:
					 @OriginalValue = (IfcCostValue)value;
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
				case "InventoryType":
					 if (value != null) @InventoryType = (IfcInventoryTypeEnum)value;
					 break;
				case "Jurisdiction":
					 @Jurisdiction = (IfcActorSelect)value;
					 break;
				case "ResponsiblePersons":
					 @ResponsiblePersons.Add((IfcPerson)value);
					 break;
				case "LastUpdateDate":
					 @LastUpdateDate = (IfcCalendarDate)value;
					 break;
				case "CurrentValue":
					 @CurrentValue = (IfcCostValue)value;
					 break;
				case "OriginalValue":
					 @OriginalValue = (IfcCostValue)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion

		#region Where rules
		/*WR41:                 ))) = 0;*/
		#endregion

		#region IPersist implementation
		void IPersist.Set(int propIndex, IPropertyValue value)
		{
            throw new System.NotImplementedException();
		}
		#endregion

	}
}