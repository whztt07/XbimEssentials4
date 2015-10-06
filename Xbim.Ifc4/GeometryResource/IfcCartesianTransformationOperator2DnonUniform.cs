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

namespace Xbim.Ifc4.GeometryResource
{
	[ExpressType("IFCCARTESIANTRANSFORMATIONOPERATOR2DNONUNIFORM", 472)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcCartesianTransformationOperator2DnonUniform : IfcCartesianTransformationOperator2D, IInstantiableEntity, IEqualityComparer<@IfcCartesianTransformationOperator2DnonUniform>, IEquatable<@IfcCartesianTransformationOperator2DnonUniform>
	{
		public static int LoadDepth = 1;

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcCartesianTransformationOperator2DnonUniform(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private double? _scale2;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public double? @Scale2 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _scale2;
				((IPersistEntity)this).Activate(false);
				return _scale2;
			} 
			set
			{
				SetValue( v =>  _scale2 = v, _scale2, value,  "Scale2");
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
				case 3: 
					base.Parse(propIndex, value); 
					return;
				case 4: 
					_scale2 = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*Scale2GreaterZero:	Scale2GreaterZero : Scl2 > 0.0;*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcCartesianTransformationOperator2DnonUniform other)
	    {
	        return this == other;
	    }


        public static bool operator ==(@IfcCartesianTransformationOperator2DnonUniform left, @IfcCartesianTransformationOperator2DnonUniform right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcCartesianTransformationOperator2DnonUniform left, @IfcCartesianTransformationOperator2DnonUniform right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcCartesianTransformationOperator2DnonUniform x, @IfcCartesianTransformationOperator2DnonUniform y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcCartesianTransformationOperator2DnonUniform obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}