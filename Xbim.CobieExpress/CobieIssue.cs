// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 10:21:14
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
	[EntityName("ISSUE", 26)]
	// ReSharper disable once PartialTypeWithSinglePart
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
					_name = value.StringVal;
					return;
				case 6: 
					_description = value.StringVal;
					return;
				case 7: 
					_issueType = (CobiePickValue)(value.EntityVal);
					return;
				case 8: 
					_risk = (CobiePickValue)(value.EntityVal);
					return;
				case 9: 
					_chance = (CobiePickValue)(value.EntityVal);
					return;
				case 10: 
					_impact = (CobiePickValue)(value.EntityVal);
					return;
				case 11: 
					_owner = (CobieContact)(value.EntityVal);
					return;
				case 12: 
					_mitigation = value.StringVal;
					return;
				case 13: 
					_causing = (CobieAsset)(value.EntityVal);
					return;
				case 14: 
					_affected = (CobieAsset)(value.EntityVal);
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