// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 10:21:08
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.MaterialResource
{
	[EntityName("IFCMATERIALLAYERSETUSAGE", 358)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcMaterialLayerSetUsage : IfcMaterialUsageDefinition, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcMaterialLayerSetUsage(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcMaterialLayerSet _forLayerSet;
		private IfcLayerSetDirectionEnum _layerSetDirection;
		private IfcDirectionSenseEnum _directionSense;
		private IfcLengthMeasure _offsetFromReferenceLine;
		private IfcPositiveLengthMeasure? _referenceExtent;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(0, EntityAttributeState.Mandatory)]
		public IfcMaterialLayerSet @ForLayerSet 
		{ 
			get 
			{
				if(Activated) return _forLayerSet;
				
				Model.Activate(this, true);
				Activated = true;
				return _forLayerSet;
			} 
			set
			{
				SetValue( v =>  _forLayerSet = v, _forLayerSet, value,  "ForLayerSet");
			} 
		}
	
		[EntityAttribute(1, EntityAttributeState.Mandatory)]
		public IfcLayerSetDirectionEnum @LayerSetDirection 
		{ 
			get 
			{
				if(Activated) return _layerSetDirection;
				
				Model.Activate(this, true);
				Activated = true;
				return _layerSetDirection;
			} 
			set
			{
				SetValue( v =>  _layerSetDirection = v, _layerSetDirection, value,  "LayerSetDirection");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Mandatory)]
		public IfcDirectionSenseEnum @DirectionSense 
		{ 
			get 
			{
				if(Activated) return _directionSense;
				
				Model.Activate(this, true);
				Activated = true;
				return _directionSense;
			} 
			set
			{
				SetValue( v =>  _directionSense = v, _directionSense, value,  "DirectionSense");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Mandatory)]
		public IfcLengthMeasure @OffsetFromReferenceLine 
		{ 
			get 
			{
				if(Activated) return _offsetFromReferenceLine;
				
				Model.Activate(this, true);
				Activated = true;
				return _offsetFromReferenceLine;
			} 
			set
			{
				SetValue( v =>  _offsetFromReferenceLine = v, _offsetFromReferenceLine, value,  "OffsetFromReferenceLine");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Optional)]
		public IfcPositiveLengthMeasure? @ReferenceExtent 
		{ 
			get 
			{
				if(Activated) return _referenceExtent;
				
				Model.Activate(this, true);
				Activated = true;
				return _referenceExtent;
			} 
			set
			{
				SetValue( v =>  _referenceExtent = v, _referenceExtent, value,  "ReferenceExtent");
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
					_forLayerSet = (IfcMaterialLayerSet)(value.EntityVal);
					return;
				case 1: 
                    _layerSetDirection = (IfcLayerSetDirectionEnum) System.Enum.Parse(typeof (IfcLayerSetDirectionEnum), value.EnumVal, true);
					return;
				case 2: 
                    _directionSense = (IfcDirectionSenseEnum) System.Enum.Parse(typeof (IfcDirectionSenseEnum), value.EnumVal, true);
					return;
				case 3: 
					_offsetFromReferenceLine = value.RealVal;
					return;
				case 4: 
					_referenceExtent = value.RealVal;
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