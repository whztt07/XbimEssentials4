// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 10:21:09
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.PropertyResource
{
	[EntityName("IFCPROPERTYBOUNDEDVALUE", 459)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcPropertyBoundedValue : IfcSimpleProperty, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPropertyBoundedValue(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcValue _upperBoundValue;
		private IfcValue _lowerBoundValue;
		private IfcUnit _unit;
		private IfcValue _setPointValue;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Optional)]
		public IfcValue @UpperBoundValue 
		{ 
			get 
			{
				if(Activated) return _upperBoundValue;
				
				Model.Activate(this, true);
				Activated = true;
				return _upperBoundValue;
			} 
			set
			{
				SetValue( v =>  _upperBoundValue = v, _upperBoundValue, value,  "UpperBoundValue");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Optional)]
		public IfcValue @LowerBoundValue 
		{ 
			get 
			{
				if(Activated) return _lowerBoundValue;
				
				Model.Activate(this, true);
				Activated = true;
				return _lowerBoundValue;
			} 
			set
			{
				SetValue( v =>  _lowerBoundValue = v, _lowerBoundValue, value,  "LowerBoundValue");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Optional)]
		public IfcUnit @Unit 
		{ 
			get 
			{
				if(Activated) return _unit;
				
				Model.Activate(this, true);
				Activated = true;
				return _unit;
			} 
			set
			{
				SetValue( v =>  _unit = v, _unit, value,  "Unit");
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Optional)]
		public IfcValue @SetPointValue 
		{ 
			get 
			{
				if(Activated) return _setPointValue;
				
				Model.Activate(this, true);
				Activated = true;
				return _setPointValue;
			} 
			set
			{
				SetValue( v =>  _setPointValue = v, _setPointValue, value,  "SetPointValue");
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
				case 1: 
					base.Parse(propIndex, value); 
					return;
				case 2: 
					_upperBoundValue = (IfcValue)(value.EntityVal);
					return;
				case 3: 
					_lowerBoundValue = (IfcValue)(value.EntityVal);
					return;
				case 4: 
					_unit = (IfcUnit)(value.EntityVal);
					return;
				case 5: 
					_setPointValue = (IfcValue)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*SameUnitUpperLower:                           (TYPEOF(UpperBoundValue) = TYPEOF(LowerBoundValue));*/
		/*SameUnitUpperSet:                           (TYPEOF(UpperBoundValue) = TYPEOF(SetPointValue));*/
		/*SameUnitLowerSet:                           (TYPEOF(LowerBoundValue) = TYPEOF(SetPointValue));*/
		}
		#endregion
	}
}