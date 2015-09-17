// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 10:20:58
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.PresentationResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.PresentationAppearanceResource
{
	[EntityName("IFCCURVESTYLE", 118)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcCurveStyle : IfcPresentationStyle, IfcPresentationStyleSelect, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcCurveStyle(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcCurveFontOrScaledCurveFontSelect _curveFont;
		private IfcSizeSelect _curveWidth;
		private IfcColour _curveColour;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Optional)]
		public IfcCurveFontOrScaledCurveFontSelect @CurveFont 
		{ 
			get 
			{
				if(Activated) return _curveFont;
				
				Model.Activate(this, true);
				Activated = true;
				return _curveFont;
			} 
			set
			{
				SetValue( v =>  _curveFont = v, _curveFont, value,  "CurveFont");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Optional)]
		public IfcSizeSelect @CurveWidth 
		{ 
			get 
			{
				if(Activated) return _curveWidth;
				
				Model.Activate(this, true);
				Activated = true;
				return _curveWidth;
			} 
			set
			{
				SetValue( v =>  _curveWidth = v, _curveWidth, value,  "CurveWidth");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Optional)]
		public IfcColour @CurveColour 
		{ 
			get 
			{
				if(Activated) return _curveColour;
				
				Model.Activate(this, true);
				Activated = true;
				return _curveColour;
			} 
			set
			{
				SetValue( v =>  _curveColour = v, _curveColour, value,  "CurveColour");
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
					base.Parse(propIndex, value); 
					return;
				case 1: 
					_curveFont = (IfcCurveFontOrScaledCurveFontSelect)(value.EntityVal);
					return;
				case 2: 
					_curveWidth = (IfcSizeSelect)(value.EntityVal);
					return;
				case 3: 
					_curveColour = (IfcColour)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR11:              (CurveWidth = 'by layer'));*/
		}
		#endregion
	}
}