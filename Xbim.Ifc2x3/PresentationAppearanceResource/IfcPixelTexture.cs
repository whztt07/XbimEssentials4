// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		09/09/2015 04:20:35
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.GeometryResource;
using Xbim.Ifc2x3.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc2x3.PresentationAppearanceResource
{
	[EntityName("IFCPIXELTEXTURE", 728)]
	public  partial class @IfcPixelTexture : IfcSurfaceTexture, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPixelTexture(IModel model) : base(model) 		{ 
			Model = model; 
			_pixel = new ItemSet<byte[]>( model );
		}

		#region Explicit attribute fields
		private IfcInteger _width;
		private IfcInteger _height;
		private IfcInteger _colourComponents;
		private ItemSet<byte[]> _pixel;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Mandatory)]
		public IfcInteger @Width 
		{ 
			get 
			{
				if(Activated) return _width;
				
				Model.Activate(this, true);
				Activated = true;
				return _width;
			} 
			set
			{
				SetValue( v =>  _width = v, _width, value,  "Width");
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Mandatory)]
		public IfcInteger @Height 
		{ 
			get 
			{
				if(Activated) return _height;
				
				Model.Activate(this, true);
				Activated = true;
				return _height;
			} 
			set
			{
				SetValue( v =>  _height = v, _height, value,  "Height");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Mandatory)]
		public IfcInteger @ColourComponents 
		{ 
			get 
			{
				if(Activated) return _colourComponents;
				
				Model.Activate(this, true);
				Activated = true;
				return _colourComponents;
			} 
			set
			{
				SetValue( v =>  _colourComponents = v, _colourComponents, value,  "ColourComponents");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Mandatory)]
		public ItemSet<byte[]> @Pixel 
		{ 
			get 
			{
				if(Activated) return _pixel;
				
				Model.Activate(this, true);
				Activated = true;
				return _pixel;
			} 
			set
			{
				SetValue( v =>  _pixel = v, _pixel, value,  "Pixel");
			} 
		}
	
		#endregion

		#region Inverse attributes

		#endregion

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"RepeatS",
			"RepeatT",
			"TextureType",
			"TextureTransform",
			"Width",
			"Height",
			"ColourComponents",
			"Pixel",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @RepeatS;
				case 1: 
					return @RepeatT;
				case 2: 
					return @TextureType;
				case 3: 
					return @TextureTransform;
				case 4: 
					return @Width;
				case 5: 
					return @Height;
				case 6: 
					return @ColourComponents;
				case 7: 
					return @Pixel;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "RepeatS":  
					return @RepeatS;
				case "RepeatT":  
					return @RepeatT;
				case "TextureType":  
					return @TextureType;
				case "TextureTransform":  
					return @TextureTransform;
				case "Width":  
					return @Width;
				case "Height":  
					return @Height;
				case "ColourComponents":  
					return @ColourComponents;
				case "Pixel":  
					return @Pixel;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 if (value != null) @RepeatS = (bool)value;
					 break;
				case 1:
					 if (value != null) @RepeatT = (bool)value;
					 break;
				case 2:
					 if (value != null) @TextureType = (IfcSurfaceTextureEnum)value;
					 break;
				case 3:
					 @TextureTransform = (IfcCartesianTransformationOperator2D)value;
					 break;
				case 4:
					 if (value != null) @Width = (IfcInteger)value;
					 break;
				case 5:
					 if (value != null) @Height = (IfcInteger)value;
					 break;
				case 6:
					 if (value != null) @ColourComponents = (IfcInteger)value;
					 break;
				case 7:
					 @Pixel.Add((byte[])value);
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "RepeatS":
					 if (value != null) @RepeatS = (bool)value;
					 break;
				case "RepeatT":
					 if (value != null) @RepeatT = (bool)value;
					 break;
				case "TextureType":
					 if (value != null) @TextureType = (IfcSurfaceTextureEnum)value;
					 break;
				case "TextureTransform":
					 @TextureTransform = (IfcCartesianTransformationOperator2D)value;
					 break;
				case "Width":
					 if (value != null) @Width = (IfcInteger)value;
					 break;
				case "Height":
					 if (value != null) @Height = (IfcInteger)value;
					 break;
				case "ColourComponents":
					 if (value != null) @ColourComponents = (IfcInteger)value;
					 break;
				case "Pixel":
					 @Pixel.Add((byte[])value);
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion

		#region Where rules
		/*WR21:	WR21 : Width >= 1;*/
		/*WR22:	WR22 : Height >= 1;*/
		/*WR23:	WR23 : {1 <= ColourComponents <= 4};*/
		/*WR24:	WR24 : SIZEOF(Pixel) = (Width * Height);*/
		#endregion

		#region IPersist implementation
		void IPersist.Set(int propIndex, IPropertyValue value)
		{
            throw new System.NotImplementedException();
		}
		#endregion

		public  override string WhereRule() 
		{
			return "";
		}
	}
}