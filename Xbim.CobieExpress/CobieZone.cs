// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 09:16:44
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.CobieExpress
{
	[EntityName("ZONE")]
	public  partial class @CobieZone : CobieAsset, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal CobieZone(IModel model) : base(model) 		{ 
			Model = model; 
			_spaces = new ItemSet<CobieSpace>( model );
		}

		#region Explicit attribute fields
		private ItemSet<CobieSpace> _spaces;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(11, EntityAttributeState.Mandatory)]
		public ItemSet<CobieSpace> @Spaces 
		{ 
			get 
			{
				if(IsActivated) return _spaces;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _spaces;
			} 
			set
			{
				SetValue( v =>  _spaces = v, _spaces, value,  "Spaces");
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
			"Category",
			"Impacts",
			"Documents",
			"Attributes",
			"Spaces",
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
					return @Category;
				case 8: 
					return @Impacts;
				case 9: 
					return @Documents;
				case 10: 
					return @Attributes;
				case 11: 
					return @Spaces;
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
				case "Spaces":  
					return @Spaces;
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
					 @Spaces.Add((CobieSpace)value);
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
				case "Spaces":
					 @Spaces.Add((CobieSpace)value);
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