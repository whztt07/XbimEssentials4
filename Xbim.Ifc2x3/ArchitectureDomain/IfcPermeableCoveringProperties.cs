// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 03:43:56
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.Kernel;
using Xbim.Ifc2x3.UtilityResource;
using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.SharedBldgElements;
using Xbim.Ifc2x3.RepresentationResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.ArchitectureDomain
{
	[EntityName("IFCPERMEABLECOVERINGPROPERTIES", 707)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcPermeableCoveringProperties : IfcPropertySetDefinition, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPermeableCoveringProperties(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcPermeableCoveringOperationEnum _operationType;
		private IfcWindowPanelPositionEnum _panelPosition;
		private IfcPositiveLengthMeasure? _frameDepth;
		private IfcPositiveLengthMeasure? _frameThickness;
		private IfcShapeAspect _shapeAspectStyle;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Mandatory)]
		public IfcPermeableCoveringOperationEnum @OperationType 
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
	
		[EntityAttribute(5, EntityAttributeState.Mandatory)]
		public IfcWindowPanelPositionEnum @PanelPosition 
		{ 
			get 
			{
				if(Activated) return _panelPosition;
				
				Model.Activate(this, true);
				Activated = true;
				return _panelPosition;
			} 
			set
			{
				SetValue( v =>  _panelPosition = v, _panelPosition, value,  "PanelPosition");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Optional)]
		public IfcPositiveLengthMeasure? @FrameDepth 
		{ 
			get 
			{
				if(Activated) return _frameDepth;
				
				Model.Activate(this, true);
				Activated = true;
				return _frameDepth;
			} 
			set
			{
				SetValue( v =>  _frameDepth = v, _frameDepth, value,  "FrameDepth");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Optional)]
		public IfcPositiveLengthMeasure? @FrameThickness 
		{ 
			get 
			{
				if(Activated) return _frameThickness;
				
				Model.Activate(this, true);
				Activated = true;
				return _frameThickness;
			} 
			set
			{
				SetValue( v =>  _frameThickness = v, _frameThickness, value,  "FrameThickness");
			} 
		}
	
		[EntityAttribute(8, EntityAttributeState.Optional)]
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
					base.Parse(propIndex, value); 
					return;
				case 4: 
                    _operationType = (IfcPermeableCoveringOperationEnum) System.Enum.Parse(typeof (IfcPermeableCoveringOperationEnum), value.EnumVal, true);
					return;
				case 5: 
                    _panelPosition = (IfcWindowPanelPositionEnum) System.Enum.Parse(typeof (IfcWindowPanelPositionEnum), value.EnumVal, true);
					return;
				case 6: 
					_frameDepth = value.RealVal;
					return;
				case 7: 
					_frameThickness = value.RealVal;
					return;
				case 8: 
					_shapeAspectStyle = (IfcShapeAspect)(value.EntityVal);
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