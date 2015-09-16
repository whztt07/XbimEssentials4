// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		16.09.2015 04:23:02
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.CobieExpress
{
	[EntityName("SYSTEM", 18)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @CobieSystem : CobieAsset, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal CobieSystem(IModel model) : base(model) 		{ 
			Model = model; 
			_components = new ItemSet<CobieComponent>( this );
		}

		#region Explicit attribute fields
		private ItemSet<CobieComponent> _components;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(11, EntityAttributeState.Mandatory)]
		public ItemSet<CobieComponent> @Components 
		{ 
			get 
			{
				if(Activated) return _components;
				
				Model.Activate(this, true);
				Activated = true;
				return _components;
			} 
			set
			{
				SetValue( v =>  _components = v, _components, value,  "Components");
			} 
		}
	
		#endregion

		#region Inverse attributes

		#endregion

		#region Index access
		private static readonly List<string> AttributeNames = new List<string>
		{
			"Created",
			"ExternalSystem",
			"ExternalObject",
			"ExternalId",
			"LocalId",
			"Name",
			"Description",
			"Category",
			"Impacts",
			"Documents",
			"Attributes",
			"Components",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return AttributeNames; } }

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
					return @Category;
				case 8: 
					return @Impacts;
				case 9: 
					return @Documents;
				case 10: 
					return @Attributes;
				case 11: 
					return @Components;
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
				case "Category":  
					return @Category;
				case "Impacts":  
					return @Impacts;
				case "Documents":  
					return @Documents;
				case "Attributes":  
					return @Attributes;
				case "Components":  
					return @Components;
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
					 if (value != null) @LocalId = (long)value;
					 break;
				case 5:
					 @Name = (string)value;
					 break;
				case 6:
					 @Description = (string)value;
					 break;
				case 7:
					 @Category.Add((CobiePickKeyValue)value);
					 break;
				case 8:
					 @Impacts.Add((CobieImpact)value);
					 break;
				case 9:
					 @Documents.Add((CobieDocument)value);
					 break;
				case 10:
					 @Attributes.Add((CobieAttribute)value);
					 break;
				case 11:
					 @Components.Add((CobieComponent)value);
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
					 if (value != null) @LocalId = (long)value;
					 break;
				case "Name":
					 @Name = (string)value;
					 break;
				case "Description":
					 @Description = (string)value;
					 break;
				case "Category":
					 @Category.Add((CobiePickKeyValue)value);
					 break;
				case "Impacts":
					 @Impacts.Add((CobieImpact)value);
					 break;
				case "Documents":
					 @Documents.Add((CobieDocument)value);
					 break;
				case "Attributes":
					 @Attributes.Add((CobieAttribute)value);
					 break;
				case "Components":
					 @Components.Add((CobieComponent)value);
					 break;
				default:
					throw new System.IndexOutOfRangeException();
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
				case 6: 
				case 7: 
				case 8: 
				case 9: 
				case 10: 
					base.Parse(propIndex, value); 
					return;
				case 11: 
					if (_components == null) _components = new ItemSet<CobieComponent>( this );
					_components.Add((CobieComponent)value.EntityVal);
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