// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		09/09/2015 04:20:42
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.UtilityResource;
using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.Kernel;
using Xbim.Ifc4.GeometryResource;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc4.SharedComponentElements
{
	[EntityName("IFCMECHANICALFASTENERTYPE", 371)]
	public  partial class @IfcMechanicalFastenerType : IfcElementComponentType, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcMechanicalFastenerType(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcMechanicalFastenerTypeEnum _predefinedType;
		private IfcPositiveLengthMeasure? _nominalDiameter;
		private IfcPositiveLengthMeasure? _nominalLength;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(9, EntityAttributeState.Mandatory)]
		public IfcMechanicalFastenerTypeEnum @PredefinedType 
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
	
		[EntityAttribute(10, EntityAttributeState.Optional)]
		public IfcPositiveLengthMeasure? @NominalDiameter 
		{ 
			get 
			{
				if(Activated) return _nominalDiameter;
				
				Model.Activate(this, true);
				Activated = true;
				return _nominalDiameter;
			} 
			set
			{
				SetValue( v =>  _nominalDiameter = v, _nominalDiameter, value,  "NominalDiameter");
			} 
		}
	
		[EntityAttribute(11, EntityAttributeState.Optional)]
		public IfcPositiveLengthMeasure? @NominalLength 
		{ 
			get 
			{
				if(Activated) return _nominalLength;
				
				Model.Activate(this, true);
				Activated = true;
				return _nominalLength;
			} 
			set
			{
				SetValue( v =>  _nominalLength = v, _nominalLength, value,  "NominalLength");
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
			"NominalDiameter",
			"NominalLength",
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
					return @NominalDiameter;
				case 11: 
					return @NominalLength;
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
				case "NominalDiameter":  
					return @NominalDiameter;
				case "NominalLength":  
					return @NominalLength;
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
					 if (value != null) @PredefinedType = (IfcMechanicalFastenerTypeEnum)value;
					 break;
				case 10:
					 @NominalDiameter = (IfcPositiveLengthMeasure?)value;
					 break;
				case 11:
					 @NominalLength = (IfcPositiveLengthMeasure?)value;
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
					 if (value != null) @PredefinedType = (IfcMechanicalFastenerTypeEnum)value;
					 break;
				case "NominalDiameter":
					 @NominalDiameter = (IfcPositiveLengthMeasure?)value;
					 break;
				case "NominalLength":
					 @NominalLength = (IfcPositiveLengthMeasure?)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion

		#region Where rules
		/*CorrectPredefinedType:                              ((PredefinedType = IfcMechanicalFastenerTypeEnum.USERDEFINED) AND EXISTS(SELF\IfcElementType.ElementType));*/
		#endregion

		#region IPersist implementation
		void IPersist.Set(int propIndex, IPropertyValue value)
		{
            throw new System.NotImplementedException();
		}
		#endregion

		public  override string WhereRule() 
		{
			return "";
		}
	}
}