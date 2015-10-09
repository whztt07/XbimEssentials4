// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.Kernel;
using Xbim.Ifc2x3.UtilityResource;
using Xbim.Ifc2x3.MeasureResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.FacilitiesMgmtDomain
{
	[ExpressType("IFCFURNITURESTANDARD", 75)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcFurnitureStandard : IfcControl, IInstantiableEntity, IEqualityComparer<@IfcFurnitureStandard>, IEquatable<@IfcFurnitureStandard>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcFurnitureStandard(IModel model) : base(model) 		{ 
			Model = model; 
		}




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
					base.Parse(propIndex, value, nestedIndex); 
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
        public bool Equals(@IfcFurnitureStandard other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcFurnitureStandard
            var root = (@IfcFurnitureStandard)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcFurnitureStandard left, @IfcFurnitureStandard right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcFurnitureStandard left, @IfcFurnitureStandard right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcFurnitureStandard x, @IfcFurnitureStandard y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcFurnitureStandard obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}