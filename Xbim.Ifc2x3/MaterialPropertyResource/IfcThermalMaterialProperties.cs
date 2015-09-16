// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		16.09.2015 04:23:01
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
	[EntityName("IFCTHERMALMATERIALPROPERTIES", 720)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcThermalMaterialProperties : IfcMaterialProperties, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcThermalMaterialProperties(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcSpecificHeatCapacityMeasure? _specificHeatCapacity;
		private IfcThermodynamicTemperatureMeasure? _boilingPoint;
		private IfcThermodynamicTemperatureMeasure? _freezingPoint;
		private IfcThermalConductivityMeasure? _thermalConductivity;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Optional)]
		public IfcSpecificHeatCapacityMeasure? @SpecificHeatCapacity 
		{ 
			get 
			{
				if(Activated) return _specificHeatCapacity;
				
				Model.Activate(this, true);
				Activated = true;
				return _specificHeatCapacity;
			} 
			set
			{
				SetValue( v =>  _specificHeatCapacity = v, _specificHeatCapacity, value,  "SpecificHeatCapacity");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Optional)]
		public IfcThermodynamicTemperatureMeasure? @BoilingPoint 
		{ 
			get 
			{
				if(Activated) return _boilingPoint;
				
				Model.Activate(this, true);
				Activated = true;
				return _boilingPoint;
			} 
			set
			{
				SetValue( v =>  _boilingPoint = v, _boilingPoint, value,  "BoilingPoint");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Optional)]
		public IfcThermodynamicTemperatureMeasure? @FreezingPoint 
		{ 
			get 
			{
				if(Activated) return _freezingPoint;
				
				Model.Activate(this, true);
				Activated = true;
				return _freezingPoint;
			} 
			set
			{
				SetValue( v =>  _freezingPoint = v, _freezingPoint, value,  "FreezingPoint");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Optional)]
		public IfcThermalConductivityMeasure? @ThermalConductivity 
		{ 
			get 
			{
				if(Activated) return _thermalConductivity;
				
				Model.Activate(this, true);
				Activated = true;
				return _thermalConductivity;
			} 
			set
			{
				SetValue( v =>  _thermalConductivity = v, _thermalConductivity, value,  "ThermalConductivity");
			} 
		}
	
		#endregion

		#region Inverse attributes

		#endregion

		#region Index access
		private static readonly List<string> AttributeNames = new List<string>
		{
			"Material",
			"SpecificHeatCapacity",
			"BoilingPoint",
			"FreezingPoint",
			"ThermalConductivity",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return AttributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @Material;
				case 1: 
					return @SpecificHeatCapacity;
				case 2: 
					return @BoilingPoint;
				case 3: 
					return @FreezingPoint;
				case 4: 
					return @ThermalConductivity;
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
				case "SpecificHeatCapacity":  
					return @SpecificHeatCapacity;
				case "BoilingPoint":  
					return @BoilingPoint;
				case "FreezingPoint":  
					return @FreezingPoint;
				case "ThermalConductivity":  
					return @ThermalConductivity;
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
					 @SpecificHeatCapacity = (IfcSpecificHeatCapacityMeasure?)value;
					 break;
				case 2:
					 @BoilingPoint = (IfcThermodynamicTemperatureMeasure?)value;
					 break;
				case 3:
					 @FreezingPoint = (IfcThermodynamicTemperatureMeasure?)value;
					 break;
				case 4:
					 @ThermalConductivity = (IfcThermalConductivityMeasure?)value;
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
				case "SpecificHeatCapacity":
					 @SpecificHeatCapacity = (IfcSpecificHeatCapacityMeasure?)value;
					 break;
				case "BoilingPoint":
					 @BoilingPoint = (IfcThermodynamicTemperatureMeasure?)value;
					 break;
				case "FreezingPoint":
					 @FreezingPoint = (IfcThermodynamicTemperatureMeasure?)value;
					 break;
				case "ThermalConductivity":
					 @ThermalConductivity = (IfcThermalConductivityMeasure?)value;
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
					base.Parse(propIndex, value); 
					return;
				case 1: 
					_specificHeatCapacity = value.RealVal;
					return;
				case 2: 
					_boilingPoint = value.RealVal;
					return;
				case 3: 
					_freezingPoint = value.RealVal;
					return;
				case 4: 
					_thermalConductivity = value.RealVal;
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

		
	}
}