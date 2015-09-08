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

namespace Xbim.Ifc4.PropertyResource
{
	[EntityName("IFCPROPERTYENUMERATION")]
	public  partial class @IfcPropertyEnumeration : IfcPropertyAbstraction, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPropertyEnumeration(IModel model) : base(model) 		{ 
			Model = model; 
			_enumerationValues = new ItemSet<IfcValue>( model );
		}

		#region Explicit attribute fields
		private IfcLabel _name;
		private ItemSet<IfcValue> _enumerationValues;
		private IfcUnit _unit;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(0, EntityAttributeState.Mandatory)]
		public IfcLabel @Name 
		{ 
			get 
			{
				if(IsActivated) return _name;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _name;
			} 
			set
			{
				SetValue( v =>  _name = v, _name, value,  "Name");
			} 
		}
	
		[EntityAttribute(1, EntityAttributeState.Mandatory)]
		public ItemSet<IfcValue> @EnumerationValues 
		{ 
			get 
			{
				if(IsActivated) return _enumerationValues;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _enumerationValues;
			} 
			set
			{
				SetValue( v =>  _enumerationValues = v, _enumerationValues, value,  "EnumerationValues");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Optional)]
		public IfcUnit @Unit 
		{ 
			get 
			{
				if(IsActivated) return _unit;
				
				Model.Activate(this, true);
				IsActivated = true;
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
			"EnumerationValues",
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
					return @EnumerationValues;
				case 2: 
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
				case "EnumerationValues":  
					return @EnumerationValues;
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
					 if (value != null) @Name = (IfcLabel)value;
					 break;
				case 1:
					 @EnumerationValues.Add((IfcValue)value);
					 break;
				case 2:
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
					 if (value != null) @Name = (IfcLabel)value;
					 break;
				case "EnumerationValues":
					 @EnumerationValues.Add((IfcValue)value);
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
		/*WR01:               )) = 0;*/
		#endregion

		#region IPersist implementation
		public void Set(int propIndex, IPropertyValue value)
		{
            throw new System.NotImplementedException();
		}
		#endregion

	}
}