// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		22.09.2015 04:44:04
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.UtilityResource;
using Xbim.Ifc2x3.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.SharedBldgServiceElements
{
	[IndexedClass]
	[ExpressType("IFCELECTRICALBASEPROPERTIES", 177)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcElectricalBaseProperties : IfcEnergyProperties, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcElectricalBaseProperties(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcElectricCurrentEnum? _electricCurrentType;
		private IfcElectricVoltageMeasure _inputVoltage;
		private IfcFrequencyMeasure _inputFrequency;
		private IfcElectricCurrentMeasure? _fullLoadCurrent;
		private IfcElectricCurrentMeasure? _minimumCircuitCurrent;
		private IfcPowerMeasure? _maximumPowerInput;
		private IfcPowerMeasure? _ratedPowerInput;
		private long _inputPhase;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcElectricCurrentEnum? @ElectricCurrentType 
		{ 
			get 
			{
				if(Activated) return _electricCurrentType;
				
				Model.Activate(this, true);
				Activated = true;
				return _electricCurrentType;
			} 
			set
			{
				SetValue( v =>  _electricCurrentType = v, _electricCurrentType, value,  "ElectricCurrentType");
			} 
		}
	
		[EntityAttribute(8, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcElectricVoltageMeasure @InputVoltage 
		{ 
			get 
			{
				if(Activated) return _inputVoltage;
				
				Model.Activate(this, true);
				Activated = true;
				return _inputVoltage;
			} 
			set
			{
				SetValue( v =>  _inputVoltage = v, _inputVoltage, value,  "InputVoltage");
			} 
		}
	
		[EntityAttribute(9, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcFrequencyMeasure @InputFrequency 
		{ 
			get 
			{
				if(Activated) return _inputFrequency;
				
				Model.Activate(this, true);
				Activated = true;
				return _inputFrequency;
			} 
			set
			{
				SetValue( v =>  _inputFrequency = v, _inputFrequency, value,  "InputFrequency");
			} 
		}
	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcElectricCurrentMeasure? @FullLoadCurrent 
		{ 
			get 
			{
				if(Activated) return _fullLoadCurrent;
				
				Model.Activate(this, true);
				Activated = true;
				return _fullLoadCurrent;
			} 
			set
			{
				SetValue( v =>  _fullLoadCurrent = v, _fullLoadCurrent, value,  "FullLoadCurrent");
			} 
		}
	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcElectricCurrentMeasure? @MinimumCircuitCurrent 
		{ 
			get 
			{
				if(Activated) return _minimumCircuitCurrent;
				
				Model.Activate(this, true);
				Activated = true;
				return _minimumCircuitCurrent;
			} 
			set
			{
				SetValue( v =>  _minimumCircuitCurrent = v, _minimumCircuitCurrent, value,  "MinimumCircuitCurrent");
			} 
		}
	
		[EntityAttribute(12, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPowerMeasure? @MaximumPowerInput 
		{ 
			get 
			{
				if(Activated) return _maximumPowerInput;
				
				Model.Activate(this, true);
				Activated = true;
				return _maximumPowerInput;
			} 
			set
			{
				SetValue( v =>  _maximumPowerInput = v, _maximumPowerInput, value,  "MaximumPowerInput");
			} 
		}
	
		[EntityAttribute(13, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPowerMeasure? @RatedPowerInput 
		{ 
			get 
			{
				if(Activated) return _ratedPowerInput;
				
				Model.Activate(this, true);
				Activated = true;
				return _ratedPowerInput;
			} 
			set
			{
				SetValue( v =>  _ratedPowerInput = v, _ratedPowerInput, value,  "RatedPowerInput");
			} 
		}
	
		[EntityAttribute(14, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public long @InputPhase 
		{ 
			get 
			{
				if(Activated) return _inputPhase;
				
				Model.Activate(this, true);
				Activated = true;
				return _inputPhase;
			} 
			set
			{
				SetValue( v =>  _inputPhase = v, _inputPhase, value,  "InputPhase");
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
                    _electricCurrentType = (IfcElectricCurrentEnum) System.Enum.Parse(typeof (IfcElectricCurrentEnum), value.EnumVal, true);
					return;
				case 7: 
					_inputVoltage = value.RealVal;
					return;
				case 8: 
					_inputFrequency = value.RealVal;
					return;
				case 9: 
					_fullLoadCurrent = value.RealVal;
					return;
				case 10: 
					_minimumCircuitCurrent = value.RealVal;
					return;
				case 11: 
					_maximumPowerInput = value.RealVal;
					return;
				case 12: 
					_ratedPowerInput = value.RealVal;
					return;
				case 13: 
					_inputPhase = value.IntegerVal;
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