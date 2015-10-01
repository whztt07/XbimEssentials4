// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.ProductExtension;
using Xbim.Ifc2x3.UtilityResource;
using Xbim.Ifc2x3.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.ElectricalDomain
{
	[ExpressType("IFCELECTRICALCIRCUIT", 406)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcElectricalCircuit : IfcSystem, IInstantiableEntity, System.Collections.Generic.IEqualityComparer<@IfcElectricalCircuit>, System.IEquatable<@IfcElectricalCircuit>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcElectricalCircuit(IModel model) : base(model) 		{ 
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
				case 4: 
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
        public bool Equals(@IfcElectricalCircuit other)
	    {
	        return this == other;
	    }


        public static bool operator ==(@IfcElectricalCircuit left, @IfcElectricalCircuit right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcElectricalCircuit left, @IfcElectricalCircuit right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcElectricalCircuit x, @IfcElectricalCircuit y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcElectricalCircuit obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}