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

namespace Xbim.Ifc4.ProductExtension
{
	[ExpressType("IFCFEATUREELEMENTADDITION", 655)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcFeatureElementAddition : IfcFeatureElement, IEqualityComparer<@IfcFeatureElementAddition>, IEquatable<@IfcFeatureElementAddition>
	{
		public static int LoadDepth = 1;

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcFeatureElementAddition(IModel model) : base(model) 		{ 
			Model = model; 
		}


		#region Inverse attributes
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IfcRelProjectsElement @ProjectsElements 
		{ 
			get 
			{
				return Model.Instances.FirstOrDefault<IfcRelProjectsElement>(e => e.RelatedFeatureElement == this);
			} 
		}
		#endregion


		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
				case 3: 
				case 4: 
				case 5: 
				case 6: 
				case 7: 
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
        public bool Equals(@IfcFeatureElementAddition other)
	    {
	        return this == other;
	    }


        public static bool operator ==(@IfcFeatureElementAddition left, @IfcFeatureElementAddition right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcFeatureElementAddition left, @IfcFeatureElementAddition right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcFeatureElementAddition x, @IfcFeatureElementAddition y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcFeatureElementAddition obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}