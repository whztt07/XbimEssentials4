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

namespace Xbim.Ifc4.PresentationAppearanceResource
{
	[ExpressType("IFCPREDEFINEDCOLOUR", 824)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcPreDefinedColour : IfcPreDefinedItem, IfcColour, IEqualityComparer<@IfcPreDefinedColour>, IEquatable<@IfcPreDefinedColour>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPreDefinedColour(IModel model) : base(model) 		{ 
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
        public bool Equals(@IfcPreDefinedColour other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcPreDefinedColour
            var root = (@IfcPreDefinedColour)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcPreDefinedColour left, @IfcPreDefinedColour right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcPreDefinedColour left, @IfcPreDefinedColour right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcPreDefinedColour x, @IfcPreDefinedColour y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcPreDefinedColour obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}