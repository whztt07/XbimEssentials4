// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		22.09.2015 02:32:08
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.PresentationAppearanceResource
{
	[IndexedClass]
	[ExpressType("IFCSURFACESTYLERENDERING", 1062)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcSurfaceStyleRendering : IfcSurfaceStyleShading, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcSurfaceStyleRendering(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcNormalisedRatioMeasure? _transparency;
		private IfcColourOrFactor _diffuseColour;
		private IfcColourOrFactor _transmissionColour;
		private IfcColourOrFactor _diffuseTransmissionColour;
		private IfcColourOrFactor _reflectionColour;
		private IfcColourOrFactor _specularColour;
		private IfcSpecularHighlightSelect _specularHighlight;
		private IfcReflectanceMethodEnum _reflectanceMethod;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcNormalisedRatioMeasure? @Transparency 
		{ 
			get 
			{
				if(Activated) return _transparency;
				
				Model.Activate(this, true);
				Activated = true;
				return _transparency;
			} 
			set
			{
				SetValue( v =>  _transparency = v, _transparency, value,  "Transparency");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcColourOrFactor @DiffuseColour 
		{ 
			get 
			{
				if(Activated) return _diffuseColour;
				
				Model.Activate(this, true);
				Activated = true;
				return _diffuseColour;
			} 
			set
			{
				SetValue( v =>  _diffuseColour = v, _diffuseColour, value,  "DiffuseColour");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcColourOrFactor @TransmissionColour 
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
	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcColourOrFactor @DiffuseTransmissionColour 
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
	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcColourOrFactor @ReflectionColour 
		{ 
			get 
			{
				if(Activated) return _reflectionColour;
				
				Model.Activate(this, true);
				Activated = true;
				return _reflectionColour;
			} 
			set
			{
				SetValue( v =>  _reflectionColour = v, _reflectionColour, value,  "ReflectionColour");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcColourOrFactor @SpecularColour 
		{ 
			get 
			{
				if(Activated) return _specularColour;
				
				Model.Activate(this, true);
				Activated = true;
				return _specularColour;
			} 
			set
			{
				SetValue( v =>  _specularColour = v, _specularColour, value,  "SpecularColour");
			} 
		}
	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcSpecularHighlightSelect @SpecularHighlight 
		{ 
			get 
			{
				if(Activated) return _specularHighlight;
				
				Model.Activate(this, true);
				Activated = true;
				return _specularHighlight;
			} 
			set
			{
				SetValue( v =>  _specularHighlight = v, _specularHighlight, value,  "SpecularHighlight");
			} 
		}
	
		[EntityAttribute(9, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcReflectanceMethodEnum @ReflectanceMethod 
		{ 
			get 
			{
				if(Activated) return _reflectanceMethod;
				
				Model.Activate(this, true);
				Activated = true;
				return _reflectanceMethod;
			} 
			set
			{
				SetValue( v =>  _reflectanceMethod = v, _reflectanceMethod, value,  "ReflectanceMethod");
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
					base.Parse(propIndex, value); 
					return;
				case 1: 
					_transparency = value.RealVal;
					return;
				case 2: 
					_diffuseColour = (IfcColourOrFactor)(value.EntityVal);
					return;
				case 3: 
					_transmissionColour = (IfcColourOrFactor)(value.EntityVal);
					return;
				case 4: 
					_diffuseTransmissionColour = (IfcColourOrFactor)(value.EntityVal);
					return;
				case 5: 
					_reflectionColour = (IfcColourOrFactor)(value.EntityVal);
					return;
				case 6: 
					_specularColour = (IfcColourOrFactor)(value.EntityVal);
					return;
				case 7: 
					_specularHighlight = (IfcSpecularHighlightSelect)(value.EntityVal);
					return;
				case 8: 
                    _reflectanceMethod = (IfcReflectanceMethodEnum) System.Enum.Parse(typeof (IfcReflectanceMethodEnum), value.EnumVal, true);
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