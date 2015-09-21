// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		21.09.2015 05:11:14
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
	[IndexedClass]
	[ExpressType("IFCTHERMALMATERIALPROPERTIES", 720)]
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
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
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
	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
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
	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
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
	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
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