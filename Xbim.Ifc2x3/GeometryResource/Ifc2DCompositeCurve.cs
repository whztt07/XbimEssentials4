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
	[ExpressType("IFC2DCOMPOSITECURVE", 524)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @Ifc2DCompositeCurve : IfcCompositeCurve, IInstantiableEntity, IEqualityComparer<@Ifc2DCompositeCurve>, IEquatable<@Ifc2DCompositeCurve>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal Ifc2DCompositeCurve(IModel model) : base(model) 		{ 
			Model = model; 
		}




		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR1:	WR1 : SELF\IfcCompositeCurve.ClosedCurve;*/
		/*WR2:	WR2 : SELF\IfcCurve.Dim = 2;*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@Ifc2DCompositeCurve other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @Ifc2DCompositeCurve
            var root = (@Ifc2DCompositeCurve)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@Ifc2DCompositeCurve left, @Ifc2DCompositeCurve right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@Ifc2DCompositeCurve left, @Ifc2DCompositeCurve right)
        {
            return !(left == right);
        }


        public bool Equals(@Ifc2DCompositeCurve x, @Ifc2DCompositeCurve y)
        {
            return x == y;
        }

        public int GetHashCode(@Ifc2DCompositeCurve obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}