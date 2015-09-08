// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 02:29:20
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.UtilityResource;
using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.QuantityResource;
using Xbim.Ifc4.Kernel;
using Xbim.Ifc4.CostResource;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc4.ConstructionMgmtDomain
{
	[EntityName("IFCCREWRESOURCETYPE", 153)]
	public  partial class @IfcCrewResourceType : IfcConstructionResourceType, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcCrewResourceType(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcCrewResourceTypeEnum _predefinedType;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(11, EntityAttributeState.Mandatory)]
		public IfcCrewResourceTypeEnum @PredefinedType 
		{ 
			get 
			{
				if(Activated) return _predefinedType;
				
				Model.Activate(this, true);
				Activated = true;
				return _predefinedType;
			} 
			set
			{
				SetValue( v =>  _predefinedType = v, _predefinedType, value,  "PredefinedType");
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
			"ApplicableOccurrence",
			"HasPropertySets",
			"Identification",
			"LongDescription",
			"ResourceType",
			"BaseCosts",
			"BaseQuantity",
			"PredefinedType",
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
					return @ApplicableOccurrence;
				case 5: 
					return @HasPropertySets;
				case 6: 
					return @Identification;
				case 7: 
					return @LongDescription;
				case 8: 
					return @ResourceType;
				case 9: 
					return @BaseCosts;
				case 10: 
					return @BaseQuantity;
				case 11: 
					return @PredefinedType;
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
				case "ApplicableOccurrence":  
					return @ApplicableOccurrence;
				case "HasPropertySets":  
					return @HasPropertySets;
				case "Identification":  
					return @Identification;
				case "LongDescription":  
					return @LongDescription;
				case "ResourceType":  
					return @ResourceType;
				case "BaseCosts":  
					return @BaseCosts;
				case "BaseQuantity":  
					return @BaseQuantity;
				case "PredefinedType":  
					return @PredefinedType;
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
					 @ApplicableOccurrence = (IfcIdentifier?)value;
					 break;
				case 5:
					 @HasPropertySets.Add((IfcPropertySetDefinition)value);
					 break;
				case 6:
					 @Identification = (IfcIdentifier?)value;
					 break;
				case 7:
					 @LongDescription = (IfcText?)value;
					 break;
				case 8:
					 @ResourceType = (IfcLabel?)value;
					 break;
				case 9:
					 @BaseCosts.Add((IfcAppliedValue)value);
					 break;
				case 10:
					 @BaseQuantity = (IfcPhysicalQuantity)value;
					 break;
				case 11:
					 if (value != null) @PredefinedType = (IfcCrewResourceTypeEnum)value;
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
				case "ApplicableOccurrence":
					 @ApplicableOccurrence = (IfcIdentifier?)value;
					 break;
				case "HasPropertySets":
					 @HasPropertySets.Add((IfcPropertySetDefinition)value);
					 break;
				case "Identification":
					 @Identification = (IfcIdentifier?)value;
					 break;
				case "LongDescription":
					 @LongDescription = (IfcText?)value;
					 break;
				case "ResourceType":
					 @ResourceType = (IfcLabel?)value;
					 break;
				case "BaseCosts":
					 @BaseCosts.Add((IfcAppliedValue)value);
					 break;
				case "BaseQuantity":
					 @BaseQuantity = (IfcPhysicalQuantity)value;
					 break;
				case "PredefinedType":
					 if (value != null) @PredefinedType = (IfcCrewResourceTypeEnum)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion

		#region Where rules
		/*CorrectPredefinedType:                              ((PredefinedType = IfcCrewResourceTypeEnum.USERDEFINED) AND EXISTS(SELF\IfcTypeResource.ResourceType));*/
		#endregion

		#region IPersist implementation
		void IPersist.Set(int propIndex, IPropertyValue value)
		{
            throw new System.NotImplementedException();
		}
		#endregion

	}
}