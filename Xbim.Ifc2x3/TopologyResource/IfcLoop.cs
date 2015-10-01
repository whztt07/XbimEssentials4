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

namespace Xbim.Ifc2x3.TopologyResource
{
	[ExpressType("IFCLOOP", 199)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcLoop : IfcTopologicalRepresentationItem, IInstantiableEntity, System.Collections.Generic.IEqualityComparer<@IfcLoop>, System.IEquatable<@IfcLoop>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcLoop(IModel model) : base(model) 		{ 
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
        public bool Equals(@IfcLoop other)
	    {
	        return this == other;
	    }


        public static bool operator ==(@IfcLoop left, @IfcLoop right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcLoop left, @IfcLoop right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcLoop x, @IfcLoop y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcLoop obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}