// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		22.09.2015 04:44:11
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.DateTimeResource;
using Xbim.Ifc4.Kernel;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.ExternalReferenceResource
{
	[IndexedClass]
	[ExpressType("IFCCLASSIFICATION", 485)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcClassification : IfcExternalInformation, IfcClassificationReferenceSelect, IfcClassificationSelect, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcClassification(IModel model) : base(model) 		{ 
			Model = model; 
			_referenceTokens = new OptionalItemSet<IfcIdentifier>( this );
		}

		#region Explicit attribute fields
		private IfcLabel? _source;
		private IfcLabel? _edition;
		private IfcDate? _editionDate;
		private IfcLabel _name;
		private IfcText? _description;
		private IfcURIReference? _location;
		private OptionalItemSet<IfcIdentifier> _referenceTokens;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel? @Source 
		{ 
			get 
			{
				if(Activated) return _source;
				
				Model.Activate(this, true);
				Activated = true;
				return _source;
			} 
			set
			{
				SetValue( v =>  _source = v, _source, value,  "Source");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel? @Edition 
		{ 
			get 
			{
				if(Activated) return _edition;
				
				Model.Activate(this, true);
				Activated = true;
				return _edition;
			} 
			set
			{
				SetValue( v =>  _edition = v, _edition, value,  "Edition");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcDate? @EditionDate 
		{ 
			get 
			{
				if(Activated) return _editionDate;
				
				Model.Activate(this, true);
				Activated = true;
				return _editionDate;
			} 
			set
			{
				SetValue( v =>  _editionDate = v, _editionDate, value,  "EditionDate");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel @Name 
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
	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcText? @Description 
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
	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcURIReference? @Location 
		{ 
			get 
			{
				if(Activated) return _location;
				
				Model.Activate(this, true);
				Activated = true;
				return _location;
			} 
			set
			{
				SetValue( v =>  _location = v, _location, value,  "Location");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.None, 1, -1)]
		public OptionalItemSet<IfcIdentifier> @ReferenceTokens 
		{ 
			get 
			{
				if(Activated) return _referenceTokens;
				
				Model.Activate(this, true);
				Activated = true;
				return _referenceTokens;
			} 
		}
	
		#endregion

		#region Inverse attributes
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcRelAssociatesClassification> @ClassificationForObjects 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelAssociatesClassification>(e => e.RelatingClassification == this);
			} 
		}
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcClassificationReference> @HasReferences 
		{ 
			get 
			{
				return Model.Instances.Where<IfcClassificationReference>(e => e.ReferencedSource == this);
			} 
		}
		#endregion


		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
					_source = value.StringVal;
					return;
				case 1: 
					_edition = value.StringVal;
					return;
				case 2: 
					_editionDate = value.StringVal;
					return;
				case 3: 
					_name = value.StringVal;
					return;
				case 4: 
					_description = value.StringVal;
					return;
				case 5: 
					_location = value.StringVal;
					return;
				case 6: 
					if (_referenceTokens == null) _referenceTokens = new OptionalItemSet<IfcIdentifier>( this );
					_referenceTokens.InternalAdd(value.StringVal);
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