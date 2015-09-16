// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		16.09.2015 04:23:01
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.UtilityResource;
using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.GeometricConstraintResource;
using Xbim.Ifc2x3.RepresentationResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.StructuralElementsDomain
{
	[EntityName("IFCTENDON", 261)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcTendon : IfcReinforcingElement, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTendon(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcTendonTypeEnum _predefinedType;
		private IfcPositiveLengthMeasure _nominalDiameter;
		private IfcAreaMeasure _crossSectionArea;
		private IfcForceMeasure? _tensionForce;
		private IfcPressureMeasure? _preStress;
		private IfcNormalisedRatioMeasure? _frictionCoefficient;
		private IfcPositiveLengthMeasure? _anchorageSlip;
		private IfcPositiveLengthMeasure? _minCurvatureRadius;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(9, EntityAttributeState.Mandatory)]
		public IfcTendonTypeEnum @PredefinedType 
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
		public IfcPositiveLengthMeasure @NominalDiameter 
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
	
		[EntityAttribute(11, EntityAttributeState.Mandatory)]
		public IfcAreaMeasure @CrossSectionArea 
		{ 
			get 
			{
				if(Activated) return _crossSectionArea;
				
				Model.Activate(this, true);
				Activated = true;
				return _crossSectionArea;
			} 
			set
			{
				SetValue( v =>  _crossSectionArea = v, _crossSectionArea, value,  "CrossSectionArea");
			} 
		}
	
		[EntityAttribute(12, EntityAttributeState.Optional)]
		public IfcForceMeasure? @TensionForce 
		{ 
			get 
			{
				if(Activated) return _tensionForce;
				
				Model.Activate(this, true);
				Activated = true;
				return _tensionForce;
			} 
			set
			{
				SetValue( v =>  _tensionForce = v, _tensionForce, value,  "TensionForce");
			} 
		}
	
		[EntityAttribute(13, EntityAttributeState.Optional)]
		public IfcPressureMeasure? @PreStress 
		{ 
			get 
			{
				if(Activated) return _preStress;
				
				Model.Activate(this, true);
				Activated = true;
				return _preStress;
			} 
			set
			{
				SetValue( v =>  _preStress = v, _preStress, value,  "PreStress");
			} 
		}
	
		[EntityAttribute(14, EntityAttributeState.Optional)]
		public IfcNormalisedRatioMeasure? @FrictionCoefficient 
		{ 
			get 
			{
				if(Activated) return _frictionCoefficient;
				
				Model.Activate(this, true);
				Activated = true;
				return _frictionCoefficient;
			} 
			set
			{
				SetValue( v =>  _frictionCoefficient = v, _frictionCoefficient, value,  "FrictionCoefficient");
			} 
		}
	
		[EntityAttribute(15, EntityAttributeState.Optional)]
		public IfcPositiveLengthMeasure? @AnchorageSlip 
		{ 
			get 
			{
				if(Activated) return _anchorageSlip;
				
				Model.Activate(this, true);
				Activated = true;
				return _anchorageSlip;
			} 
			set
			{
				SetValue( v =>  _anchorageSlip = v, _anchorageSlip, value,  "AnchorageSlip");
			} 
		}
	
		[EntityAttribute(16, EntityAttributeState.Optional)]
		public IfcPositiveLengthMeasure? @MinCurvatureRadius 
		{ 
			get 
			{
				if(Activated) return _minCurvatureRadius;
				
				Model.Activate(this, true);
				Activated = true;
				return _minCurvatureRadius;
			} 
			set
			{
				SetValue( v =>  _minCurvatureRadius = v, _minCurvatureRadius, value,  "MinCurvatureRadius");
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
			"ObjectType",
			"ObjectPlacement",
			"Representation",
			"Tag",
			"SteelGrade",
			"PredefinedType",
			"NominalDiameter",
			"CrossSectionArea",
			"TensionForce",
			"PreStress",
			"FrictionCoefficient",
			"AnchorageSlip",
			"MinCurvatureRadius",
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
					return @ObjectType;
				case 5: 
					return @ObjectPlacement;
				case 6: 
					return @Representation;
				case 7: 
					return @Tag;
				case 8: 
					return @SteelGrade;
				case 9: 
					return @PredefinedType;
				case 10: 
					return @NominalDiameter;
				case 11: 
					return @CrossSectionArea;
				case 12: 
					return @TensionForce;
				case 13: 
					return @PreStress;
				case 14: 
					return @FrictionCoefficient;
				case 15: 
					return @AnchorageSlip;
				case 16: 
					return @MinCurvatureRadius;
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
				case "ObjectType":  
					return @ObjectType;
				case "ObjectPlacement":  
					return @ObjectPlacement;
				case "Representation":  
					return @Representation;
				case "Tag":  
					return @Tag;
				case "SteelGrade":  
					return @SteelGrade;
				case "PredefinedType":  
					return @PredefinedType;
				case "NominalDiameter":  
					return @NominalDiameter;
				case "CrossSectionArea":  
					return @CrossSectionArea;
				case "TensionForce":  
					return @TensionForce;
				case "PreStress":  
					return @PreStress;
				case "FrictionCoefficient":  
					return @FrictionCoefficient;
				case "AnchorageSlip":  
					return @AnchorageSlip;
				case "MinCurvatureRadius":  
					return @MinCurvatureRadius;
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
					 @ObjectType = (IfcLabel?)value;
					 break;
				case 5:
					 @ObjectPlacement = (IfcObjectPlacement)value;
					 break;
				case 6:
					 @Representation = (IfcProductRepresentation)value;
					 break;
				case 7:
					 @Tag = (IfcIdentifier?)value;
					 break;
				case 8:
					 @SteelGrade = (IfcLabel?)value;
					 break;
				case 9:
					 if (value != null) @PredefinedType = (IfcTendonTypeEnum)value;
					 break;
				case 10:
					 if (value != null) @NominalDiameter = (IfcPositiveLengthMeasure)value;
					 break;
				case 11:
					 if (value != null) @CrossSectionArea = (IfcAreaMeasure)value;
					 break;
				case 12:
					 @TensionForce = (IfcForceMeasure?)value;
					 break;
				case 13:
					 @PreStress = (IfcPressureMeasure?)value;
					 break;
				case 14:
					 @FrictionCoefficient = (IfcNormalisedRatioMeasure?)value;
					 break;
				case 15:
					 @AnchorageSlip = (IfcPositiveLengthMeasure?)value;
					 break;
				case 16:
					 @MinCurvatureRadius = (IfcPositiveLengthMeasure?)value;
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
				case "ObjectType":
					 @ObjectType = (IfcLabel?)value;
					 break;
				case "ObjectPlacement":
					 @ObjectPlacement = (IfcObjectPlacement)value;
					 break;
				case "Representation":
					 @Representation = (IfcProductRepresentation)value;
					 break;
				case "Tag":
					 @Tag = (IfcIdentifier?)value;
					 break;
				case "SteelGrade":
					 @SteelGrade = (IfcLabel?)value;
					 break;
				case "PredefinedType":
					 if (value != null) @PredefinedType = (IfcTendonTypeEnum)value;
					 break;
				case "NominalDiameter":
					 if (value != null) @NominalDiameter = (IfcPositiveLengthMeasure)value;
					 break;
				case "CrossSectionArea":
					 if (value != null) @CrossSectionArea = (IfcAreaMeasure)value;
					 break;
				case "TensionForce":
					 @TensionForce = (IfcForceMeasure?)value;
					 break;
				case "PreStress":
					 @PreStress = (IfcPressureMeasure?)value;
					 break;
				case "FrictionCoefficient":
					 @FrictionCoefficient = (IfcNormalisedRatioMeasure?)value;
					 break;
				case "AnchorageSlip":
					 @AnchorageSlip = (IfcPositiveLengthMeasure?)value;
					 break;
				case "MinCurvatureRadius":
					 @MinCurvatureRadius = (IfcPositiveLengthMeasure?)value;
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
				case 4: 
				case 5: 
				case 6: 
				case 7: 
				case 8: 
					base.Parse(propIndex, value); 
					return;
				case 9: 
                    _predefinedType = (IfcTendonTypeEnum) System.Enum.Parse(typeof (IfcTendonTypeEnum), value.EnumVal, true);
					return;
				case 10: 
					_nominalDiameter = value.RealVal;
					return;
				case 11: 
					_crossSectionArea = value.RealVal;
					return;
				case 12: 
					_tensionForce = value.RealVal;
					return;
				case 13: 
					_preStress = value.RealVal;
					return;
				case 14: 
					_frictionCoefficient = value.RealVal;
					return;
				case 15: 
					_anchorageSlip = value.RealVal;
					return;
				case 16: 
					_minCurvatureRadius = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR1:	WR1 : (PredefinedType <> IfcTendonTypeEnum.USERDEFINED) OR ((PredefinedType = IfcTendonTypeEnum.USERDEFINED) AND EXISTS(SELF\IfcObject.ObjectType));*/
		}
		#endregion

		
	}
}