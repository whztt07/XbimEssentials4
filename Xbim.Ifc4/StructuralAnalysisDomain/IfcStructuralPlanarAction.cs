// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.UtilityResource;
using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.GeometricConstraintResource;
using Xbim.Ifc4.RepresentationResource;
using Xbim.Ifc4.StructuralLoadResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.StructuralAnalysisDomain
{
	[ExpressType("IFCSTRUCTURALPLANARACTION", 1036)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcStructuralPlanarAction : IfcStructuralSurfaceAction, IInstantiableEntity, IEqualityComparer<@IfcStructuralPlanarAction>, IEquatable<@IfcStructuralPlanarAction>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcStructuralPlanarAction(IModel model) : base(model) 		{ 
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
				case 5: 
				case 6: 
				case 7: 
				case 8: 
				case 9: 
				case 10: 
				case 11: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*SuitableLoadType:	SuitableLoadType : SIZEOF(['IFC4.IFCSTRUCTURALLOADPLANARFORCE', 'IFC4.IFCSTRUCTURALLOADTEMPERATURE'] * TYPEOF(SELF\IfcStructuralActivity.AppliedLoad)) = 1;*/
		/*ConstPredefinedType:	ConstPredefinedType : SELF\IfcStructuralSurfaceAction.PredefinedType = IfcStructuralSurfaceActivityTypeEnum.CONST;*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcStructuralPlanarAction other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcStructuralPlanarAction
            var root = (@IfcStructuralPlanarAction)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcStructuralPlanarAction left, @IfcStructuralPlanarAction right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcStructuralPlanarAction left, @IfcStructuralPlanarAction right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcStructuralPlanarAction x, @IfcStructuralPlanarAction y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcStructuralPlanarAction obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}