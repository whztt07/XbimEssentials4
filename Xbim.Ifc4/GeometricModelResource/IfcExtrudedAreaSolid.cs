// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.ProfileResource;
using Xbim.Ifc4.GeometryResource;
using Xbim.Ifc4.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.GeometricModelResource
{
	[ExpressType("IFCEXTRUDEDAREASOLID", 640)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcExtrudedAreaSolid : IfcSweptAreaSolid, IInstantiableEntity, System.Collections.Generic.IEqualityComparer<@IfcExtrudedAreaSolid>, System.IEquatable<@IfcExtrudedAreaSolid>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcExtrudedAreaSolid(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcDirection _extrudedDirection;
		private IfcPositiveLengthMeasure _depth;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcDirection @ExtrudedDirection 
		{ 
			get 
			{
				if(Activated) return _extrudedDirection;
				
				Model.Activate(this, true);
				Activated = true;
				return _extrudedDirection;
			} 
			set
			{
				SetValue( v =>  _extrudedDirection = v, _extrudedDirection, value,  "ExtrudedDirection");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure @Depth 
		{ 
			get 
			{
				if(Activated) return _depth;
				
				Model.Activate(this, true);
				Activated = true;
				return _depth;
			} 
			set
			{
				SetValue( v =>  _depth = v, _depth, value,  "Depth");
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
					base.Parse(propIndex, value); 
					return;
				case 2: 
					_extrudedDirection = (IfcDirection)(value.EntityVal);
					return;
				case 3: 
					_depth = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*ValidExtrusionDirection:	ValidExtrusionDirection : IfcDotProduct(IfcRepresentationItem() || IfcGeometricRepresentationItem() || IfcDirection([0.0,0.0,1.0]), SELF.ExtrudedDirection) <> 0.0;*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcExtrudedAreaSolid other)
	    {
	        return this == other;
	    }


        public static bool operator ==(@IfcExtrudedAreaSolid left, @IfcExtrudedAreaSolid right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcExtrudedAreaSolid left, @IfcExtrudedAreaSolid right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcExtrudedAreaSolid x, @IfcExtrudedAreaSolid y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcExtrudedAreaSolid obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}