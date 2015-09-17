// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 10:20:57
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
	[EntityName("IFCBLOBTEXTURE", 723)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcBlobTexture : IfcSurfaceTexture, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcBlobTexture(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcIdentifier _rasterFormat;
		private bool _rasterCode;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Mandatory)]
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
	
		[EntityAttribute(5, EntityAttributeState.Mandatory)]
		public bool @RasterCode 
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
					_rasterFormat = value.StringVal;
					return;
				case 5: 
					_rasterCode = value.BooleanVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR11:	WR11 : SELF.RasterFormat IN ['BMP', 'JPG', 'GIF', 'PNG'];*/
		}
		#endregion
	}
}