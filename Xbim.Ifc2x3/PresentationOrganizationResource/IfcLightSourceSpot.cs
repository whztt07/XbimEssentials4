// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		22.09.2015 04:44:05
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.PresentationResource;
using Xbim.Ifc2x3.GeometryResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.PresentationOrganizationResource
{
	[IndexedClass]
	[ExpressType("IFCLIGHTSOURCESPOT", 760)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcLightSourceSpot : IfcLightSourcePositional, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcLightSourceSpot(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcDirection _orientation;
		private IfcReal? _concentrationExponent;
		private IfcPositivePlaneAngleMeasure _spreadAngle;
		private IfcPositivePlaneAngleMeasure _beamWidthAngle;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(10, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcDirection @Orientation 
		{ 
			get 
			{
				if(Activated) return _orientation;
				
				Model.Activate(this, true);
				Activated = true;
				return _orientation;
			} 
			set
			{
				SetValue( v =>  _orientation = v, _orientation, value,  "Orientation");
			} 
		}
	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcReal? @ConcentrationExponent 
		{ 
			get 
			{
				if(Activated) return _concentrationExponent;
				
				Model.Activate(this, true);
				Activated = true;
				return _concentrationExponent;
			} 
			set
			{
				SetValue( v =>  _concentrationExponent = v, _concentrationExponent, value,  "ConcentrationExponent");
			} 
		}
	
		[EntityAttribute(12, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositivePlaneAngleMeasure @SpreadAngle 
		{ 
			get 
			{
				if(Activated) return _spreadAngle;
				
				Model.Activate(this, true);
				Activated = true;
				return _spreadAngle;
			} 
			set
			{
				SetValue( v =>  _spreadAngle = v, _spreadAngle, value,  "SpreadAngle");
			} 
		}
	
		[EntityAttribute(13, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositivePlaneAngleMeasure @BeamWidthAngle 
		{ 
			get 
			{
				if(Activated) return _beamWidthAngle;
				
				Model.Activate(this, true);
				Activated = true;
				return _beamWidthAngle;
			} 
			set
			{
				SetValue( v =>  _beamWidthAngle = v, _beamWidthAngle, value,  "BeamWidthAngle");
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
					_orientation = (IfcDirection)(value.EntityVal);
					return;
				case 10: 
					_concentrationExponent = value.RealVal;
					return;
				case 11: 
					_spreadAngle = value.RealVal;
					return;
				case 12: 
					_beamWidthAngle = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
			return "";
		}
		#endregion
	}
}