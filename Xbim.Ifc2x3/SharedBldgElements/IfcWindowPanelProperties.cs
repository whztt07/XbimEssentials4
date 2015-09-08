// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 09:16:39
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

namespace Xbim.Ifc2x3.SharedBldgElements
{
	[EntityName("IFCWINDOWPANELPROPERTIES")]
	public  partial class @IfcWindowPanelProperties : IfcPropertySetDefinition, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcWindowPanelProperties(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcWindowPanelOperationEnum _operationType;
		private IfcWindowPanelPositionEnum _panelPosition;
		private IfcPositiveLengthMeasure? _frameDepth;
		private IfcPositiveLengthMeasure? _frameThickness;
		private IfcShapeAspect _shapeAspectStyle;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Mandatory)]
		public IfcWindowPanelOperationEnum @OperationType 
		{ 
			get 
			{
				if(IsActivated) return _operationType;
				
				Model.Activate(this, true);
				IsActivated = true;
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
				if(IsActivated) return _panelPosition;
				
				Model.Activate(this, true);
				IsActivated = true;
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
				if(IsActivated) return _frameDepth;
				
				Model.Activate(this, true);
				IsActivated = true;
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
				if(IsActivated) return _frameThickness;
				
				Model.Activate(this, true);
				IsActivated = true;
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
				if(IsActivated) return _shapeAspectStyle;
				
				Model.Activate(this, true);
				IsActivated = true;
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

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"GlobalId",
			"OwnerHistory",
			"Name",
			"Description",
			"OperationType",
			"PanelPosition",
			"FrameDepth",
			"FrameThickness",
			"ShapeAspectStyle",
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
					return @OperationType;
				case 5: 
					return @PanelPosition;
				case 6: 
					return @FrameDepth;
				case 7: 
					return @FrameThickness;
				case 8: 
					return @ShapeAspectStyle;
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
				case "OperationType":  
					return @OperationType;
				case "PanelPosition":  
					return @PanelPosition;
				case "FrameDepth":  
					return @FrameDepth;
				case "FrameThickness":  
					return @FrameThickness;
				case "ShapeAspectStyle":  
					return @ShapeAspectStyle;
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
					 if (value != null) @OperationType = (IfcWindowPanelOperationEnum)value;
					 break;
				case 5:
					 if (value != null) @PanelPosition = (IfcWindowPanelPositionEnum)value;
					 break;
				case 6:
					 @FrameDepth = (IfcPositiveLengthMeasure?)value;
					 break;
				case 7:
					 @FrameThickness = (IfcPositiveLengthMeasure?)value;
					 break;
				case 8:
					 @ShapeAspectStyle = (IfcShapeAspect)value;
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
				case "OperationType":
					 if (value != null) @OperationType = (IfcWindowPanelOperationEnum)value;
					 break;
				case "PanelPosition":
					 if (value != null) @PanelPosition = (IfcWindowPanelPositionEnum)value;
					 break;
				case "FrameDepth":
					 @FrameDepth = (IfcPositiveLengthMeasure?)value;
					 break;
				case "FrameThickness":
					 @FrameThickness = (IfcPositiveLengthMeasure?)value;
					 break;
				case "ShapeAspectStyle":
					 @ShapeAspectStyle = (IfcShapeAspect)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion


		#region IPersist implementation
		public void Set(int propIndex, IPropertyValue value)
		{
            throw new System.NotImplementedException();
		}
		#endregion

	}
}