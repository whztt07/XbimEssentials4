// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
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
	[ExpressType("IFCMECHANICALCONCRETEMATERIALPROPERTIES", 693)]
	// ReSharper disable once PartialTypeWithSinglePart
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
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
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
	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
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
	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
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
	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
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
	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
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
	
		[EntityAttribute(12, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
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
					_compressiveStrength = value.RealVal;
					return;
				case 7: 
					_maxAggregateSize = value.RealVal;
					return;
				case 8: 
					_admixturesDescription = value.StringVal;
					return;
				case 9: 
					_workability = value.StringVal;
					return;
				case 10: 
					_protectivePoreRatio = value.RealVal;
					return;
				case 11: 
					_waterImpermeability = value.StringVal;
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