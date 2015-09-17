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
	[EntityName("IFCHYGROSCOPICMATERIALPROPERTIES", 717)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcHygroscopicMaterialProperties : IfcMaterialProperties, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcHygroscopicMaterialProperties(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcPositiveRatioMeasure? _upperVaporResistanceFactor;
		private IfcPositiveRatioMeasure? _lowerVaporResistanceFactor;
		private IfcIsothermalMoistureCapacityMeasure? _isothermalMoistureCapacity;
		private IfcVaporPermeabilityMeasure? _vaporPermeability;
		private IfcMoistureDiffusivityMeasure? _moistureDiffusivity;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Optional)]
		public IfcPositiveRatioMeasure? @UpperVaporResistanceFactor 
		{ 
			get 
			{
				if(Activated) return _upperVaporResistanceFactor;
				
				Model.Activate(this, true);
				Activated = true;
				return _upperVaporResistanceFactor;
			} 
			set
			{
				SetValue( v =>  _upperVaporResistanceFactor = v, _upperVaporResistanceFactor, value,  "UpperVaporResistanceFactor");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Optional)]
		public IfcPositiveRatioMeasure? @LowerVaporResistanceFactor 
		{ 
			get 
			{
				if(Activated) return _lowerVaporResistanceFactor;
				
				Model.Activate(this, true);
				Activated = true;
				return _lowerVaporResistanceFactor;
			} 
			set
			{
				SetValue( v =>  _lowerVaporResistanceFactor = v, _lowerVaporResistanceFactor, value,  "LowerVaporResistanceFactor");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Optional)]
		public IfcIsothermalMoistureCapacityMeasure? @IsothermalMoistureCapacity 
		{ 
			get 
			{
				if(Activated) return _isothermalMoistureCapacity;
				
				Model.Activate(this, true);
				Activated = true;
				return _isothermalMoistureCapacity;
			} 
			set
			{
				SetValue( v =>  _isothermalMoistureCapacity = v, _isothermalMoistureCapacity, value,  "IsothermalMoistureCapacity");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Optional)]
		public IfcVaporPermeabilityMeasure? @VaporPermeability 
		{ 
			get 
			{
				if(Activated) return _vaporPermeability;
				
				Model.Activate(this, true);
				Activated = true;
				return _vaporPermeability;
			} 
			set
			{
				SetValue( v =>  _vaporPermeability = v, _vaporPermeability, value,  "VaporPermeability");
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Optional)]
		public IfcMoistureDiffusivityMeasure? @MoistureDiffusivity 
		{ 
			get 
			{
				if(Activated) return _moistureDiffusivity;
				
				Model.Activate(this, true);
				Activated = true;
				return _moistureDiffusivity;
			} 
			set
			{
				SetValue( v =>  _moistureDiffusivity = v, _moistureDiffusivity, value,  "MoistureDiffusivity");
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
					_upperVaporResistanceFactor = value.RealVal;
					return;
				case 2: 
					_lowerVaporResistanceFactor = value.RealVal;
					return;
				case 3: 
					_isothermalMoistureCapacity = value.RealVal;
					return;
				case 4: 
					_vaporPermeability = value.RealVal;
					return;
				case 5: 
					_moistureDiffusivity = value.RealVal;
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