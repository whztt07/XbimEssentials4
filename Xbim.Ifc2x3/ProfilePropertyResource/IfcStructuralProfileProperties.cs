// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		21.09.2015 05:11:14
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.ProfileResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.ProfilePropertyResource
{
	[IndexedClass]
	[ExpressType("IFCSTRUCTURALPROFILEPROPERTIES", 683)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcStructuralProfileProperties : IfcGeneralProfileProperties, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcStructuralProfileProperties(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcMomentOfInertiaMeasure? _torsionalConstantX;
		private IfcMomentOfInertiaMeasure? _momentOfInertiaYZ;
		private IfcMomentOfInertiaMeasure? _momentOfInertiaY;
		private IfcMomentOfInertiaMeasure? _momentOfInertiaZ;
		private IfcWarpingConstantMeasure? _warpingConstant;
		private IfcLengthMeasure? _shearCentreZ;
		private IfcLengthMeasure? _shearCentreY;
		private IfcAreaMeasure? _shearDeformationAreaZ;
		private IfcAreaMeasure? _shearDeformationAreaY;
		private IfcSectionModulusMeasure? _maximumSectionModulusY;
		private IfcSectionModulusMeasure? _minimumSectionModulusY;
		private IfcSectionModulusMeasure? _maximumSectionModulusZ;
		private IfcSectionModulusMeasure? _minimumSectionModulusZ;
		private IfcSectionModulusMeasure? _torsionalSectionModulus;
		private IfcLengthMeasure? _centreOfGravityInX;
		private IfcLengthMeasure? _centreOfGravityInY;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcMomentOfInertiaMeasure? @TorsionalConstantX 
		{ 
			get 
			{
				if(Activated) return _torsionalConstantX;
				
				Model.Activate(this, true);
				Activated = true;
				return _torsionalConstantX;
			} 
			set
			{
				SetValue( v =>  _torsionalConstantX = v, _torsionalConstantX, value,  "TorsionalConstantX");
			} 
		}
	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcMomentOfInertiaMeasure? @MomentOfInertiaYZ 
		{ 
			get 
			{
				if(Activated) return _momentOfInertiaYZ;
				
				Model.Activate(this, true);
				Activated = true;
				return _momentOfInertiaYZ;
			} 
			set
			{
				SetValue( v =>  _momentOfInertiaYZ = v, _momentOfInertiaYZ, value,  "MomentOfInertiaYZ");
			} 
		}
	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcMomentOfInertiaMeasure? @MomentOfInertiaY 
		{ 
			get 
			{
				if(Activated) return _momentOfInertiaY;
				
				Model.Activate(this, true);
				Activated = true;
				return _momentOfInertiaY;
			} 
			set
			{
				SetValue( v =>  _momentOfInertiaY = v, _momentOfInertiaY, value,  "MomentOfInertiaY");
			} 
		}
	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcMomentOfInertiaMeasure? @MomentOfInertiaZ 
		{ 
			get 
			{
				if(Activated) return _momentOfInertiaZ;
				
				Model.Activate(this, true);
				Activated = true;
				return _momentOfInertiaZ;
			} 
			set
			{
				SetValue( v =>  _momentOfInertiaZ = v, _momentOfInertiaZ, value,  "MomentOfInertiaZ");
			} 
		}
	
		[EntityAttribute(12, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcWarpingConstantMeasure? @WarpingConstant 
		{ 
			get 
			{
				if(Activated) return _warpingConstant;
				
				Model.Activate(this, true);
				Activated = true;
				return _warpingConstant;
			} 
			set
			{
				SetValue( v =>  _warpingConstant = v, _warpingConstant, value,  "WarpingConstant");
			} 
		}
	
		[EntityAttribute(13, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLengthMeasure? @ShearCentreZ 
		{ 
			get 
			{
				if(Activated) return _shearCentreZ;
				
				Model.Activate(this, true);
				Activated = true;
				return _shearCentreZ;
			} 
			set
			{
				SetValue( v =>  _shearCentreZ = v, _shearCentreZ, value,  "ShearCentreZ");
			} 
		}
	
		[EntityAttribute(14, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLengthMeasure? @ShearCentreY 
		{ 
			get 
			{
				if(Activated) return _shearCentreY;
				
				Model.Activate(this, true);
				Activated = true;
				return _shearCentreY;
			} 
			set
			{
				SetValue( v =>  _shearCentreY = v, _shearCentreY, value,  "ShearCentreY");
			} 
		}
	
		[EntityAttribute(15, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcAreaMeasure? @ShearDeformationAreaZ 
		{ 
			get 
			{
				if(Activated) return _shearDeformationAreaZ;
				
				Model.Activate(this, true);
				Activated = true;
				return _shearDeformationAreaZ;
			} 
			set
			{
				SetValue( v =>  _shearDeformationAreaZ = v, _shearDeformationAreaZ, value,  "ShearDeformationAreaZ");
			} 
		}
	
		[EntityAttribute(16, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcAreaMeasure? @ShearDeformationAreaY 
		{ 
			get 
			{
				if(Activated) return _shearDeformationAreaY;
				
				Model.Activate(this, true);
				Activated = true;
				return _shearDeformationAreaY;
			} 
			set
			{
				SetValue( v =>  _shearDeformationAreaY = v, _shearDeformationAreaY, value,  "ShearDeformationAreaY");
			} 
		}
	
		[EntityAttribute(17, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcSectionModulusMeasure? @MaximumSectionModulusY 
		{ 
			get 
			{
				if(Activated) return _maximumSectionModulusY;
				
				Model.Activate(this, true);
				Activated = true;
				return _maximumSectionModulusY;
			} 
			set
			{
				SetValue( v =>  _maximumSectionModulusY = v, _maximumSectionModulusY, value,  "MaximumSectionModulusY");
			} 
		}
	
		[EntityAttribute(18, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcSectionModulusMeasure? @MinimumSectionModulusY 
		{ 
			get 
			{
				if(Activated) return _minimumSectionModulusY;
				
				Model.Activate(this, true);
				Activated = true;
				return _minimumSectionModulusY;
			} 
			set
			{
				SetValue( v =>  _minimumSectionModulusY = v, _minimumSectionModulusY, value,  "MinimumSectionModulusY");
			} 
		}
	
		[EntityAttribute(19, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcSectionModulusMeasure? @MaximumSectionModulusZ 
		{ 
			get 
			{
				if(Activated) return _maximumSectionModulusZ;
				
				Model.Activate(this, true);
				Activated = true;
				return _maximumSectionModulusZ;
			} 
			set
			{
				SetValue( v =>  _maximumSectionModulusZ = v, _maximumSectionModulusZ, value,  "MaximumSectionModulusZ");
			} 
		}
	
		[EntityAttribute(20, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcSectionModulusMeasure? @MinimumSectionModulusZ 
		{ 
			get 
			{
				if(Activated) return _minimumSectionModulusZ;
				
				Model.Activate(this, true);
				Activated = true;
				return _minimumSectionModulusZ;
			} 
			set
			{
				SetValue( v =>  _minimumSectionModulusZ = v, _minimumSectionModulusZ, value,  "MinimumSectionModulusZ");
			} 
		}
	
		[EntityAttribute(21, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcSectionModulusMeasure? @TorsionalSectionModulus 
		{ 
			get 
			{
				if(Activated) return _torsionalSectionModulus;
				
				Model.Activate(this, true);
				Activated = true;
				return _torsionalSectionModulus;
			} 
			set
			{
				SetValue( v =>  _torsionalSectionModulus = v, _torsionalSectionModulus, value,  "TorsionalSectionModulus");
			} 
		}
	
		[EntityAttribute(22, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLengthMeasure? @CentreOfGravityInX 
		{ 
			get 
			{
				if(Activated) return _centreOfGravityInX;
				
				Model.Activate(this, true);
				Activated = true;
				return _centreOfGravityInX;
			} 
			set
			{
				SetValue( v =>  _centreOfGravityInX = v, _centreOfGravityInX, value,  "CentreOfGravityInX");
			} 
		}
	
		[EntityAttribute(23, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLengthMeasure? @CentreOfGravityInY 
		{ 
			get 
			{
				if(Activated) return _centreOfGravityInY;
				
				Model.Activate(this, true);
				Activated = true;
				return _centreOfGravityInY;
			} 
			set
			{
				SetValue( v =>  _centreOfGravityInY = v, _centreOfGravityInY, value,  "CentreOfGravityInY");
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
					base.Parse(propIndex, value); 
					return;
				case 7: 
					_torsionalConstantX = value.RealVal;
					return;
				case 8: 
					_momentOfInertiaYZ = value.RealVal;
					return;
				case 9: 
					_momentOfInertiaY = value.RealVal;
					return;
				case 10: 
					_momentOfInertiaZ = value.RealVal;
					return;
				case 11: 
					_warpingConstant = value.RealVal;
					return;
				case 12: 
					_shearCentreZ = value.RealVal;
					return;
				case 13: 
					_shearCentreY = value.RealVal;
					return;
				case 14: 
					_shearDeformationAreaZ = value.RealVal;
					return;
				case 15: 
					_shearDeformationAreaY = value.RealVal;
					return;
				case 16: 
					_maximumSectionModulusY = value.RealVal;
					return;
				case 17: 
					_minimumSectionModulusY = value.RealVal;
					return;
				case 18: 
					_maximumSectionModulusZ = value.RealVal;
					return;
				case 19: 
					_minimumSectionModulusZ = value.RealVal;
					return;
				case 20: 
					_torsionalSectionModulus = value.RealVal;
					return;
				case 21: 
					_centreOfGravityInX = value.RealVal;
					return;
				case 22: 
					_centreOfGravityInY = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR21:	WR21 : NOT(EXISTS(ShearDeformationAreaY)) OR (ShearDeformationAreaY >= 0.);*/
		/*WR22:	WR22 : NOT(EXISTS(ShearDeformationAreaZ)) OR (ShearDeformationAreaZ >= 0.);*/
		}
		#endregion
	}
}