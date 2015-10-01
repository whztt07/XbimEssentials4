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

namespace Xbim.Ifc4.ProfileResource
{
	[ExpressType("IFCASYMMETRICISHAPEPROFILEDEF", 418)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcAsymmetricIShapeProfileDef : IfcParameterizedProfileDef, IInstantiableEntity, System.Collections.Generic.IEqualityComparer<@IfcAsymmetricIShapeProfileDef>, System.IEquatable<@IfcAsymmetricIShapeProfileDef>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcAsymmetricIShapeProfileDef(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcPositiveLengthMeasure _bottomFlangeWidth;
		private IfcPositiveLengthMeasure _overallDepth;
		private IfcPositiveLengthMeasure _webThickness;
		private IfcPositiveLengthMeasure _bottomFlangeThickness;
		private IfcNonNegativeLengthMeasure? _bottomFlangeFilletRadius;
		private IfcPositiveLengthMeasure _topFlangeWidth;
		private IfcPositiveLengthMeasure? _topFlangeThickness;
		private IfcNonNegativeLengthMeasure? _topFlangeFilletRadius;
		private IfcNonNegativeLengthMeasure? _bottomFlangeEdgeRadius;
		private IfcPlaneAngleMeasure? _bottomFlangeSlope;
		private IfcNonNegativeLengthMeasure? _topFlangeEdgeRadius;
		private IfcPlaneAngleMeasure? _topFlangeSlope;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure @BottomFlangeWidth 
		{ 
			get 
			{
				if(Activated) return _bottomFlangeWidth;
				
				Model.Activate(this, true);
				Activated = true;
				return _bottomFlangeWidth;
			} 
			set
			{
				SetValue( v =>  _bottomFlangeWidth = v, _bottomFlangeWidth, value,  "BottomFlangeWidth");
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure @OverallDepth 
		{ 
			get 
			{
				if(Activated) return _overallDepth;
				
				Model.Activate(this, true);
				Activated = true;
				return _overallDepth;
			} 
			set
			{
				SetValue( v =>  _overallDepth = v, _overallDepth, value,  "OverallDepth");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure @WebThickness 
		{ 
			get 
			{
				if(Activated) return _webThickness;
				
				Model.Activate(this, true);
				Activated = true;
				return _webThickness;
			} 
			set
			{
				SetValue( v =>  _webThickness = v, _webThickness, value,  "WebThickness");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure @BottomFlangeThickness 
		{ 
			get 
			{
				if(Activated) return _bottomFlangeThickness;
				
				Model.Activate(this, true);
				Activated = true;
				return _bottomFlangeThickness;
			} 
			set
			{
				SetValue( v =>  _bottomFlangeThickness = v, _bottomFlangeThickness, value,  "BottomFlangeThickness");
			} 
		}
	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcNonNegativeLengthMeasure? @BottomFlangeFilletRadius 
		{ 
			get 
			{
				if(Activated) return _bottomFlangeFilletRadius;
				
				Model.Activate(this, true);
				Activated = true;
				return _bottomFlangeFilletRadius;
			} 
			set
			{
				SetValue( v =>  _bottomFlangeFilletRadius = v, _bottomFlangeFilletRadius, value,  "BottomFlangeFilletRadius");
			} 
		}
	
		[EntityAttribute(9, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure @TopFlangeWidth 
		{ 
			get 
			{
				if(Activated) return _topFlangeWidth;
				
				Model.Activate(this, true);
				Activated = true;
				return _topFlangeWidth;
			} 
			set
			{
				SetValue( v =>  _topFlangeWidth = v, _topFlangeWidth, value,  "TopFlangeWidth");
			} 
		}
	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure? @TopFlangeThickness 
		{ 
			get 
			{
				if(Activated) return _topFlangeThickness;
				
				Model.Activate(this, true);
				Activated = true;
				return _topFlangeThickness;
			} 
			set
			{
				SetValue( v =>  _topFlangeThickness = v, _topFlangeThickness, value,  "TopFlangeThickness");
			} 
		}
	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcNonNegativeLengthMeasure? @TopFlangeFilletRadius 
		{ 
			get 
			{
				if(Activated) return _topFlangeFilletRadius;
				
				Model.Activate(this, true);
				Activated = true;
				return _topFlangeFilletRadius;
			} 
			set
			{
				SetValue( v =>  _topFlangeFilletRadius = v, _topFlangeFilletRadius, value,  "TopFlangeFilletRadius");
			} 
		}
	
		[EntityAttribute(12, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcNonNegativeLengthMeasure? @BottomFlangeEdgeRadius 
		{ 
			get 
			{
				if(Activated) return _bottomFlangeEdgeRadius;
				
				Model.Activate(this, true);
				Activated = true;
				return _bottomFlangeEdgeRadius;
			} 
			set
			{
				SetValue( v =>  _bottomFlangeEdgeRadius = v, _bottomFlangeEdgeRadius, value,  "BottomFlangeEdgeRadius");
			} 
		}
	
		[EntityAttribute(13, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPlaneAngleMeasure? @BottomFlangeSlope 
		{ 
			get 
			{
				if(Activated) return _bottomFlangeSlope;
				
				Model.Activate(this, true);
				Activated = true;
				return _bottomFlangeSlope;
			} 
			set
			{
				SetValue( v =>  _bottomFlangeSlope = v, _bottomFlangeSlope, value,  "BottomFlangeSlope");
			} 
		}
	
		[EntityAttribute(14, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcNonNegativeLengthMeasure? @TopFlangeEdgeRadius 
		{ 
			get 
			{
				if(Activated) return _topFlangeEdgeRadius;
				
				Model.Activate(this, true);
				Activated = true;
				return _topFlangeEdgeRadius;
			} 
			set
			{
				SetValue( v =>  _topFlangeEdgeRadius = v, _topFlangeEdgeRadius, value,  "TopFlangeEdgeRadius");
			} 
		}
	
		[EntityAttribute(15, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPlaneAngleMeasure? @TopFlangeSlope 
		{ 
			get 
			{
				if(Activated) return _topFlangeSlope;
				
				Model.Activate(this, true);
				Activated = true;
				return _topFlangeSlope;
			} 
			set
			{
				SetValue( v =>  _topFlangeSlope = v, _topFlangeSlope, value,  "TopFlangeSlope");
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
					base.Parse(propIndex, value); 
					return;
				case 3: 
					_bottomFlangeWidth = value.RealVal;
					return;
				case 4: 
					_overallDepth = value.RealVal;
					return;
				case 5: 
					_webThickness = value.RealVal;
					return;
				case 6: 
					_bottomFlangeThickness = value.RealVal;
					return;
				case 7: 
					_bottomFlangeFilletRadius = value.RealVal;
					return;
				case 8: 
					_topFlangeWidth = value.RealVal;
					return;
				case 9: 
					_topFlangeThickness = value.RealVal;
					return;
				case 10: 
					_topFlangeFilletRadius = value.RealVal;
					return;
				case 11: 
					_bottomFlangeEdgeRadius = value.RealVal;
					return;
				case 12: 
					_bottomFlangeSlope = value.RealVal;
					return;
				case 13: 
					_topFlangeEdgeRadius = value.RealVal;
					return;
				case 14: 
					_topFlangeSlope = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*ValidFlangeThickness:	ValidFlangeThickness : NOT(EXISTS(TopFlangeThickness)) OR ((BottomFlangeThickness + TopFlangeThickness) < OverallDepth);*/
		/*ValidWebThickness:	ValidWebThickness : (WebThickness < BottomFlangeWidth) AND (WebThickness < TopFlangeWidth);*/
		/*ValidBottomFilletRadius:                                (BottomFlangeFilletRadius <= (BottomFlangeWidth - WebThickness)/2.);*/
		/*ValidTopFilletRadius:                                (TopFlangeFilletRadius <= (TopFlangeWidth - WebThickness)/2.);*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcAsymmetricIShapeProfileDef other)
	    {
	        return this == other;
	    }


        public static bool operator ==(@IfcAsymmetricIShapeProfileDef left, @IfcAsymmetricIShapeProfileDef right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcAsymmetricIShapeProfileDef left, @IfcAsymmetricIShapeProfileDef right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcAsymmetricIShapeProfileDef x, @IfcAsymmetricIShapeProfileDef y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcAsymmetricIShapeProfileDef obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}