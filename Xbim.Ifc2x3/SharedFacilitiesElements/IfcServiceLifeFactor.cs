// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.Kernel;
using Xbim.Ifc2x3.UtilityResource;
using Xbim.Ifc2x3.MeasureResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.SharedFacilitiesElements
{
	[ExpressType("IFCSERVICELIFEFACTOR", 770)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcServiceLifeFactor : IfcPropertySetDefinition, IInstantiableEntity, IEqualityComparer<@IfcServiceLifeFactor>, IEquatable<@IfcServiceLifeFactor>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcServiceLifeFactor(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcServiceLifeFactorTypeEnum _predefinedType;
		private IfcMeasureValue _upperValue;
		private IfcMeasureValue _mostUsedValue;
		private IfcMeasureValue _lowerValue;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcServiceLifeFactorTypeEnum @PredefinedType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _predefinedType;
				((IPersistEntity)this).Activate(false);
				return _predefinedType;
			} 
			set
			{
				SetValue( v =>  _predefinedType = v, _predefinedType, value,  "PredefinedType");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcMeasureValue @UpperValue 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _upperValue;
				((IPersistEntity)this).Activate(false);
				return _upperValue;
			} 
			set
			{
				SetValue( v =>  _upperValue = v, _upperValue, value,  "UpperValue");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcMeasureValue @MostUsedValue 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _mostUsedValue;
				((IPersistEntity)this).Activate(false);
				return _mostUsedValue;
			} 
			set
			{
				SetValue( v =>  _mostUsedValue = v, _mostUsedValue, value,  "MostUsedValue");
			} 
		}
	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcMeasureValue @LowerValue 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _lowerValue;
				((IPersistEntity)this).Activate(false);
				return _lowerValue;
			} 
			set
			{
				SetValue( v =>  _lowerValue = v, _lowerValue, value,  "LowerValue");
			} 
		}
	
		#endregion



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
				case 3: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 4: 
                    _predefinedType = (IfcServiceLifeFactorTypeEnum) System.Enum.Parse(typeof (IfcServiceLifeFactorTypeEnum), value.EnumVal, true);
					return;
				case 5: 
					_upperValue = (IfcMeasureValue)(value.EntityVal);
					return;
				case 6: 
					_mostUsedValue = (IfcMeasureValue)(value.EntityVal);
					return;
				case 7: 
					_lowerValue = (IfcMeasureValue)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR31:             OR EXISTS(SELF\IfcObject.ObjectType);*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcServiceLifeFactor other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcServiceLifeFactor
            var root = (@IfcServiceLifeFactor)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcServiceLifeFactor left, @IfcServiceLifeFactor right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcServiceLifeFactor left, @IfcServiceLifeFactor right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcServiceLifeFactor x, @IfcServiceLifeFactor y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcServiceLifeFactor obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}