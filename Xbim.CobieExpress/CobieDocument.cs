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
	[EntityName("DOCUMENT", 24)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @CobieDocument : CobieExternalReference, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal CobieDocument(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private string _name;
		private string _description;
		private CobiePickValue _documentType;
		private CobiePickValue _approvalBy;
		private CobiePickValue _stage;
		private string _uRL;
		private string _reference;
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
		public CobiePickValue @DocumentType 
		{ 
			get 
			{
				if(Activated) return _documentType;
				
				Model.Activate(this, true);
				Activated = true;
				return _documentType;
			} 
			set
			{
				SetValue( v =>  _documentType = v, _documentType, value,  "DocumentType");
			} 
		}
	
		[EntityAttribute(8, EntityAttributeState.Mandatory)]
		public CobiePickValue @ApprovalBy 
		{ 
			get 
			{
				if(Activated) return _approvalBy;
				
				Model.Activate(this, true);
				Activated = true;
				return _approvalBy;
			} 
			set
			{
				SetValue( v =>  _approvalBy = v, _approvalBy, value,  "ApprovalBy");
			} 
		}
	
		[EntityAttribute(9, EntityAttributeState.Mandatory)]
		public CobiePickValue @Stage 
		{ 
			get 
			{
				if(Activated) return _stage;
				
				Model.Activate(this, true);
				Activated = true;
				return _stage;
			} 
			set
			{
				SetValue( v =>  _stage = v, _stage, value,  "Stage");
			} 
		}
	
		[EntityAttribute(10, EntityAttributeState.Mandatory)]
		public string @URL 
		{ 
			get 
			{
				if(Activated) return _uRL;
				
				Model.Activate(this, true);
				Activated = true;
				return _uRL;
			} 
			set
			{
				SetValue( v =>  _uRL = v, _uRL, value,  "URL");
			} 
		}
	
		[EntityAttribute(11, EntityAttributeState.Optional)]
		public string @Reference 
		{ 
			get 
			{
				if(Activated) return _reference;
				
				Model.Activate(this, true);
				Activated = true;
				return _reference;
			} 
			set
			{
				SetValue( v =>  _reference = v, _reference, value,  "Reference");
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
					_documentType = (CobiePickValue)(value.EntityVal);
					return;
				case 8: 
					_approvalBy = (CobiePickValue)(value.EntityVal);
					return;
				case 9: 
					_stage = (CobiePickValue)(value.EntityVal);
					return;
				case 10: 
					_uRL = value.StringVal;
					return;
				case 11: 
					_reference = value.StringVal;
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