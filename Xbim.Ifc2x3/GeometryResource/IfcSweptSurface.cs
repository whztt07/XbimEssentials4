// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.ProfileResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.GeometryResource
{
	[ExpressType("IFCSWEPTSURFACE", 110)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcSweptSurface : IfcSurface, IEqualityComparer<@IfcSweptSurface>, IEquatable<@IfcSweptSurface>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcSweptSurface(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcProfileDef _sweptCurve;
		private IfcAxis2Placement3D _position;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcProfileDef @SweptCurve 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _sweptCurve;
				((IPersistEntity)this).Activate(false);
				return _sweptCurve;
			} 
			set
			{
				SetValue( v =>  _sweptCurve = v, _sweptCurve, value,  "SweptCurve");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcAxis2Placement3D @Position 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _position;
				((IPersistEntity)this).Activate(false);
				return _position;
			} 
			set
			{
				SetValue( v =>  _position = v, _position, value,  "Position");
			} 
		}
	
		#endregion



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
					_sweptCurve = (IfcProfileDef)(value.EntityVal);
					return;
				case 1: 
					_position = (IfcAxis2Placement3D)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR1:	WR1 : NOT('IFC2X3.IFCDERIVEDPROFILEDEF' IN TYPEOF(SweptCurve));*/
		/*WR2:	WR2 : SweptCurve.ProfileType = IfcProfileTypeEnum.Curve;*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcSweptSurface other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcSweptSurface
            var root = (@IfcSweptSurface)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcSweptSurface left, @IfcSweptSurface right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcSweptSurface left, @IfcSweptSurface right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcSweptSurface x, @IfcSweptSurface y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcSweptSurface obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}