// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.GeometryResource
{
	[ExpressType("IFCCARTESIANTRANSFORMATIONOPERATOR2D", 145)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcCartesianTransformationOperator2D : IfcCartesianTransformationOperator, IInstantiableEntity, IEqualityComparer<@IfcCartesianTransformationOperator2D>, IEquatable<@IfcCartesianTransformationOperator2D>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcCartesianTransformationOperator2D(IModel model) : base(model) 		{ 
			Model = model; 
		}




		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
				case 3: 
					base.Parse(propIndex, value); 
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR1:	WR1 : SELF\IfcCartesianTransformationOperator.Dim = 2;*/
		/*WR2:            (SELF\IfcCartesianTransformationOperator.Axis1.Dim = 2);*/
		/*WR3:            (SELF\IfcCartesianTransformationOperator.Axis2.Dim = 2);*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcCartesianTransformationOperator2D other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcCartesianTransformationOperator2D
            var root = (@IfcCartesianTransformationOperator2D)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcCartesianTransformationOperator2D left, @IfcCartesianTransformationOperator2D right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcCartesianTransformationOperator2D left, @IfcCartesianTransformationOperator2D right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcCartesianTransformationOperator2D x, @IfcCartesianTransformationOperator2D y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcCartesianTransformationOperator2D obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}