// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		22.09.2015 04:44:06
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.PresentationAppearanceResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.PresentationResource
{
	[IndexedClass]
	[ExpressType("IFCTEXTSTYLEFONTMODEL", 503)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcTextStyleFontModel : IfcPreDefinedTextFont, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTextStyleFontModel(IModel model) : base(model) 		{ 
			Model = model; 
			_fontFamily = new OptionalItemSet<IfcTextFontName>( this );
		}

		#region Explicit attribute fields
		private OptionalItemSet<IfcTextFontName> _fontFamily;
		private IfcFontStyle? _fontStyle;
		private IfcFontVariant? _fontVariant;
		private IfcFontWeight? _fontWeight;
		private IfcSizeSelect _fontSize;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.None, 1, -1)]
		public OptionalItemSet<IfcTextFontName> @FontFamily 
		{ 
			get 
			{
				if(Activated) return _fontFamily;
				
				Model.Activate(this, true);
				Activated = true;
				return _fontFamily;
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcFontStyle? @FontStyle 
		{ 
			get 
			{
				if(Activated) return _fontStyle;
				
				Model.Activate(this, true);
				Activated = true;
				return _fontStyle;
			} 
			set
			{
				SetValue( v =>  _fontStyle = v, _fontStyle, value,  "FontStyle");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcFontVariant? @FontVariant 
		{ 
			get 
			{
				if(Activated) return _fontVariant;
				
				Model.Activate(this, true);
				Activated = true;
				return _fontVariant;
			} 
			set
			{
				SetValue( v =>  _fontVariant = v, _fontVariant, value,  "FontVariant");
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcFontWeight? @FontWeight 
		{ 
			get 
			{
				if(Activated) return _fontWeight;
				
				Model.Activate(this, true);
				Activated = true;
				return _fontWeight;
			} 
			set
			{
				SetValue( v =>  _fontWeight = v, _fontWeight, value,  "FontWeight");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcSizeSelect @FontSize 
		{ 
			get 
			{
				if(Activated) return _fontSize;
				
				Model.Activate(this, true);
				Activated = true;
				return _fontSize;
			} 
			set
			{
				SetValue( v =>  _fontSize = v, _fontSize, value,  "FontSize");
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
					if (_fontFamily == null) _fontFamily = new OptionalItemSet<IfcTextFontName>( this );
					_fontFamily.InternalAdd(value.StringVal);
					return;
				case 2: 
					_fontStyle = value.StringVal;
					return;
				case 3: 
					_fontVariant = value.StringVal;
					return;
				case 4: 
					_fontWeight = value.StringVal;
					return;
				case 5: 
					_fontSize = (IfcSizeSelect)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR31:             (SELF.FontSize > 0.);*/
		}
		#endregion
	}
}