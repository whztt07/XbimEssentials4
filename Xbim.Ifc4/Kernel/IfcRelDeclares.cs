// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 09:16:43
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.UtilityResource;
using Xbim.Ifc4.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc4.Kernel
{
	[EntityName("IFCRELDECLARES")]
	public  partial class @IfcRelDeclares : IfcRelationship, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelDeclares(IModel model) : base(model) 		{ 
			Model = model; 
			_relatedDefinitions = new ItemSet<IfcDefinitionSelect>( model );
		}

		#region Explicit attribute fields
		private IfcContext _relatingContext;
		private ItemSet<IfcDefinitionSelect> _relatedDefinitions;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Mandatory)]
		public IfcContext @RelatingContext 
		{ 
			get 
			{
				if(IsActivated) return _relatingContext;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _relatingContext;
			} 
			set
			{
				SetValue( v =>  _relatingContext = v, _relatingContext, value,  "RelatingContext");
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Mandatory)]
		public ItemSet<IfcDefinitionSelect> @RelatedDefinitions 
		{ 
			get 
			{
				if(IsActivated) return _relatedDefinitions;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _relatedDefinitions;
			} 
			set
			{
				SetValue( v =>  _relatedDefinitions = v, _relatedDefinitions, value,  "RelatedDefinitions");
			} 
		}
	
		#endregion

		#region Inverse attributes

		#endregion

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"GlobalId",
			"OwnerHistory",
			"Name",
			"Description",
			"RelatingContext",
			"RelatedDefinitions",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @GlobalId;
				case 1: 
					return @OwnerHistory;
				case 2: 
					return @Name;
				case 3: 
					return @Description;
				case 4: 
					return @RelatingContext;
				case 5: 
					return @RelatedDefinitions;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "GlobalId":  
					return @GlobalId;
				case "OwnerHistory":  
					return @OwnerHistory;
				case "Name":  
					return @Name;
				case "Description":  
					return @Description;
				case "RelatingContext":  
					return @RelatingContext;
				case "RelatedDefinitions":  
					return @RelatedDefinitions;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 if (value != null) @GlobalId = (IfcGloballyUniqueId)value;
					 break;
				case 1:
					 @OwnerHistory = (IfcOwnerHistory)value;
					 break;
				case 2:
					 @Name = (IfcLabel?)value;
					 break;
				case 3:
					 @Description = (IfcText?)value;
					 break;
				case 4:
					 @RelatingContext = (IfcContext)value;
					 break;
				case 5:
					 @RelatedDefinitions.Add((IfcDefinitionSelect)value);
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "GlobalId":
					 if (value != null) @GlobalId = (IfcGloballyUniqueId)value;
					 break;
				case "OwnerHistory":
					 @OwnerHistory = (IfcOwnerHistory)value;
					 break;
				case "Name":
					 @Name = (IfcLabel?)value;
					 break;
				case "Description":
					 @Description = (IfcText?)value;
					 break;
				case "RelatingContext":
					 @RelatingContext = (IfcContext)value;
					 break;
				case "RelatedDefinitions":
					 @RelatedDefinitions.Add((IfcDefinitionSelect)value);
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion

		#region Where rules
		/*NoSelfReference:	NoSelfReference : SIZEOF(QUERY(Temp <* RelatedDefinitions | RelatingContext :=: Temp)) = 0;*/
		#endregion

		#region IPersist implementation
		public void Set(int propIndex, IPropertyValue value)
		{
            throw new System.NotImplementedException();
		}
		#endregion

	}
}