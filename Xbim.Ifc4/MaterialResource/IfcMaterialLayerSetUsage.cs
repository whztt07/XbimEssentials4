// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
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
	[IndexedClass]
	[ExpressType("IFCMATERIALLAYERSETUSAGE", 749)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcMaterialLayerSetUsage : IfcMaterialUsageDefinition, IInstantiableEntity, System.Collections.Generic.IEqualityComparer<@IfcMaterialLayerSetUsage>, System.IEquatable<@IfcMaterialLayerSetUsage>
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
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
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
	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
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
	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
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
	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
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
	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
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

		#region Equality comparers and operators
        public bool Equals(@IfcMaterialLayerSetUsage other)
	    {
	        return this == other;
	    }


        public static bool operator ==(@IfcMaterialLayerSetUsage left, @IfcMaterialLayerSetUsage right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcMaterialLayerSetUsage left, @IfcMaterialLayerSetUsage right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcMaterialLayerSetUsage x, @IfcMaterialLayerSetUsage y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcMaterialLayerSetUsage obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}