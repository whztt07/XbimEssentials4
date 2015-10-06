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
	[ExpressType("IFCMECHANICALCONCRETEMATERIALPROPERTIES", 693)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcMechanicalConcreteMaterialProperties : IfcMechanicalMaterialProperties, IInstantiableEntity, IEqualityComparer<@IfcMechanicalConcreteMaterialProperties>, IEquatable<@IfcMechanicalConcreteMaterialProperties>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcMechanicalConcreteMaterialProperties(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcPressureMeasure? _compressiveStrength;
		private IfcPositiveLengthMeasure? _maxAggregateSize;
		private IfcText? _admixturesDescription;
		private IfcText? _workability;
		private IfcNormalisedRatioMeasure? _protectivePoreRatio;
		private IfcText? _waterImpermeability;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPressureMeasure? @CompressiveStrength 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _compressiveStrength;
				((IPersistEntity)this).Activate(false);
				return _compressiveStrength;
			} 
			set
			{
				SetValue( v =>  _compressiveStrength = v, _compressiveStrength, value,  "CompressiveStrength");
			} 
		}
	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure? @MaxAggregateSize 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _maxAggregateSize;
				((IPersistEntity)this).Activate(false);
				return _maxAggregateSize;
			} 
			set
			{
				SetValue( v =>  _maxAggregateSize = v, _maxAggregateSize, value,  "MaxAggregateSize");
			} 
		}
	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcText? @AdmixturesDescription 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _admixturesDescription;
				((IPersistEntity)this).Activate(false);
				return _admixturesDescription;
			} 
			set
			{
				SetValue( v =>  _admixturesDescription = v, _admixturesDescription, value,  "AdmixturesDescription");
			} 
		}
	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcText? @Workability 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _workability;
				((IPersistEntity)this).Activate(false);
				return _workability;
			} 
			set
			{
				SetValue( v =>  _workability = v, _workability, value,  "Workability");
			} 
		}
	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcNormalisedRatioMeasure? @ProtectivePoreRatio 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _protectivePoreRatio;
				((IPersistEntity)this).Activate(false);
				return _protectivePoreRatio;
			} 
			set
			{
				SetValue( v =>  _protectivePoreRatio = v, _protectivePoreRatio, value,  "ProtectivePoreRatio");
			} 
		}
	
		[EntityAttribute(12, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcText? @WaterImpermeability 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _waterImpermeability;
				((IPersistEntity)this).Activate(false);
				return _waterImpermeability;
			} 
			set
			{
				SetValue( v =>  _waterImpermeability = v, _waterImpermeability, value,  "WaterImpermeability");
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
					_compressiveStrength = value.RealVal;
					return;
				case 7: 
					_maxAggregateSize = value.RealVal;
					return;
				case 8: 
					_admixturesDescription = value.StringVal;
					return;
				case 9: 
					_workability = value.StringVal;
					return;
				case 10: 
					_protectivePoreRatio = value.RealVal;
					return;
				case 11: 
					_waterImpermeability = value.StringVal;
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
        public bool Equals(@IfcMechanicalConcreteMaterialProperties other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcMechanicalConcreteMaterialProperties
            var root = (@IfcMechanicalConcreteMaterialProperties)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcMechanicalConcreteMaterialProperties left, @IfcMechanicalConcreteMaterialProperties right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcMechanicalConcreteMaterialProperties left, @IfcMechanicalConcreteMaterialProperties right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcMechanicalConcreteMaterialProperties x, @IfcMechanicalConcreteMaterialProperties y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcMechanicalConcreteMaterialProperties obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}