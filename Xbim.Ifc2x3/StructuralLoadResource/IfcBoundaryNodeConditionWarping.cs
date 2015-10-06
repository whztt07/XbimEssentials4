// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.StructuralLoadResource
{
	[ExpressType("IFCBOUNDARYNODECONDITIONWARPING", 395)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcBoundaryNodeConditionWarping : IfcBoundaryNodeCondition, IInstantiableEntity, IEqualityComparer<@IfcBoundaryNodeConditionWarping>, IEquatable<@IfcBoundaryNodeConditionWarping>
	{
		public static int LoadDepth = 1;

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcBoundaryNodeConditionWarping(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcWarpingMomentMeasure? _warpingStiffness;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcWarpingMomentMeasure? @WarpingStiffness 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _warpingStiffness;
				((IPersistEntity)this).Activate(false);
				return _warpingStiffness;
			} 
			set
			{
				SetValue( v =>  _warpingStiffness = v, _warpingStiffness, value,  "WarpingStiffness");
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
					base.Parse(propIndex, value); 
					return;
				case 7: 
					_warpingStiffness = value.RealVal;
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
        public bool Equals(@IfcBoundaryNodeConditionWarping other)
	    {
	        return this == other;
	    }


        public static bool operator ==(@IfcBoundaryNodeConditionWarping left, @IfcBoundaryNodeConditionWarping right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcBoundaryNodeConditionWarping left, @IfcBoundaryNodeConditionWarping right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcBoundaryNodeConditionWarping x, @IfcBoundaryNodeConditionWarping y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcBoundaryNodeConditionWarping obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}