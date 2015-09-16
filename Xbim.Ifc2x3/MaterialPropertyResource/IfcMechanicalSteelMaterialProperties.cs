// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		16.09.2015 10:12:19
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MaterialResource;
using Xbim.Ifc2x3.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.MaterialPropertyResource
{
	[EntityName("IFCMECHANICALSTEELMATERIALPROPERTIES", 510)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcMechanicalSteelMaterialProperties : IfcMechanicalMaterialProperties, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcMechanicalSteelMaterialProperties(IModel model) : base(model) 		{ 
			Model = model; 
			_relaxations = new ItemSet<IfcRelaxation>( model );
		}

		#region Explicit attribute fields
		private IfcPressureMeasure? _yieldStress;
		private IfcPressureMeasure? _ultimateStress;
		private IfcPositiveRatioMeasure? _ultimateStrain;
		private IfcModulusOfElasticityMeasure? _hardeningModule;
		private IfcPressureMeasure? _proportionalStress;
		private IfcPositiveRatioMeasure? _plasticStrain;
		private ItemSet<IfcRelaxation> _relaxations;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(6, EntityAttributeState.Optional)]
		public IfcPressureMeasure? @YieldStress 
		{ 
			get 
			{
				if(Activated) return _yieldStress;
				
				Model.Activate(this, true);
				Activated = true;
				return _yieldStress;
			} 
			set
			{
				SetValue( v =>  _yieldStress = v, _yieldStress, value,  "YieldStress");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Optional)]
		public IfcPressureMeasure? @UltimateStress 
		{ 
			get 
			{
				if(Activated) return _ultimateStress;
				
				Model.Activate(this, true);
				Activated = true;
				return _ultimateStress;
			} 
			set
			{
				SetValue( v =>  _ultimateStress = v, _ultimateStress, value,  "UltimateStress");
			} 
		}
	
		[EntityAttribute(8, EntityAttributeState.Optional)]
		public IfcPositiveRatioMeasure? @UltimateStrain 
		{ 
			get 
			{
				if(Activated) return _ultimateStrain;
				
				Model.Activate(this, true);
				Activated = true;
				return _ultimateStrain;
			} 
			set
			{
				SetValue( v =>  _ultimateStrain = v, _ultimateStrain, value,  "UltimateStrain");
			} 
		}
	
		[EntityAttribute(9, EntityAttributeState.Optional)]
		public IfcModulusOfElasticityMeasure? @HardeningModule 
		{ 
			get 
			{
				if(Activated) return _hardeningModule;
				
				Model.Activate(this, true);
				Activated = true;
				return _hardeningModule;
			} 
			set
			{
				SetValue( v =>  _hardeningModule = v, _hardeningModule, value,  "HardeningModule");
			} 
		}
	
		[EntityAttribute(10, EntityAttributeState.Optional)]
		public IfcPressureMeasure? @ProportionalStress 
		{ 
			get 
			{
				if(Activated) return _proportionalStress;
				
				Model.Activate(this, true);
				Activated = true;
				return _proportionalStress;
			} 
			set
			{
				SetValue( v =>  _proportionalStress = v, _proportionalStress, value,  "ProportionalStress");
			} 
		}
	
		[EntityAttribute(11, EntityAttributeState.Optional)]
		public IfcPositiveRatioMeasure? @PlasticStrain 
		{ 
			get 
			{
				if(Activated) return _plasticStrain;
				
				Model.Activate(this, true);
				Activated = true;
				return _plasticStrain;
			} 
			set
			{
				SetValue( v =>  _plasticStrain = v, _plasticStrain, value,  "PlasticStrain");
			} 
		}
	
		[EntityAttribute(12, EntityAttributeState.Optional)]
		public ItemSet<IfcRelaxation> @Relaxations 
		{ 
			get 
			{
				if(Activated) return _relaxations;
				
				Model.Activate(this, true);
				Activated = true;
				return _relaxations;
			} 
			set
			{
				SetValue( v =>  _relaxations = v, _relaxations, value,  "Relaxations");
			} 
		}
	
		#endregion

		#region Inverse attributes

		#endregion

		#region Index access
		private static readonly List<string> AttributeNames = new List<string>
		{
			"Material",
			"DynamicViscosity",
			"YoungModulus",
			"ShearModulus",
			"PoissonRatio",
			"ThermalExpansionCoefficient",
			"YieldStress",
			"UltimateStress",
			"UltimateStrain",
			"HardeningModule",
			"ProportionalStress",
			"PlasticStrain",
			"Relaxations",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return AttributeNames; } }

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
					return @YieldStress;
				case 7: 
					return @UltimateStress;
				case 8: 
					return @UltimateStrain;
				case 9: 
					return @HardeningModule;
				case 10: 
					return @ProportionalStress;
				case 11: 
					return @PlasticStrain;
				case 12: 
					return @Relaxations;
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
				case "YieldStress":  
					return @YieldStress;
				case "UltimateStress":  
					return @UltimateStress;
				case "UltimateStrain":  
					return @UltimateStrain;
				case "HardeningModule":  
					return @HardeningModule;
				case "ProportionalStress":  
					return @ProportionalStress;
				case "PlasticStrain":  
					return @PlasticStrain;
				case "Relaxations":  
					return @Relaxations;
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
					 @YieldStress = (IfcPressureMeasure?)value;
					 break;
				case 7:
					 @UltimateStress = (IfcPressureMeasure?)value;
					 break;
				case 8:
					 @UltimateStrain = (IfcPositiveRatioMeasure?)value;
					 break;
				case 9:
					 @HardeningModule = (IfcModulusOfElasticityMeasure?)value;
					 break;
				case 10:
					 @ProportionalStress = (IfcPressureMeasure?)value;
					 break;
				case 11:
					 @PlasticStrain = (IfcPositiveRatioMeasure?)value;
					 break;
				case 12:
					 @Relaxations.Add((IfcRelaxation)value);
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
				case "YieldStress":
					 @YieldStress = (IfcPressureMeasure?)value;
					 break;
				case "UltimateStress":
					 @UltimateStress = (IfcPressureMeasure?)value;
					 break;
				case "UltimateStrain":
					 @UltimateStrain = (IfcPositiveRatioMeasure?)value;
					 break;
				case "HardeningModule":
					 @HardeningModule = (IfcModulusOfElasticityMeasure?)value;
					 break;
				case "ProportionalStress":
					 @ProportionalStress = (IfcPressureMeasure?)value;
					 break;
				case "PlasticStrain":
					 @PlasticStrain = (IfcPositiveRatioMeasure?)value;
					 break;
				case "Relaxations":
					 @Relaxations.Add((IfcRelaxation)value);
					 break;
				default:
					throw new System.IndexOutOfRangeException();
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
					if (_relaxations == null) _relaxations = new ItemSet<IfcRelaxation>( Model );
					_relaxations.Add((IfcRelaxation)value.EntityVal);
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

		
	}
}