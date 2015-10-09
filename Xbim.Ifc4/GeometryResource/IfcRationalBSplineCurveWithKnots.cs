// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.GeometryResource
{
	[ExpressType("IFCRATIONALBSPLINECURVEWITHKNOTS", 884)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRationalBSplineCurveWithKnots : IfcBSplineCurveWithKnots, IInstantiableEntity, IEqualityComparer<@IfcRationalBSplineCurveWithKnots>, IEquatable<@IfcRationalBSplineCurveWithKnots>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRationalBSplineCurveWithKnots(IModel model) : base(model) 		{ 
			Model = model; 
			_weightsData = new ItemSet<double>( this, 0 );
		}

		#region Explicit attribute fields
		private ItemSet<double> _weightsData;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(9, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.None, 2, -1)]
		public ItemSet<double> @WeightsData 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _weightsData;
				((IPersistEntity)this).Activate(false);
				return _weightsData;
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
				case 3: 
				case 4: 
				case 5: 
				case 6: 
				case 7: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 8: 
					if (_weightsData == null) _weightsData = new ItemSet<double>( this );
					_weightsData.InternalAdd(value.RealVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*SameNumOfWeightsAndPoints:	SameNumOfWeightsAndPoints : SIZEOF(WeightsData) = SIZEOF(SELF\IfcBSplineCurve.ControlPointsList);*/
		/*WeightsGreaterZero:	WeightsGreaterZero : IfcCurveWeightsPositive(SELF);*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcRationalBSplineCurveWithKnots other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcRationalBSplineCurveWithKnots
            var root = (@IfcRationalBSplineCurveWithKnots)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcRationalBSplineCurveWithKnots left, @IfcRationalBSplineCurveWithKnots right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcRationalBSplineCurveWithKnots left, @IfcRationalBSplineCurveWithKnots right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcRationalBSplineCurveWithKnots x, @IfcRationalBSplineCurveWithKnots y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcRationalBSplineCurveWithKnots obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}