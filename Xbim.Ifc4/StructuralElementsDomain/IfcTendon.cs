// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 03:44:07
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.UtilityResource;
using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.GeometricConstraintResource;
using Xbim.Ifc4.RepresentationResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.StructuralElementsDomain
{
	[EntityName("IFCTENDON", 695)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcTendon : IfcReinforcingElement, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTendon(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcTendonTypeEnum? _predefinedType;
		private IfcPositiveLengthMeasure? _nominalDiameter;
		private IfcAreaMeasure? _crossSectionArea;
		private IfcForceMeasure? _tensionForce;
		private IfcPressureMeasure? _preStress;
		private IfcNormalisedRatioMeasure? _frictionCoefficient;
		private IfcPositiveLengthMeasure? _anchorageSlip;
		private IfcPositiveLengthMeasure? _minCurvatureRadius;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttributee(9, EntityAttributeState.Optional)]
		public IfcTendonTypeEnum? @PredefinedType 
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
	
		[EntityAttributee(10, EntityAttributeState.Optional)]
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
	
		[EntityAttributee(11, EntityAttributeState.Optional)]
		public IfcAreaMeasure? @CrossSectionArea 
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
	
		[EntityAttributee(12, EntityAttributeState.Optional)]
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
	
		[EntityAttributee(13, EntityAttributeState.Optional)]
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
	
		[EntityAttributee(14, EntityAttributeState.Optional)]
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
	
		[EntityAttributee(15, EntityAttributeState.Optional)]
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
	
		[EntityAttributee(16, EntityAttributeState.Optional)]
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
		/*CorrectPredefinedType:                              ((PredefinedType = IfcTendonTypeEnum.USERDEFINED) AND EXISTS (SELF\IfcObject.ObjectType));*/
		/*CorrectTypeAssigned:                              ('IFC4.IFCTENDONTYPE' IN TYPEOF(SELF\IfcObject.IsTypedBy[1].RelatingType));*/
		}
		#endregion
	}
}