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
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.MaterialPropertyResource
{
	[ExpressType("IFCPRODUCTSOFCOMBUSTIONPROPERTIES", 719)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcProductsOfCombustionProperties : IfcMaterialProperties, IInstantiableEntity, IEqualityComparer<@IfcProductsOfCombustionProperties>, IEquatable<@IfcProductsOfCombustionProperties>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcProductsOfCombustionProperties(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcSpecificHeatCapacityMeasure? _specificHeatCapacity;
		private IfcPositiveRatioMeasure? _n20Content;
		private IfcPositiveRatioMeasure? _cOContent;
		private IfcPositiveRatioMeasure? _cO2Content;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcSpecificHeatCapacityMeasure? @SpecificHeatCapacity 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _specificHeatCapacity;
				((IPersistEntity)this).Activate(false);
				return _specificHeatCapacity;
			} 
			set
			{
				SetValue( v =>  _specificHeatCapacity = v, _specificHeatCapacity, value,  "SpecificHeatCapacity");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveRatioMeasure? @N20Content 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _n20Content;
				((IPersistEntity)this).Activate(false);
				return _n20Content;
			} 
			set
			{
				SetValue( v =>  _n20Content = v, _n20Content, value,  "N20Content");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveRatioMeasure? @COContent 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _cOContent;
				((IPersistEntity)this).Activate(false);
				return _cOContent;
			} 
			set
			{
				SetValue( v =>  _cOContent = v, _cOContent, value,  "COContent");
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveRatioMeasure? @CO2Content 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _cO2Content;
				((IPersistEntity)this).Activate(false);
				return _cO2Content;
			} 
			set
			{
				SetValue( v =>  _cO2Content = v, _cO2Content, value,  "CO2Content");
			} 
		}
	
		#endregion



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 1: 
					_specificHeatCapacity = value.RealVal;
					return;
				case 2: 
					_n20Content = value.RealVal;
					return;
				case 3: 
					_cOContent = value.RealVal;
					return;
				case 4: 
					_cO2Content = value.RealVal;
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
        public bool Equals(@IfcProductsOfCombustionProperties other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcProductsOfCombustionProperties
            var root = (@IfcProductsOfCombustionProperties)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcProductsOfCombustionProperties left, @IfcProductsOfCombustionProperties right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcProductsOfCombustionProperties left, @IfcProductsOfCombustionProperties right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcProductsOfCombustionProperties x, @IfcProductsOfCombustionProperties y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcProductsOfCombustionProperties obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}