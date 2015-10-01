// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.GeometricConstraintResource;
using Xbim.Ifc4.GeometryResource;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.GeometricModelResource
{
	[IndexedClass]
	[ExpressType("IFCSOLIDMODEL", 992)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcSolidModel : IfcGeometricRepresentationItem, IfcBooleanOperand, IfcSolidOrShell, System.Collections.Generic.IEqualityComparer<@IfcSolidModel>, System.IEquatable<@IfcSolidModel>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcSolidModel(IModel model) : base(model) 		{ 
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
        public bool Equals(@IfcSolidModel other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcSolidModel
            var root = (@IfcSolidModel)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcSolidModel left, @IfcSolidModel right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcSolidModel left, @IfcSolidModel right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcSolidModel x, @IfcSolidModel y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcSolidModel obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}