// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.PresentationDefinitionResource;
using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.PresentationAppearanceResource
{
	[ExpressType("IFCCURVESTYLEFONTPATTERN", 556)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcCurveStyleFontPattern : IfcPresentationItem, IInstantiableEntity, IEqualityComparer<@IfcCurveStyleFontPattern>, IEquatable<@IfcCurveStyleFontPattern>
	{
		public static int LoadDepth = 1;

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcCurveStyleFontPattern(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcLengthMeasure _visibleSegmentLength;
		private IfcPositiveLengthMeasure _invisibleSegmentLength;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLengthMeasure @VisibleSegmentLength 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _visibleSegmentLength;
				((IPersistEntity)this).Activate(false);
				return _visibleSegmentLength;
			} 
			set
			{
				SetValue( v =>  _visibleSegmentLength = v, _visibleSegmentLength, value,  "VisibleSegmentLength");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure @InvisibleSegmentLength 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _invisibleSegmentLength;
				((IPersistEntity)this).Activate(false);
				return _invisibleSegmentLength;
			} 
			set
			{
				SetValue( v =>  _invisibleSegmentLength = v, _invisibleSegmentLength, value,  "InvisibleSegmentLength");
			} 
		}
	
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

		#region Equality comparers and operators
        public bool Equals(@IfcCurveStyleFontPattern other)
	    {
	        return this == other;
	    }


        public static bool operator ==(@IfcCurveStyleFontPattern left, @IfcCurveStyleFontPattern right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcCurveStyleFontPattern left, @IfcCurveStyleFontPattern right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcCurveStyleFontPattern x, @IfcCurveStyleFontPattern y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcCurveStyleFontPattern obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}