// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Kernel;
using Xbim.Ifc4.UtilityResource;
using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.CostResource;
using Xbim.Ifc4.QuantityResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.SharedMgmtElements
{
	[ExpressType("IFCCOSTITEM", 538)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcCostItem : IfcControl, IInstantiableEntity, IEqualityComparer<@IfcCostItem>, IEquatable<@IfcCostItem>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcCostItem(IModel model) : base(model) 		{ 
			Model = model; 
			_costValues = new OptionalItemSet<IfcCostValue>( this, 0 );
			_costQuantities = new OptionalItemSet<IfcPhysicalQuantity>( this, 0 );
		}

		#region Explicit attribute fields
		private IfcCostItemTypeEnum? _predefinedType;
		private OptionalItemSet<IfcCostValue> _costValues;
		private OptionalItemSet<IfcPhysicalQuantity> _costQuantities;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcCostItemTypeEnum? @PredefinedType 
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
	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.Class, 1, -1)]
		public OptionalItemSet<IfcCostValue> @CostValues 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _costValues;
				((IPersistEntity)this).Activate(false);
				return _costValues;
			} 
		}
	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.Class, 1, -1)]
		public OptionalItemSet<IfcPhysicalQuantity> @CostQuantities 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _costQuantities;
				((IPersistEntity)this).Activate(false);
				return _costQuantities;
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
				case 4: 
				case 5: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 6: 
                    _predefinedType = (IfcCostItemTypeEnum) System.Enum.Parse(typeof (IfcCostItemTypeEnum), value.EnumVal, true);
					return;
				case 7: 
					if (_costValues == null) _costValues = new OptionalItemSet<IfcCostValue>( this );
					_costValues.InternalAdd((IfcCostValue)value.EntityVal);
					return;
				case 8: 
					if (_costQuantities == null) _costQuantities = new OptionalItemSet<IfcPhysicalQuantity>( this );
					_costQuantities.InternalAdd((IfcPhysicalQuantity)value.EntityVal);
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
        public bool Equals(@IfcCostItem other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcCostItem
            var root = (@IfcCostItem)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcCostItem left, @IfcCostItem right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcCostItem left, @IfcCostItem right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcCostItem x, @IfcCostItem y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcCostItem obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}