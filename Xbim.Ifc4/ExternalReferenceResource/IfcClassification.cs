// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 02:29:20
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

namespace Xbim.Ifc4.ExternalReferenceResource
{
	[EntityName("IFCCLASSIFICATION", 94)]
	public  partial class @IfcClassification : IfcExternalInformation, IfcClassificationReferenceSelect, IfcClassificationSelect, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcClassification(IModel model) : base(model) 		{ 
			Model = model; 
			_referenceTokens = new ItemSet<IfcIdentifier>( model );
		}

		#region Explicit attribute fields
		private IfcLabel? _source;
		private IfcLabel? _edition;
		private IfcDate? _editionDate;
		private IfcLabel _name;
		private IfcText? _description;
		private IfcURIReference? _location;
		private ItemSet<IfcIdentifier> _referenceTokens;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(0, EntityAttributeState.Optional)]
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
	
		[EntityAttribute(1, EntityAttributeState.Optional)]
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
	
		[EntityAttribute(2, EntityAttributeState.Optional)]
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
	
		[EntityAttribute(3, EntityAttributeState.Mandatory)]
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
	
		[EntityAttribute(4, EntityAttributeState.Optional)]
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
	
		[EntityAttribute(5, EntityAttributeState.Optional)]
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
	
		[EntityAttribute(6, EntityAttributeState.Optional)]
		public ItemSet<IfcIdentifier> @ReferenceTokens 
		{ 
			get 
			{
				if(Activated) return _referenceTokens;
				
				Model.Activate(this, true);
				Activated = true;
				return _referenceTokens;
			} 
			set
			{
				SetValue( v =>  _referenceTokens = v, _referenceTokens, value,  "ReferenceTokens");
			} 
		}
	
		#endregion

		#region Inverse attributes
		public IEnumerable<IfcRelAssociatesClassification> @ClassificationForObjects 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelAssociatesClassification>(e => e.RelatingClassification == this);
			} 
		}
	
		public IEnumerable<IfcClassificationReference> @HasReferences 
		{ 
			get 
			{
				return Model.Instances.Where<IfcClassificationReference>(e => e.ReferencedSource == this);
			} 
		}
	

		#endregion

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"Source",
			"Edition",
			"EditionDate",
			"Name",
			"Description",
			"Location",
			"ReferenceTokens",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @Source;
				case 1: 
					return @Edition;
				case 2: 
					return @EditionDate;
				case 3: 
					return @Name;
				case 4: 
					return @Description;
				case 5: 
					return @Location;
				case 6: 
					return @ReferenceTokens;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "Source":  
					return @Source;
				case "Edition":  
					return @Edition;
				case "EditionDate":  
					return @EditionDate;
				case "Name":  
					return @Name;
				case "Description":  
					return @Description;
				case "Location":  
					return @Location;
				case "ReferenceTokens":  
					return @ReferenceTokens;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 @Source = (IfcLabel?)value;
					 break;
				case 1:
					 @Edition = (IfcLabel?)value;
					 break;
				case 2:
					 @EditionDate = (IfcDate?)value;
					 break;
				case 3:
					 if (value != null) @Name = (IfcLabel)value;
					 break;
				case 4:
					 @Description = (IfcText?)value;
					 break;
				case 5:
					 @Location = (IfcURIReference?)value;
					 break;
				case 6:
					 @ReferenceTokens = (ItemSet<IfcIdentifier>)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "Source":
					 @Source = (IfcLabel?)value;
					 break;
				case "Edition":
					 @Edition = (IfcLabel?)value;
					 break;
				case "EditionDate":
					 @EditionDate = (IfcDate?)value;
					 break;
				case "Name":
					 if (value != null) @Name = (IfcLabel)value;
					 break;
				case "Description":
					 @Description = (IfcText?)value;
					 break;
				case "Location":
					 @Location = (IfcURIReference?)value;
					 break;
				case "ReferenceTokens":
					 @ReferenceTokens = (ItemSet<IfcIdentifier>)value;
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