// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 02:29:23
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Kernel;
using Xbim.Ifc4.UtilityResource;
using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.ProfileResource;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc4.StructuralElementsDomain
{
	[EntityName("IFCREINFORCEMENTDEFINITIONPROPERTIES", 503)]
	public  partial class @IfcReinforcementDefinitionProperties : IfcPreDefinedPropertySet, IInstantiableEntity
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
		private readonly List<string> _attributeNames = new List<string>
		{
			"GlobalId",
			"OwnerHistory",
			"Name",
			"Description",
			"DefinitionType",
			"ReinforcementSectionDefinitions",
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
		void IPersist.Set(int propIndex, IPropertyValue value)
		{
            throw new System.NotImplementedException();
		}
		#endregion

	}
}