// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 03:44:05
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.GeometryResource;
using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.PresentationAppearanceResource;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.PresentationOrganizationResource
{
	[EntityName("IFCLIGHTSOURCE", 338)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcLightSource : IfcGeometricRepresentationItem
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcLightSource(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcLabel? _name;
		private IfcColourRgb _lightColour;
		private IfcNormalisedRatioMeasure? _ambientIntensity;
		private IfcNormalisedRatioMeasure? _intensity;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(0, EntityAttributeState.Optional)]
		public IfcLabel? @Name 
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
	
		[EntityAttribute(1, EntityAttributeState.Mandatory)]
		public IfcColourRgb @LightColour 
		{ 
			get 
			{
				if(Activated) return _lightColour;
				
				Model.Activate(this, true);
				Activated = true;
				return _lightColour;
			} 
			set
			{
				SetValue( v =>  _lightColour = v, _lightColour, value,  "LightColour");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Optional)]
		public IfcNormalisedRatioMeasure? @AmbientIntensity 
		{ 
			get 
			{
				if(Activated) return _ambientIntensity;
				
				Model.Activate(this, true);
				Activated = true;
				return _ambientIntensity;
			} 
			set
			{
				SetValue( v =>  _ambientIntensity = v, _ambientIntensity, value,  "AmbientIntensity");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Optional)]
		public IfcNormalisedRatioMeasure? @Intensity 
		{ 
			get 
			{
				if(Activated) return _intensity;
				
				Model.Activate(this, true);
				Activated = true;
				return _intensity;
			} 
			set
			{
				SetValue( v =>  _intensity = v, _intensity, value,  "Intensity");
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
					_name = value.StringVal;
					return;
				case 1: 
					_lightColour = (IfcColourRgb)(value.EntityVal);
					return;
				case 2: 
					_ambientIntensity = value.RealVal;
					return;
				case 3: 
					_intensity = value.RealVal;
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