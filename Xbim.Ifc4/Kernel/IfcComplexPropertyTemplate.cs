// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		24.09.2015 10:03:40
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.UtilityResource;
using Xbim.Ifc4.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.Kernel
{
	[IndexedClass]
	[ExpressType("IFCCOMPLEXPROPERTYTEMPLATE", 499)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcComplexPropertyTemplate : IfcPropertyTemplate, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcComplexPropertyTemplate(IModel model) : base(model) 		{ 
			Model = model; 
			_hasPropertyTemplates = new OptionalItemSet<IfcPropertyTemplate>( this );
		}

		#region Explicit attribute fields
		private IfcLabel? _usageName;
		private IfcComplexPropertyTemplateTypeEnum? _templateType;
		private OptionalItemSet<IfcPropertyTemplate> _hasPropertyTemplates;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
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
	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
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
	
		[IndexedProperty]
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1)]
		public OptionalItemSet<IfcPropertyTemplate> @HasPropertyTemplates 
		{ 
			get 
			{
				if(Activated) return _hasPropertyTemplates;
				
				Model.Activate(this, true);
				Activated = true;
				return _hasPropertyTemplates;
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
					base.Parse(propIndex, value); 
					return;
				case 4: 
					_usageName = value.StringVal;
					return;
				case 5: 
                    _templateType = (IfcComplexPropertyTemplateTypeEnum) System.Enum.Parse(typeof (IfcComplexPropertyTemplateTypeEnum), value.EnumVal, true);
					return;
				case 6: 
					if (_hasPropertyTemplates == null) _hasPropertyTemplates = new OptionalItemSet<IfcPropertyTemplate>( this );
					_hasPropertyTemplates.InternalAdd((IfcPropertyTemplate)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*UniquePropertyNames:	UniquePropertyNames : IfcUniquePropertyTemplateNames(HasPropertyTemplates);*/
		/*NoSelfReference:	NoSelfReference : SIZEOF(QUERY(temp <* HasPropertyTemplates | SELF :=: temp)) = 0;*/
		}
		#endregion
	}
}