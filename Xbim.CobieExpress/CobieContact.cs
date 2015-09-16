// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		16.09.2015 04:23:02
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.CobieExpress
{
	[EntityName("CONTACT", 7)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @CobieContact : CobieExternalReference, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal CobieContact(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private string _email;
		private CobiePickValue _category;
		private string _company;
		private string _phone;
		private string _department;
		private string _organizationCode;
		private string _givenName;
		private string _familyName;
		private string _street;
		private string _postalBox;
		private string _town;
		private string _stateRegion;
		private string _postalCode;
		private string _country;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(5, EntityAttributeState.Mandatory)]
		public string @Email 
		{ 
			get 
			{
				if(Activated) return _email;
				
				Model.Activate(this, true);
				Activated = true;
				return _email;
			} 
			set
			{
				SetValue( v =>  _email = v, _email, value,  "Email");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Mandatory)]
		public CobiePickValue @Category 
		{ 
			get 
			{
				if(Activated) return _category;
				
				Model.Activate(this, true);
				Activated = true;
				return _category;
			} 
			set
			{
				SetValue( v =>  _category = v, _category, value,  "Category");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Mandatory)]
		public string @Company 
		{ 
			get 
			{
				if(Activated) return _company;
				
				Model.Activate(this, true);
				Activated = true;
				return _company;
			} 
			set
			{
				SetValue( v =>  _company = v, _company, value,  "Company");
			} 
		}
	
		[EntityAttribute(8, EntityAttributeState.Mandatory)]
		public string @Phone 
		{ 
			get 
			{
				if(Activated) return _phone;
				
				Model.Activate(this, true);
				Activated = true;
				return _phone;
			} 
			set
			{
				SetValue( v =>  _phone = v, _phone, value,  "Phone");
			} 
		}
	
		[EntityAttribute(9, EntityAttributeState.Optional)]
		public string @Department 
		{ 
			get 
			{
				if(Activated) return _department;
				
				Model.Activate(this, true);
				Activated = true;
				return _department;
			} 
			set
			{
				SetValue( v =>  _department = v, _department, value,  "Department");
			} 
		}
	
		[EntityAttribute(10, EntityAttributeState.Optional)]
		public string @OrganizationCode 
		{ 
			get 
			{
				if(Activated) return _organizationCode;
				
				Model.Activate(this, true);
				Activated = true;
				return _organizationCode;
			} 
			set
			{
				SetValue( v =>  _organizationCode = v, _organizationCode, value,  "OrganizationCode");
			} 
		}
	
		[EntityAttribute(11, EntityAttributeState.Optional)]
		public string @GivenName 
		{ 
			get 
			{
				if(Activated) return _givenName;
				
				Model.Activate(this, true);
				Activated = true;
				return _givenName;
			} 
			set
			{
				SetValue( v =>  _givenName = v, _givenName, value,  "GivenName");
			} 
		}
	
		[EntityAttribute(12, EntityAttributeState.Optional)]
		public string @FamilyName 
		{ 
			get 
			{
				if(Activated) return _familyName;
				
				Model.Activate(this, true);
				Activated = true;
				return _familyName;
			} 
			set
			{
				SetValue( v =>  _familyName = v, _familyName, value,  "FamilyName");
			} 
		}
	
		[EntityAttribute(13, EntityAttributeState.Optional)]
		public string @Street 
		{ 
			get 
			{
				if(Activated) return _street;
				
				Model.Activate(this, true);
				Activated = true;
				return _street;
			} 
			set
			{
				SetValue( v =>  _street = v, _street, value,  "Street");
			} 
		}
	
		[EntityAttribute(14, EntityAttributeState.Optional)]
		public string @PostalBox 
		{ 
			get 
			{
				if(Activated) return _postalBox;
				
				Model.Activate(this, true);
				Activated = true;
				return _postalBox;
			} 
			set
			{
				SetValue( v =>  _postalBox = v, _postalBox, value,  "PostalBox");
			} 
		}
	
		[EntityAttribute(15, EntityAttributeState.Optional)]
		public string @Town 
		{ 
			get 
			{
				if(Activated) return _town;
				
				Model.Activate(this, true);
				Activated = true;
				return _town;
			} 
			set
			{
				SetValue( v =>  _town = v, _town, value,  "Town");
			} 
		}
	
		[EntityAttribute(16, EntityAttributeState.Optional)]
		public string @StateRegion 
		{ 
			get 
			{
				if(Activated) return _stateRegion;
				
				Model.Activate(this, true);
				Activated = true;
				return _stateRegion;
			} 
			set
			{
				SetValue( v =>  _stateRegion = v, _stateRegion, value,  "StateRegion");
			} 
		}
	
		[EntityAttribute(17, EntityAttributeState.Optional)]
		public string @PostalCode 
		{ 
			get 
			{
				if(Activated) return _postalCode;
				
				Model.Activate(this, true);
				Activated = true;
				return _postalCode;
			} 
			set
			{
				SetValue( v =>  _postalCode = v, _postalCode, value,  "PostalCode");
			} 
		}
	
		[EntityAttribute(18, EntityAttributeState.Optional)]
		public string @Country 
		{ 
			get 
			{
				if(Activated) return _country;
				
				Model.Activate(this, true);
				Activated = true;
				return _country;
			} 
			set
			{
				SetValue( v =>  _country = v, _country, value,  "Country");
			} 
		}
	
		#endregion

		#region Inverse attributes

		#endregion

		#region Index access
		private static readonly List<string> AttributeNames = new List<string>
		{
			"Created",
			"ExternalSystem",
			"ExternalObject",
			"ExternalId",
			"LocalId",
			"Email",
			"Category",
			"Company",
			"Phone",
			"Department",
			"OrganizationCode",
			"GivenName",
			"FamilyName",
			"Street",
			"PostalBox",
			"Town",
			"StateRegion",
			"PostalCode",
			"Country",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return AttributeNames; } }

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
					return @Email;
				case 6: 
					return @Category;
				case 7: 
					return @Company;
				case 8: 
					return @Phone;
				case 9: 
					return @Department;
				case 10: 
					return @OrganizationCode;
				case 11: 
					return @GivenName;
				case 12: 
					return @FamilyName;
				case 13: 
					return @Street;
				case 14: 
					return @PostalBox;
				case 15: 
					return @Town;
				case 16: 
					return @StateRegion;
				case 17: 
					return @PostalCode;
				case 18: 
					return @Country;
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
				case "Email":  
					return @Email;
				case "Category":  
					return @Category;
				case "Company":  
					return @Company;
				case "Phone":  
					return @Phone;
				case "Department":  
					return @Department;
				case "OrganizationCode":  
					return @OrganizationCode;
				case "GivenName":  
					return @GivenName;
				case "FamilyName":  
					return @FamilyName;
				case "Street":  
					return @Street;
				case "PostalBox":  
					return @PostalBox;
				case "Town":  
					return @Town;
				case "StateRegion":  
					return @StateRegion;
				case "PostalCode":  
					return @PostalCode;
				case "Country":  
					return @Country;
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
					 if (value != null) @LocalId = (long)value;
					 break;
				case 5:
					 @Email = (string)value;
					 break;
				case 6:
					 @Category = (CobiePickValue)value;
					 break;
				case 7:
					 @Company = (string)value;
					 break;
				case 8:
					 @Phone = (string)value;
					 break;
				case 9:
					 @Department = (string)value;
					 break;
				case 10:
					 @OrganizationCode = (string)value;
					 break;
				case 11:
					 @GivenName = (string)value;
					 break;
				case 12:
					 @FamilyName = (string)value;
					 break;
				case 13:
					 @Street = (string)value;
					 break;
				case 14:
					 @PostalBox = (string)value;
					 break;
				case 15:
					 @Town = (string)value;
					 break;
				case 16:
					 @StateRegion = (string)value;
					 break;
				case 17:
					 @PostalCode = (string)value;
					 break;
				case 18:
					 @Country = (string)value;
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
					 if (value != null) @LocalId = (long)value;
					 break;
				case "Email":
					 @Email = (string)value;
					 break;
				case "Category":
					 @Category = (CobiePickValue)value;
					 break;
				case "Company":
					 @Company = (string)value;
					 break;
				case "Phone":
					 @Phone = (string)value;
					 break;
				case "Department":
					 @Department = (string)value;
					 break;
				case "OrganizationCode":
					 @OrganizationCode = (string)value;
					 break;
				case "GivenName":
					 @GivenName = (string)value;
					 break;
				case "FamilyName":
					 @FamilyName = (string)value;
					 break;
				case "Street":
					 @Street = (string)value;
					 break;
				case "PostalBox":
					 @PostalBox = (string)value;
					 break;
				case "Town":
					 @Town = (string)value;
					 break;
				case "StateRegion":
					 @StateRegion = (string)value;
					 break;
				case "PostalCode":
					 @PostalCode = (string)value;
					 break;
				case "Country":
					 @Country = (string)value;
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
					_email = value.StringVal;
					return;
				case 6: 
					_category = (CobiePickValue)(value.EntityVal);
					return;
				case 7: 
					_company = value.StringVal;
					return;
				case 8: 
					_phone = value.StringVal;
					return;
				case 9: 
					_department = value.StringVal;
					return;
				case 10: 
					_organizationCode = value.StringVal;
					return;
				case 11: 
					_givenName = value.StringVal;
					return;
				case 12: 
					_familyName = value.StringVal;
					return;
				case 13: 
					_street = value.StringVal;
					return;
				case 14: 
					_postalBox = value.StringVal;
					return;
				case 15: 
					_town = value.StringVal;
					return;
				case 16: 
					_stateRegion = value.StringVal;
					return;
				case 17: 
					_postalCode = value.StringVal;
					return;
				case 18: 
					_country = value.StringVal;
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