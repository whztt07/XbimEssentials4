// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		09/09/2015 04:20:40
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
	[EntityName("IFCCOMPLEXPROPERTYTEMPLATE", 108)]
	public  partial class @IfcComplexPropertyTemplate : IfcPropertyTemplate, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcComplexPropertyTemplate(IModel model) : base(model) 		{ 
			Model = model; 
			_hasPropertyTemplates = new ItemSet<IfcPropertyTemplate>( model );
		}

		#region Explicit attribute fields
		private IfcLabel? _usageName;
		private IfcComplexPropertyTemplateTypeEnum? _templateType;
		private ItemSet<IfcPropertyTemplate> _hasPropertyTemplates;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Optional)]
		public IfcLabel? @UsageName 
		{ 
			get 
			{
				if(Activated) return _usageName;
				
				Model.Activate(this, true);
				Activated = true;
				return _usageName;
			} 
			set
			{
				SetValue( v =>  _usageName = v, _usageName, value,  "UsageName");
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Optional)]
		public IfcComplexPropertyTemplateTypeEnum? @TemplateType 
		{ 
			get 
			{
				if(Activated) return _templateType;
				
				Model.Activate(this, true);
				Activated = true;
				return _templateType;
			} 
			set
			{
				SetValue( v =>  _templateType = v, _templateType, value,  "TemplateType");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Optional)]
		public ItemSet<IfcPropertyTemplate> @HasPropertyTemplates 
		{ 
			get 
			{
				if(Activated) return _hasPropertyTemplates;
				
				Model.Activate(this, true);
				Activated = true;
				return _hasPropertyTemplates;
			} 
			set
			{
				SetValue( v =>  _hasPropertyTemplates = v, _hasPropertyTemplates, value,  "HasPropertyTemplates");
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
			"UsageName",
			"TemplateType",
			"HasPropertyTemplates",
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
					return @UsageName;
				case 5: 
					return @TemplateType;
				case 6: 
					return @HasPropertyTemplates;
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
				case "UsageName":  
					return @UsageName;
				case "TemplateType":  
					return @TemplateType;
				case "HasPropertyTemplates":  
					return @HasPropertyTemplates;
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
					 @UsageName = (IfcLabel?)value;
					 break;
				case 5:
					 @TemplateType = (IfcComplexPropertyTemplateTypeEnum?)value;
					 break;
				case 6:
					 @HasPropertyTemplates.Add((IfcPropertyTemplate)value);
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
				case "UsageName":
					 @UsageName = (IfcLabel?)value;
					 break;
				case "TemplateType":
					 @TemplateType = (IfcComplexPropertyTemplateTypeEnum?)value;
					 break;
				case "HasPropertyTemplates":
					 @HasPropertyTemplates.Add((IfcPropertyTemplate)value);
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion

		#region Where rules
		/*UniquePropertyNames:	UniquePropertyNames : IfcUniquePropertyTemplateNames(HasPropertyTemplates);*/
		/*NoSelfReference:	NoSelfReference : SIZEOF(QUERY(temp <* HasPropertyTemplates | SELF :=: temp)) = 0;*/
		#endregion

		#region IPersist implementation
		void IPersist.Set(int propIndex, IPropertyValue value)
		{
            throw new System.NotImplementedException();
		}
		#endregion

		public  override string WhereRule() 
		{
			return "";
		}
	}
}