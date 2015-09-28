// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
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
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.StructuralElementsDomain
{
	[ExpressType("IFCREINFORCINGMESHTYPE", 900)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcReinforcingMeshType : IfcReinforcingElementType, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcReinforcingMeshType(IModel model) : base(model) 		{ 
			Model = model; 
			_bendingParameters = new OptionalItemSet<IfcBendingParameterSelect>( this );
		}

		#region Explicit attribute fields
		private IfcReinforcingMeshTypeEnum _predefinedType;
		private IfcPositiveLengthMeasure? _meshLength;
		private IfcPositiveLengthMeasure? _meshWidth;
		private IfcPositiveLengthMeasure? _longitudinalBarNominalDiameter;
		private IfcPositiveLengthMeasure? _transverseBarNominalDiameter;
		private IfcAreaMeasure? _longitudinalBarCrossSectionArea;
		private IfcAreaMeasure? _transverseBarCrossSectionArea;
		private IfcPositiveLengthMeasure? _longitudinalBarSpacing;
		private IfcPositiveLengthMeasure? _transverseBarSpacing;
		private IfcLabel? _bendingShapeCode;
		private OptionalItemSet<IfcBendingParameterSelect> _bendingParameters;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(10, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcReinforcingMeshTypeEnum @PredefinedType 
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
	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure? @MeshLength 
		{ 
			get 
			{
				if(Activated) return _meshLength;
				
				Model.Activate(this, true);
				Activated = true;
				return _meshLength;
			} 
			set
			{
				SetValue( v =>  _meshLength = v, _meshLength, value,  "MeshLength");
			} 
		}
	
		[EntityAttribute(12, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure? @MeshWidth 
		{ 
			get 
			{
				if(Activated) return _meshWidth;
				
				Model.Activate(this, true);
				Activated = true;
				return _meshWidth;
			} 
			set
			{
				SetValue( v =>  _meshWidth = v, _meshWidth, value,  "MeshWidth");
			} 
		}
	
		[EntityAttribute(13, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure? @LongitudinalBarNominalDiameter 
		{ 
			get 
			{
				if(Activated) return _longitudinalBarNominalDiameter;
				
				Model.Activate(this, true);
				Activated = true;
				return _longitudinalBarNominalDiameter;
			} 
			set
			{
				SetValue( v =>  _longitudinalBarNominalDiameter = v, _longitudinalBarNominalDiameter, value,  "LongitudinalBarNominalDiameter");
			} 
		}
	
		[EntityAttribute(14, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure? @TransverseBarNominalDiameter 
		{ 
			get 
			{
				if(Activated) return _transverseBarNominalDiameter;
				
				Model.Activate(this, true);
				Activated = true;
				return _transverseBarNominalDiameter;
			} 
			set
			{
				SetValue( v =>  _transverseBarNominalDiameter = v, _transverseBarNominalDiameter, value,  "TransverseBarNominalDiameter");
			} 
		}
	
		[EntityAttribute(15, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcAreaMeasure? @LongitudinalBarCrossSectionArea 
		{ 
			get 
			{
				if(Activated) return _longitudinalBarCrossSectionArea;
				
				Model.Activate(this, true);
				Activated = true;
				return _longitudinalBarCrossSectionArea;
			} 
			set
			{
				SetValue( v =>  _longitudinalBarCrossSectionArea = v, _longitudinalBarCrossSectionArea, value,  "LongitudinalBarCrossSectionArea");
			} 
		}
	
		[EntityAttribute(16, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcAreaMeasure? @TransverseBarCrossSectionArea 
		{ 
			get 
			{
				if(Activated) return _transverseBarCrossSectionArea;
				
				Model.Activate(this, true);
				Activated = true;
				return _transverseBarCrossSectionArea;
			} 
			set
			{
				SetValue( v =>  _transverseBarCrossSectionArea = v, _transverseBarCrossSectionArea, value,  "TransverseBarCrossSectionArea");
			} 
		}
	
		[EntityAttribute(17, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure? @LongitudinalBarSpacing 
		{ 
			get 
			{
				if(Activated) return _longitudinalBarSpacing;
				
				Model.Activate(this, true);
				Activated = true;
				return _longitudinalBarSpacing;
			} 
			set
			{
				SetValue( v =>  _longitudinalBarSpacing = v, _longitudinalBarSpacing, value,  "LongitudinalBarSpacing");
			} 
		}
	
		[EntityAttribute(18, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure? @TransverseBarSpacing 
		{ 
			get 
			{
				if(Activated) return _transverseBarSpacing;
				
				Model.Activate(this, true);
				Activated = true;
				return _transverseBarSpacing;
			} 
			set
			{
				SetValue( v =>  _transverseBarSpacing = v, _transverseBarSpacing, value,  "TransverseBarSpacing");
			} 
		}
	
		[EntityAttribute(19, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel? @BendingShapeCode 
		{ 
			get 
			{
				if(Activated) return _bendingShapeCode;
				
				Model.Activate(this, true);
				Activated = true;
				return _bendingShapeCode;
			} 
			set
			{
				SetValue( v =>  _bendingShapeCode = v, _bendingShapeCode, value,  "BendingShapeCode");
			} 
		}
	
		[EntityAttribute(20, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.Class, 1, -1)]
		public OptionalItemSet<IfcBendingParameterSelect> @BendingParameters 
		{ 
			get 
			{
				if(Activated) return _bendingParameters;
				
				Model.Activate(this, true);
				Activated = true;
				return _bendingParameters;
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
                    _predefinedType = (IfcReinforcingMeshTypeEnum) System.Enum.Parse(typeof (IfcReinforcingMeshTypeEnum), value.EnumVal, true);
					return;
				case 10: 
					_meshLength = value.RealVal;
					return;
				case 11: 
					_meshWidth = value.RealVal;
					return;
				case 12: 
					_longitudinalBarNominalDiameter = value.RealVal;
					return;
				case 13: 
					_transverseBarNominalDiameter = value.RealVal;
					return;
				case 14: 
					_longitudinalBarCrossSectionArea = value.RealVal;
					return;
				case 15: 
					_transverseBarCrossSectionArea = value.RealVal;
					return;
				case 16: 
					_longitudinalBarSpacing = value.RealVal;
					return;
				case 17: 
					_transverseBarSpacing = value.RealVal;
					return;
				case 18: 
					_bendingShapeCode = value.StringVal;
					return;
				case 19: 
					if (_bendingParameters == null) _bendingParameters = new OptionalItemSet<IfcBendingParameterSelect>( this );
					_bendingParameters.InternalAdd((IfcBendingParameterSelect)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*CorrectPredefinedType:                                 ((PredefinedType = IfcReinforcingMeshTypeEnum.USERDEFINED) AND EXISTS(SELF\IfcElementType.ElementType));*/
		/*BendingShapeCodeProvided:	BendingShapeCodeProvided : NOT EXISTS(BendingParameters) OR EXISTS(BendingShapeCode);*/
		}
		#endregion
	}
}