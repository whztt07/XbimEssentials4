// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		23.09.2015 10:21:43
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
	[ExpressType("IFCGENERALMATERIALPROPERTIES", 716)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcGeneralMaterialProperties : IfcMaterialProperties, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcGeneralMaterialProperties(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcMolecularWeightMeasure? _molecularWeight;
		private IfcNormalisedRatioMeasure? _porosity;
		private IfcMassDensityMeasure? _massDensity;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcMolecularWeightMeasure? @MolecularWeight 
		{ 
			get 
			{
				if(Activated) return _molecularWeight;
				
				Model.Activate(this, true);
				Activated = true;
				return _molecularWeight;
			} 
			set
			{
				SetValue( v =>  _molecularWeight = v, _molecularWeight, value,  "MolecularWeight");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcNormalisedRatioMeasure? @Porosity 
		{ 
			get 
			{
				if(Activated) return _porosity;
				
				Model.Activate(this, true);
				Activated = true;
				return _porosity;
			} 
			set
			{
				SetValue( v =>  _porosity = v, _porosity, value,  "Porosity");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcMassDensityMeasure? @MassDensity 
		{ 
			get 
			{
				if(Activated) return _massDensity;
				
				Model.Activate(this, true);
				Activated = true;
				return _massDensity;
			} 
			set
			{
				SetValue( v =>  _massDensity = v, _massDensity, value,  "MassDensity");
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
					_molecularWeight = value.RealVal;
					return;
				case 2: 
					_porosity = value.RealVal;
					return;
				case 3: 
					_massDensity = value.RealVal;
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