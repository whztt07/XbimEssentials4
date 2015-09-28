// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.GeometryResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.PresentationAppearanceResource
{
	[ExpressType("IFCBLOBTEXTURE", 431)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcBlobTexture : IfcSurfaceTexture, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcBlobTexture(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcIdentifier _rasterFormat;
		private long _rasterCode;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcIdentifier @RasterFormat 
		{ 
			get 
			{
				if(Activated) return _rasterFormat;
				
				Model.Activate(this, true);
				Activated = true;
				return _rasterFormat;
			} 
			set
			{
				SetValue( v =>  _rasterFormat = v, _rasterFormat, value,  "RasterFormat");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public long @RasterCode 
		{ 
			get 
			{
				if(Activated) return _rasterCode;
				
				Model.Activate(this, true);
				Activated = true;
				return _rasterCode;
			} 
			set
			{
				SetValue( v =>  _rasterCode = v, _rasterCode, value,  "RasterCode");
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
					base.Parse(propIndex, value); 
					return;
				case 5: 
					_rasterFormat = value.StringVal;
					return;
				case 6: 
					_rasterCode = value.HexadecimalVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*SupportedRasterFormat:	SupportedRasterFormat : SELF.RasterFormat IN ['BMP', 'JPG', 'GIF', 'PNG'];*/
		/*RasterCodeByteStream:	RasterCodeByteStream : BLENGTH(RasterCode) MOD 8 = 0;*/
		}
		#endregion
	}
}