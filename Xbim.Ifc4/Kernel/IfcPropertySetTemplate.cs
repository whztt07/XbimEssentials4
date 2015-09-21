// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		21.09.2015 05:11:20
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
	[ExpressType("IFCPROPERTYSETTEMPLATE", 859)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcPropertySetTemplate : IfcPropertyTemplateDefinition, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPropertySetTemplate(IModel model) : base(model) 		{ 
			Model = model; 
			_hasPropertyTemplates = new ItemSet<IfcPropertyTemplate>( this );
		}

		#region Explicit attribute fields
		private IfcPropertySetTemplateTypeEnum? _templateType;
		private IfcIdentifier? _applicableEntity;
		private ItemSet<IfcPropertyTemplate> _hasPropertyTemplates;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcPropertySetTemplateTypeEnum? @TemplateType 
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
	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcIdentifier? @ApplicableEntity 
		{ 
			get 
			{
				if(Activated) return _applicableEntity;
				
				Model.Activate(this, true);
				Activated = true;
				return _applicableEntity;
			} 
			set
			{
				SetValue( v =>  _applicableEntity = v, _applicableEntity, value,  "ApplicableEntity");
			} 
		}
	
		[IndexedProperty]
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1)]
		public ItemSet<IfcPropertyTemplate> @HasPropertyTemplates 
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

		#region Inverse attributes
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcRelDefinesByTemplate> @Defines 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelDefinesByTemplate>(e => e.RelatingTemplate == this);
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
                    _templateType = (IfcPropertySetTemplateTypeEnum) System.Enum.Parse(typeof (IfcPropertySetTemplateTypeEnum), value.EnumVal, true);
					return;
				case 5: 
					_applicableEntity = value.StringVal;
					return;
				case 6: 
					if (_hasPropertyTemplates == null) _hasPropertyTemplates = new ItemSet<IfcPropertyTemplate>( this );
					_hasPropertyTemplates.InternalAdd((IfcPropertyTemplate)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*ExistsName:	ExistsName : EXISTS(SELF\IfcRoot.Name);*/
		/*UniquePropertyNames:	UniquePropertyNames : IfcUniquePropertyTemplateNames(HasPropertyTemplates);*/
		}
		#endregion
	}
}