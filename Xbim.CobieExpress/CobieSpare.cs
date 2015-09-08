// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 02:29:26
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.CobieExpress
{
	[EntityName("SPARE", 20)]
	public  partial class @CobieSpare : CobieExternalReference, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal CobieSpare(IModel model) : base(model) 		{ 
			Model = model; 
			_suppliers = new ItemSet<CobieContact>( model );
		}

		#region Explicit attribute fields
		private string _name;
		private string _description;
		private CobiePickValue _spareType;
		private CobieType _type;
		private ItemSet<CobieContact> _suppliers;
		private string _setNumber;
		private string _partNumber;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(5, EntityAttributeState.Mandatory)]
		public string @Name 
		{ 
			get 
			{
				if(Activated) return _name;
				
				Model.Activate(this, true);
				Activated = true;
				return _name;
			} 
			set
			{
				SetValue( v =>  _name = v, _name, value,  "Name");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Optional)]
		public string @Description 
		{ 
			get 
			{
				if(Activated) return _description;
				
				Model.Activate(this, true);
				Activated = true;
				return _description;
			} 
			set
			{
				SetValue( v =>  _description = v, _description, value,  "Description");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Mandatory)]
		public CobiePickValue @SpareType 
		{ 
			get 
			{
				if(Activated) return _spareType;
				
				Model.Activate(this, true);
				Activated = true;
				return _spareType;
			} 
			set
			{
				SetValue( v =>  _spareType = v, _spareType, value,  "SpareType");
			} 
		}
	
		[EntityAttribute(8, EntityAttributeState.Mandatory)]
		public CobieType @Type 
		{ 
			get 
			{
				if(Activated) return _type;
				
				Model.Activate(this, true);
				Activated = true;
				return _type;
			} 
			set
			{
				SetValue( v =>  _type = v, _type, value,  "Type");
			} 
		}
	
		[EntityAttribute(9, EntityAttributeState.Mandatory)]
		public ItemSet<CobieContact> @Suppliers 
		{ 
			get 
			{
				if(Activated) return _suppliers;
				
				Model.Activate(this, true);
				Activated = true;
				return _suppliers;
			} 
			set
			{
				SetValue( v =>  _suppliers = v, _suppliers, value,  "Suppliers");
			} 
		}
	
		[EntityAttribute(10, EntityAttributeState.Optional)]
		public string @SetNumber 
		{ 
			get 
			{
				if(Activated) return _setNumber;
				
				Model.Activate(this, true);
				Activated = true;
				return _setNumber;
			} 
			set
			{
				SetValue( v =>  _setNumber = v, _setNumber, value,  "SetNumber");
			} 
		}
	
		[EntityAttribute(11, EntityAttributeState.Optional)]
		public string @PartNumber 
		{ 
			get 
			{
				if(Activated) return _partNumber;
				
				Model.Activate(this, true);
				Activated = true;
				return _partNumber;
			} 
			set
			{
				SetValue( v =>  _partNumber = v, _partNumber, value,  "PartNumber");
			} 
		}
	
		#endregion

		#region Inverse attributes

		#endregion

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"Created",
			"ExternalSystem",
			"ExternalObject",
			"ExternalId",
			"LocalId",
			"Name",
			"Description",
			"SpareType",
			"Type",
			"Suppliers",
			"SetNumber",
			"PartNumber",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @Created;
				case 1: 
					return @ExternalSystem;
				case 2: 
					return @ExternalObject;
				case 3: 
					return @ExternalId;
				case 4: 
					return @LocalId;
				case 5: 
					return @Name;
				case 6: 
					return @Description;
				case 7: 
					return @SpareType;
				case 8: 
					return @Type;
				case 9: 
					return @Suppliers;
				case 10: 
					return @SetNumber;
				case 11: 
					return @PartNumber;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "Created":  
					return @Created;
				case "ExternalSystem":  
					return @ExternalSystem;
				case "ExternalObject":  
					return @ExternalObject;
				case "ExternalId":  
					return @ExternalId;
				case "LocalId":  
					return @LocalId;
				case "Name":  
					return @Name;
				case "Description":  
					return @Description;
				case "SpareType":  
					return @SpareType;
				case "Type":  
					return @Type;
				case "Suppliers":  
					return @Suppliers;
				case "SetNumber":  
					return @SetNumber;
				case "PartNumber":  
					return @PartNumber;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 @Created = (CobieCreatedInfo)value;
					 break;
				case 1:
					 @ExternalSystem = (CobieExternalSystem)value;
					 break;
				case 2:
					 @ExternalObject = (string)value;
					 break;
				case 3:
					 @ExternalId = (string)value;
					 break;
				case 4:
					 if (value != null) @LocalId = (int)value;
					 break;
				case 5:
					 @Name = (string)value;
					 break;
				case 6:
					 @Description = (string)value;
					 break;
				case 7:
					 @SpareType = (CobiePickValue)value;
					 break;
				case 8:
					 @Type = (CobieType)value;
					 break;
				case 9:
					 @Suppliers.Add((CobieContact)value);
					 break;
				case 10:
					 @SetNumber = (string)value;
					 break;
				case 11:
					 @PartNumber = (string)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "Created":
					 @Created = (CobieCreatedInfo)value;
					 break;
				case "ExternalSystem":
					 @ExternalSystem = (CobieExternalSystem)value;
					 break;
				case "ExternalObject":
					 @ExternalObject = (string)value;
					 break;
				case "ExternalId":
					 @ExternalId = (string)value;
					 break;
				case "LocalId":
					 if (value != null) @LocalId = (int)value;
					 break;
				case "Name":
					 @Name = (string)value;
					 break;
				case "Description":
					 @Description = (string)value;
					 break;
				case "SpareType":
					 @SpareType = (CobiePickValue)value;
					 break;
				case "Type":
					 @Type = (CobieType)value;
					 break;
				case "Suppliers":
					 @Suppliers.Add((CobieContact)value);
					 break;
				case "SetNumber":
					 @SetNumber = (string)value;
					 break;
				case "PartNumber":
					 @PartNumber = (string)value;
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