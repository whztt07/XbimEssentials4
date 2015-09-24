// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.PresentationDefinitionResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.PresentationAppearanceResource
{
	[IndexedClass]
	[ExpressType("IFCSURFACESTYLELIGHTING", 1060)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcSurfaceStyleLighting : IfcPresentationItem, IfcSurfaceStyleElementSelect, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcSurfaceStyleLighting(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcColourRgb _diffuseTransmissionColour;
		private IfcColourRgb _diffuseReflectionColour;
		private IfcColourRgb _transmissionColour;
		private IfcColourRgb _reflectanceColour;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcColourRgb @DiffuseTransmissionColour 
		{ 
			get 
			{
				if(Activated) return _diffuseTransmissionColour;
				
				Model.Activate(this, true);
				Activated = true;
				return _diffuseTransmissionColour;
			} 
			set
			{
				SetValue( v =>  _diffuseTransmissionColour = v, _diffuseTransmissionColour, value,  "DiffuseTransmissionColour");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcColourRgb @DiffuseReflectionColour 
		{ 
			get 
			{
				if(Activated) return _diffuseReflectionColour;
				
				Model.Activate(this, true);
				Activated = true;
				return _diffuseReflectionColour;
			} 
			set
			{
				SetValue( v =>  _diffuseReflectionColour = v, _diffuseReflectionColour, value,  "DiffuseReflectionColour");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcColourRgb @TransmissionColour 
		{ 
			get 
			{
				if(Activated) return _transmissionColour;
				
				Model.Activate(this, true);
				Activated = true;
				return _transmissionColour;
			} 
			set
			{
				SetValue( v =>  _transmissionColour = v, _transmissionColour, value,  "TransmissionColour");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcColourRgb @ReflectanceColour 
		{ 
			get 
			{
				if(Activated) return _reflectanceColour;
				
				Model.Activate(this, true);
				Activated = true;
				return _reflectanceColour;
			} 
			set
			{
				SetValue( v =>  _reflectanceColour = v, _reflectanceColour, value,  "ReflectanceColour");
			} 
		}
	
		#endregion



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
					_diffuseTransmissionColour = (IfcColourRgb)(value.EntityVal);
					return;
				case 1: 
					_diffuseReflectionColour = (IfcColourRgb)(value.EntityVal);
					return;
				case 2: 
					_transmissionColour = (IfcColourRgb)(value.EntityVal);
					return;
				case 3: 
					_reflectanceColour = (IfcColourRgb)(value.EntityVal);
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