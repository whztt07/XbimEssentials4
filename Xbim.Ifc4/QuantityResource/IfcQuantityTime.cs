// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 09:16:42
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc4.QuantityResource
{
	[EntityName("IFCQUANTITYTIME")]
	public  partial class @IfcQuantityTime : IfcPhysicalSimpleQuantity, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcQuantityTime(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcTimeMeasure _timeValue;
		private IfcLabel? _formula;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(3, EntityAttributeState.Mandatory)]
		public IfcTimeMeasure @TimeValue 
		{ 
			get 
			{
				if(IsActivated) return _timeValue;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _timeValue;
			} 
			set
			{
				SetValue( v =>  _timeValue = v, _timeValue, value,  "TimeValue");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Optional)]
		public IfcLabel? @Formula 
		{ 
			get 
			{
				if(IsActivated) return _formula;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _formula;
			} 
			set
			{
				SetValue( v =>  _formula = v, _formula, value,  "Formula");
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
			"Unit",
			"TimeValue",
			"Formula",
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
					return @Unit;
				case 3: 
					return @TimeValue;
				case 4: 
					return @Formula;
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
				case "Unit":  
					return @Unit;
				case "TimeValue":  
					return @TimeValue;
				case "Formula":  
					return @Formula;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 if (value != null) @Name = (IfcLabel)value;
					 break;
				case 1:
					 @Description = (IfcText?)value;
					 break;
				case 2:
					 @Unit = (IfcNamedUnit)value;
					 break;
				case 3:
					 if (value != null) @TimeValue = (IfcTimeMeasure)value;
					 break;
				case 4:
					 @Formula = (IfcLabel?)value;
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
					 if (value != null) @Name = (IfcLabel)value;
					 break;
				case "Description":
					 @Description = (IfcText?)value;
					 break;
				case "Unit":
					 @Unit = (IfcNamedUnit)value;
					 break;
				case "TimeValue":
					 if (value != null) @TimeValue = (IfcTimeMeasure)value;
					 break;
				case "Formula":
					 @Formula = (IfcLabel?)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion

		#region Where rules
		/*WR21:                (SELF\IfcPhysicalSimpleQuantity.Unit.UnitType = IfcUnitEnum.TIMEUNIT);*/
		/*WR22:	WR22 : TimeValue >= 0.;*/
		#endregion

		#region IPersist implementation
		public void Set(int propIndex, IPropertyValue value)
		{
            throw new System.NotImplementedException();
		}
		#endregion

	}
}