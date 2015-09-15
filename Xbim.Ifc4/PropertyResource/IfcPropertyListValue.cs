// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		15.09.2015 07:03:40
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc4.PropertyResource
{
	[EntityName("IFCPROPERTYLISTVALUE", 464)]
	public  partial class @IfcPropertyListValue : IfcSimpleProperty, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPropertyListValue(IModel model) : base(model) 		{ 
			Model = model; 
			_listValues = new ItemSet<IfcValue>( model );
		}

		#region Explicit attribute fields
		private ItemSet<IfcValue> _listValues;
		private IfcUnit _unit;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Optional)]
		public ItemSet<IfcValue> @ListValues 
		{ 
			get 
			{
				if(Activated) return _listValues;
				
				Model.Activate(this, true);
				Activated = true;
				return _listValues;
			} 
			set
			{
				SetValue( v =>  _listValues = v, _listValues, value,  "ListValues");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Optional)]
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
			"ListValues",
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
					return @ListValues;
				case 3: 
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
				case "ListValues":  
					return @ListValues;
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
					 @ListValues.Add((IfcValue)value);
					 break;
				case 3:
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
				case "ListValues":
					 @ListValues.Add((IfcValue)value);
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
		/*WR31:               )) = 0;*/
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