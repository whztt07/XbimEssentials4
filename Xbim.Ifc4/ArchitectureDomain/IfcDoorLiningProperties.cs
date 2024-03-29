// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		24.09.2015 10:03:40
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Kernel;
using Xbim.Ifc4.UtilityResource;
using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.RepresentationResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.ArchitectureDomain
{
	[IndexedClass]
	[ExpressType("IFCDOORLININGPROPERTIES", 582)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcDoorLiningProperties : IfcPreDefinedPropertySet, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcDoorLiningProperties(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcPositiveLengthMeasure? _liningDepth;
		private IfcNonNegativeLengthMeasure? _liningThickness;
		private IfcPositiveLengthMeasure? _thresholdDepth;
		private IfcNonNegativeLengthMeasure? _thresholdThickness;
		private IfcNonNegativeLengthMeasure? _transomThickness;
		private IfcLengthMeasure? _transomOffset;
		private IfcLengthMeasure? _liningOffset;
		private IfcLengthMeasure? _thresholdOffset;
		private IfcPositiveLengthMeasure? _casingThickness;
		private IfcPositiveLengthMeasure? _casingDepth;
		private IfcShapeAspect _shapeAspectStyle;
		private IfcLengthMeasure? _liningToPanelOffsetX;
		private IfcLengthMeasure? _liningToPanelOffsetY;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure? @LiningDepth 
		{ 
			get 
			{
				if(Activated) return _liningDepth;
				
				Model.Activate(this, true);
				Activated = true;
				return _liningDepth;
			} 
			set
			{
				SetValue( v =>  _liningDepth = v, _liningDepth, value,  "LiningDepth");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcNonNegativeLengthMeasure? @LiningThickness 
		{ 
			get 
			{
				if(Activated) return _liningThickness;
				
				Model.Activate(this, true);
				Activated = true;
				return _liningThickness;
			} 
			set
			{
				SetValue( v =>  _liningThickness = v, _liningThickness, value,  "LiningThickness");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure? @ThresholdDepth 
		{ 
			get 
			{
				if(Activated) return _thresholdDepth;
				
				Model.Activate(this, true);
				Activated = true;
				return _thresholdDepth;
			} 
			set
			{
				SetValue( v =>  _thresholdDepth = v, _thresholdDepth, value,  "ThresholdDepth");
			} 
		}
	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcNonNegativeLengthMeasure? @ThresholdThickness 
		{ 
			get 
			{
				if(Activated) return _thresholdThickness;
				
				Model.Activate(this, true);
				Activated = true;
				return _thresholdThickness;
			} 
			set
			{
				SetValue( v =>  _thresholdThickness = v, _thresholdThickness, value,  "ThresholdThickness");
			} 
		}
	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcNonNegativeLengthMeasure? @TransomThickness 
		{ 
			get 
			{
				if(Activated) return _transomThickness;
				
				Model.Activate(this, true);
				Activated = true;
				return _transomThickness;
			} 
			set
			{
				SetValue( v =>  _transomThickness = v, _transomThickness, value,  "TransomThickness");
			} 
		}
	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLengthMeasure? @TransomOffset 
		{ 
			get 
			{
				if(Activated) return _transomOffset;
				
				Model.Activate(this, true);
				Activated = true;
				return _transomOffset;
			} 
			set
			{
				SetValue( v =>  _transomOffset = v, _transomOffset, value,  "TransomOffset");
			} 
		}
	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLengthMeasure? @LiningOffset 
		{ 
			get 
			{
				if(Activated) return _liningOffset;
				
				Model.Activate(this, true);
				Activated = true;
				return _liningOffset;
			} 
			set
			{
				SetValue( v =>  _liningOffset = v, _liningOffset, value,  "LiningOffset");
			} 
		}
	
		[EntityAttribute(12, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLengthMeasure? @ThresholdOffset 
		{ 
			get 
			{
				if(Activated) return _thresholdOffset;
				
				Model.Activate(this, true);
				Activated = true;
				return _thresholdOffset;
			} 
			set
			{
				SetValue( v =>  _thresholdOffset = v, _thresholdOffset, value,  "ThresholdOffset");
			} 
		}
	
		[EntityAttribute(13, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure? @CasingThickness 
		{ 
			get 
			{
				if(Activated) return _casingThickness;
				
				Model.Activate(this, true);
				Activated = true;
				return _casingThickness;
			} 
			set
			{
				SetValue( v =>  _casingThickness = v, _casingThickness, value,  "CasingThickness");
			} 
		}
	
		[EntityAttribute(14, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure? @CasingDepth 
		{ 
			get 
			{
				if(Activated) return _casingDepth;
				
				Model.Activate(this, true);
				Activated = true;
				return _casingDepth;
			} 
			set
			{
				SetValue( v =>  _casingDepth = v, _casingDepth, value,  "CasingDepth");
			} 
		}
	
		[EntityAttribute(15, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcShapeAspect @ShapeAspectStyle 
		{ 
			get 
			{
				if(Activated) return _shapeAspectStyle;
				
				Model.Activate(this, true);
				Activated = true;
				return _shapeAspectStyle;
			} 
			set
			{
				SetValue( v =>  _shapeAspectStyle = v, _shapeAspectStyle, value,  "ShapeAspectStyle");
			} 
		}
	
		[EntityAttribute(16, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLengthMeasure? @LiningToPanelOffsetX 
		{ 
			get 
			{
				if(Activated) return _liningToPanelOffsetX;
				
				Model.Activate(this, true);
				Activated = true;
				return _liningToPanelOffsetX;
			} 
			set
			{
				SetValue( v =>  _liningToPanelOffsetX = v, _liningToPanelOffsetX, value,  "LiningToPanelOffsetX");
			} 
		}
	
		[EntityAttribute(17, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLengthMeasure? @LiningToPanelOffsetY 
		{ 
			get 
			{
				if(Activated) return _liningToPanelOffsetY;
				
				Model.Activate(this, true);
				Activated = true;
				return _liningToPanelOffsetY;
			} 
			set
			{
				SetValue( v =>  _liningToPanelOffsetY = v, _liningToPanelOffsetY, value,  "LiningToPanelOffsetY");
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
					base.Parse(propIndex, value); 
					return;
				case 4: 
					_liningDepth = value.RealVal;
					return;
				case 5: 
					_liningThickness = value.RealVal;
					return;
				case 6: 
					_thresholdDepth = value.RealVal;
					return;
				case 7: 
					_thresholdThickness = value.RealVal;
					return;
				case 8: 
					_transomThickness = value.RealVal;
					return;
				case 9: 
					_transomOffset = value.RealVal;
					return;
				case 10: 
					_liningOffset = value.RealVal;
					return;
				case 11: 
					_thresholdOffset = value.RealVal;
					return;
				case 12: 
					_casingThickness = value.RealVal;
					return;
				case 13: 
					_casingDepth = value.RealVal;
					return;
				case 14: 
					_shapeAspectStyle = (IfcShapeAspect)(value.EntityVal);
					return;
				case 15: 
					_liningToPanelOffsetX = value.RealVal;
					return;
				case 16: 
					_liningToPanelOffsetY = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR31:	WR31 : NOT(EXISTS(LiningDepth) AND NOT(EXISTS(LiningThickness)));*/
		/*WR32:	WR32 : NOT(EXISTS(ThresholdDepth) AND NOT(EXISTS(ThresholdThickness)));*/
		/*WR33:             (NOT(EXISTS(TransomOffset)) AND NOT(EXISTS(TransomThickness)));*/
		/*WR34:             (NOT(EXISTS(CasingDepth)) AND NOT(EXISTS(CasingThickness)));*/
		/*WR35:             );*/
		}
		#endregion
	}
}