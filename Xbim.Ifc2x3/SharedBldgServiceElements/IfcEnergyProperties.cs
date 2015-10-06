// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.Kernel;
using Xbim.Ifc2x3.UtilityResource;
using Xbim.Ifc2x3.MeasureResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.SharedBldgServiceElements
{
	[ExpressType("IFCENERGYPROPERTIES", 176)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcEnergyProperties : IfcPropertySetDefinition, IInstantiableEntity, IEqualityComparer<@IfcEnergyProperties>, IEquatable<@IfcEnergyProperties>
	{
		public static int LoadDepth = 1;

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcEnergyProperties(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcEnergySequenceEnum? _energySequence;
		private IfcLabel? _userDefinedEnergySequence;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcEnergySequenceEnum? @EnergySequence 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _energySequence;
				((IPersistEntity)this).Activate(false);
				return _energySequence;
			} 
			set
			{
				SetValue( v =>  _energySequence = v, _energySequence, value,  "EnergySequence");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel? @UserDefinedEnergySequence 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _userDefinedEnergySequence;
				((IPersistEntity)this).Activate(false);
				return _userDefinedEnergySequence;
			} 
			set
			{
				SetValue( v =>  _userDefinedEnergySequence = v, _userDefinedEnergySequence, value,  "UserDefinedEnergySequence");
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
					base.Parse(propIndex, value); 
					return;
				case 4: 
                    _energySequence = (IfcEnergySequenceEnum) System.Enum.Parse(typeof (IfcEnergySequenceEnum), value.EnumVal, true);
					return;
				case 5: 
					_userDefinedEnergySequence = value.StringVal;
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
        public bool Equals(@IfcEnergyProperties other)
	    {
	        return this == other;
	    }


        public static bool operator ==(@IfcEnergyProperties left, @IfcEnergyProperties right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcEnergyProperties left, @IfcEnergyProperties right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcEnergyProperties x, @IfcEnergyProperties y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcEnergyProperties obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}