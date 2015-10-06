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
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.ProfileResource
{
	[ExpressType("IFCELLIPSEPROFILEDEF", 619)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcEllipseProfileDef : IfcParameterizedProfileDef, IInstantiableEntity, IEqualityComparer<@IfcEllipseProfileDef>, IEquatable<@IfcEllipseProfileDef>
	{
		public static int LoadDepth = 1;

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcEllipseProfileDef(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcPositiveLengthMeasure _semiAxis1;
		private IfcPositiveLengthMeasure _semiAxis2;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure @SemiAxis1 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _semiAxis1;
				((IPersistEntity)this).Activate(false);
				return _semiAxis1;
			} 
			set
			{
				SetValue( v =>  _semiAxis1 = v, _semiAxis1, value,  "SemiAxis1");
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure @SemiAxis2 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _semiAxis2;
				((IPersistEntity)this).Activate(false);
				return _semiAxis2;
			} 
			set
			{
				SetValue( v =>  _semiAxis2 = v, _semiAxis2, value,  "SemiAxis2");
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
					_semiAxis1 = value.RealVal;
					return;
				case 4: 
					_semiAxis2 = value.RealVal;
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

		#region Equality comparers and operators
        public bool Equals(@IfcEllipseProfileDef other)
	    {
	        return this == other;
	    }


        public static bool operator ==(@IfcEllipseProfileDef left, @IfcEllipseProfileDef right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcEllipseProfileDef left, @IfcEllipseProfileDef right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcEllipseProfileDef x, @IfcEllipseProfileDef y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcEllipseProfileDef obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}