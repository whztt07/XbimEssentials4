// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 09:16:38
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.Kernel;
using Xbim.Ifc2x3.UtilityResource;
using Xbim.Ifc2x3.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc2x3.SharedBldgServiceElements
{
	[EntityName("IFCENERGYPROPERTIES")]
	public  partial class @IfcEnergyProperties : IfcPropertySetDefinition, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcEnergyProperties(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcEnergySequenceEnum _energySequence;
		private IfcLabel? _userDefinedEnergySequence;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Optional)]
		public IfcEnergySequenceEnum @EnergySequence 
		{ 
			get 
			{
				if(IsActivated) return _energySequence;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _energySequence;
			} 
			set
			{
				SetValue( v =>  _energySequence = v, _energySequence, value,  "EnergySequence");
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Optional)]
		public IfcLabel? @UserDefinedEnergySequence 
		{ 
			get 
			{
				if(IsActivated) return _userDefinedEnergySequence;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _userDefinedEnergySequence;
			} 
			set
			{
				SetValue( v =>  _userDefinedEnergySequence = v, _userDefinedEnergySequence, value,  "UserDefinedEnergySequence");
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
			"EnergySequence",
			"UserDefinedEnergySequence",
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
					return @EnergySequence;
				case 5: 
					return @UserDefinedEnergySequence;
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
				case "EnergySequence":  
					return @EnergySequence;
				case "UserDefinedEnergySequence":  
					return @UserDefinedEnergySequence;
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
					 @EnergySequence = (IfcEnergySequenceEnum)value;
					 break;
				case 5:
					 @UserDefinedEnergySequence = (IfcLabel?)value;
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
				case "EnergySequence":
					 @EnergySequence = (IfcEnergySequenceEnum)value;
					 break;
				case "UserDefinedEnergySequence":
					 @UserDefinedEnergySequence = (IfcLabel?)value;
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