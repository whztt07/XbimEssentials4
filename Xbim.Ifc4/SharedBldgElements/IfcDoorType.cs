// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 02:29:21
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.ProductExtension;
using Xbim.Ifc4.UtilityResource;
using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.Kernel;
using Xbim.Ifc4.GeometryResource;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc4.SharedBldgElements
{
	[EntityName("IFCDOORTYPE", 195)]
	public  partial class @IfcDoorType : IfcBuildingElementType, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcDoorType(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcDoorTypeEnum _predefinedType;
		private IfcDoorTypeOperationEnum _operationType;
		private bool? _parameterTakesPrecedence;
		private IfcLabel? _userDefinedOperationType;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(9, EntityAttributeState.Mandatory)]
		public IfcDoorTypeEnum @PredefinedType 
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
	
		[EntityAttribute(10, EntityAttributeState.Mandatory)]
		public IfcDoorTypeOperationEnum @OperationType 
		{ 
			get 
			{
				if(Activated) return _operationType;
				
				Model.Activate(this, true);
				Activated = true;
				return _operationType;
			} 
			set
			{
				SetValue( v =>  _operationType = v, _operationType, value,  "OperationType");
			} 
		}
	
		[EntityAttribute(11, EntityAttributeState.Optional)]
		public bool? @ParameterTakesPrecedence 
		{ 
			get 
			{
				if(Activated) return _parameterTakesPrecedence;
				
				Model.Activate(this, true);
				Activated = true;
				return _parameterTakesPrecedence;
			} 
			set
			{
				SetValue( v =>  _parameterTakesPrecedence = v, _parameterTakesPrecedence, value,  "ParameterTakesPrecedence");
			} 
		}
	
		[EntityAttribute(12, EntityAttributeState.Optional)]
		public IfcLabel? @UserDefinedOperationType 
		{ 
			get 
			{
				if(Activated) return _userDefinedOperationType;
				
				Model.Activate(this, true);
				Activated = true;
				return _userDefinedOperationType;
			} 
			set
			{
				SetValue( v =>  _userDefinedOperationType = v, _userDefinedOperationType, value,  "UserDefinedOperationType");
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
			"RepresentationMaps",
			"Tag",
			"ElementType",
			"PredefinedType",
			"OperationType",
			"ParameterTakesPrecedence",
			"UserDefinedOperationType",
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
					return @RepresentationMaps;
				case 7: 
					return @Tag;
				case 8: 
					return @ElementType;
				case 9: 
					return @PredefinedType;
				case 10: 
					return @OperationType;
				case 11: 
					return @ParameterTakesPrecedence;
				case 12: 
					return @UserDefinedOperationType;
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
				case "RepresentationMaps":  
					return @RepresentationMaps;
				case "Tag":  
					return @Tag;
				case "ElementType":  
					return @ElementType;
				case "PredefinedType":  
					return @PredefinedType;
				case "OperationType":  
					return @OperationType;
				case "ParameterTakesPrecedence":  
					return @ParameterTakesPrecedence;
				case "UserDefinedOperationType":  
					return @UserDefinedOperationType;
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
					 @RepresentationMaps.Add((IfcRepresentationMap)value);
					 break;
				case 7:
					 @Tag = (IfcLabel?)value;
					 break;
				case 8:
					 @ElementType = (IfcLabel?)value;
					 break;
				case 9:
					 if (value != null) @PredefinedType = (IfcDoorTypeEnum)value;
					 break;
				case 10:
					 if (value != null) @OperationType = (IfcDoorTypeOperationEnum)value;
					 break;
				case 11:
					 @ParameterTakesPrecedence = (bool?)value;
					 break;
				case 12:
					 @UserDefinedOperationType = (IfcLabel?)value;
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
				case "RepresentationMaps":
					 @RepresentationMaps.Add((IfcRepresentationMap)value);
					 break;
				case "Tag":
					 @Tag = (IfcLabel?)value;
					 break;
				case "ElementType":
					 @ElementType = (IfcLabel?)value;
					 break;
				case "PredefinedType":
					 if (value != null) @PredefinedType = (IfcDoorTypeEnum)value;
					 break;
				case "OperationType":
					 if (value != null) @OperationType = (IfcDoorTypeOperationEnum)value;
					 break;
				case "ParameterTakesPrecedence":
					 @ParameterTakesPrecedence = (bool?)value;
					 break;
				case "UserDefinedOperationType":
					 @UserDefinedOperationType = (IfcLabel?)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion

		#region Where rules
		/*CorrectPredefinedType:                              ((PredefinedType = IfcDoorTypeEnum.USERDEFINED) AND EXISTS(SELF\IfcElementType.ElementType));*/
		#endregion

		#region IPersist implementation
		void IPersist.Set(int propIndex, IPropertyValue value)
		{
            throw new System.NotImplementedException();
		}
		#endregion

	}
}