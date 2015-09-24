// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		24.09.2015 10:03:45
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
	[IndexedClass]
	[ExpressType("CONTACT", 14)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @CobieContact : CobieReferencedObject, IInstantiableEntity
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
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
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
	
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
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
	
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
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
	
		[EntityAttribute(8, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
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
	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
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
	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
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
	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
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
	
		[EntityAttribute(12, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
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
	
		[EntityAttribute(13, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
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
	
		[EntityAttribute(14, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
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
	
		[EntityAttribute(15, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
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
	
		[EntityAttribute(16, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
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
	
		[EntityAttribute(17, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
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
	
		[EntityAttribute(18, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
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



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
				case 3: 
					base.Parse(propIndex, value); 
					return;
				case 4: 
					_email = value.StringVal;
					return;
				case 5: 
					_category = (CobiePickValue)(value.EntityVal);
					return;
				case 6: 
					_company = value.StringVal;
					return;
				case 7: 
					_phone = value.StringVal;
					return;
				case 8: 
					_department = value.StringVal;
					return;
				case 9: 
					_organizationCode = value.StringVal;
					return;
				case 10: 
					_givenName = value.StringVal;
					return;
				case 11: 
					_familyName = value.StringVal;
					return;
				case 12: 
					_street = value.StringVal;
					return;
				case 13: 
					_postalBox = value.StringVal;
					return;
				case 14: 
					_town = value.StringVal;
					return;
				case 15: 
					_stateRegion = value.StringVal;
					return;
				case 16: 
					_postalCode = value.StringVal;
					return;
				case 17: 
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