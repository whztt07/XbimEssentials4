// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.UtilityResource;
using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.PropertyResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.Kernel
{
	[IndexedClass]
	[ExpressType("IFCSIMPLEPROPERTYTEMPLATE", 983)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcSimplePropertyTemplate : IfcPropertyTemplate, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcSimplePropertyTemplate(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcSimplePropertyTemplateTypeEnum? _templateType;
		private IfcLabel? _primaryMeasureType;
		private IfcLabel? _secondaryMeasureType;
		private IfcPropertyEnumeration _enumerators;
		private IfcUnit _primaryUnit;
		private IfcUnit _secondaryUnit;
		private IfcLabel? _expression;
		private IfcStateEnum? _accessState;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcSimplePropertyTemplateTypeEnum? @TemplateType 
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
		public IfcLabel? @PrimaryMeasureType 
		{ 
			get 
			{
				if(Activated) return _primaryMeasureType;
				
				Model.Activate(this, true);
				Activated = true;
				return _primaryMeasureType;
			} 
			set
			{
				SetValue( v =>  _primaryMeasureType = v, _primaryMeasureType, value,  "PrimaryMeasureType");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel? @SecondaryMeasureType 
		{ 
			get 
			{
				if(Activated) return _secondaryMeasureType;
				
				Model.Activate(this, true);
				Activated = true;
				return _secondaryMeasureType;
			} 
			set
			{
				SetValue( v =>  _secondaryMeasureType = v, _secondaryMeasureType, value,  "SecondaryMeasureType");
			} 
		}
	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcPropertyEnumeration @Enumerators 
		{ 
			get 
			{
				if(Activated) return _enumerators;
				
				Model.Activate(this, true);
				Activated = true;
				return _enumerators;
			} 
			set
			{
				SetValue( v =>  _enumerators = v, _enumerators, value,  "Enumerators");
			} 
		}
	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcUnit @PrimaryUnit 
		{ 
			get 
			{
				if(Activated) return _primaryUnit;
				
				Model.Activate(this, true);
				Activated = true;
				return _primaryUnit;
			} 
			set
			{
				SetValue( v =>  _primaryUnit = v, _primaryUnit, value,  "PrimaryUnit");
			} 
		}
	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcUnit @SecondaryUnit 
		{ 
			get 
			{
				if(Activated) return _secondaryUnit;
				
				Model.Activate(this, true);
				Activated = true;
				return _secondaryUnit;
			} 
			set
			{
				SetValue( v =>  _secondaryUnit = v, _secondaryUnit, value,  "SecondaryUnit");
			} 
		}
	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel? @Expression 
		{ 
			get 
			{
				if(Activated) return _expression;
				
				Model.Activate(this, true);
				Activated = true;
				return _expression;
			} 
			set
			{
				SetValue( v =>  _expression = v, _expression, value,  "Expression");
			} 
		}
	
		[EntityAttribute(12, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcStateEnum? @AccessState 
		{ 
			get 
			{
				if(Activated) return _accessState;
				
				Model.Activate(this, true);
				Activated = true;
				return _accessState;
			} 
			set
			{
				SetValue( v =>  _accessState = v, _accessState, value,  "AccessState");
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
                    _templateType = (IfcSimplePropertyTemplateTypeEnum) System.Enum.Parse(typeof (IfcSimplePropertyTemplateTypeEnum), value.EnumVal, true);
					return;
				case 5: 
					_primaryMeasureType = value.StringVal;
					return;
				case 6: 
					_secondaryMeasureType = value.StringVal;
					return;
				case 7: 
					_enumerators = (IfcPropertyEnumeration)(value.EntityVal);
					return;
				case 8: 
					_primaryUnit = (IfcUnit)(value.EntityVal);
					return;
				case 9: 
					_secondaryUnit = (IfcUnit)(value.EntityVal);
					return;
				case 10: 
					_expression = value.StringVal;
					return;
				case 11: 
                    _accessState = (IfcStateEnum) System.Enum.Parse(typeof (IfcStateEnum), value.EnumVal, true);
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