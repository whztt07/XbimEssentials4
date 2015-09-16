// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		16.09.2015 04:22:59
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
	[EntityName("IFCIMAGETEXTURE", 727)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcImageTexture : IfcSurfaceTexture, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcImageTexture(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcIdentifier _urlReference;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Mandatory)]
		public IfcIdentifier @UrlReference 
		{ 
			get 
			{
				if(Activated) return _urlReference;
				
				Model.Activate(this, true);
				Activated = true;
				return _urlReference;
			} 
			set
			{
				SetValue( v =>  _urlReference = v, _urlReference, value,  "UrlReference");
			} 
		}
	
		#endregion

		#region Inverse attributes

		#endregion

		#region Index access
		private static readonly List<string> AttributeNames = new List<string>
		{
			"RepeatS",
			"RepeatT",
			"TextureType",
			"TextureTransform",
			"UrlReference",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return AttributeNames; } }

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
					return @UrlReference;
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
				case "UrlReference":  
					return @UrlReference;
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
					 if (value != null) @UrlReference = (IfcIdentifier)value;
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
				case "UrlReference":
					 if (value != null) @UrlReference = (IfcIdentifier)value;
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
					base.Parse(propIndex, value); 
					return;
				case 4: 
					_urlReference = value.StringVal;
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