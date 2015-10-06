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
	[IndexedClass]
	[ExpressType("IFCCOMPOSITECURVE", 279)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcCompositeCurve : IfcBoundedCurve, IInstantiableEntity, IEqualityComparer<@IfcCompositeCurve>, IEquatable<@IfcCompositeCurve>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcCompositeCurve(IModel model) : base(model) 		{ 
			Model = model; 
			_segments = new ItemSet<IfcCompositeCurveSegment>( this );
		}

		#region Explicit attribute fields
		private ItemSet<IfcCompositeCurveSegment> _segments;
		private bool? _selfIntersect;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.Class, 1, -1)]
		public ItemSet<IfcCompositeCurveSegment> @Segments 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _segments;
				((IPersistEntity)this).Activate(false);
				return _segments;
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public bool? @SelfIntersect 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _selfIntersect;
				((IPersistEntity)this).Activate(false);
				return _selfIntersect;
			} 
			set
			{
				SetValue( v =>  _selfIntersect = v, _selfIntersect, value,  "SelfIntersect");
			} 
		}
	
		#endregion



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
					if (_segments == null) _segments = new ItemSet<IfcCompositeCurveSegment>( this );
					_segments.InternalAdd((IfcCompositeCurveSegment)value.EntityVal);
					return;
				case 1: 
					_selfIntersect = value.BooleanVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR41:	WR41 : ((NOT ClosedCurve) AND (SIZEOF(QUERY(Temp <* Segments | Temp.Transition = Discontinuous)) = 1)) OR ((ClosedCurve) AND (SIZEOF(QUERY(Temp <* Segments | Temp.Transition = Discontinuous)) = 0));*/
		/*WR42:	WR42 : SIZEOF( QUERY( Temp <* Segments | Temp.Dim <> Segments[1].Dim)) = 0;*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcCompositeCurve other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcCompositeCurve
            var root = (@IfcCompositeCurve)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcCompositeCurve left, @IfcCompositeCurve right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcCompositeCurve left, @IfcCompositeCurve right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcCompositeCurve x, @IfcCompositeCurve y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcCompositeCurve obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}