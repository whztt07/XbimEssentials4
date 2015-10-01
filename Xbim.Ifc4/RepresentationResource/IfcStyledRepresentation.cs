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
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.RepresentationResource
{
	[ExpressType("IFCSTYLEDREPRESENTATION", 1049)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcStyledRepresentation : IfcStyleModel, IInstantiableEntity, System.Collections.Generic.IEqualityComparer<@IfcStyledRepresentation>, System.IEquatable<@IfcStyledRepresentation>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcStyledRepresentation(IModel model) : base(model) 		{ 
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
		/*OnlyStyledItems:                        )) = 0;*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcStyledRepresentation other)
	    {
	        return this == other;
	    }


        public static bool operator ==(@IfcStyledRepresentation left, @IfcStyledRepresentation right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcStyledRepresentation left, @IfcStyledRepresentation right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcStyledRepresentation x, @IfcStyledRepresentation y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcStyledRepresentation obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}