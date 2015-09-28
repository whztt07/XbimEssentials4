// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.PresentationAppearanceResource
{
	[ExpressType("IFCTEXTSTYLE", 1094)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcTextStyle : IfcPresentationStyle, IfcPresentationStyleSelect, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTextStyle(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcTextStyleForDefinedFont _textCharacterAppearance;
		private IfcTextStyleTextModel _textStyle;
		private IfcTextFontSelect _textFontStyle;
		private bool? _modelOrDraughting;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcTextStyleForDefinedFont @TextCharacterAppearance 
		{ 
			get 
			{
				if(Activated) return _textCharacterAppearance;
				
				Model.Activate(this, true);
				Activated = true;
				return _textCharacterAppearance;
			} 
			set
			{
				SetValue( v =>  _textCharacterAppearance = v, _textCharacterAppearance, value,  "TextCharacterAppearance");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcTextStyleTextModel @TextStyle 
		{ 
			get 
			{
				if(Activated) return _textStyle;
				
				Model.Activate(this, true);
				Activated = true;
				return _textStyle;
			} 
			set
			{
				SetValue( v =>  _textStyle = v, _textStyle, value,  "TextStyle");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcTextFontSelect @TextFontStyle 
		{ 
			get 
			{
				if(Activated) return _textFontStyle;
				
				Model.Activate(this, true);
				Activated = true;
				return _textFontStyle;
			} 
			set
			{
				SetValue( v =>  _textFontStyle = v, _textFontStyle, value,  "TextFontStyle");
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public bool? @ModelOrDraughting 
		{ 
			get 
			{
				if(Activated) return _modelOrDraughting;
				
				Model.Activate(this, true);
				Activated = true;
				return _modelOrDraughting;
			} 
			set
			{
				SetValue( v =>  _modelOrDraughting = v, _modelOrDraughting, value,  "ModelOrDraughting");
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
					_textCharacterAppearance = (IfcTextStyleForDefinedFont)(value.EntityVal);
					return;
				case 2: 
					_textStyle = (IfcTextStyleTextModel)(value.EntityVal);
					return;
				case 3: 
					_textFontStyle = (IfcTextFontSelect)(value.EntityVal);
					return;
				case 4: 
					_modelOrDraughting = value.BooleanVal;
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