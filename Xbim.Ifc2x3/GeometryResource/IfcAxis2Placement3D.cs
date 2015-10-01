// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.GeometryResource
{
	[ExpressType("IFCAXIS2PLACEMENT3D", 448)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcAxis2Placement3D : IfcPlacement, IfcAxis2Placement, IInstantiableEntity, System.Collections.Generic.IEqualityComparer<@IfcAxis2Placement3D>, System.IEquatable<@IfcAxis2Placement3D>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcAxis2Placement3D(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcDirection _axis;
		private IfcDirection _refDirection;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcDirection @Axis 
		{ 
			get 
			{
				if(Activated) return _axis;
				
				Model.Activate(this, true);
				Activated = true;
				return _axis;
			} 
			set
			{
				SetValue( v =>  _axis = v, _axis, value,  "Axis");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcDirection @RefDirection 
		{ 
			get 
			{
				if(Activated) return _refDirection;
				
				Model.Activate(this, true);
				Activated = true;
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
					_axis = (IfcDirection)(value.EntityVal);
					return;
				case 2: 
					_refDirection = (IfcDirection)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR1:	WR1 : SELF\IfcPlacement.Location.Dim = 3;*/
		/*WR2:	WR2 : (NOT (EXISTS (Axis))) OR (Axis.Dim = 3);*/
		/*WR3:	WR3 : (NOT (EXISTS (RefDirection))) OR (RefDirection.Dim = 3);*/
		/*WR4:	WR4 : (NOT (EXISTS (Axis))) OR (NOT (EXISTS (RefDirection))) OR (IfcCrossProduct(Axis,RefDirection).Magnitude > 0.0);*/
		/*WR5:	WR5 : NOT ((EXISTS (Axis)) XOR (EXISTS (RefDirection)));*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcAxis2Placement3D other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcAxis2Placement3D
            var root = (@IfcAxis2Placement3D)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcAxis2Placement3D left, @IfcAxis2Placement3D right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcAxis2Placement3D left, @IfcAxis2Placement3D right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcAxis2Placement3D x, @IfcAxis2Placement3D y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcAxis2Placement3D obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}