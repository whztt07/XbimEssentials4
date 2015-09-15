// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		15.09.2015 07:04:17
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc2x3.PropertyResource
{
	[EntityName("IFCPROPERTYBOUNDEDVALUE", 3)]
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

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"Name",
			"Description",
			"UpperBoundValue",
			"LowerBoundValue",
			"Unit",
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
					return @UpperBoundValue;
				case 3: 
					return @LowerBoundValue;
				case 4: 
					return @Unit;
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
				case "UpperBoundValue":  
					return @UpperBoundValue;
				case "LowerBoundValue":  
					return @LowerBoundValue;
				case "Unit":  
					return @Unit;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 if (value != null) @Name = (IfcIdentifier)value;
					 break;
				case 1:
					 @Description = (IfcText?)value;
					 break;
				case 2:
					 @UpperBoundValue = (IfcValue)value;
					 break;
				case 3:
					 @LowerBoundValue = (IfcValue)value;
					 break;
				case 4:
					 @Unit = (IfcUnit)value;
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
					 if (value != null) @Name = (IfcIdentifier)value;
					 break;
				case "Description":
					 @Description = (IfcText?)value;
					 break;
				case "UpperBoundValue":
					 @UpperBoundValue = (IfcValue)value;
					 break;
				case "LowerBoundValue":
					 @LowerBoundValue = (IfcValue)value;
					 break;
				case "Unit":
					 @Unit = (IfcUnit)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion

		#region Where rules
		/*WR21:             (TYPEOF(UpperBoundValue) = TYPEOF(LowerBoundValue));*/
		/*WR22:	WR22 : EXISTS(UpperBoundValue) OR EXISTS(LowerBoundValue);*/
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