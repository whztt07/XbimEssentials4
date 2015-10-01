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
	[ExpressType("IFCOPTICALMATERIALPROPERTIES", 718)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcOpticalMaterialProperties : IfcMaterialProperties, IInstantiableEntity, System.Collections.Generic.IEqualityComparer<@IfcOpticalMaterialProperties>, System.IEquatable<@IfcOpticalMaterialProperties>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcOpticalMaterialProperties(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcPositiveRatioMeasure? _visibleTransmittance;
		private IfcPositiveRatioMeasure? _solarTransmittance;
		private IfcPositiveRatioMeasure? _thermalIrTransmittance;
		private IfcPositiveRatioMeasure? _thermalIrEmissivityBack;
		private IfcPositiveRatioMeasure? _thermalIrEmissivityFront;
		private IfcPositiveRatioMeasure? _visibleReflectanceBack;
		private IfcPositiveRatioMeasure? _visibleReflectanceFront;
		private IfcPositiveRatioMeasure? _solarReflectanceFront;
		private IfcPositiveRatioMeasure? _solarReflectanceBack;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveRatioMeasure? @VisibleTransmittance 
		{ 
			get 
			{
				if(Activated) return _visibleTransmittance;
				
				Model.Activate(this, true);
				Activated = true;
				return _visibleTransmittance;
			} 
			set
			{
				SetValue( v =>  _visibleTransmittance = v, _visibleTransmittance, value,  "VisibleTransmittance");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveRatioMeasure? @SolarTransmittance 
		{ 
			get 
			{
				if(Activated) return _solarTransmittance;
				
				Model.Activate(this, true);
				Activated = true;
				return _solarTransmittance;
			} 
			set
			{
				SetValue( v =>  _solarTransmittance = v, _solarTransmittance, value,  "SolarTransmittance");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveRatioMeasure? @ThermalIrTransmittance 
		{ 
			get 
			{
				if(Activated) return _thermalIrTransmittance;
				
				Model.Activate(this, true);
				Activated = true;
				return _thermalIrTransmittance;
			} 
			set
			{
				SetValue( v =>  _thermalIrTransmittance = v, _thermalIrTransmittance, value,  "ThermalIrTransmittance");
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveRatioMeasure? @ThermalIrEmissivityBack 
		{ 
			get 
			{
				if(Activated) return _thermalIrEmissivityBack;
				
				Model.Activate(this, true);
				Activated = true;
				return _thermalIrEmissivityBack;
			} 
			set
			{
				SetValue( v =>  _thermalIrEmissivityBack = v, _thermalIrEmissivityBack, value,  "ThermalIrEmissivityBack");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveRatioMeasure? @ThermalIrEmissivityFront 
		{ 
			get 
			{
				if(Activated) return _thermalIrEmissivityFront;
				
				Model.Activate(this, true);
				Activated = true;
				return _thermalIrEmissivityFront;
			} 
			set
			{
				SetValue( v =>  _thermalIrEmissivityFront = v, _thermalIrEmissivityFront, value,  "ThermalIrEmissivityFront");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveRatioMeasure? @VisibleReflectanceBack 
		{ 
			get 
			{
				if(Activated) return _visibleReflectanceBack;
				
				Model.Activate(this, true);
				Activated = true;
				return _visibleReflectanceBack;
			} 
			set
			{
				SetValue( v =>  _visibleReflectanceBack = v, _visibleReflectanceBack, value,  "VisibleReflectanceBack");
			} 
		}
	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveRatioMeasure? @VisibleReflectanceFront 
		{ 
			get 
			{
				if(Activated) return _visibleReflectanceFront;
				
				Model.Activate(this, true);
				Activated = true;
				return _visibleReflectanceFront;
			} 
			set
			{
				SetValue( v =>  _visibleReflectanceFront = v, _visibleReflectanceFront, value,  "VisibleReflectanceFront");
			} 
		}
	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveRatioMeasure? @SolarReflectanceFront 
		{ 
			get 
			{
				if(Activated) return _solarReflectanceFront;
				
				Model.Activate(this, true);
				Activated = true;
				return _solarReflectanceFront;
			} 
			set
			{
				SetValue( v =>  _solarReflectanceFront = v, _solarReflectanceFront, value,  "SolarReflectanceFront");
			} 
		}
	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveRatioMeasure? @SolarReflectanceBack 
		{ 
			get 
			{
				if(Activated) return _solarReflectanceBack;
				
				Model.Activate(this, true);
				Activated = true;
				return _solarReflectanceBack;
			} 
			set
			{
				SetValue( v =>  _solarReflectanceBack = v, _solarReflectanceBack, value,  "SolarReflectanceBack");
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
					_visibleTransmittance = value.RealVal;
					return;
				case 2: 
					_solarTransmittance = value.RealVal;
					return;
				case 3: 
					_thermalIrTransmittance = value.RealVal;
					return;
				case 4: 
					_thermalIrEmissivityBack = value.RealVal;
					return;
				case 5: 
					_thermalIrEmissivityFront = value.RealVal;
					return;
				case 6: 
					_visibleReflectanceBack = value.RealVal;
					return;
				case 7: 
					_visibleReflectanceFront = value.RealVal;
					return;
				case 8: 
					_solarReflectanceFront = value.RealVal;
					return;
				case 9: 
					_solarReflectanceBack = value.RealVal;
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
        public bool Equals(@IfcOpticalMaterialProperties other)
	    {
	        return this == other;
	    }


        public static bool operator ==(@IfcOpticalMaterialProperties left, @IfcOpticalMaterialProperties right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcOpticalMaterialProperties left, @IfcOpticalMaterialProperties right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcOpticalMaterialProperties x, @IfcOpticalMaterialProperties y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcOpticalMaterialProperties obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}