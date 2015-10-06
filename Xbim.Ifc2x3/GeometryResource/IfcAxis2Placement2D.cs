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

namespace Xbim.Ifc2x3.GeometryResource
{
	[ExpressType("IFCAXIS2PLACEMENT2D", 411)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcAxis2Placement2D : IfcPlacement, IfcAxis2Placement, IInstantiableEntity, IEqualityComparer<@IfcAxis2Placement2D>, IEquatable<@IfcAxis2Placement2D>
	{
		public static int LoadDepth = 1;

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcAxis2Placement2D(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcDirection _refDirection;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcDirection @RefDirection 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _refDirection;
				((IPersistEntity)this).Activate(false);
				return _refDirection;
			} 
			set
			{
				SetValue( v =>  _refDirection = v, _refDirection, value,  "RefDirection");
			} 
		}
	
		#endregion



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
					base.Parse(propIndex, value); 
					return;
				case 1: 
					_refDirection = (IfcDirection)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR1:	WR1 : (NOT (EXISTS (RefDirection))) OR (RefDirection.Dim = 2);*/
		/*WR2:	WR2 : SELF\IfcPlacement.Location.Dim = 2;*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcAxis2Placement2D other)
	    {
	        return this == other;
	    }


        public static bool operator ==(@IfcAxis2Placement2D left, @IfcAxis2Placement2D right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcAxis2Placement2D left, @IfcAxis2Placement2D right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcAxis2Placement2D x, @IfcAxis2Placement2D y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcAxis2Placement2D obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}