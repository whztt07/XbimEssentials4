// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		24.09.2015 10:03:33
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.Kernel;
using Xbim.Ifc2x3.UtilityResource;
using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.TimeSeriesResource;
using Xbim.Ifc2x3.MaterialResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.SharedBldgServiceElements
{
	[IndexedClass]
	[ExpressType("IFCFLUIDFLOWPROPERTIES", 466)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcFluidFlowProperties : IfcPropertySetDefinition, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcFluidFlowProperties(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcPropertySourceEnum _propertySource;
		private IfcTimeSeries _flowConditionTimeSeries;
		private IfcTimeSeries _velocityTimeSeries;
		private IfcTimeSeries _flowrateTimeSeries;
		private IfcMaterial _fluid;
		private IfcTimeSeries _pressureTimeSeries;
		private IfcLabel? _userDefinedPropertySource;
		private IfcThermodynamicTemperatureMeasure? _temperatureSingleValue;
		private IfcThermodynamicTemperatureMeasure? _wetBulbTemperatureSingleValue;
		private IfcTimeSeries _wetBulbTemperatureTimeSeries;
		private IfcTimeSeries _temperatureTimeSeries;
		private IfcDerivedMeasureValue _flowrateSingleValue;
		private IfcPositiveRatioMeasure? _flowConditionSingleValue;
		private IfcLinearVelocityMeasure? _velocitySingleValue;
		private IfcPressureMeasure? _pressureSingleValue;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcPropertySourceEnum @PropertySource 
		{ 
			get 
			{
				if(Activated) return _propertySource;
				
				Model.Activate(this, true);
				Activated = true;
				return _propertySource;
			} 
			set
			{
				SetValue( v =>  _propertySource = v, _propertySource, value,  "PropertySource");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcTimeSeries @FlowConditionTimeSeries 
		{ 
			get 
			{
				if(Activated) return _flowConditionTimeSeries;
				
				Model.Activate(this, true);
				Activated = true;
				return _flowConditionTimeSeries;
			} 
			set
			{
				SetValue( v =>  _flowConditionTimeSeries = v, _flowConditionTimeSeries, value,  "FlowConditionTimeSeries");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcTimeSeries @VelocityTimeSeries 
		{ 
			get 
			{
				if(Activated) return _velocityTimeSeries;
				
				Model.Activate(this, true);
				Activated = true;
				return _velocityTimeSeries;
			} 
			set
			{
				SetValue( v =>  _velocityTimeSeries = v, _velocityTimeSeries, value,  "VelocityTimeSeries");
			} 
		}
	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcTimeSeries @FlowrateTimeSeries 
		{ 
			get 
			{
				if(Activated) return _flowrateTimeSeries;
				
				Model.Activate(this, true);
				Activated = true;
				return _flowrateTimeSeries;
			} 
			set
			{
				SetValue( v =>  _flowrateTimeSeries = v, _flowrateTimeSeries, value,  "FlowrateTimeSeries");
			} 
		}
	
		[EntityAttribute(9, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcMaterial @Fluid 
		{ 
			get 
			{
				if(Activated) return _fluid;
				
				Model.Activate(this, true);
				Activated = true;
				return _fluid;
			} 
			set
			{
				SetValue( v =>  _fluid = v, _fluid, value,  "Fluid");
			} 
		}
	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcTimeSeries @PressureTimeSeries 
		{ 
			get 
			{
				if(Activated) return _pressureTimeSeries;
				
				Model.Activate(this, true);
				Activated = true;
				return _pressureTimeSeries;
			} 
			set
			{
				SetValue( v =>  _pressureTimeSeries = v, _pressureTimeSeries, value,  "PressureTimeSeries");
			} 
		}
	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel? @UserDefinedPropertySource 
		{ 
			get 
			{
				if(Activated) return _userDefinedPropertySource;
				
				Model.Activate(this, true);
				Activated = true;
				return _userDefinedPropertySource;
			} 
			set
			{
				SetValue( v =>  _userDefinedPropertySource = v, _userDefinedPropertySource, value,  "UserDefinedPropertySource");
			} 
		}
	
		[EntityAttribute(12, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcThermodynamicTemperatureMeasure? @TemperatureSingleValue 
		{ 
			get 
			{
				if(Activated) return _temperatureSingleValue;
				
				Model.Activate(this, true);
				Activated = true;
				return _temperatureSingleValue;
			} 
			set
			{
				SetValue( v =>  _temperatureSingleValue = v, _temperatureSingleValue, value,  "TemperatureSingleValue");
			} 
		}
	
		[EntityAttribute(13, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcThermodynamicTemperatureMeasure? @WetBulbTemperatureSingleValue 
		{ 
			get 
			{
				if(Activated) return _wetBulbTemperatureSingleValue;
				
				Model.Activate(this, true);
				Activated = true;
				return _wetBulbTemperatureSingleValue;
			} 
			set
			{
				SetValue( v =>  _wetBulbTemperatureSingleValue = v, _wetBulbTemperatureSingleValue, value,  "WetBulbTemperatureSingleValue");
			} 
		}
	
		[EntityAttribute(14, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcTimeSeries @WetBulbTemperatureTimeSeries 
		{ 
			get 
			{
				if(Activated) return _wetBulbTemperatureTimeSeries;
				
				Model.Activate(this, true);
				Activated = true;
				return _wetBulbTemperatureTimeSeries;
			} 
			set
			{
				SetValue( v =>  _wetBulbTemperatureTimeSeries = v, _wetBulbTemperatureTimeSeries, value,  "WetBulbTemperatureTimeSeries");
			} 
		}
	
		[EntityAttribute(15, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcTimeSeries @TemperatureTimeSeries 
		{ 
			get 
			{
				if(Activated) return _temperatureTimeSeries;
				
				Model.Activate(this, true);
				Activated = true;
				return _temperatureTimeSeries;
			} 
			set
			{
				SetValue( v =>  _temperatureTimeSeries = v, _temperatureTimeSeries, value,  "TemperatureTimeSeries");
			} 
		}
	
		[EntityAttribute(16, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcDerivedMeasureValue @FlowrateSingleValue 
		{ 
			get 
			{
				if(Activated) return _flowrateSingleValue;
				
				Model.Activate(this, true);
				Activated = true;
				return _flowrateSingleValue;
			} 
			set
			{
				SetValue( v =>  _flowrateSingleValue = v, _flowrateSingleValue, value,  "FlowrateSingleValue");
			} 
		}
	
		[EntityAttribute(17, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveRatioMeasure? @FlowConditionSingleValue 
		{ 
			get 
			{
				if(Activated) return _flowConditionSingleValue;
				
				Model.Activate(this, true);
				Activated = true;
				return _flowConditionSingleValue;
			} 
			set
			{
				SetValue( v =>  _flowConditionSingleValue = v, _flowConditionSingleValue, value,  "FlowConditionSingleValue");
			} 
		}
	
		[EntityAttribute(18, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLinearVelocityMeasure? @VelocitySingleValue 
		{ 
			get 
			{
				if(Activated) return _velocitySingleValue;
				
				Model.Activate(this, true);
				Activated = true;
				return _velocitySingleValue;
			} 
			set
			{
				SetValue( v =>  _velocitySingleValue = v, _velocitySingleValue, value,  "VelocitySingleValue");
			} 
		}
	
		[EntityAttribute(19, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPressureMeasure? @PressureSingleValue 
		{ 
			get 
			{
				if(Activated) return _pressureSingleValue;
				
				Model.Activate(this, true);
				Activated = true;
				return _pressureSingleValue;
			} 
			set
			{
				SetValue( v =>  _pressureSingleValue = v, _pressureSingleValue, value,  "PressureSingleValue");
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
                    _propertySource = (IfcPropertySourceEnum) System.Enum.Parse(typeof (IfcPropertySourceEnum), value.EnumVal, true);
					return;
				case 5: 
					_flowConditionTimeSeries = (IfcTimeSeries)(value.EntityVal);
					return;
				case 6: 
					_velocityTimeSeries = (IfcTimeSeries)(value.EntityVal);
					return;
				case 7: 
					_flowrateTimeSeries = (IfcTimeSeries)(value.EntityVal);
					return;
				case 8: 
					_fluid = (IfcMaterial)(value.EntityVal);
					return;
				case 9: 
					_pressureTimeSeries = (IfcTimeSeries)(value.EntityVal);
					return;
				case 10: 
					_userDefinedPropertySource = value.StringVal;
					return;
				case 11: 
					_temperatureSingleValue = value.RealVal;
					return;
				case 12: 
					_wetBulbTemperatureSingleValue = value.RealVal;
					return;
				case 13: 
					_wetBulbTemperatureTimeSeries = (IfcTimeSeries)(value.EntityVal);
					return;
				case 14: 
					_temperatureTimeSeries = (IfcTimeSeries)(value.EntityVal);
					return;
				case 15: 
					_flowrateSingleValue = (IfcDerivedMeasureValue)(value.EntityVal);
					return;
				case 16: 
					_flowConditionSingleValue = value.RealVal;
					return;
				case 17: 
					_velocitySingleValue = value.RealVal;
					return;
				case 18: 
					_pressureSingleValue = value.RealVal;
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