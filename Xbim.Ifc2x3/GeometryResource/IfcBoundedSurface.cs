// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.GeometryResource
{
	[ExpressType("IFCBOUNDEDSURFACE", 335)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcBoundedSurface : IfcSurface, IInstantiableEntity, System.Collections.Generic.IEqualityComparer<@IfcBoundedSurface>, System.IEquatable<@IfcBoundedSurface>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcBoundedSurface(IModel model) : base(model) 		{ 
			Model = model; 
		}




		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
			//there are no attributes defined for this entity
            throw new System.IndexOutOfRangeException("There are no attributes defined for this entity");
		}
		
		public  override string WhereRule() 
		{
			return "";
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcBoundedSurface other)
	    {
	        return this == other;
	    }


        public static bool operator ==(@IfcBoundedSurface left, @IfcBoundedSurface right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcBoundedSurface left, @IfcBoundedSurface right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcBoundedSurface x, @IfcBoundedSurface y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcBoundedSurface obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}