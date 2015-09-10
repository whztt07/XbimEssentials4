// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		09/09/2015 04:20:42
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.GeometryResource;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc4.ProfileResource
{
	[EntityName("IFCLSHAPEPROFILEDEF", 326)]
	public  partial class @IfcLShapeProfileDef : IfcParameterizedProfileDef, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcLShapeProfileDef(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcPositiveLengthMeasure _depth;
		private IfcPositiveLengthMeasure? _width;
		private IfcPositiveLengthMeasure _thickness;
		private IfcNonNegativeLengthMeasure? _filletRadius;
		private IfcNonNegativeLengthMeasure? _edgeRadius;
		private IfcPlaneAngleMeasure? _legSlope;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(3, EntityAttributeState.Mandatory)]
		public IfcPositiveLengthMeasure @Depth 
		{ 
			get 
			{
				if(Activated) return _depth;
				
				Model.Activate(this, true);
				Activated = true;
				return _depth;
			} 
			set
			{
				SetValue( v =>  _depth = v, _depth, value,  "Depth");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Optional)]
		public IfcPositiveLengthMeasure? @Width 
		{ 
			get 
			{
				if(Activated) return _width;
				
				Model.Activate(this, true);
				Activated = true;
				return _width;
			} 
			set
			{
				SetValue( v =>  _width = v, _width, value,  "Width");
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Mandatory)]
		public IfcPositiveLengthMeasure @Thickness 
		{ 
			get 
			{
				if(Activated) return _thickness;
				
				Model.Activate(this, true);
				Activated = true;
				return _thickness;
			} 
			set
			{
				SetValue( v =>  _thickness = v, _thickness, value,  "Thickness");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Optional)]
		public IfcNonNegativeLengthMeasure? @FilletRadius 
		{ 
			get 
			{
				if(Activated) return _filletRadius;
				
				Model.Activate(this, true);
				Activated = true;
				return _filletRadius;
			} 
			set
			{
				SetValue( v =>  _filletRadius = v, _filletRadius, value,  "FilletRadius");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Optional)]
		public IfcNonNegativeLengthMeasure? @EdgeRadius 
		{ 
			get 
			{
				if(Activated) return _edgeRadius;
				
				Model.Activate(this, true);
				Activated = true;
				return _edgeRadius;
			} 
			set
			{
				SetValue( v =>  _edgeRadius = v, _edgeRadius, value,  "EdgeRadius");
			} 
		}
	
		[EntityAttribute(8, EntityAttributeState.Optional)]
		public IfcPlaneAngleMeasure? @LegSlope 
		{ 
			get 
			{
				if(Activated) return _legSlope;
				
				Model.Activate(this, true);
				Activated = true;
				return _legSlope;
			} 
			set
			{
				SetValue( v =>  _legSlope = v, _legSlope, value,  "LegSlope");
			} 
		}
	
		#endregion

		#region Inverse attributes

		#endregion

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"ProfileType",
			"ProfileName",
			"Position",
			"Depth",
			"Width",
			"Thickness",
			"FilletRadius",
			"EdgeRadius",
			"LegSlope",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @ProfileType;
				case 1: 
					return @ProfileName;
				case 2: 
					return @Position;
				case 3: 
					return @Depth;
				case 4: 
					return @Width;
				case 5: 
					return @Thickness;
				case 6: 
					return @FilletRadius;
				case 7: 
					return @EdgeRadius;
				case 8: 
					return @LegSlope;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "ProfileType":  
					return @ProfileType;
				case "ProfileName":  
					return @ProfileName;
				case "Position":  
					return @Position;
				case "Depth":  
					return @Depth;
				case "Width":  
					return @Width;
				case "Thickness":  
					return @Thickness;
				case "FilletRadius":  
					return @FilletRadius;
				case "EdgeRadius":  
					return @EdgeRadius;
				case "LegSlope":  
					return @LegSlope;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 if (value != null) @ProfileType = (IfcProfileTypeEnum)value;
					 break;
				case 1:
					 @ProfileName = (IfcLabel?)value;
					 break;
				case 2:
					 @Position = (IfcAxis2Placement2D)value;
					 break;
				case 3:
					 if (value != null) @Depth = (IfcPositiveLengthMeasure)value;
					 break;
				case 4:
					 @Width = (IfcPositiveLengthMeasure?)value;
					 break;
				case 5:
					 if (value != null) @Thickness = (IfcPositiveLengthMeasure)value;
					 break;
				case 6:
					 @FilletRadius = (IfcNonNegativeLengthMeasure?)value;
					 break;
				case 7:
					 @EdgeRadius = (IfcNonNegativeLengthMeasure?)value;
					 break;
				case 8:
					 @LegSlope = (IfcPlaneAngleMeasure?)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "ProfileType":
					 if (value != null) @ProfileType = (IfcProfileTypeEnum)value;
					 break;
				case "ProfileName":
					 @ProfileName = (IfcLabel?)value;
					 break;
				case "Position":
					 @Position = (IfcAxis2Placement2D)value;
					 break;
				case "Depth":
					 if (value != null) @Depth = (IfcPositiveLengthMeasure)value;
					 break;
				case "Width":
					 @Width = (IfcPositiveLengthMeasure?)value;
					 break;
				case "Thickness":
					 if (value != null) @Thickness = (IfcPositiveLengthMeasure)value;
					 break;
				case "FilletRadius":
					 @FilletRadius = (IfcNonNegativeLengthMeasure?)value;
					 break;
				case "EdgeRadius":
					 @EdgeRadius = (IfcNonNegativeLengthMeasure?)value;
					 break;
				case "LegSlope":
					 @LegSlope = (IfcPlaneAngleMeasure?)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion

		#region Where rules
		/*ValidThickness:	ValidThickness : (Thickness < Depth) AND (NOT(EXISTS(Width)) OR (Thickness < Width));*/
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