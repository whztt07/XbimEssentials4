// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		16.09.2015 10:12:20
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
	[EntityName("IFCREINFORCEMENTDEFINITIONPROPERTIES", 263)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcReinforcementDefinitionProperties : IfcPropertySetDefinition, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcReinforcementDefinitionProperties(IModel model) : base(model) 		{ 
			Model = model; 
			_reinforcementSectionDefinitions = new ItemSet<IfcSectionReinforcementProperties>( model );
		}

		#region Explicit attribute fields
		private IfcLabel? _definitionType;
		private ItemSet<IfcSectionReinforcementProperties> _reinforcementSectionDefinitions;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Optional)]
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
	
		[EntityAttribute(5, EntityAttributeState.Mandatory)]
		public ItemSet<IfcSectionReinforcementProperties> @ReinforcementSectionDefinitions 
		{ 
			get 
			{
				if(Activated) return _reinforcementSectionDefinitions;
				
				Model.Activate(this, true);
				Activated = true;
				return _reinforcementSectionDefinitions;
			} 
			set
			{
				SetValue( v =>  _reinforcementSectionDefinitions = v, _reinforcementSectionDefinitions, value,  "ReinforcementSectionDefinitions");
			} 
		}
	
		#endregion

		#region Inverse attributes

		#endregion

		#region Index access
		private static readonly List<string> AttributeNames = new List<string>
		{
			"GlobalId",
			"OwnerHistory",
			"Name",
			"Description",
			"DefinitionType",
			"ReinforcementSectionDefinitions",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return AttributeNames; } }

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
					return @DefinitionType;
				case 5: 
					return @ReinforcementSectionDefinitions;
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
				case "DefinitionType":  
					return @DefinitionType;
				case "ReinforcementSectionDefinitions":  
					return @ReinforcementSectionDefinitions;
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
					 @DefinitionType = (IfcLabel?)value;
					 break;
				case 5:
					 @ReinforcementSectionDefinitions.Add((IfcSectionReinforcementProperties)value);
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
				case "DefinitionType":
					 @DefinitionType = (IfcLabel?)value;
					 break;
				case "ReinforcementSectionDefinitions":
					 @ReinforcementSectionDefinitions.Add((IfcSectionReinforcementProperties)value);
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
					base.Parse(propIndex, value); 
					return;
				case 4: 
					_definitionType = value.StringVal;
					return;
				case 5: 
					if (_reinforcementSectionDefinitions == null) _reinforcementSectionDefinitions = new ItemSet<IfcSectionReinforcementProperties>( Model );
					_reinforcementSectionDefinitions.Add((IfcSectionReinforcementProperties)value.EntityVal);
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