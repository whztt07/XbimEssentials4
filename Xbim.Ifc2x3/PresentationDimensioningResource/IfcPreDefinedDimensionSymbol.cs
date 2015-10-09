// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.PresentationDefinitionResource;
using Xbim.Ifc2x3.MeasureResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.PresentationDimensioningResource
{
	[ExpressType("IFCPREDEFINEDDIMENSIONSYMBOL", 747)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcPreDefinedDimensionSymbol : IfcPreDefinedSymbol, IInstantiableEntity, IEqualityComparer<@IfcPreDefinedDimensionSymbol>, IEquatable<@IfcPreDefinedDimensionSymbol>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPreDefinedDimensionSymbol(IModel model) : base(model) 		{ 
			Model = model; 
		}




		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR31:                  'slope','spherical diameter','spherical radius','square'];*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcPreDefinedDimensionSymbol other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcPreDefinedDimensionSymbol
            var root = (@IfcPreDefinedDimensionSymbol)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcPreDefinedDimensionSymbol left, @IfcPreDefinedDimensionSymbol right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcPreDefinedDimensionSymbol left, @IfcPreDefinedDimensionSymbol right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcPreDefinedDimensionSymbol x, @IfcPreDefinedDimensionSymbol y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcPreDefinedDimensionSymbol obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}