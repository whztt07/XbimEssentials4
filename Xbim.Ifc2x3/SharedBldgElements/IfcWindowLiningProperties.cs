// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		23.09.2015 10:21:45
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.Kernel;
using Xbim.Ifc2x3.UtilityResource;
using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.RepresentationResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.SharedBldgElements
{
	[IndexedClass]
	[ExpressType("IFCWINDOWLININGPROPERTIES", 252)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcWindowLiningProperties : IfcPropertySetDefinition, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcWindowLiningProperties(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcPositiveLengthMeasure? _liningDepth;
		private IfcPositiveLengthMeasure? _liningThickness;
		private IfcPositiveLengthMeasure? _transomThickness;
		private IfcPositiveLengthMeasure? _mullionThickness;
		private IfcNormalisedRatioMeasure? _firstTransomOffset;
		private IfcNormalisedRatioMeasure? _secondTransomOffset;
		private IfcNormalisedRatioMeasure? _firstMullionOffset;
		private IfcNormalisedRatioMeasure? _secondMullionOffset;
		private IfcShapeAspect _shapeAspectStyle;
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
		public IfcPositiveLengthMeasure? @LiningThickness 
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
		public IfcPositiveLengthMeasure? @TransomThickness 
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
	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure? @MullionThickness 
		{ 
			get 
			{
				if(Activated) return _mullionThickness;
				
				Model.Activate(this, true);
				Activated = true;
				return _mullionThickness;
			} 
			set
			{
				SetValue( v =>  _mullionThickness = v, _mullionThickness, value,  "MullionThickness");
			} 
		}
	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcNormalisedRatioMeasure? @FirstTransomOffset 
		{ 
			get 
			{
				if(Activated) return _firstTransomOffset;
				
				Model.Activate(this, true);
				Activated = true;
				return _firstTransomOffset;
			} 
			set
			{
				SetValue( v =>  _firstTransomOffset = v, _firstTransomOffset, value,  "FirstTransomOffset");
			} 
		}
	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcNormalisedRatioMeasure? @SecondTransomOffset 
		{ 
			get 
			{
				if(Activated) return _secondTransomOffset;
				
				Model.Activate(this, true);
				Activated = true;
				return _secondTransomOffset;
			} 
			set
			{
				SetValue( v =>  _secondTransomOffset = v, _secondTransomOffset, value,  "SecondTransomOffset");
			} 
		}
	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcNormalisedRatioMeasure? @FirstMullionOffset 
		{ 
			get 
			{
				if(Activated) return _firstMullionOffset;
				
				Model.Activate(this, true);
				Activated = true;
				return _firstMullionOffset;
			} 
			set
			{
				SetValue( v =>  _firstMullionOffset = v, _firstMullionOffset, value,  "FirstMullionOffset");
			} 
		}
	
		[EntityAttribute(12, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcNormalisedRatioMeasure? @SecondMullionOffset 
		{ 
			get 
			{
				if(Activated) return _secondMullionOffset;
				
				Model.Activate(this, true);
				Activated = true;
				return _secondMullionOffset;
			} 
			set
			{
				SetValue( v =>  _secondMullionOffset = v, _secondMullionOffset, value,  "SecondMullionOffset");
			} 
		}
	
		[EntityAttribute(13, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
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
					_transomThickness = value.RealVal;
					return;
				case 7: 
					_mullionThickness = value.RealVal;
					return;
				case 8: 
					_firstTransomOffset = value.RealVal;
					return;
				case 9: 
					_secondTransomOffset = value.RealVal;
					return;
				case 10: 
					_firstMullionOffset = value.RealVal;
					return;
				case 11: 
					_secondMullionOffset = value.RealVal;
					return;
				case 12: 
					_shapeAspectStyle = (IfcShapeAspect)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR31:	WR31 : NOT(NOT(EXISTS(LiningDepth)) AND EXISTS(LiningThickness));*/
		/*WR32:	WR32 : NOT(NOT(EXISTS(FirstTransomOffset)) AND EXISTS(SecondTransomOffset));*/
		/*WR33:	WR33 : NOT(NOT(EXISTS(FirstMullionOffset)) AND EXISTS(SecondMullionOffset));*/
		/*WR34:             ('IFC2X3.IFCWINDOWSTYLE' IN TYPEOF(SELF\IfcPropertySetDefinition.DefinesType[1]));*/
		}
		#endregion
	}
}