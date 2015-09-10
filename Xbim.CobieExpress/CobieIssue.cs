// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		09/09/2015 04:20:46
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.CobieExpress
{
	[EntityName("ISSUE", 26)]
	public  partial class @CobieIssue : CobieExternalReference, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal CobieIssue(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private string _name;
		private string _description;
		private CobiePickValue _issueType;
		private CobiePickValue _risk;
		private CobiePickValue _chance;
		private CobiePickValue _impact;
		private CobieContact _owner;
		private string _mitigation;
		private CobieAsset _causing;
		private CobieAsset _affected;
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
	
		[EntityAttribute(6, EntityAttributeState.Mandatory)]
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
		public CobiePickValue @IssueType 
		{ 
			get 
			{
				if(Activated) return _issueType;
				
				Model.Activate(this, true);
				Activated = true;
				return _issueType;
			} 
			set
			{
				SetValue( v =>  _issueType = v, _issueType, value,  "IssueType");
			} 
		}
	
		[EntityAttribute(8, EntityAttributeState.Mandatory)]
		public CobiePickValue @Risk 
		{ 
			get 
			{
				if(Activated) return _risk;
				
				Model.Activate(this, true);
				Activated = true;
				return _risk;
			} 
			set
			{
				SetValue( v =>  _risk = v, _risk, value,  "Risk");
			} 
		}
	
		[EntityAttribute(9, EntityAttributeState.Mandatory)]
		public CobiePickValue @Chance 
		{ 
			get 
			{
				if(Activated) return _chance;
				
				Model.Activate(this, true);
				Activated = true;
				return _chance;
			} 
			set
			{
				SetValue( v =>  _chance = v, _chance, value,  "Chance");
			} 
		}
	
		[EntityAttribute(10, EntityAttributeState.Mandatory)]
		public CobiePickValue @Impact 
		{ 
			get 
			{
				if(Activated) return _impact;
				
				Model.Activate(this, true);
				Activated = true;
				return _impact;
			} 
			set
			{
				SetValue( v =>  _impact = v, _impact, value,  "Impact");
			} 
		}
	
		[EntityAttribute(11, EntityAttributeState.Mandatory)]
		public CobieContact @Owner 
		{ 
			get 
			{
				if(Activated) return _owner;
				
				Model.Activate(this, true);
				Activated = true;
				return _owner;
			} 
			set
			{
				SetValue( v =>  _owner = v, _owner, value,  "Owner");
			} 
		}
	
		[EntityAttribute(12, EntityAttributeState.Mandatory)]
		public string @Mitigation 
		{ 
			get 
			{
				if(Activated) return _mitigation;
				
				Model.Activate(this, true);
				Activated = true;
				return _mitigation;
			} 
			set
			{
				SetValue( v =>  _mitigation = v, _mitigation, value,  "Mitigation");
			} 
		}
	
		[EntityAttribute(13, EntityAttributeState.Mandatory)]
		public CobieAsset @Causing 
		{ 
			get 
			{
				if(Activated) return _causing;
				
				Model.Activate(this, true);
				Activated = true;
				return _causing;
			} 
			set
			{
				SetValue( v =>  _causing = v, _causing, value,  "Causing");
			} 
		}
	
		[EntityAttribute(14, EntityAttributeState.Mandatory)]
		public CobieAsset @Affected 
		{ 
			get 
			{
				if(Activated) return _affected;
				
				Model.Activate(this, true);
				Activated = true;
				return _affected;
			} 
			set
			{
				SetValue( v =>  _affected = v, _affected, value,  "Affected");
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
			"IssueType",
			"Risk",
			"Chance",
			"Impact",
			"Owner",
			"Mitigation",
			"Causing",
			"Affected",
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
					return @IssueType;
				case 8: 
					return @Risk;
				case 9: 
					return @Chance;
				case 10: 
					return @Impact;
				case 11: 
					return @Owner;
				case 12: 
					return @Mitigation;
				case 13: 
					return @Causing;
				case 14: 
					return @Affected;
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
				case "IssueType":  
					return @IssueType;
				case "Risk":  
					return @Risk;
				case "Chance":  
					return @Chance;
				case "Impact":  
					return @Impact;
				case "Owner":  
					return @Owner;
				case "Mitigation":  
					return @Mitigation;
				case "Causing":  
					return @Causing;
				case "Affected":  
					return @Affected;
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
					 @Name = (string)value;
					 break;
				case 6:
					 @Description = (string)value;
					 break;
				case 7:
					 @IssueType = (CobiePickValue)value;
					 break;
				case 8:
					 @Risk = (CobiePickValue)value;
					 break;
				case 9:
					 @Chance = (CobiePickValue)value;
					 break;
				case 10:
					 @Impact = (CobiePickValue)value;
					 break;
				case 11:
					 @Owner = (CobieContact)value;
					 break;
				case 12:
					 @Mitigation = (string)value;
					 break;
				case 13:
					 @Causing = (CobieAsset)value;
					 break;
				case 14:
					 @Affected = (CobieAsset)value;
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
				case "Name":
					 @Name = (string)value;
					 break;
				case "Description":
					 @Description = (string)value;
					 break;
				case "IssueType":
					 @IssueType = (CobiePickValue)value;
					 break;
				case "Risk":
					 @Risk = (CobiePickValue)value;
					 break;
				case "Chance":
					 @Chance = (CobiePickValue)value;
					 break;
				case "Impact":
					 @Impact = (CobiePickValue)value;
					 break;
				case "Owner":
					 @Owner = (CobieContact)value;
					 break;
				case "Mitigation":
					 @Mitigation = (string)value;
					 break;
				case "Causing":
					 @Causing = (CobieAsset)value;
					 break;
				case "Affected":
					 @Affected = (CobieAsset)value;
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

		public  override string WhereRule() 
		{
			return "";
		}
	}
}