// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		24.09.2015 10:03:32
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.ConstraintResource;
using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.DateTimeResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.CostResource
{
	[IndexedClass]
	[ExpressType("IFCCOSTVALUE", 658)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcCostValue : IfcAppliedValue, IfcMetricValueSelect, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcCostValue(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcLabel _costType;
		private IfcText? _condition;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel @CostType 
		{ 
			get 
			{
				if(Activated) return _costType;
				
				Model.Activate(this, true);
				Activated = true;
				return _costType;
			} 
			set
			{
				SetValue( v =>  _costType = v, _costType, value,  "CostType");
			} 
		}
	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcText? @Condition 
		{ 
			get 
			{
				if(Activated) return _condition;
				
				Model.Activate(this, true);
				Activated = true;
				return _condition;
			} 
			set
			{
				SetValue( v =>  _condition = v, _condition, value,  "Condition");
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
					_costType = value.StringVal;
					return;
				case 7: 
					_condition = value.StringVal;
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