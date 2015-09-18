// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 03:44:08
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
	[EntityName("ASSET", 8)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @CobieAsset : CobieExternalReference
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal CobieAsset(IModel model) : base(model) 		{ 
			Model = model; 
			_category = new ItemSet<CobiePickKeyValue>( this );
			_impacts = new ItemSet<CobieImpact>( this );
			_documents = new ItemSet<CobieDocument>( this );
			_attributes = new ItemSet<CobieAttribute>( this );
		}

		#region Explicit attribute fields
		private string _name;
		private string _description;
		private ItemSet<CobiePickKeyValue> _category;
		private ItemSet<CobieImpact> _impacts;
		private ItemSet<CobieDocument> _documents;
		private ItemSet<CobieAttribute> _attributes;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttributee(5, EntityAttributeState.Mandatory)]
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
	
		[EntityAttributee(6, EntityAttributeState.Optional)]
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
	
		[EntityAttributee(7, EntityAttributeState.Mandatory)]
		public ItemSet<CobiePickKeyValue> @Category 
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
	
		[EntityAttributee(8, EntityAttributeState.Mandatory)]
		public ItemSet<CobieImpact> @Impacts 
		{ 
			get 
			{
				if(Activated) return _impacts;
				
				Model.Activate(this, true);
				Activated = true;
				return _impacts;
			} 
			set
			{
				SetValue( v =>  _impacts = v, _impacts, value,  "Impacts");
			} 
		}
	
		[EntityAttributee(9, EntityAttributeState.Mandatory)]
		public ItemSet<CobieDocument> @Documents 
		{ 
			get 
			{
				if(Activated) return _documents;
				
				Model.Activate(this, true);
				Activated = true;
				return _documents;
			} 
			set
			{
				SetValue( v =>  _documents = v, _documents, value,  "Documents");
			} 
		}
	
		[EntityAttributee(10, EntityAttributeState.Mandatory)]
		public ItemSet<CobieAttribute> @Attributes 
		{ 
			get 
			{
				if(Activated) return _attributes;
				
				Model.Activate(this, true);
				Activated = true;
				return _attributes;
			} 
			set
			{
				SetValue( v =>  _attributes = v, _attributes, value,  "Attributes");
			} 
		}
	
		#endregion

		#region Inverse attributes
		public IEnumerable<CobieIssue> @CausingIssues 
		{ 
			get 
			{
				return Model.Instances.Where<CobieIssue>(e => e.Causing == this);
			} 
		}
	
		public IEnumerable<CobieIssue> @AffectedBy 
		{ 
			get 
			{
				return Model.Instances.Where<CobieIssue>(e => e.Affected == this);
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
					_name = value.StringVal;
					return;
				case 6: 
					_description = value.StringVal;
					return;
				case 7: 
					if (_category == null) _category = new ItemSet<CobiePickKeyValue>( this );
					_category.InternalAdd((CobiePickKeyValue)value.EntityVal);
					return;
				case 8: 
					if (_impacts == null) _impacts = new ItemSet<CobieImpact>( this );
					_impacts.InternalAdd((CobieImpact)value.EntityVal);
					return;
				case 9: 
					if (_documents == null) _documents = new ItemSet<CobieDocument>( this );
					_documents.InternalAdd((CobieDocument)value.EntityVal);
					return;
				case 10: 
					if (_attributes == null) _attributes = new ItemSet<CobieAttribute>( this );
					_attributes.InternalAdd((CobieAttribute)value.EntityVal);
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