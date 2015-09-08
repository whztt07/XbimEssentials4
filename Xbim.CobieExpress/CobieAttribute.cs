// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 02:29:26
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.CobieExpress
{
	[EntityName("ATTRIBUTE", 25)]
	public  partial class @CobieAttribute : CobieExternalReference, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal CobieAttribute(IModel model) : base(model) 		{ 
			Model = model; 
			_allowedValues = new ItemSet<string>( model );
		}

		#region Explicit attribute fields
		private string _name;
		private string _description;
		private CobiePickValue _stage;
		private AttributeValue _value;
		private string _unit;
		private ItemSet<string> _allowedValues;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(5, EntityAttributeState.Mandatory)]
		public string @Name 
		{ 
			get 
			{
				if(Activated) return _name;
				
				Model.Activate(this, true);
				Activated = true;
				return _name;
			} 
			set
			{
				SetValue( v =>  _name = v, _name, value,  "Name");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Optional)]
		public string @Description 
		{ 
			get 
			{
				if(Activated) return _description;
				
				Model.Activate(this, true);
				Activated = true;
				return _description;
			} 
			set
			{
				SetValue( v =>  _description = v, _description, value,  "Description");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Mandatory)]
		public CobiePickValue @Stage 
		{ 
			get 
			{
				if(Activated) return _stage;
				
				Model.Activate(this, true);
				Activated = true;
				return _stage;
			} 
			set
			{
				SetValue( v =>  _stage = v, _stage, value,  "Stage");
			} 
		}
	
		[EntityAttribute(8, EntityAttributeState.Mandatory)]
		public AttributeValue @Value 
		{ 
			get 
			{
				if(Activated) return _value;
				
				Model.Activate(this, true);
				Activated = true;
				return _value;
			} 
			set
			{
				SetValue( v =>  _value = v, _value, value,  "Value");
			} 
		}
	
		[EntityAttribute(9, EntityAttributeState.Optional)]
		public string @Unit 
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
	
		[EntityAttribute(10, EntityAttributeState.Optional)]
		public ItemSet<string> @AllowedValues 
		{ 
			get 
			{
				if(Activated) return _allowedValues;
				
				Model.Activate(this, true);
				Activated = true;
				return _allowedValues;
			} 
			set
			{
				SetValue( v =>  _allowedValues = v, _allowedValues, value,  "AllowedValues");
			} 
		}
	
		#endregion

		#region Inverse attributes

		#endregion

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"Created",
			"ExternalSystem",
			"ExternalObject",
			"ExternalId",
			"LocalId",
			"Name",
			"Description",
			"Stage",
			"Value",
			"Unit",
			"AllowedValues",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @Created;
				case 1: 
					return @ExternalSystem;
				case 2: 
					return @ExternalObject;
				case 3: 
					return @ExternalId;
				case 4: 
					return @LocalId;
				case 5: 
					return @Name;
				case 6: 
					return @Description;
				case 7: 
					return @Stage;
				case 8: 
					return @Value;
				case 9: 
					return @Unit;
				case 10: 
					return @AllowedValues;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "Created":  
					return @Created;
				case "ExternalSystem":  
					return @ExternalSystem;
				case "ExternalObject":  
					return @ExternalObject;
				case "ExternalId":  
					return @ExternalId;
				case "LocalId":  
					return @LocalId;
				case "Name":  
					return @Name;
				case "Description":  
					return @Description;
				case "Stage":  
					return @Stage;
				case "Value":  
					return @Value;
				case "Unit":  
					return @Unit;
				case "AllowedValues":  
					return @AllowedValues;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 @Created = (CobieCreatedInfo)value;
					 break;
				case 1:
					 @ExternalSystem = (CobieExternalSystem)value;
					 break;
				case 2:
					 @ExternalObject = (string)value;
					 break;
				case 3:
					 @ExternalId = (string)value;
					 break;
				case 4:
					 if (value != null) @LocalId = (int)value;
					 break;
				case 5:
					 @Name = (string)value;
					 break;
				case 6:
					 @Description = (string)value;
					 break;
				case 7:
					 @Stage = (CobiePickValue)value;
					 break;
				case 8:
					 @Value = (AttributeValue)value;
					 break;
				case 9:
					 @Unit = (string)value;
					 break;
				case 10:
					 @AllowedValues.Add((string)value);
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "Created":
					 @Created = (CobieCreatedInfo)value;
					 break;
				case "ExternalSystem":
					 @ExternalSystem = (CobieExternalSystem)value;
					 break;
				case "ExternalObject":
					 @ExternalObject = (string)value;
					 break;
				case "ExternalId":
					 @ExternalId = (string)value;
					 break;
				case "LocalId":
					 if (value != null) @LocalId = (int)value;
					 break;
				case "Name":
					 @Name = (string)value;
					 break;
				case "Description":
					 @Description = (string)value;
					 break;
				case "Stage":
					 @Stage = (CobiePickValue)value;
					 break;
				case "Value":
					 @Value = (AttributeValue)value;
					 break;
				case "Unit":
					 @Unit = (string)value;
					 break;
				case "AllowedValues":
					 @AllowedValues.Add((string)value);
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion


		#region IPersist implementation
		void IPersist.Set(int propIndex, IPropertyValue value)
		{
            throw new System.NotImplementedException();
		}
		#endregion

	}
}