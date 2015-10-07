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

namespace Xbim.Ifc2x3.GeometryResource
{
	[ExpressType("IFCCARTESIANPOINT", 410)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcCartesianPoint : IfcPoint, IfcTrimmingSelect, IInstantiableEntity, IEqualityComparer<@IfcCartesianPoint>, IEquatable<@IfcCartesianPoint>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcCartesianPoint(IModel model) : base(model) 		{ 
			Model = model; 
			_coordinates = new ItemSet<IfcLengthMeasure>( this, 3 );
		}

		#region Explicit attribute fields
		private ItemSet<IfcLengthMeasure> _coordinates;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.None, 1, 3)]
		public ItemSet<IfcLengthMeasure> @Coordinates 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _coordinates;
				((IPersistEntity)this).Activate(false);
				return _coordinates;
			} 
		}
	
		#endregion



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
					if (_coordinates == null) _coordinates = new ItemSet<IfcLengthMeasure>( this );
					_coordinates.InternalAdd(value.RealVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR1:	WR1 : HIINDEX(Coordinates) >= 2;*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcCartesianPoint other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcCartesianPoint
            var root = (@IfcCartesianPoint)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcCartesianPoint left, @IfcCartesianPoint right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcCartesianPoint left, @IfcCartesianPoint right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcCartesianPoint x, @IfcCartesianPoint y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcCartesianPoint obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}