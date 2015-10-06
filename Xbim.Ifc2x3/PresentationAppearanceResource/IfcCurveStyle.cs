// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.PresentationResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.PresentationAppearanceResource
{
	[ExpressType("IFCCURVESTYLE", 118)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcCurveStyle : IfcPresentationStyle, IfcPresentationStyleSelect, IInstantiableEntity, IEqualityComparer<@IfcCurveStyle>, IEquatable<@IfcCurveStyle>
	{
		public static int LoadDepth = 1;

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
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcCurveFontOrScaledCurveFontSelect @CurveFont 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _curveFont;
				((IPersistEntity)this).Activate(false);
				return _curveFont;
			} 
			set
			{
				SetValue( v =>  _curveFont = v, _curveFont, value,  "CurveFont");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcSizeSelect @CurveWidth 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _curveWidth;
				((IPersistEntity)this).Activate(false);
				return _curveWidth;
			} 
			set
			{
				SetValue( v =>  _curveWidth = v, _curveWidth, value,  "CurveWidth");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcColour @CurveColour 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _curveColour;
				((IPersistEntity)this).Activate(false);
				return _curveColour;
			} 
			set
			{
				SetValue( v =>  _curveColour = v, _curveColour, value,  "CurveColour");
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

		#region Equality comparers and operators
        public bool Equals(@IfcCurveStyle other)
	    {
	        return this == other;
	    }


        public static bool operator ==(@IfcCurveStyle left, @IfcCurveStyle right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcCurveStyle left, @IfcCurveStyle right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcCurveStyle x, @IfcCurveStyle y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcCurveStyle obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}