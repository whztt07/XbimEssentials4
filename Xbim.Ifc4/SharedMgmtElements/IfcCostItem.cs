// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		24.09.2015 10:03:40
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
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.SharedMgmtElements
{
	[IndexedClass]
	[ExpressType("IFCCOSTITEM", 538)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcCostItem : IfcControl, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcCostItem(IModel model) : base(model) 		{ 
			Model = model; 
			_costValues = new OptionalItemSet<IfcCostValue>( this );
			_costQuantities = new OptionalItemSet<IfcPhysicalQuantity>( this );
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
				if(Activated) return _predefinedType;
				
				Model.Activate(this, true);
				Activated = true;
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
				if(Activated) return _costValues;
				
				Model.Activate(this, true);
				Activated = true;
				return _costValues;
			} 
		}
	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.Class, 1, -1)]
		public OptionalItemSet<IfcPhysicalQuantity> @CostQuantities 
		{ 
			get 
			{
				if(Activated) return _costQuantities;
				
				Model.Activate(this, true);
				Activated = true;
				return _costQuantities;
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
	}
}