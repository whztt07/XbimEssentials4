// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 03:43:56
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.PropertyResource
{
	[EntityName("IFCPROPERTYBOUNDEDVALUE", 3)]
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
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR21:             (TYPEOF(UpperBoundValue) = TYPEOF(LowerBoundValue));*/
		/*WR22:	WR22 : EXISTS(UpperBoundValue) OR EXISTS(LowerBoundValue);*/
		}
		#endregion
	}
}