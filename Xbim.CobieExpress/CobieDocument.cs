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
	[EntityName("DOCUMENT", 24)]
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
			"DocumentType",
			"ApprovalBy",
			"Stage",
			"URL",
			"Reference",
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
					return @DocumentType;
				case 8: 
					return @ApprovalBy;
				case 9: 
					return @Stage;
				case 10: 
					return @URL;
				case 11: 
					return @Reference;
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
				case "DocumentType":  
					return @DocumentType;
				case "ApprovalBy":  
					return @ApprovalBy;
				case "Stage":  
					return @Stage;
				case "URL":  
					return @URL;
				case "Reference":  
					return @Reference;
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
					 @DocumentType = (CobiePickValue)value;
					 break;
				case 8:
					 @ApprovalBy = (CobiePickValue)value;
					 break;
				case 9:
					 @Stage = (CobiePickValue)value;
					 break;
				case 10:
					 @URL = (string)value;
					 break;
				case 11:
					 @Reference = (string)value;
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
				case "DocumentType":
					 @DocumentType = (CobiePickValue)value;
					 break;
				case "ApprovalBy":
					 @ApprovalBy = (CobiePickValue)value;
					 break;
				case "Stage":
					 @Stage = (CobiePickValue)value;
					 break;
				case "URL":
					 @URL = (string)value;
					 break;
				case "Reference":
					 @Reference = (string)value;
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