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

namespace Xbim.Ifc2x3.GeometricConstraintResource
{
	[ExpressType("IFCGRIDPLACEMENT", 439)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcGridPlacement : IfcObjectPlacement, IInstantiableEntity, System.Collections.Generic.IEqualityComparer<@IfcGridPlacement>, System.IEquatable<@IfcGridPlacement>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcGridPlacement(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcVirtualGridIntersection _placementLocation;
		private IfcVirtualGridIntersection _placementRefDirection;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcVirtualGridIntersection @PlacementLocation 
		{ 
			get 
			{
				if(Activated) return _placementLocation;
				
				Model.Activate(this, true);
				Activated = true;
				return _placementLocation;
			} 
			set
			{
				SetValue( v =>  _placementLocation = v, _placementLocation, value,  "PlacementLocation");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcVirtualGridIntersection @PlacementRefDirection 
		{ 
			get 
			{
				if(Activated) return _placementRefDirection;
				
				Model.Activate(this, true);
				Activated = true;
				return _placementRefDirection;
			} 
			set
			{
				SetValue( v =>  _placementRefDirection = v, _placementRefDirection, value,  "PlacementRefDirection");
			} 
		}
	
		#endregion



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
					_placementLocation = (IfcVirtualGridIntersection)(value.EntityVal);
					return;
				case 1: 
					_placementRefDirection = (IfcVirtualGridIntersection)(value.EntityVal);
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
        public bool Equals(@IfcGridPlacement other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcGridPlacement
            var root = (@IfcGridPlacement)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcGridPlacement left, @IfcGridPlacement right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcGridPlacement left, @IfcGridPlacement right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcGridPlacement x, @IfcGridPlacement y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcGridPlacement obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}