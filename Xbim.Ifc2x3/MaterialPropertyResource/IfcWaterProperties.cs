// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 10:21:01
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
	[EntityName("IFCWATERPROPERTIES", 721)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcWaterProperties : IfcMaterialProperties, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcWaterProperties(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private bool? _isPotable;
		private IfcIonConcentrationMeasure? _hardness;
		private IfcIonConcentrationMeasure? _alkalinityConcentration;
		private IfcIonConcentrationMeasure? _acidityConcentration;
		private IfcNormalisedRatioMeasure? _impuritiesContent;
		private IfcPHMeasure? _pHLevel;
		private IfcNormalisedRatioMeasure? _dissolvedSolidsContent;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Optional)]
		public bool? @IsPotable 
		{ 
			get 
			{
				if(Activated) return _isPotable;
				
				Model.Activate(this, true);
				Activated = true;
				return _isPotable;
			} 
			set
			{
				SetValue( v =>  _isPotable = v, _isPotable, value,  "IsPotable");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Optional)]
		public IfcIonConcentrationMeasure? @Hardness 
		{ 
			get 
			{
				if(Activated) return _hardness;
				
				Model.Activate(this, true);
				Activated = true;
				return _hardness;
			} 
			set
			{
				SetValue( v =>  _hardness = v, _hardness, value,  "Hardness");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Optional)]
		public IfcIonConcentrationMeasure? @AlkalinityConcentration 
		{ 
			get 
			{
				if(Activated) return _alkalinityConcentration;
				
				Model.Activate(this, true);
				Activated = true;
				return _alkalinityConcentration;
			} 
			set
			{
				SetValue( v =>  _alkalinityConcentration = v, _alkalinityConcentration, value,  "AlkalinityConcentration");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Optional)]
		public IfcIonConcentrationMeasure? @AcidityConcentration 
		{ 
			get 
			{
				if(Activated) return _acidityConcentration;
				
				Model.Activate(this, true);
				Activated = true;
				return _acidityConcentration;
			} 
			set
			{
				SetValue( v =>  _acidityConcentration = v, _acidityConcentration, value,  "AcidityConcentration");
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Optional)]
		public IfcNormalisedRatioMeasure? @ImpuritiesContent 
		{ 
			get 
			{
				if(Activated) return _impuritiesContent;
				
				Model.Activate(this, true);
				Activated = true;
				return _impuritiesContent;
			} 
			set
			{
				SetValue( v =>  _impuritiesContent = v, _impuritiesContent, value,  "ImpuritiesContent");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Optional)]
		public IfcPHMeasure? @PHLevel 
		{ 
			get 
			{
				if(Activated) return _pHLevel;
				
				Model.Activate(this, true);
				Activated = true;
				return _pHLevel;
			} 
			set
			{
				SetValue( v =>  _pHLevel = v, _pHLevel, value,  "PHLevel");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Optional)]
		public IfcNormalisedRatioMeasure? @DissolvedSolidsContent 
		{ 
			get 
			{
				if(Activated) return _dissolvedSolidsContent;
				
				Model.Activate(this, true);
				Activated = true;
				return _dissolvedSolidsContent;
			} 
			set
			{
				SetValue( v =>  _dissolvedSolidsContent = v, _dissolvedSolidsContent, value,  "DissolvedSolidsContent");
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
					_isPotable = value.BooleanVal;
					return;
				case 2: 
					_hardness = value.RealVal;
					return;
				case 3: 
					_alkalinityConcentration = value.RealVal;
					return;
				case 4: 
					_acidityConcentration = value.RealVal;
					return;
				case 5: 
					_impuritiesContent = value.RealVal;
					return;
				case 6: 
					_pHLevel = value.RealVal;
					return;
				case 7: 
					_dissolvedSolidsContent = value.RealVal;
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