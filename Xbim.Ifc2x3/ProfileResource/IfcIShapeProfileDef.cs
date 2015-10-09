// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.GeometryResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.ProfileResource
{
	[ExpressType("IFCISHAPEPROFILEDEF", 352)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcIShapeProfileDef : IfcParameterizedProfileDef, IInstantiableEntity, IEqualityComparer<@IfcIShapeProfileDef>, IEquatable<@IfcIShapeProfileDef>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcIShapeProfileDef(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcPositiveLengthMeasure _overallWidth;
		private IfcPositiveLengthMeasure _overallDepth;
		private IfcPositiveLengthMeasure _webThickness;
		private IfcPositiveLengthMeasure _flangeThickness;
		private IfcPositiveLengthMeasure? _filletRadius;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure @OverallWidth 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _overallWidth;
				((IPersistEntity)this).Activate(false);
				return _overallWidth;
			} 
			set
			{
				SetValue( v =>  _overallWidth = v, _overallWidth, value,  "OverallWidth");
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure @OverallDepth 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _overallDepth;
				((IPersistEntity)this).Activate(false);
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
				if(ActivationStatus != ActivationStatus.NotActivated) return _webThickness;
				((IPersistEntity)this).Activate(false);
				return _webThickness;
			} 
			set
			{
				SetValue( v =>  _webThickness = v, _webThickness, value,  "WebThickness");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure @FlangeThickness 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _flangeThickness;
				((IPersistEntity)this).Activate(false);
				return _flangeThickness;
			} 
			set
			{
				SetValue( v =>  _flangeThickness = v, _flangeThickness, value,  "FlangeThickness");
			} 
		}
	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure? @FilletRadius 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _filletRadius;
				((IPersistEntity)this).Activate(false);
				return _filletRadius;
			} 
			set
			{
				SetValue( v =>  _filletRadius = v, _filletRadius, value,  "FilletRadius");
			} 
		}
	
		#endregion



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 3: 
					_overallWidth = value.RealVal;
					return;
				case 4: 
					_overallDepth = value.RealVal;
					return;
				case 5: 
					_webThickness = value.RealVal;
					return;
				case 6: 
					_flangeThickness = value.RealVal;
					return;
				case 7: 
					_filletRadius = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR1:	WR1 : FlangeThickness < (OverallDepth / 2.);*/
		/*WR2:	WR2 : WebThickness < OverallWidth;*/
		/*WR3:             (FilletRadius <= (OverallDepth - (2. * FlangeThickness))/2.));*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcIShapeProfileDef other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcIShapeProfileDef
            var root = (@IfcIShapeProfileDef)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcIShapeProfileDef left, @IfcIShapeProfileDef right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcIShapeProfileDef left, @IfcIShapeProfileDef right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcIShapeProfileDef x, @IfcIShapeProfileDef y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcIShapeProfileDef obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}