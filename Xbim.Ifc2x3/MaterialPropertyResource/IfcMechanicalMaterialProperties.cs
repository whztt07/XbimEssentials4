// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 09:16:38
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
	[EntityName("IFCMECHANICALMATERIALPROPERTIES")]
	public  partial class @IfcMechanicalMaterialProperties : IfcMaterialProperties, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcMechanicalMaterialProperties(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcDynamicViscosityMeasure? _dynamicViscosity;
		private IfcModulusOfElasticityMeasure? _youngModulus;
		private IfcModulusOfElasticityMeasure? _shearModulus;
		private IfcPositiveRatioMeasure? _poissonRatio;
		private IfcThermalExpansionCoefficientMeasure? _thermalExpansionCoefficient;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Optional)]
		public IfcDynamicViscosityMeasure? @DynamicViscosity 
		{ 
			get 
			{
				if(IsActivated) return _dynamicViscosity;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _dynamicViscosity;
			} 
			set
			{
				SetValue( v =>  _dynamicViscosity = v, _dynamicViscosity, value,  "DynamicViscosity");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Optional)]
		public IfcModulusOfElasticityMeasure? @YoungModulus 
		{ 
			get 
			{
				if(IsActivated) return _youngModulus;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _youngModulus;
			} 
			set
			{
				SetValue( v =>  _youngModulus = v, _youngModulus, value,  "YoungModulus");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Optional)]
		public IfcModulusOfElasticityMeasure? @ShearModulus 
		{ 
			get 
			{
				if(IsActivated) return _shearModulus;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _shearModulus;
			} 
			set
			{
				SetValue( v =>  _shearModulus = v, _shearModulus, value,  "ShearModulus");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Optional)]
		public IfcPositiveRatioMeasure? @PoissonRatio 
		{ 
			get 
			{
				if(IsActivated) return _poissonRatio;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _poissonRatio;
			} 
			set
			{
				SetValue( v =>  _poissonRatio = v, _poissonRatio, value,  "PoissonRatio");
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Optional)]
		public IfcThermalExpansionCoefficientMeasure? @ThermalExpansionCoefficient 
		{ 
			get 
			{
				if(IsActivated) return _thermalExpansionCoefficient;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _thermalExpansionCoefficient;
			} 
			set
			{
				SetValue( v =>  _thermalExpansionCoefficient = v, _thermalExpansionCoefficient, value,  "ThermalExpansionCoefficient");
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
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion

		#region Where rules
		/*WR21:	WR21 : NOT(EXISTS(YoungModulus)) OR (YoungModulus >= 0.0);*/
		/*WR22:	WR22 : NOT(EXISTS(ShearModulus)) OR (ShearModulus >= 0.0);*/
		#endregion

		#region IPersist implementation
		public void Set(int propIndex, IPropertyValue value)
		{
            throw new System.NotImplementedException();
		}
		#endregion

	}
}