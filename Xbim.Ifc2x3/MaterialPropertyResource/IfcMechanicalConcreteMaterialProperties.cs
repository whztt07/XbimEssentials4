// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		09/09/2015 04:20:35
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MaterialResource;
using Xbim.Ifc2x3.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc2x3.MaterialPropertyResource
{
	[EntityName("IFCMECHANICALCONCRETEMATERIALPROPERTIES", 693)]
	public  partial class @IfcMechanicalConcreteMaterialProperties : IfcMechanicalMaterialProperties, IInstantiableEntity
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
		[EntityAttribute(6, EntityAttributeState.Optional)]
		public IfcPressureMeasure? @CompressiveStrength 
		{ 
			get 
			{
				if(Activated) return _compressiveStrength;
				
				Model.Activate(this, true);
				Activated = true;
				return _compressiveStrength;
			} 
			set
			{
				SetValue( v =>  _compressiveStrength = v, _compressiveStrength, value,  "CompressiveStrength");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Optional)]
		public IfcPositiveLengthMeasure? @MaxAggregateSize 
		{ 
			get 
			{
				if(Activated) return _maxAggregateSize;
				
				Model.Activate(this, true);
				Activated = true;
				return _maxAggregateSize;
			} 
			set
			{
				SetValue( v =>  _maxAggregateSize = v, _maxAggregateSize, value,  "MaxAggregateSize");
			} 
		}
	
		[EntityAttribute(8, EntityAttributeState.Optional)]
		public IfcText? @AdmixturesDescription 
		{ 
			get 
			{
				if(Activated) return _admixturesDescription;
				
				Model.Activate(this, true);
				Activated = true;
				return _admixturesDescription;
			} 
			set
			{
				SetValue( v =>  _admixturesDescription = v, _admixturesDescription, value,  "AdmixturesDescription");
			} 
		}
	
		[EntityAttribute(9, EntityAttributeState.Optional)]
		public IfcText? @Workability 
		{ 
			get 
			{
				if(Activated) return _workability;
				
				Model.Activate(this, true);
				Activated = true;
				return _workability;
			} 
			set
			{
				SetValue( v =>  _workability = v, _workability, value,  "Workability");
			} 
		}
	
		[EntityAttribute(10, EntityAttributeState.Optional)]
		public IfcNormalisedRatioMeasure? @ProtectivePoreRatio 
		{ 
			get 
			{
				if(Activated) return _protectivePoreRatio;
				
				Model.Activate(this, true);
				Activated = true;
				return _protectivePoreRatio;
			} 
			set
			{
				SetValue( v =>  _protectivePoreRatio = v, _protectivePoreRatio, value,  "ProtectivePoreRatio");
			} 
		}
	
		[EntityAttribute(11, EntityAttributeState.Optional)]
		public IfcText? @WaterImpermeability 
		{ 
			get 
			{
				if(Activated) return _waterImpermeability;
				
				Model.Activate(this, true);
				Activated = true;
				return _waterImpermeability;
			} 
			set
			{
				SetValue( v =>  _waterImpermeability = v, _waterImpermeability, value,  "WaterImpermeability");
			} 
		}
	
		#endregion

		#region Inverse attributes

		#endregion

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"Material",
			"DynamicViscosity",
			"YoungModulus",
			"ShearModulus",
			"PoissonRatio",
			"ThermalExpansionCoefficient",
			"CompressiveStrength",
			"MaxAggregateSize",
			"AdmixturesDescription",
			"Workability",
			"ProtectivePoreRatio",
			"WaterImpermeability",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @Material;
				case 1: 
					return @DynamicViscosity;
				case 2: 
					return @YoungModulus;
				case 3: 
					return @ShearModulus;
				case 4: 
					return @PoissonRatio;
				case 5: 
					return @ThermalExpansionCoefficient;
				case 6: 
					return @CompressiveStrength;
				case 7: 
					return @MaxAggregateSize;
				case 8: 
					return @AdmixturesDescription;
				case 9: 
					return @Workability;
				case 10: 
					return @ProtectivePoreRatio;
				case 11: 
					return @WaterImpermeability;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "Material":  
					return @Material;
				case "DynamicViscosity":  
					return @DynamicViscosity;
				case "YoungModulus":  
					return @YoungModulus;
				case "ShearModulus":  
					return @ShearModulus;
				case "PoissonRatio":  
					return @PoissonRatio;
				case "ThermalExpansionCoefficient":  
					return @ThermalExpansionCoefficient;
				case "CompressiveStrength":  
					return @CompressiveStrength;
				case "MaxAggregateSize":  
					return @MaxAggregateSize;
				case "AdmixturesDescription":  
					return @AdmixturesDescription;
				case "Workability":  
					return @Workability;
				case "ProtectivePoreRatio":  
					return @ProtectivePoreRatio;
				case "WaterImpermeability":  
					return @WaterImpermeability;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 @Material = (IfcMaterial)value;
					 break;
				case 1:
					 @DynamicViscosity = (IfcDynamicViscosityMeasure?)value;
					 break;
				case 2:
					 @YoungModulus = (IfcModulusOfElasticityMeasure?)value;
					 break;
				case 3:
					 @ShearModulus = (IfcModulusOfElasticityMeasure?)value;
					 break;
				case 4:
					 @PoissonRatio = (IfcPositiveRatioMeasure?)value;
					 break;
				case 5:
					 @ThermalExpansionCoefficient = (IfcThermalExpansionCoefficientMeasure?)value;
					 break;
				case 6:
					 @CompressiveStrength = (IfcPressureMeasure?)value;
					 break;
				case 7:
					 @MaxAggregateSize = (IfcPositiveLengthMeasure?)value;
					 break;
				case 8:
					 @AdmixturesDescription = (IfcText?)value;
					 break;
				case 9:
					 @Workability = (IfcText?)value;
					 break;
				case 10:
					 @ProtectivePoreRatio = (IfcNormalisedRatioMeasure?)value;
					 break;
				case 11:
					 @WaterImpermeability = (IfcText?)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "Material":
					 @Material = (IfcMaterial)value;
					 break;
				case "DynamicViscosity":
					 @DynamicViscosity = (IfcDynamicViscosityMeasure?)value;
					 break;
				case "YoungModulus":
					 @YoungModulus = (IfcModulusOfElasticityMeasure?)value;
					 break;
				case "ShearModulus":
					 @ShearModulus = (IfcModulusOfElasticityMeasure?)value;
					 break;
				case "PoissonRatio":
					 @PoissonRatio = (IfcPositiveRatioMeasure?)value;
					 break;
				case "ThermalExpansionCoefficient":
					 @ThermalExpansionCoefficient = (IfcThermalExpansionCoefficientMeasure?)value;
					 break;
				case "CompressiveStrength":
					 @CompressiveStrength = (IfcPressureMeasure?)value;
					 break;
				case "MaxAggregateSize":
					 @MaxAggregateSize = (IfcPositiveLengthMeasure?)value;
					 break;
				case "AdmixturesDescription":
					 @AdmixturesDescription = (IfcText?)value;
					 break;
				case "Workability":
					 @Workability = (IfcText?)value;
					 break;
				case "ProtectivePoreRatio":
					 @ProtectivePoreRatio = (IfcNormalisedRatioMeasure?)value;
					 break;
				case "WaterImpermeability":
					 @WaterImpermeability = (IfcText?)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion


		#region IPersist implementation
		void IPersist.Set(int propIndex, IPropertyValue value)
		{
            throw new System.NotImplementedException();
		}
		#endregion

		public  override string WhereRule() 
		{
			return "";
		}
	}
}