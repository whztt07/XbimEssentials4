// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		09/09/2015 04:20:41
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.GeometryResource;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc4.RepresentationResource
{
	[EntityName("IFCGEOMETRICREPRESENTATIONSUBCONTEXT", 303)]
	public  partial class @IfcGeometricRepresentationSubContext : IfcGeometricRepresentationContext, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcGeometricRepresentationSubContext(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcGeometricRepresentationContext _parentContext;
		private IfcPositiveRatioMeasure? _targetScale;
		private IfcGeometricProjectionEnum _targetView;
		private IfcLabel? _userDefinedTargetView;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(6, EntityAttributeState.Mandatory)]
		public IfcGeometricRepresentationContext @ParentContext 
		{ 
			get 
			{
				if(Activated) return _parentContext;
				
				Model.Activate(this, true);
				Activated = true;
				return _parentContext;
			} 
			set
			{
				SetValue( v =>  _parentContext = v, _parentContext, value,  "ParentContext");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Optional)]
		public IfcPositiveRatioMeasure? @TargetScale 
		{ 
			get 
			{
				if(Activated) return _targetScale;
				
				Model.Activate(this, true);
				Activated = true;
				return _targetScale;
			} 
			set
			{
				SetValue( v =>  _targetScale = v, _targetScale, value,  "TargetScale");
			} 
		}
	
		[EntityAttribute(8, EntityAttributeState.Mandatory)]
		public IfcGeometricProjectionEnum @TargetView 
		{ 
			get 
			{
				if(Activated) return _targetView;
				
				Model.Activate(this, true);
				Activated = true;
				return _targetView;
			} 
			set
			{
				SetValue( v =>  _targetView = v, _targetView, value,  "TargetView");
			} 
		}
	
		[EntityAttribute(9, EntityAttributeState.Optional)]
		public IfcLabel? @UserDefinedTargetView 
		{ 
			get 
			{
				if(Activated) return _userDefinedTargetView;
				
				Model.Activate(this, true);
				Activated = true;
				return _userDefinedTargetView;
			} 
			set
			{
				SetValue( v =>  _userDefinedTargetView = v, _userDefinedTargetView, value,  "UserDefinedTargetView");
			} 
		}
	
		#endregion

		#region Inverse attributes

		#endregion

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"ContextIdentifier",
			"ContextType",
			"CoordinateSpaceDimension",
			"Precision",
			"WorldCoordinateSystem",
			"TrueNorth",
			"ParentContext",
			"TargetScale",
			"TargetView",
			"UserDefinedTargetView",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @ContextIdentifier;
				case 1: 
					return @ContextType;
				case 2: 
					return @CoordinateSpaceDimension;
				case 3: 
					return @Precision;
				case 4: 
					return @WorldCoordinateSystem;
				case 5: 
					return @TrueNorth;
				case 6: 
					return @ParentContext;
				case 7: 
					return @TargetScale;
				case 8: 
					return @TargetView;
				case 9: 
					return @UserDefinedTargetView;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "ContextIdentifier":  
					return @ContextIdentifier;
				case "ContextType":  
					return @ContextType;
				case "CoordinateSpaceDimension":  
					return @CoordinateSpaceDimension;
				case "Precision":  
					return @Precision;
				case "WorldCoordinateSystem":  
					return @WorldCoordinateSystem;
				case "TrueNorth":  
					return @TrueNorth;
				case "ParentContext":  
					return @ParentContext;
				case "TargetScale":  
					return @TargetScale;
				case "TargetView":  
					return @TargetView;
				case "UserDefinedTargetView":  
					return @UserDefinedTargetView;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 @ContextIdentifier = (IfcLabel?)value;
					 break;
				case 1:
					 @ContextType = (IfcLabel?)value;
					 break;
				case 2:
					 if (value != null) @CoordinateSpaceDimension = (IfcDimensionCount)value;
					 break;
				case 3:
					 @Precision = (double?)value;
					 break;
				case 4:
					 @WorldCoordinateSystem = (IfcAxis2Placement)value;
					 break;
				case 5:
					 @TrueNorth = (IfcDirection)value;
					 break;
				case 6:
					 @ParentContext = (IfcGeometricRepresentationContext)value;
					 break;
				case 7:
					 @TargetScale = (IfcPositiveRatioMeasure?)value;
					 break;
				case 8:
					 if (value != null) @TargetView = (IfcGeometricProjectionEnum)value;
					 break;
				case 9:
					 @UserDefinedTargetView = (IfcLabel?)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "ContextIdentifier":
					 @ContextIdentifier = (IfcLabel?)value;
					 break;
				case "ContextType":
					 @ContextType = (IfcLabel?)value;
					 break;
				case "CoordinateSpaceDimension":
					 if (value != null) @CoordinateSpaceDimension = (IfcDimensionCount)value;
					 break;
				case "Precision":
					 @Precision = (double?)value;
					 break;
				case "WorldCoordinateSystem":
					 @WorldCoordinateSystem = (IfcAxis2Placement)value;
					 break;
				case "TrueNorth":
					 @TrueNorth = (IfcDirection)value;
					 break;
				case "ParentContext":
					 @ParentContext = (IfcGeometricRepresentationContext)value;
					 break;
				case "TargetScale":
					 @TargetScale = (IfcPositiveRatioMeasure?)value;
					 break;
				case "TargetView":
					 if (value != null) @TargetView = (IfcGeometricProjectionEnum)value;
					 break;
				case "UserDefinedTargetView":
					 @UserDefinedTargetView = (IfcLabel?)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion

		#region Where rules
		/*WR31:	WR31 : NOT('IFC4.IFCGEOMETRICREPRESENTATIONSUBCONTEXT' IN TYPEOF(ParentContext));*/
		/*WR32:              EXISTS(UserDefinedTargetView));*/
		#endregion

		#region IPersist implementation
		void IPersist.Set(int propIndex, IPropertyValue value)
		{
            throw new System.NotImplementedException();
		}
		#endregion

		public  override string WhereRule() 
		{
			return "";
		}
	}
}