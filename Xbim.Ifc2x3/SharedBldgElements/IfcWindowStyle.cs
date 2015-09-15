// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		15.09.2015 07:04:19
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.Kernel;
using Xbim.Ifc2x3.UtilityResource;
using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.GeometryResource;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc2x3.SharedBldgElements
{
	[EntityName("IFCWINDOWSTYLE", 345)]
	public  partial class @IfcWindowStyle : IfcTypeProduct, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcWindowStyle(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcWindowStyleConstructionEnum _constructionType;
		private IfcWindowStyleOperationEnum _operationType;
		private bool _parameterTakesPrecedence;
		private bool _sizeable;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(8, EntityAttributeState.Mandatory)]
		public IfcWindowStyleConstructionEnum @ConstructionType 
		{ 
			get 
			{
				if(Activated) return _constructionType;
				
				Model.Activate(this, true);
				Activated = true;
				return _constructionType;
			} 
			set
			{
				SetValue( v =>  _constructionType = v, _constructionType, value,  "ConstructionType");
			} 
		}
	
		[EntityAttribute(9, EntityAttributeState.Mandatory)]
		public IfcWindowStyleOperationEnum @OperationType 
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
	
		[EntityAttribute(10, EntityAttributeState.Mandatory)]
		public bool @ParameterTakesPrecedence 
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
	
		[EntityAttribute(11, EntityAttributeState.Mandatory)]
		public bool @Sizeable 
		{ 
			get 
			{
				if(Activated) return _sizeable;
				
				Model.Activate(this, true);
				Activated = true;
				return _sizeable;
			} 
			set
			{
				SetValue( v =>  _sizeable = v, _sizeable, value,  "Sizeable");
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
			"ConstructionType",
			"OperationType",
			"ParameterTakesPrecedence",
			"Sizeable",
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
					return @ConstructionType;
				case 9: 
					return @OperationType;
				case 10: 
					return @ParameterTakesPrecedence;
				case 11: 
					return @Sizeable;
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
				case "ConstructionType":  
					return @ConstructionType;
				case "OperationType":  
					return @OperationType;
				case "ParameterTakesPrecedence":  
					return @ParameterTakesPrecedence;
				case "Sizeable":  
					return @Sizeable;
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
					 @ApplicableOccurrence = (IfcLabel?)value;
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
					 if (value != null) @ConstructionType = (IfcWindowStyleConstructionEnum)value;
					 break;
				case 9:
					 if (value != null) @OperationType = (IfcWindowStyleOperationEnum)value;
					 break;
				case 10:
					 if (value != null) @ParameterTakesPrecedence = (bool)value;
					 break;
				case 11:
					 if (value != null) @Sizeable = (bool)value;
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
					 @ApplicableOccurrence = (IfcLabel?)value;
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
				case "ConstructionType":
					 if (value != null) @ConstructionType = (IfcWindowStyleConstructionEnum)value;
					 break;
				case "OperationType":
					 if (value != null) @OperationType = (IfcWindowStyleOperationEnum)value;
					 break;
				case "ParameterTakesPrecedence":
					 if (value != null) @ParameterTakesPrecedence = (bool)value;
					 break;
				case "Sizeable":
					 if (value != null) @Sizeable = (bool)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion


		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
            throw new System.NotImplementedException();
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		}
		#endregion

		
	}
}