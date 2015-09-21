// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		21.09.2015 05:11:13
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.PresentationResource;
using Xbim.Ifc2x3.GeometryResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.PresentationOrganizationResource
{
	[IndexedClass]
	[ExpressType("IFCLIGHTSOURCEGONIOMETRIC", 758)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcLightSourceGoniometric : IfcLightSource, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcLightSourceGoniometric(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcAxis2Placement3D _position;
		private IfcColourRgb _colourAppearance;
		private IfcThermodynamicTemperatureMeasure _colourTemperature;
		private IfcLuminousFluxMeasure _luminousFlux;
		private IfcLightEmissionSourceEnum _lightEmissionSource;
		private IfcLightDistributionDataSourceSelect _lightDistributionDataSource;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcAxis2Placement3D @Position 
		{ 
			get 
			{
				if(Activated) return _position;
				
				Model.Activate(this, true);
				Activated = true;
				return _position;
			} 
			set
			{
				SetValue( v =>  _position = v, _position, value,  "Position");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcColourRgb @ColourAppearance 
		{ 
			get 
			{
				if(Activated) return _colourAppearance;
				
				Model.Activate(this, true);
				Activated = true;
				return _colourAppearance;
			} 
			set
			{
				SetValue( v =>  _colourAppearance = v, _colourAppearance, value,  "ColourAppearance");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcThermodynamicTemperatureMeasure @ColourTemperature 
		{ 
			get 
			{
				if(Activated) return _colourTemperature;
				
				Model.Activate(this, true);
				Activated = true;
				return _colourTemperature;
			} 
			set
			{
				SetValue( v =>  _colourTemperature = v, _colourTemperature, value,  "ColourTemperature");
			} 
		}
	
		[EntityAttribute(8, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLuminousFluxMeasure @LuminousFlux 
		{ 
			get 
			{
				if(Activated) return _luminousFlux;
				
				Model.Activate(this, true);
				Activated = true;
				return _luminousFlux;
			} 
			set
			{
				SetValue( v =>  _luminousFlux = v, _luminousFlux, value,  "LuminousFlux");
			} 
		}
	
		[EntityAttribute(9, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcLightEmissionSourceEnum @LightEmissionSource 
		{ 
			get 
			{
				if(Activated) return _lightEmissionSource;
				
				Model.Activate(this, true);
				Activated = true;
				return _lightEmissionSource;
			} 
			set
			{
				SetValue( v =>  _lightEmissionSource = v, _lightEmissionSource, value,  "LightEmissionSource");
			} 
		}
	
		[EntityAttribute(10, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcLightDistributionDataSourceSelect @LightDistributionDataSource 
		{ 
			get 
			{
				if(Activated) return _lightDistributionDataSource;
				
				Model.Activate(this, true);
				Activated = true;
				return _lightDistributionDataSource;
			} 
			set
			{
				SetValue( v =>  _lightDistributionDataSource = v, _lightDistributionDataSource, value,  "LightDistributionDataSource");
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
					base.Parse(propIndex, value); 
					return;
				case 4: 
					_position = (IfcAxis2Placement3D)(value.EntityVal);
					return;
				case 5: 
					_colourAppearance = (IfcColourRgb)(value.EntityVal);
					return;
				case 6: 
					_colourTemperature = value.RealVal;
					return;
				case 7: 
					_luminousFlux = value.RealVal;
					return;
				case 8: 
                    _lightEmissionSource = (IfcLightEmissionSourceEnum) System.Enum.Parse(typeof (IfcLightEmissionSourceEnum), value.EnumVal, true);
					return;
				case 9: 
					_lightDistributionDataSource = (IfcLightDistributionDataSourceSelect)(value.EntityVal);
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