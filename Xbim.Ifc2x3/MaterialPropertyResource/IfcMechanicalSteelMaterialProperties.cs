// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MaterialResource;
using Xbim.Ifc2x3.MeasureResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.MaterialPropertyResource
{
	[ExpressType("IFCMECHANICALSTEELMATERIALPROPERTIES", 510)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcMechanicalSteelMaterialProperties : IfcMechanicalMaterialProperties, IInstantiableEntity, IEqualityComparer<@IfcMechanicalSteelMaterialProperties>, IEquatable<@IfcMechanicalSteelMaterialProperties>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcMechanicalSteelMaterialProperties(IModel model) : base(model) 		{ 
			Model = model; 
			_relaxations = new OptionalItemSet<IfcRelaxation>( this, 0 );
		}

		#region Explicit attribute fields
		private IfcPressureMeasure? _yieldStress;
		private IfcPressureMeasure? _ultimateStress;
		private IfcPositiveRatioMeasure? _ultimateStrain;
		private IfcModulusOfElasticityMeasure? _hardeningModule;
		private IfcPressureMeasure? _proportionalStress;
		private IfcPositiveRatioMeasure? _plasticStrain;
		private OptionalItemSet<IfcRelaxation> _relaxations;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPressureMeasure? @YieldStress 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _yieldStress;
				((IPersistEntity)this).Activate(false);
				return _yieldStress;
			} 
			set
			{
				SetValue( v =>  _yieldStress = v, _yieldStress, value,  "YieldStress");
			} 
		}
	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPressureMeasure? @UltimateStress 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _ultimateStress;
				((IPersistEntity)this).Activate(false);
				return _ultimateStress;
			} 
			set
			{
				SetValue( v =>  _ultimateStress = v, _ultimateStress, value,  "UltimateStress");
			} 
		}
	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveRatioMeasure? @UltimateStrain 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _ultimateStrain;
				((IPersistEntity)this).Activate(false);
				return _ultimateStrain;
			} 
			set
			{
				SetValue( v =>  _ultimateStrain = v, _ultimateStrain, value,  "UltimateStrain");
			} 
		}
	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcModulusOfElasticityMeasure? @HardeningModule 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _hardeningModule;
				((IPersistEntity)this).Activate(false);
				return _hardeningModule;
			} 
			set
			{
				SetValue( v =>  _hardeningModule = v, _hardeningModule, value,  "HardeningModule");
			} 
		}
	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPressureMeasure? @ProportionalStress 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _proportionalStress;
				((IPersistEntity)this).Activate(false);
				return _proportionalStress;
			} 
			set
			{
				SetValue( v =>  _proportionalStress = v, _proportionalStress, value,  "ProportionalStress");
			} 
		}
	
		[EntityAttribute(12, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveRatioMeasure? @PlasticStrain 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _plasticStrain;
				((IPersistEntity)this).Activate(false);
				return _plasticStrain;
			} 
			set
			{
				SetValue( v =>  _plasticStrain = v, _plasticStrain, value,  "PlasticStrain");
			} 
		}
	
		[EntityAttribute(13, EntityAttributeState.Optional, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1)]
		public OptionalItemSet<IfcRelaxation> @Relaxations 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _relaxations;
				((IPersistEntity)this).Activate(false);
				return _relaxations;
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
					base.Parse(propIndex, value); 
					return;
				case 6: 
					_yieldStress = value.RealVal;
					return;
				case 7: 
					_ultimateStress = value.RealVal;
					return;
				case 8: 
					_ultimateStrain = value.RealVal;
					return;
				case 9: 
					_hardeningModule = value.RealVal;
					return;
				case 10: 
					_proportionalStress = value.RealVal;
					return;
				case 11: 
					_plasticStrain = value.RealVal;
					return;
				case 12: 
					if (_relaxations == null) _relaxations = new OptionalItemSet<IfcRelaxation>( this );
					_relaxations.InternalAdd((IfcRelaxation)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR31:	WR31 : NOT(EXISTS(YieldStress)) OR (YieldStress >= 0.);*/
		/*WR32:	WR32 : NOT(EXISTS(UltimateStress)) OR (UltimateStress >= 0.);*/
		/*WR33:	WR33 : NOT(EXISTS(HardeningModule)) OR (HardeningModule >= 0.);*/
		/*WR34:	WR34 : NOT(EXISTS(ProportionalStress)) OR (ProportionalStress >= 0.);*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcMechanicalSteelMaterialProperties other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcMechanicalSteelMaterialProperties
            var root = (@IfcMechanicalSteelMaterialProperties)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcMechanicalSteelMaterialProperties left, @IfcMechanicalSteelMaterialProperties right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcMechanicalSteelMaterialProperties left, @IfcMechanicalSteelMaterialProperties right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcMechanicalSteelMaterialProperties x, @IfcMechanicalSteelMaterialProperties y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcMechanicalSteelMaterialProperties obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}