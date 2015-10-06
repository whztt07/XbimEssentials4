// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.PresentationResource;
using Xbim.Ifc2x3.MeasureResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.PresentationAppearanceResource
{
	[ExpressType("IFCSURFACESTYLERENDERING", 317)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcSurfaceStyleRendering : IfcSurfaceStyleShading, IInstantiableEntity, IEqualityComparer<@IfcSurfaceStyleRendering>, IEquatable<@IfcSurfaceStyleRendering>
	{
		public static int LoadDepth = 1;

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
				if(ActivationStatus != ActivationStatus.NotActivated) return _transparency;
				((IPersistEntity)this).Activate(false);
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
				if(ActivationStatus != ActivationStatus.NotActivated) return _diffuseColour;
				((IPersistEntity)this).Activate(false);
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
				if(ActivationStatus != ActivationStatus.NotActivated) return _transmissionColour;
				((IPersistEntity)this).Activate(false);
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
				if(ActivationStatus != ActivationStatus.NotActivated) return _diffuseTransmissionColour;
				((IPersistEntity)this).Activate(false);
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
				if(ActivationStatus != ActivationStatus.NotActivated) return _reflectionColour;
				((IPersistEntity)this).Activate(false);
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
				if(ActivationStatus != ActivationStatus.NotActivated) return _specularColour;
				((IPersistEntity)this).Activate(false);
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
				if(ActivationStatus != ActivationStatus.NotActivated) return _specularHighlight;
				((IPersistEntity)this).Activate(false);
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
				if(ActivationStatus != ActivationStatus.NotActivated) return _reflectanceMethod;
				((IPersistEntity)this).Activate(false);
				return _reflectanceMethod;
			} 
			set
			{
				SetValue( v =>  _reflectanceMethod = v, _reflectanceMethod, value,  "ReflectanceMethod");
			} 
		}
	
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

		#region Equality comparers and operators
        public bool Equals(@IfcSurfaceStyleRendering other)
	    {
	        return this == other;
	    }


        public static bool operator ==(@IfcSurfaceStyleRendering left, @IfcSurfaceStyleRendering right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcSurfaceStyleRendering left, @IfcSurfaceStyleRendering right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcSurfaceStyleRendering x, @IfcSurfaceStyleRendering y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcSurfaceStyleRendering obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}