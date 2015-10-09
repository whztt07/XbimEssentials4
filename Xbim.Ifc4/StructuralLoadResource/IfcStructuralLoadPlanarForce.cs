// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.StructuralLoadResource
{
	[ExpressType("IFCSTRUCTURALLOADPLANARFORCE", 1028)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcStructuralLoadPlanarForce : IfcStructuralLoadStatic, IInstantiableEntity, IEqualityComparer<@IfcStructuralLoadPlanarForce>, IEquatable<@IfcStructuralLoadPlanarForce>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcStructuralLoadPlanarForce(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcPlanarForceMeasure? _planarForceX;
		private IfcPlanarForceMeasure? _planarForceY;
		private IfcPlanarForceMeasure? _planarForceZ;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPlanarForceMeasure? @PlanarForceX 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _planarForceX;
				((IPersistEntity)this).Activate(false);
				return _planarForceX;
			} 
			set
			{
				SetValue( v =>  _planarForceX = v, _planarForceX, value,  "PlanarForceX");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPlanarForceMeasure? @PlanarForceY 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _planarForceY;
				((IPersistEntity)this).Activate(false);
				return _planarForceY;
			} 
			set
			{
				SetValue( v =>  _planarForceY = v, _planarForceY, value,  "PlanarForceY");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPlanarForceMeasure? @PlanarForceZ 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _planarForceZ;
				((IPersistEntity)this).Activate(false);
				return _planarForceZ;
			} 
			set
			{
				SetValue( v =>  _planarForceZ = v, _planarForceZ, value,  "PlanarForceZ");
			} 
		}
	
		#endregion



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 1: 
					_planarForceX = value.RealVal;
					return;
				case 2: 
					_planarForceY = value.RealVal;
					return;
				case 3: 
					_planarForceZ = value.RealVal;
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
        public bool Equals(@IfcStructuralLoadPlanarForce other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcStructuralLoadPlanarForce
            var root = (@IfcStructuralLoadPlanarForce)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcStructuralLoadPlanarForce left, @IfcStructuralLoadPlanarForce right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcStructuralLoadPlanarForce left, @IfcStructuralLoadPlanarForce right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcStructuralLoadPlanarForce x, @IfcStructuralLoadPlanarForce y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcStructuralLoadPlanarForce obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}