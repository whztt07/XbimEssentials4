// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 03:44:04
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.PresentationDefinitionResource;
using Xbim.Ifc4.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.PresentationAppearanceResource
{
	[EntityName("IFCCURVESTYLEFONTPATTERN", 165)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcCurveStyleFontPattern : IfcPresentationItem, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcCurveStyleFontPattern(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcLengthMeasure _visibleSegmentLength;
		private IfcPositiveLengthMeasure _invisibleSegmentLength;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttributee(0, EntityAttributeState.Mandatory)]
		public IfcLengthMeasure @VisibleSegmentLength 
		{ 
			get 
			{
				if(Activated) return _visibleSegmentLength;
				
				Model.Activate(this, true);
				Activated = true;
				return _visibleSegmentLength;
			} 
			set
			{
				SetValue( v =>  _visibleSegmentLength = v, _visibleSegmentLength, value,  "VisibleSegmentLength");
			} 
		}
	
		[EntityAttributee(1, EntityAttributeState.Mandatory)]
		public IfcPositiveLengthMeasure @InvisibleSegmentLength 
		{ 
			get 
			{
				if(Activated) return _invisibleSegmentLength;
				
				Model.Activate(this, true);
				Activated = true;
				return _invisibleSegmentLength;
			} 
			set
			{
				SetValue( v =>  _invisibleSegmentLength = v, _invisibleSegmentLength, value,  "InvisibleSegmentLength");
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
					_visibleSegmentLength = value.RealVal;
					return;
				case 1: 
					_invisibleSegmentLength = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*VisibleLengthGreaterEqualZero:	VisibleLengthGreaterEqualZero : VisibleSegmentLength >= 0.;*/
		}
		#endregion
	}
}