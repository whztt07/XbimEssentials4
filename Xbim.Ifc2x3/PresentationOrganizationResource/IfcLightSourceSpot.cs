// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		16.09.2015 10:12:19
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
	[EntityName("IFCLIGHTSOURCESPOT", 760)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcLightSourceSpot : IfcLightSourcePositional, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcLightSourceSpot(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcDirection _orientation;
		private IfcReal? _concentrationExponent;
		private IfcPositivePlaneAngleMeasure _spreadAngle;
		private IfcPositivePlaneAngleMeasure _beamWidthAngle;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(9, EntityAttributeState.Mandatory)]
		public IfcDirection @Orientation 
		{ 
			get 
			{
				if(Activated) return _orientation;
				
				Model.Activate(this, true);
				Activated = true;
				return _orientation;
			} 
			set
			{
				SetValue( v =>  _orientation = v, _orientation, value,  "Orientation");
			} 
		}
	
		[EntityAttribute(10, EntityAttributeState.Optional)]
		public IfcReal? @ConcentrationExponent 
		{ 
			get 
			{
				if(Activated) return _concentrationExponent;
				
				Model.Activate(this, true);
				Activated = true;
				return _concentrationExponent;
			} 
			set
			{
				SetValue( v =>  _concentrationExponent = v, _concentrationExponent, value,  "ConcentrationExponent");
			} 
		}
	
		[EntityAttribute(11, EntityAttributeState.Mandatory)]
		public IfcPositivePlaneAngleMeasure @SpreadAngle 
		{ 
			get 
			{
				if(Activated) return _spreadAngle;
				
				Model.Activate(this, true);
				Activated = true;
				return _spreadAngle;
			} 
			set
			{
				SetValue( v =>  _spreadAngle = v, _spreadAngle, value,  "SpreadAngle");
			} 
		}
	
		[EntityAttribute(12, EntityAttributeState.Mandatory)]
		public IfcPositivePlaneAngleMeasure @BeamWidthAngle 
		{ 
			get 
			{
				if(Activated) return _beamWidthAngle;
				
				Model.Activate(this, true);
				Activated = true;
				return _beamWidthAngle;
			} 
			set
			{
				SetValue( v =>  _beamWidthAngle = v, _beamWidthAngle, value,  "BeamWidthAngle");
			} 
		}
	
		#endregion

		#region Inverse attributes

		#endregion

		#region Index access
		private static readonly List<string> AttributeNames = new List<string>
		{
			"Name",
			"LightColour",
			"AmbientIntensity",
			"Intensity",
			"Position",
			"Radius",
			"ConstantAttenuation",
			"DistanceAttenuation",
			"QuadricAttenuation",
			"Orientation",
			"ConcentrationExponent",
			"SpreadAngle",
			"BeamWidthAngle",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return AttributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @Name;
				case 1: 
					return @LightColour;
				case 2: 
					return @AmbientIntensity;
				case 3: 
					return @Intensity;
				case 4: 
					return @Position;
				case 5: 
					return @Radius;
				case 6: 
					return @ConstantAttenuation;
				case 7: 
					return @DistanceAttenuation;
				case 8: 
					return @QuadricAttenuation;
				case 9: 
					return @Orientation;
				case 10: 
					return @ConcentrationExponent;
				case 11: 
					return @SpreadAngle;
				case 12: 
					return @BeamWidthAngle;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "Name":  
					return @Name;
				case "LightColour":  
					return @LightColour;
				case "AmbientIntensity":  
					return @AmbientIntensity;
				case "Intensity":  
					return @Intensity;
				case "Position":  
					return @Position;
				case "Radius":  
					return @Radius;
				case "ConstantAttenuation":  
					return @ConstantAttenuation;
				case "DistanceAttenuation":  
					return @DistanceAttenuation;
				case "QuadricAttenuation":  
					return @QuadricAttenuation;
				case "Orientation":  
					return @Orientation;
				case "ConcentrationExponent":  
					return @ConcentrationExponent;
				case "SpreadAngle":  
					return @SpreadAngle;
				case "BeamWidthAngle":  
					return @BeamWidthAngle;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 @Name = (IfcLabel?)value;
					 break;
				case 1:
					 @LightColour = (IfcColourRgb)value;
					 break;
				case 2:
					 @AmbientIntensity = (IfcNormalisedRatioMeasure?)value;
					 break;
				case 3:
					 @Intensity = (IfcNormalisedRatioMeasure?)value;
					 break;
				case 4:
					 @Position = (IfcCartesianPoint)value;
					 break;
				case 5:
					 if (value != null) @Radius = (IfcPositiveLengthMeasure)value;
					 break;
				case 6:
					 if (value != null) @ConstantAttenuation = (IfcReal)value;
					 break;
				case 7:
					 if (value != null) @DistanceAttenuation = (IfcReal)value;
					 break;
				case 8:
					 if (value != null) @QuadricAttenuation = (IfcReal)value;
					 break;
				case 9:
					 @Orientation = (IfcDirection)value;
					 break;
				case 10:
					 @ConcentrationExponent = (IfcReal?)value;
					 break;
				case 11:
					 if (value != null) @SpreadAngle = (IfcPositivePlaneAngleMeasure)value;
					 break;
				case 12:
					 if (value != null) @BeamWidthAngle = (IfcPositivePlaneAngleMeasure)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "Name":
					 @Name = (IfcLabel?)value;
					 break;
				case "LightColour":
					 @LightColour = (IfcColourRgb)value;
					 break;
				case "AmbientIntensity":
					 @AmbientIntensity = (IfcNormalisedRatioMeasure?)value;
					 break;
				case "Intensity":
					 @Intensity = (IfcNormalisedRatioMeasure?)value;
					 break;
				case "Position":
					 @Position = (IfcCartesianPoint)value;
					 break;
				case "Radius":
					 if (value != null) @Radius = (IfcPositiveLengthMeasure)value;
					 break;
				case "ConstantAttenuation":
					 if (value != null) @ConstantAttenuation = (IfcReal)value;
					 break;
				case "DistanceAttenuation":
					 if (value != null) @DistanceAttenuation = (IfcReal)value;
					 break;
				case "QuadricAttenuation":
					 if (value != null) @QuadricAttenuation = (IfcReal)value;
					 break;
				case "Orientation":
					 @Orientation = (IfcDirection)value;
					 break;
				case "ConcentrationExponent":
					 @ConcentrationExponent = (IfcReal?)value;
					 break;
				case "SpreadAngle":
					 if (value != null) @SpreadAngle = (IfcPositivePlaneAngleMeasure)value;
					 break;
				case "BeamWidthAngle":
					 if (value != null) @BeamWidthAngle = (IfcPositivePlaneAngleMeasure)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
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
				case 5: 
				case 6: 
				case 7: 
				case 8: 
					base.Parse(propIndex, value); 
					return;
				case 9: 
					_orientation = (IfcDirection)(value.EntityVal);
					return;
				case 10: 
					_concentrationExponent = value.RealVal;
					return;
				case 11: 
					_spreadAngle = value.RealVal;
					return;
				case 12: 
					_beamWidthAngle = value.RealVal;
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