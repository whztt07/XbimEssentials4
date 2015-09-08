// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 09:16:43
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc4.MeasureResource
{
	[EntityName("IFCSIUNIT")]
	public  partial class @IfcSIUnit : IfcNamedUnit, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcSIUnit(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcSIPrefix _prefix;
		private IfcSIUnitName _name;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Optional)]
		public IfcSIPrefix @Prefix 
		{ 
			get 
			{
				if(IsActivated) return _prefix;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _prefix;
			} 
			set
			{
				SetValue( v =>  _prefix = v, _prefix, value,  "Prefix");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Mandatory)]
		public IfcSIUnitName @Name 
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
	
		#endregion

		#region Inverse attributes

		#endregion

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"Dimensions",
			"UnitType",
			"Prefix",
			"Name",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @Dimensions;
				case 1: 
					return @UnitType;
				case 2: 
					return @Prefix;
				case 3: 
					return @Name;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "Dimensions":  
					return @Dimensions;
				case "UnitType":  
					return @UnitType;
				case "Prefix":  
					return @Prefix;
				case "Name":  
					return @Name;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 @Dimensions = (IfcDimensionalExponents)value;
					 break;
				case 1:
					 if (value != null) @UnitType = (IfcUnitEnum)value;
					 break;
				case 2:
					 @Prefix = (IfcSIPrefix)value;
					 break;
				case 3:
					 if (value != null) @Name = (IfcSIUnitName)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "Dimensions":
					 @Dimensions = (IfcDimensionalExponents)value;
					 break;
				case "UnitType":
					 if (value != null) @UnitType = (IfcUnitEnum)value;
					 break;
				case "Prefix":
					 @Prefix = (IfcSIPrefix)value;
					 break;
				case "Name":
					 if (value != null) @Name = (IfcSIUnitName)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion


		#region IPersist implementation
		public void Set(int propIndex, IPropertyValue value)
		{
            throw new System.NotImplementedException();
		}
		#endregion

	}
}