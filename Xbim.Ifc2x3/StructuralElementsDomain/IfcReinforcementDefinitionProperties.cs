// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		22.09.2015 02:31:59
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.Kernel;
using Xbim.Ifc2x3.UtilityResource;
using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.ProfilePropertyResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.StructuralElementsDomain
{
	[IndexedClass]
	[ExpressType("IFCREINFORCEMENTDEFINITIONPROPERTIES", 263)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcReinforcementDefinitionProperties : IfcPropertySetDefinition, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcReinforcementDefinitionProperties(IModel model) : base(model) 		{ 
			Model = model; 
			_reinforcementSectionDefinitions = new ItemSet<IfcSectionReinforcementProperties>( this );
		}

		#region Explicit attribute fields
		private IfcLabel? _definitionType;
		private ItemSet<IfcSectionReinforcementProperties> _reinforcementSectionDefinitions;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel? @DefinitionType 
		{ 
			get 
			{
				if(Activated) return _definitionType;
				
				Model.Activate(this, true);
				Activated = true;
				return _definitionType;
			} 
			set
			{
				SetValue( v =>  _definitionType = v, _definitionType, value,  "DefinitionType");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.Class, 1, -1)]
		public ItemSet<IfcSectionReinforcementProperties> @ReinforcementSectionDefinitions 
		{ 
			get 
			{
				if(Activated) return _reinforcementSectionDefinitions;
				
				Model.Activate(this, true);
				Activated = true;
				return _reinforcementSectionDefinitions;
			} 
		}
	
		#endregion

		#region Inverse attributes

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
					_definitionType = value.StringVal;
					return;
				case 5: 
					if (_reinforcementSectionDefinitions == null) _reinforcementSectionDefinitions = new ItemSet<IfcSectionReinforcementProperties>( this );
					_reinforcementSectionDefinitions.InternalAdd((IfcSectionReinforcementProperties)value.EntityVal);
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