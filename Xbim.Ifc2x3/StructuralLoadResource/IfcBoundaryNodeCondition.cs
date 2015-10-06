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

namespace Xbim.Ifc2x3.StructuralLoadResource
{
	[ExpressType("IFCBOUNDARYNODECONDITION", 394)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcBoundaryNodeCondition : IfcBoundaryCondition, IInstantiableEntity, IEqualityComparer<@IfcBoundaryNodeCondition>, IEquatable<@IfcBoundaryNodeCondition>
	{
		public static int LoadDepth = 1;

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcBoundaryNodeCondition(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcLinearStiffnessMeasure? _linearStiffnessX;
		private IfcLinearStiffnessMeasure? _linearStiffnessY;
		private IfcLinearStiffnessMeasure? _linearStiffnessZ;
		private IfcRotationalStiffnessMeasure? _rotationalStiffnessX;
		private IfcRotationalStiffnessMeasure? _rotationalStiffnessY;
		private IfcRotationalStiffnessMeasure? _rotationalStiffnessZ;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLinearStiffnessMeasure? @LinearStiffnessX 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _linearStiffnessX;
				((IPersistEntity)this).Activate(false);
				return _linearStiffnessX;
			} 
			set
			{
				SetValue( v =>  _linearStiffnessX = v, _linearStiffnessX, value,  "LinearStiffnessX");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLinearStiffnessMeasure? @LinearStiffnessY 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _linearStiffnessY;
				((IPersistEntity)this).Activate(false);
				return _linearStiffnessY;
			} 
			set
			{
				SetValue( v =>  _linearStiffnessY = v, _linearStiffnessY, value,  "LinearStiffnessY");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLinearStiffnessMeasure? @LinearStiffnessZ 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _linearStiffnessZ;
				((IPersistEntity)this).Activate(false);
				return _linearStiffnessZ;
			} 
			set
			{
				SetValue( v =>  _linearStiffnessZ = v, _linearStiffnessZ, value,  "LinearStiffnessZ");
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcRotationalStiffnessMeasure? @RotationalStiffnessX 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _rotationalStiffnessX;
				((IPersistEntity)this).Activate(false);
				return _rotationalStiffnessX;
			} 
			set
			{
				SetValue( v =>  _rotationalStiffnessX = v, _rotationalStiffnessX, value,  "RotationalStiffnessX");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcRotationalStiffnessMeasure? @RotationalStiffnessY 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _rotationalStiffnessY;
				((IPersistEntity)this).Activate(false);
				return _rotationalStiffnessY;
			} 
			set
			{
				SetValue( v =>  _rotationalStiffnessY = v, _rotationalStiffnessY, value,  "RotationalStiffnessY");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcRotationalStiffnessMeasure? @RotationalStiffnessZ 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _rotationalStiffnessZ;
				((IPersistEntity)this).Activate(false);
				return _rotationalStiffnessZ;
			} 
			set
			{
				SetValue( v =>  _rotationalStiffnessZ = v, _rotationalStiffnessZ, value,  "RotationalStiffnessZ");
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
					_linearStiffnessX = value.RealVal;
					return;
				case 2: 
					_linearStiffnessY = value.RealVal;
					return;
				case 3: 
					_linearStiffnessZ = value.RealVal;
					return;
				case 4: 
					_rotationalStiffnessX = value.RealVal;
					return;
				case 5: 
					_rotationalStiffnessY = value.RealVal;
					return;
				case 6: 
					_rotationalStiffnessZ = value.RealVal;
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
        public bool Equals(@IfcBoundaryNodeCondition other)
	    {
	        return this == other;
	    }


        public static bool operator ==(@IfcBoundaryNodeCondition left, @IfcBoundaryNodeCondition right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcBoundaryNodeCondition left, @IfcBoundaryNodeCondition right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcBoundaryNodeCondition x, @IfcBoundaryNodeCondition y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcBoundaryNodeCondition obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}