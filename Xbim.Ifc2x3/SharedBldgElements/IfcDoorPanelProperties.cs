// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 09:16:38
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
	[EntityName("IFCDOORPANELPROPERTIES")]
	public  partial class @IfcDoorPanelProperties : IfcPropertySetDefinition, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcDoorPanelProperties(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcPositiveLengthMeasure? _panelDepth;
		private IfcDoorPanelOperationEnum _panelOperation;
		private IfcNormalisedRatioMeasure? _panelWidth;
		private IfcDoorPanelPositionEnum _panelPosition;
		private IfcShapeAspect _shapeAspectStyle;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Optional)]
		public IfcPositiveLengthMeasure? @PanelDepth 
		{ 
			get 
			{
				if(IsActivated) return _panelDepth;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _panelDepth;
			} 
			set
			{
				SetValue( v =>  _panelDepth = v, _panelDepth, value,  "PanelDepth");
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Mandatory)]
		public IfcDoorPanelOperationEnum @PanelOperation 
		{ 
			get 
			{
				if(IsActivated) return _panelOperation;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _panelOperation;
			} 
			set
			{
				SetValue( v =>  _panelOperation = v, _panelOperation, value,  "PanelOperation");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Optional)]
		public IfcNormalisedRatioMeasure? @PanelWidth 
		{ 
			get 
			{
				if(IsActivated) return _panelWidth;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _panelWidth;
			} 
			set
			{
				SetValue( v =>  _panelWidth = v, _panelWidth, value,  "PanelWidth");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Mandatory)]
		public IfcDoorPanelPositionEnum @PanelPosition 
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
			"PanelDepth",
			"PanelOperation",
			"PanelWidth",
			"PanelPosition",
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
					return @PanelDepth;
				case 5: 
					return @PanelOperation;
				case 6: 
					return @PanelWidth;
				case 7: 
					return @PanelPosition;
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
				case "PanelDepth":  
					return @PanelDepth;
				case "PanelOperation":  
					return @PanelOperation;
				case "PanelWidth":  
					return @PanelWidth;
				case "PanelPosition":  
					return @PanelPosition;
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
					 @PanelDepth = (IfcPositiveLengthMeasure?)value;
					 break;
				case 5:
					 if (value != null) @PanelOperation = (IfcDoorPanelOperationEnum)value;
					 break;
				case 6:
					 @PanelWidth = (IfcNormalisedRatioMeasure?)value;
					 break;
				case 7:
					 if (value != null) @PanelPosition = (IfcDoorPanelPositionEnum)value;
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
				case "PanelDepth":
					 @PanelDepth = (IfcPositiveLengthMeasure?)value;
					 break;
				case "PanelOperation":
					 if (value != null) @PanelOperation = (IfcDoorPanelOperationEnum)value;
					 break;
				case "PanelWidth":
					 @PanelWidth = (IfcNormalisedRatioMeasure?)value;
					 break;
				case "PanelPosition":
					 if (value != null) @PanelPosition = (IfcDoorPanelPositionEnum)value;
					 break;
				case "ShapeAspectStyle":
					 @ShapeAspectStyle = (IfcShapeAspect)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion

		#region Where rules
		/*WR31:             ('IFC2X3.IFCDOORSTYLE' IN TYPEOF(SELF\IfcPropertySetDefinition.DefinesType[1]));*/
		#endregion

		#region IPersist implementation
		public void Set(int propIndex, IPropertyValue value)
		{
            throw new System.NotImplementedException();
		}
		#endregion

	}
}