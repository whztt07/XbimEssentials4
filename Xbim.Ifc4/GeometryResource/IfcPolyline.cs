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

namespace Xbim.Ifc4.GeometryResource
{
	[ExpressType("IFCPOLYLINE", 821)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcPolyline : IfcBoundedCurve, IInstantiableEntity, System.Collections.Generic.IEqualityComparer<@IfcPolyline>, System.IEquatable<@IfcPolyline>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPolyline(IModel model) : base(model) 		{ 
			Model = model; 
			_points = new ItemSet<IfcCartesianPoint>( this );
		}

		#region Explicit attribute fields
		private ItemSet<IfcCartesianPoint> _points;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.Class, 2, -1)]
		public ItemSet<IfcCartesianPoint> @Points 
		{ 
			get 
			{
				if(Activated) return _points;
				
				Model.Activate(this, true);
				Activated = true;
				return _points;
			} 
		}
	
		#endregion



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
					if (_points == null) _points = new ItemSet<IfcCartesianPoint>( this );
					_points.InternalAdd((IfcCartesianPoint)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*SameDim:	SameDim : SIZEOF(QUERY(Temp <* Points | Temp.Dim <> Points[1].Dim)) = 0;*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcPolyline other)
	    {
	        return this == other;
	    }


        public static bool operator ==(@IfcPolyline left, @IfcPolyline right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcPolyline left, @IfcPolyline right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcPolyline x, @IfcPolyline y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcPolyline obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}