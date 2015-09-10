// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		09/09/2015 04:20:34
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
	[EntityName("IFCDOORLININGPROPERTIES", 493)]
	public  partial class @IfcDoorLiningProperties : IfcPropertySetDefinition, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcDoorLiningProperties(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcPositiveLengthMeasure? _liningDepth;
		private IfcPositiveLengthMeasure? _liningThickness;
		private IfcPositiveLengthMeasure? _thresholdDepth;
		private IfcPositiveLengthMeasure? _thresholdThickness;
		private IfcPositiveLengthMeasure? _transomThickness;
		private IfcLengthMeasure? _transomOffset;
		private IfcLengthMeasure? _liningOffset;
		private IfcLengthMeasure? _thresholdOffset;
		private IfcPositiveLengthMeasure? _casingThickness;
		private IfcPositiveLengthMeasure? _casingDepth;
		private IfcShapeAspect _shapeAspectStyle;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Optional)]
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
	
		[EntityAttribute(5, EntityAttributeState.Optional)]
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
	
		[EntityAttribute(6, EntityAttributeState.Optional)]
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
	
		[EntityAttribute(7, EntityAttributeState.Optional)]
		public IfcPositiveLengthMeasure? @ThresholdThickness 
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
	
		[EntityAttribute(8, EntityAttributeState.Optional)]
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
	
		[EntityAttribute(9, EntityAttributeState.Optional)]
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
	
		[EntityAttribute(10, EntityAttributeState.Optional)]
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
	
		[EntityAttribute(11, EntityAttributeState.Optional)]
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
	
		[EntityAttribute(12, EntityAttributeState.Optional)]
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
	
		[EntityAttribute(13, EntityAttributeState.Optional)]
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
	
		[EntityAttribute(14, EntityAttributeState.Optional)]
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

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"GlobalId",
			"OwnerHistory",
			"Name",
			"Description",
			"LiningDepth",
			"LiningThickness",
			"ThresholdDepth",
			"ThresholdThickness",
			"TransomThickness",
			"TransomOffset",
			"LiningOffset",
			"ThresholdOffset",
			"CasingThickness",
			"CasingDepth",
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
					return @LiningDepth;
				case 5: 
					return @LiningThickness;
				case 6: 
					return @ThresholdDepth;
				case 7: 
					return @ThresholdThickness;
				case 8: 
					return @TransomThickness;
				case 9: 
					return @TransomOffset;
				case 10: 
					return @LiningOffset;
				case 11: 
					return @ThresholdOffset;
				case 12: 
					return @CasingThickness;
				case 13: 
					return @CasingDepth;
				case 14: 
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
				case "LiningDepth":  
					return @LiningDepth;
				case "LiningThickness":  
					return @LiningThickness;
				case "ThresholdDepth":  
					return @ThresholdDepth;
				case "ThresholdThickness":  
					return @ThresholdThickness;
				case "TransomThickness":  
					return @TransomThickness;
				case "TransomOffset":  
					return @TransomOffset;
				case "LiningOffset":  
					return @LiningOffset;
				case "ThresholdOffset":  
					return @ThresholdOffset;
				case "CasingThickness":  
					return @CasingThickness;
				case "CasingDepth":  
					return @CasingDepth;
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
					 @LiningDepth = (IfcPositiveLengthMeasure?)value;
					 break;
				case 5:
					 @LiningThickness = (IfcPositiveLengthMeasure?)value;
					 break;
				case 6:
					 @ThresholdDepth = (IfcPositiveLengthMeasure?)value;
					 break;
				case 7:
					 @ThresholdThickness = (IfcPositiveLengthMeasure?)value;
					 break;
				case 8:
					 @TransomThickness = (IfcPositiveLengthMeasure?)value;
					 break;
				case 9:
					 @TransomOffset = (IfcLengthMeasure?)value;
					 break;
				case 10:
					 @LiningOffset = (IfcLengthMeasure?)value;
					 break;
				case 11:
					 @ThresholdOffset = (IfcLengthMeasure?)value;
					 break;
				case 12:
					 @CasingThickness = (IfcPositiveLengthMeasure?)value;
					 break;
				case 13:
					 @CasingDepth = (IfcPositiveLengthMeasure?)value;
					 break;
				case 14:
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
				case "LiningDepth":
					 @LiningDepth = (IfcPositiveLengthMeasure?)value;
					 break;
				case "LiningThickness":
					 @LiningThickness = (IfcPositiveLengthMeasure?)value;
					 break;
				case "ThresholdDepth":
					 @ThresholdDepth = (IfcPositiveLengthMeasure?)value;
					 break;
				case "ThresholdThickness":
					 @ThresholdThickness = (IfcPositiveLengthMeasure?)value;
					 break;
				case "TransomThickness":
					 @TransomThickness = (IfcPositiveLengthMeasure?)value;
					 break;
				case "TransomOffset":
					 @TransomOffset = (IfcLengthMeasure?)value;
					 break;
				case "LiningOffset":
					 @LiningOffset = (IfcLengthMeasure?)value;
					 break;
				case "ThresholdOffset":
					 @ThresholdOffset = (IfcLengthMeasure?)value;
					 break;
				case "CasingThickness":
					 @CasingThickness = (IfcPositiveLengthMeasure?)value;
					 break;
				case "CasingDepth":
					 @CasingDepth = (IfcPositiveLengthMeasure?)value;
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
		/*WR31:	WR31 : NOT(NOT(EXISTS(LiningDepth)) AND EXISTS(LiningThickness));*/
		/*WR32:	WR32 : NOT(NOT(EXISTS(ThresholdDepth)) AND EXISTS(ThresholdThickness));*/
		/*WR33:             (NOT(EXISTS(TransomOffset)) AND NOT(EXISTS(TransomThickness)));*/
		/*WR34:             (NOT(EXISTS(CasingDepth)) AND NOT(EXISTS(CasingThickness)));*/
		/*WR35:             ('IFC2X3.IFCDOORSTYLE' IN TYPEOF(SELF\IfcPropertySetDefinition.DefinesType[1]));*/
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