// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 02:29:13
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

namespace Xbim.Ifc2x3.PresentationOrganizationResource
{
	[EntityName("IFCLIGHTSOURCEPOSITIONAL", 296)]
	public  partial class @IfcLightSourcePositional : IfcLightSource, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcLightSourcePositional(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcCartesianPoint _position;
		private IfcPositiveLengthMeasure _radius;
		private IfcReal _constantAttenuation;
		private IfcReal _distanceAttenuation;
		private IfcReal _quadricAttenuation;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Mandatory)]
		public IfcCartesianPoint @Position 
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
	
		[EntityAttribute(5, EntityAttributeState.Mandatory)]
		public IfcPositiveLengthMeasure @Radius 
		{ 
			get 
			{
				if(Activated) return _radius;
				
				Model.Activate(this, true);
				Activated = true;
				return _radius;
			} 
			set
			{
				SetValue( v =>  _radius = v, _radius, value,  "Radius");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Mandatory)]
		public IfcReal @ConstantAttenuation 
		{ 
			get 
			{
				if(Activated) return _constantAttenuation;
				
				Model.Activate(this, true);
				Activated = true;
				return _constantAttenuation;
			} 
			set
			{
				SetValue( v =>  _constantAttenuation = v, _constantAttenuation, value,  "ConstantAttenuation");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Mandatory)]
		public IfcReal @DistanceAttenuation 
		{ 
			get 
			{
				if(Activated) return _distanceAttenuation;
				
				Model.Activate(this, true);
				Activated = true;
				return _distanceAttenuation;
			} 
			set
			{
				SetValue( v =>  _distanceAttenuation = v, _distanceAttenuation, value,  "DistanceAttenuation");
			} 
		}
	
		[EntityAttribute(8, EntityAttributeState.Mandatory)]
		public IfcReal @QuadricAttenuation 
		{ 
			get 
			{
				if(Activated) return _quadricAttenuation;
				
				Model.Activate(this, true);
				Activated = true;
				return _quadricAttenuation;
			} 
			set
			{
				SetValue( v =>  _quadricAttenuation = v, _quadricAttenuation, value,  "QuadricAttenuation");
			} 
		}
	
		#endregion

		#region Inverse attributes

		#endregion

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
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
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

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