// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		15.09.2015 07:04:15
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

namespace Xbim.Ifc2x3.CostResource
{
	[EntityName("IFCCOSTVALUE", 658)]
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
		[EntityAttribute(6, EntityAttributeState.Mandatory)]
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
	
		[EntityAttribute(7, EntityAttributeState.Optional)]
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

		#region Inverse attributes

		#endregion

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"Name",
			"Description",
			"AppliedValue",
			"UnitBasis",
			"ApplicableDate",
			"FixedUntilDate",
			"CostType",
			"Condition",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @Name;
				case 1: 
					return @Description;
				case 2: 
					return @AppliedValue;
				case 3: 
					return @UnitBasis;
				case 4: 
					return @ApplicableDate;
				case 5: 
					return @FixedUntilDate;
				case 6: 
					return @CostType;
				case 7: 
					return @Condition;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "Name":  
					return @Name;
				case "Description":  
					return @Description;
				case "AppliedValue":  
					return @AppliedValue;
				case "UnitBasis":  
					return @UnitBasis;
				case "ApplicableDate":  
					return @ApplicableDate;
				case "FixedUntilDate":  
					return @FixedUntilDate;
				case "CostType":  
					return @CostType;
				case "Condition":  
					return @Condition;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 @Name = (IfcLabel?)value;
					 break;
				case 1:
					 @Description = (IfcText?)value;
					 break;
				case 2:
					 @AppliedValue = (IfcAppliedValueSelect)value;
					 break;
				case 3:
					 @UnitBasis = (IfcMeasureWithUnit)value;
					 break;
				case 4:
					 @ApplicableDate = (IfcDateTimeSelect)value;
					 break;
				case 5:
					 @FixedUntilDate = (IfcDateTimeSelect)value;
					 break;
				case 6:
					 if (value != null) @CostType = (IfcLabel)value;
					 break;
				case 7:
					 @Condition = (IfcText?)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "Name":
					 @Name = (IfcLabel?)value;
					 break;
				case "Description":
					 @Description = (IfcText?)value;
					 break;
				case "AppliedValue":
					 @AppliedValue = (IfcAppliedValueSelect)value;
					 break;
				case "UnitBasis":
					 @UnitBasis = (IfcMeasureWithUnit)value;
					 break;
				case "ApplicableDate":
					 @ApplicableDate = (IfcDateTimeSelect)value;
					 break;
				case "FixedUntilDate":
					 @FixedUntilDate = (IfcDateTimeSelect)value;
					 break;
				case "CostType":
					 if (value != null) @CostType = (IfcLabel)value;
					 break;
				case "Condition":
					 @Condition = (IfcText?)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion


		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
            throw new System.NotImplementedException();
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		}
		#endregion

		
	}
}