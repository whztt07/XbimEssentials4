// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
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
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.ArchitectureDomain
{
	[ExpressType("IFCPERMEABLECOVERINGPROPERTIES", 707)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcPermeableCoveringProperties : IfcPropertySetDefinition, IInstantiableEntity, IEqualityComparer<@IfcPermeableCoveringProperties>, IEquatable<@IfcPermeableCoveringProperties>
	{
		public static int LoadDepth = 1;

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
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcPermeableCoveringOperationEnum @OperationType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _operationType;
				((IPersistEntity)this).Activate(false);
				return _operationType;
			} 
			set
			{
				SetValue( v =>  _operationType = v, _operationType, value,  "OperationType");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcWindowPanelPositionEnum @PanelPosition 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _panelPosition;
				((IPersistEntity)this).Activate(false);
				return _panelPosition;
			} 
			set
			{
				SetValue( v =>  _panelPosition = v, _panelPosition, value,  "PanelPosition");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure? @FrameDepth 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _frameDepth;
				((IPersistEntity)this).Activate(false);
				return _frameDepth;
			} 
			set
			{
				SetValue( v =>  _frameDepth = v, _frameDepth, value,  "FrameDepth");
			} 
		}
	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure? @FrameThickness 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _frameThickness;
				((IPersistEntity)this).Activate(false);
				return _frameThickness;
			} 
			set
			{
				SetValue( v =>  _frameThickness = v, _frameThickness, value,  "FrameThickness");
			} 
		}
	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcShapeAspect @ShapeAspectStyle 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _shapeAspectStyle;
				((IPersistEntity)this).Activate(false);
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

		#region Equality comparers and operators
        public bool Equals(@IfcPermeableCoveringProperties other)
	    {
	        return this == other;
	    }


        public static bool operator ==(@IfcPermeableCoveringProperties left, @IfcPermeableCoveringProperties right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcPermeableCoveringProperties left, @IfcPermeableCoveringProperties right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcPermeableCoveringProperties x, @IfcPermeableCoveringProperties y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcPermeableCoveringProperties obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}