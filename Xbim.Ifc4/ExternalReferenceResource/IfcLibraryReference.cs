// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		22.09.2015 02:32:06
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.Kernel;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.ExternalReferenceResource
{
	[IndexedClass]
	[ExpressType("IFCLIBRARYREFERENCE", 724)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcLibraryReference : IfcExternalReference, IfcLibrarySelect, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcLibraryReference(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcText? _description;
		private IfcLanguageId? _language;
		private IfcLibraryInformation _referencedLibrary;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
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
	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLanguageId? @Language 
		{ 
			get 
			{
				if(Activated) return _language;
				
				Model.Activate(this, true);
				Activated = true;
				return _language;
			} 
			set
			{
				SetValue( v =>  _language = v, _language, value,  "Language");
			} 
		}
	
		[IndexedProperty]
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcLibraryInformation @ReferencedLibrary 
		{ 
			get 
			{
				if(Activated) return _referencedLibrary;
				
				Model.Activate(this, true);
				Activated = true;
				return _referencedLibrary;
			} 
			set
			{
				SetValue( v =>  _referencedLibrary = v, _referencedLibrary, value,  "ReferencedLibrary");
			} 
		}
	
		#endregion

		#region Inverse attributes
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcRelAssociatesLibrary> @LibraryRefForObjects 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelAssociatesLibrary>(e => e.RelatingLibrary == this);
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
					base.Parse(propIndex, value); 
					return;
				case 3: 
					_description = value.StringVal;
					return;
				case 4: 
					_language = value.StringVal;
					return;
				case 5: 
					_referencedLibrary = (IfcLibraryInformation)(value.EntityVal);
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