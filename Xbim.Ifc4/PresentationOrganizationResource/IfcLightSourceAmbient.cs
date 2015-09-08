// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 02:29:22
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.PresentationAppearanceResource;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc4.PresentationOrganizationResource
{
	[EntityName("IFCLIGHTSOURCEAMBIENT", 339)]
	public  partial class @IfcLightSourceAmbient : IfcLightSource, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcLightSourceAmbient(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		#endregion
	
		#region Explicit attribute properties
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