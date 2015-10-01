// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.GeometryResource;
using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.PresentationResource;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.PresentationOrganizationResource
{
	[ExpressType("IFCLIGHTSOURCE", 755)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcLightSource : IfcGeometricRepresentationItem, System.Collections.Generic.IEqualityComparer<@IfcLightSource>, System.IEquatable<@IfcLightSource>
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
		[EntityAttribute(1, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
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
	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
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
	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
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
	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
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

		#region Equality comparers and operators
        public bool Equals(@IfcLightSource other)
	    {
	        return this == other;
	    }


        public static bool operator ==(@IfcLightSource left, @IfcLightSource right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcLightSource left, @IfcLightSource right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcLightSource x, @IfcLightSource y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcLightSource obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}