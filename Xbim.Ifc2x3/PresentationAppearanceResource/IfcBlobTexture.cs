// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		15.09.2015 07:04:14
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
	[EntityName("IFCBLOBTEXTURE", 723)]
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

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"RepeatS",
			"RepeatT",
			"TextureType",
			"TextureTransform",
			"RasterFormat",
			"RasterCode",
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
					return @RasterFormat;
				case 5: 
					return @RasterCode;
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
				case "RasterFormat":  
					return @RasterFormat;
				case "RasterCode":  
					return @RasterCode;
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
					 if (value != null) @RasterFormat = (IfcIdentifier)value;
					 break;
				case 5:
					 if (value != null) @RasterCode = (bool)value;
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
				case "RasterFormat":
					 if (value != null) @RasterFormat = (IfcIdentifier)value;
					 break;
				case "RasterCode":
					 if (value != null) @RasterCode = (bool)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion

		#region Where rules
		/*WR11:	WR11 : SELF.RasterFormat IN ['BMP', 'JPG', 'GIF', 'PNG'];*/
		#endregion

		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
            throw new System.NotImplementedException();
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		}
		#endregion

		
	}
}