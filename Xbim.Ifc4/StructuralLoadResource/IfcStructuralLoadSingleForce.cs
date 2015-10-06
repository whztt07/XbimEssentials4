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
	[ExpressType("IFCSTRUCTURALLOADSINGLEFORCE", 1031)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcStructuralLoadSingleForce : IfcStructuralLoadStatic, IInstantiableEntity, IEqualityComparer<@IfcStructuralLoadSingleForce>, IEquatable<@IfcStructuralLoadSingleForce>
	{
		public static int LoadDepth = 1;

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcStructuralLoadSingleForce(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcForceMeasure? _forceX;
		private IfcForceMeasure? _forceY;
		private IfcForceMeasure? _forceZ;
		private IfcTorqueMeasure? _momentX;
		private IfcTorqueMeasure? _momentY;
		private IfcTorqueMeasure? _momentZ;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcForceMeasure? @ForceX 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _forceX;
				((IPersistEntity)this).Activate(false);
				return _forceX;
			} 
			set
			{
				SetValue( v =>  _forceX = v, _forceX, value,  "ForceX");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcForceMeasure? @ForceY 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _forceY;
				((IPersistEntity)this).Activate(false);
				return _forceY;
			} 
			set
			{
				SetValue( v =>  _forceY = v, _forceY, value,  "ForceY");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcForceMeasure? @ForceZ 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _forceZ;
				((IPersistEntity)this).Activate(false);
				return _forceZ;
			} 
			set
			{
				SetValue( v =>  _forceZ = v, _forceZ, value,  "ForceZ");
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcTorqueMeasure? @MomentX 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _momentX;
				((IPersistEntity)this).Activate(false);
				return _momentX;
			} 
			set
			{
				SetValue( v =>  _momentX = v, _momentX, value,  "MomentX");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcTorqueMeasure? @MomentY 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _momentY;
				((IPersistEntity)this).Activate(false);
				return _momentY;
			} 
			set
			{
				SetValue( v =>  _momentY = v, _momentY, value,  "MomentY");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcTorqueMeasure? @MomentZ 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _momentZ;
				((IPersistEntity)this).Activate(false);
				return _momentZ;
			} 
			set
			{
				SetValue( v =>  _momentZ = v, _momentZ, value,  "MomentZ");
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
					_forceX = value.RealVal;
					return;
				case 2: 
					_forceY = value.RealVal;
					return;
				case 3: 
					_forceZ = value.RealVal;
					return;
				case 4: 
					_momentX = value.RealVal;
					return;
				case 5: 
					_momentY = value.RealVal;
					return;
				case 6: 
					_momentZ = value.RealVal;
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
        public bool Equals(@IfcStructuralLoadSingleForce other)
	    {
	        return this == other;
	    }


        public static bool operator ==(@IfcStructuralLoadSingleForce left, @IfcStructuralLoadSingleForce right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcStructuralLoadSingleForce left, @IfcStructuralLoadSingleForce right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcStructuralLoadSingleForce x, @IfcStructuralLoadSingleForce y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcStructuralLoadSingleForce obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}