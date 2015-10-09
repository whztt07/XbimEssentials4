// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.PresentationDimensioningResource;
using Xbim.Ifc2x3.GeometryResource;
using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.PresentationAppearanceResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.PresentationDefinitionResource
{
	[ExpressType("IFCANNOTATIONTEXTOCCURRENCE", 122)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcAnnotationTextOccurrence : IfcAnnotationOccurrence, IfcDraughtingCalloutElement, IInstantiableEntity, IEqualityComparer<@IfcAnnotationTextOccurrence>, IEquatable<@IfcAnnotationTextOccurrence>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcAnnotationTextOccurrence(IModel model) : base(model) 		{ 
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR31:             ('IFC2X3.IFCTEXTLITERAL' IN TYPEOF (SELF\IfcStyledItem.Item));*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcAnnotationTextOccurrence other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcAnnotationTextOccurrence
            var root = (@IfcAnnotationTextOccurrence)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcAnnotationTextOccurrence left, @IfcAnnotationTextOccurrence right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcAnnotationTextOccurrence left, @IfcAnnotationTextOccurrence right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcAnnotationTextOccurrence x, @IfcAnnotationTextOccurrence y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcAnnotationTextOccurrence obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}