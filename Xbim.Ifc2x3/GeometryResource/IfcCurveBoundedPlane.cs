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
	[ExpressType("IFCCURVEBOUNDEDPLANE", 334)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcCurveBoundedPlane : IfcBoundedSurface, IInstantiableEntity, IEqualityComparer<@IfcCurveBoundedPlane>, IEquatable<@IfcCurveBoundedPlane>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcCurveBoundedPlane(IModel model) : base(model) 		{ 
			Model = model; 
			_innerBoundaries = new ItemSet<IfcCurve>( this );
		}

		#region Explicit attribute fields
		private IfcPlane _basisSurface;
		private IfcCurve _outerBoundary;
		private ItemSet<IfcCurve> _innerBoundaries;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcPlane @BasisSurface 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _basisSurface;
				((IPersistEntity)this).Activate(false);
				return _basisSurface;
			} 
			set
			{
				SetValue( v =>  _basisSurface = v, _basisSurface, value,  "BasisSurface");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcCurve @OuterBoundary 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _outerBoundary;
				((IPersistEntity)this).Activate(false);
				return _outerBoundary;
			} 
			set
			{
				SetValue( v =>  _outerBoundary = v, _outerBoundary, value,  "OuterBoundary");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 0, -1)]
		public ItemSet<IfcCurve> @InnerBoundaries 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _innerBoundaries;
				((IPersistEntity)this).Activate(false);
				return _innerBoundaries;
			} 
		}
	
		#endregion



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
					_basisSurface = (IfcPlane)(value.EntityVal);
					return;
				case 1: 
					_outerBoundary = (IfcCurve)(value.EntityVal);
					return;
				case 2: 
					if (_innerBoundaries == null) _innerBoundaries = new ItemSet<IfcCurve>( this );
					_innerBoundaries.InternalAdd((IfcCurve)value.EntityVal);
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
        public bool Equals(@IfcCurveBoundedPlane other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcCurveBoundedPlane
            var root = (@IfcCurveBoundedPlane)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcCurveBoundedPlane left, @IfcCurveBoundedPlane right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcCurveBoundedPlane left, @IfcCurveBoundedPlane right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcCurveBoundedPlane x, @IfcCurveBoundedPlane y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcCurveBoundedPlane obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}