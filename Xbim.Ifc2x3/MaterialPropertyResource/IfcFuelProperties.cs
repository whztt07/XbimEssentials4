// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 03:43:56
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
	[EntityName("IFCFUELPROPERTIES", 715)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcFuelProperties : IfcMaterialProperties, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcFuelProperties(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcThermodynamicTemperatureMeasure? _combustionTemperature;
		private IfcPositiveRatioMeasure? _carbonContent;
		private IfcHeatingValueMeasure? _lowerHeatingValue;
		private IfcHeatingValueMeasure? _higherHeatingValue;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttributee(1, EntityAttributeState.Optional)]
		public IfcThermodynamicTemperatureMeasure? @CombustionTemperature 
		{ 
			get 
			{
				if(Activated) return _combustionTemperature;
				
				Model.Activate(this, true);
				Activated = true;
				return _combustionTemperature;
			} 
			set
			{
				SetValue( v =>  _combustionTemperature = v, _combustionTemperature, value,  "CombustionTemperature");
			} 
		}
	
		[EntityAttributee(2, EntityAttributeState.Optional)]
		public IfcPositiveRatioMeasure? @CarbonContent 
		{ 
			get 
			{
				if(Activated) return _carbonContent;
				
				Model.Activate(this, true);
				Activated = true;
				return _carbonContent;
			} 
			set
			{
				SetValue( v =>  _carbonContent = v, _carbonContent, value,  "CarbonContent");
			} 
		}
	
		[EntityAttributee(3, EntityAttributeState.Optional)]
		public IfcHeatingValueMeasure? @LowerHeatingValue 
		{ 
			get 
			{
				if(Activated) return _lowerHeatingValue;
				
				Model.Activate(this, true);
				Activated = true;
				return _lowerHeatingValue;
			} 
			set
			{
				SetValue( v =>  _lowerHeatingValue = v, _lowerHeatingValue, value,  "LowerHeatingValue");
			} 
		}
	
		[EntityAttributee(4, EntityAttributeState.Optional)]
		public IfcHeatingValueMeasure? @HigherHeatingValue 
		{ 
			get 
			{
				if(Activated) return _higherHeatingValue;
				
				Model.Activate(this, true);
				Activated = true;
				return _higherHeatingValue;
			} 
			set
			{
				SetValue( v =>  _higherHeatingValue = v, _higherHeatingValue, value,  "HigherHeatingValue");
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
					_combustionTemperature = value.RealVal;
					return;
				case 2: 
					_carbonContent = value.RealVal;
					return;
				case 3: 
					_lowerHeatingValue = value.RealVal;
					return;
				case 4: 
					_higherHeatingValue = value.RealVal;
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