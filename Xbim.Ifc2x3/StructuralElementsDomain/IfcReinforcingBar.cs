// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.UtilityResource;
using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.GeometricConstraintResource;
using Xbim.Ifc2x3.RepresentationResource;
using Xbim.Ifc2x3.ProfilePropertyResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.StructuralElementsDomain
{
	[ExpressType("IFCREINFORCINGBAR", 571)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcReinforcingBar : IfcReinforcingElement, IInstantiableEntity, IEqualityComparer<@IfcReinforcingBar>, IEquatable<@IfcReinforcingBar>
	{
		public static int LoadDepth = 1;

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcReinforcingBar(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcPositiveLengthMeasure _nominalDiameter;
		private IfcAreaMeasure _crossSectionArea;
		private IfcPositiveLengthMeasure? _barLength;
		private IfcReinforcingBarRoleEnum _barRole;
		private IfcReinforcingBarSurfaceEnum? _barSurface;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(10, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure @NominalDiameter 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _nominalDiameter;
				((IPersistEntity)this).Activate(false);
				return _nominalDiameter;
			} 
			set
			{
				SetValue( v =>  _nominalDiameter = v, _nominalDiameter, value,  "NominalDiameter");
			} 
		}
	
		[EntityAttribute(11, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcAreaMeasure @CrossSectionArea 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _crossSectionArea;
				((IPersistEntity)this).Activate(false);
				return _crossSectionArea;
			} 
			set
			{
				SetValue( v =>  _crossSectionArea = v, _crossSectionArea, value,  "CrossSectionArea");
			} 
		}
	
		[EntityAttribute(12, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure? @BarLength 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _barLength;
				((IPersistEntity)this).Activate(false);
				return _barLength;
			} 
			set
			{
				SetValue( v =>  _barLength = v, _barLength, value,  "BarLength");
			} 
		}
	
		[EntityAttribute(13, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcReinforcingBarRoleEnum @BarRole 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _barRole;
				((IPersistEntity)this).Activate(false);
				return _barRole;
			} 
			set
			{
				SetValue( v =>  _barRole = v, _barRole, value,  "BarRole");
			} 
		}
	
		[EntityAttribute(14, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcReinforcingBarSurfaceEnum? @BarSurface 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _barSurface;
				((IPersistEntity)this).Activate(false);
				return _barSurface;
			} 
			set
			{
				SetValue( v =>  _barSurface = v, _barSurface, value,  "BarSurface");
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
				case 2: 
				case 3: 
				case 4: 
				case 5: 
				case 6: 
				case 7: 
				case 8: 
					base.Parse(propIndex, value); 
					return;
				case 9: 
					_nominalDiameter = value.RealVal;
					return;
				case 10: 
					_crossSectionArea = value.RealVal;
					return;
				case 11: 
					_barLength = value.RealVal;
					return;
				case 12: 
                    _barRole = (IfcReinforcingBarRoleEnum) System.Enum.Parse(typeof (IfcReinforcingBarRoleEnum), value.EnumVal, true);
					return;
				case 13: 
                    _barSurface = (IfcReinforcingBarSurfaceEnum) System.Enum.Parse(typeof (IfcReinforcingBarSurfaceEnum), value.EnumVal, true);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR1:	WR1 : (BarRole <> IfcReinforcingBarRoleEnum.USERDEFINED) OR ((BarRole = IfcReinforcingBarRoleEnum.USERDEFINED) AND EXISTS(SELF\IfcObject.ObjectType));*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcReinforcingBar other)
	    {
	        return this == other;
	    }


        public static bool operator ==(@IfcReinforcingBar left, @IfcReinforcingBar right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcReinforcingBar left, @IfcReinforcingBar right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcReinforcingBar x, @IfcReinforcingBar y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcReinforcingBar obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}