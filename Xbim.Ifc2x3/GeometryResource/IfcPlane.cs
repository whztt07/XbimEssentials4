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
	[ExpressType("IFCPLANE", 388)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcPlane : IfcElementarySurface, IInstantiableEntity, System.Collections.Generic.IEqualityComparer<@IfcPlane>, System.IEquatable<@IfcPlane>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPlane(IModel model) : base(model) 		{ 
			Model = model; 
		}




		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
					base.Parse(propIndex, value); 
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
        public bool Equals(@IfcPlane other)
	    {
	        return this == other;
	    }


        public static bool operator ==(@IfcPlane left, @IfcPlane right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcPlane left, @IfcPlane right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcPlane x, @IfcPlane y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcPlane obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}