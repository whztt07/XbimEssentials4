// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 02:29:22
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc4.MaterialResource
{
	[EntityName("IFCMATERIALLAYERSETUSAGE", 358)]
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

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"ForLayerSet",
			"LayerSetDirection",
			"DirectionSense",
			"OffsetFromReferenceLine",
			"ReferenceExtent",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @ForLayerSet;
				case 1: 
					return @LayerSetDirection;
				case 2: 
					return @DirectionSense;
				case 3: 
					return @OffsetFromReferenceLine;
				case 4: 
					return @ReferenceExtent;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "ForLayerSet":  
					return @ForLayerSet;
				case "LayerSetDirection":  
					return @LayerSetDirection;
				case "DirectionSense":  
					return @DirectionSense;
				case "OffsetFromReferenceLine":  
					return @OffsetFromReferenceLine;
				case "ReferenceExtent":  
					return @ReferenceExtent;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 @ForLayerSet = (IfcMaterialLayerSet)value;
					 break;
				case 1:
					 if (value != null) @LayerSetDirection = (IfcLayerSetDirectionEnum)value;
					 break;
				case 2:
					 if (value != null) @DirectionSense = (IfcDirectionSenseEnum)value;
					 break;
				case 3:
					 if (value != null) @OffsetFromReferenceLine = (IfcLengthMeasure)value;
					 break;
				case 4:
					 @ReferenceExtent = (IfcPositiveLengthMeasure?)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "ForLayerSet":
					 @ForLayerSet = (IfcMaterialLayerSet)value;
					 break;
				case "LayerSetDirection":
					 if (value != null) @LayerSetDirection = (IfcLayerSetDirectionEnum)value;
					 break;
				case "DirectionSense":
					 if (value != null) @DirectionSense = (IfcDirectionSenseEnum)value;
					 break;
				case "OffsetFromReferenceLine":
					 if (value != null) @OffsetFromReferenceLine = (IfcLengthMeasure)value;
					 break;
				case "ReferenceExtent":
					 @ReferenceExtent = (IfcPositiveLengthMeasure?)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion


		#region IPersist implementation
		void IPersist.Set(int propIndex, IPropertyValue value)
		{
            throw new System.NotImplementedException();
		}
		#endregion

	}
}