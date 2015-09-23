// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		23.09.2015 10:21:44
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.GeometryResource;
using Xbim.Ifc2x3.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.PresentationAppearanceResource
{
	[IndexedClass]
	[ExpressType("IFCPIXELTEXTURE", 728)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcPixelTexture : IfcSurfaceTexture, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPixelTexture(IModel model) : base(model) 		{ 
			Model = model; 
			_pixel = new ItemSet<long>( this );
		}

		#region Explicit attribute fields
		private IfcInteger _width;
		private IfcInteger _height;
		private IfcInteger _colourComponents;
		private ItemSet<long> _pixel;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
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
	
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
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
	
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
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
	
		[EntityAttribute(8, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.None, 1, -1)]
		public ItemSet<long> @Pixel 
		{ 
			get 
			{
				if(Activated) return _pixel;
				
				Model.Activate(this, true);
				Activated = true;
				return _pixel;
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
					base.Parse(propIndex, value); 
					return;
				case 4: 
					_width = value.IntegerVal;
					return;
				case 5: 
					_height = value.IntegerVal;
					return;
				case 6: 
					_colourComponents = value.IntegerVal;
					return;
				case 7: 
					if (_pixel == null) _pixel = new ItemSet<long>( this );
					_pixel.InternalAdd(value.HexadecimalVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR21:	WR21 : Width >= 1;*/
		/*WR22:	WR22 : Height >= 1;*/
		/*WR23:	WR23 : {1 <= ColourComponents <= 4};*/
		/*WR24:	WR24 : SIZEOF(Pixel) = (Width * Height);*/
		}
		#endregion
	}
}