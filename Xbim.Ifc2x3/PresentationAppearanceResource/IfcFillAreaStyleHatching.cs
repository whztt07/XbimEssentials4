// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		15.09.2015 07:04:16
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.GeometryResource;
using Xbim.Ifc2x3.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc2x3.PresentationAppearanceResource
{
	[EntityName("IFCFILLAREASTYLEHATCHING", 462)]
	public  partial class @IfcFillAreaStyleHatching : IfcGeometricRepresentationItem, IfcFillStyleSelect, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcFillAreaStyleHatching(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcCurveStyle _hatchLineAppearance;
		private IfcHatchLineDistanceSelect _startOfNextHatchLine;
		private IfcCartesianPoint _pointOfReferenceHatchLine;
		private IfcCartesianPoint _patternStart;
		private IfcPlaneAngleMeasure _hatchLineAngle;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(0, EntityAttributeState.Mandatory)]
		public IfcCurveStyle @HatchLineAppearance 
		{ 
			get 
			{
				if(Activated) return _hatchLineAppearance;
				
				Model.Activate(this, true);
				Activated = true;
				return _hatchLineAppearance;
			} 
			set
			{
				SetValue( v =>  _hatchLineAppearance = v, _hatchLineAppearance, value,  "HatchLineAppearance");
			} 
		}
	
		[EntityAttribute(1, EntityAttributeState.Mandatory)]
		public IfcHatchLineDistanceSelect @StartOfNextHatchLine 
		{ 
			get 
			{
				if(Activated) return _startOfNextHatchLine;
				
				Model.Activate(this, true);
				Activated = true;
				return _startOfNextHatchLine;
			} 
			set
			{
				SetValue( v =>  _startOfNextHatchLine = v, _startOfNextHatchLine, value,  "StartOfNextHatchLine");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Optional)]
		public IfcCartesianPoint @PointOfReferenceHatchLine 
		{ 
			get 
			{
				if(Activated) return _pointOfReferenceHatchLine;
				
				Model.Activate(this, true);
				Activated = true;
				return _pointOfReferenceHatchLine;
			} 
			set
			{
				SetValue( v =>  _pointOfReferenceHatchLine = v, _pointOfReferenceHatchLine, value,  "PointOfReferenceHatchLine");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Optional)]
		public IfcCartesianPoint @PatternStart 
		{ 
			get 
			{
				if(Activated) return _patternStart;
				
				Model.Activate(this, true);
				Activated = true;
				return _patternStart;
			} 
			set
			{
				SetValue( v =>  _patternStart = v, _patternStart, value,  "PatternStart");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Mandatory)]
		public IfcPlaneAngleMeasure @HatchLineAngle 
		{ 
			get 
			{
				if(Activated) return _hatchLineAngle;
				
				Model.Activate(this, true);
				Activated = true;
				return _hatchLineAngle;
			} 
			set
			{
				SetValue( v =>  _hatchLineAngle = v, _hatchLineAngle, value,  "HatchLineAngle");
			} 
		}
	
		#endregion

		#region Inverse attributes

		#endregion

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"HatchLineAppearance",
			"StartOfNextHatchLine",
			"PointOfReferenceHatchLine",
			"PatternStart",
			"HatchLineAngle",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @HatchLineAppearance;
				case 1: 
					return @StartOfNextHatchLine;
				case 2: 
					return @PointOfReferenceHatchLine;
				case 3: 
					return @PatternStart;
				case 4: 
					return @HatchLineAngle;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "HatchLineAppearance":  
					return @HatchLineAppearance;
				case "StartOfNextHatchLine":  
					return @StartOfNextHatchLine;
				case "PointOfReferenceHatchLine":  
					return @PointOfReferenceHatchLine;
				case "PatternStart":  
					return @PatternStart;
				case "HatchLineAngle":  
					return @HatchLineAngle;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 @HatchLineAppearance = (IfcCurveStyle)value;
					 break;
				case 1:
					 @StartOfNextHatchLine = (IfcHatchLineDistanceSelect)value;
					 break;
				case 2:
					 @PointOfReferenceHatchLine = (IfcCartesianPoint)value;
					 break;
				case 3:
					 @PatternStart = (IfcCartesianPoint)value;
					 break;
				case 4:
					 if (value != null) @HatchLineAngle = (IfcPlaneAngleMeasure)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "HatchLineAppearance":
					 @HatchLineAppearance = (IfcCurveStyle)value;
					 break;
				case "StartOfNextHatchLine":
					 @StartOfNextHatchLine = (IfcHatchLineDistanceSelect)value;
					 break;
				case "PointOfReferenceHatchLine":
					 @PointOfReferenceHatchLine = (IfcCartesianPoint)value;
					 break;
				case "PatternStart":
					 @PatternStart = (IfcCartesianPoint)value;
					 break;
				case "HatchLineAngle":
					 if (value != null) @HatchLineAngle = (IfcPlaneAngleMeasure)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion

		#region Where rules
		/*WR21:             );*/
		/*WR22:             OR (PatternStart.Dim = 2);*/
		/*WR23:             OR (PointOfReferenceHatchLine.Dim = 2);*/
		#endregion

		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
            throw new System.NotImplementedException();
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		}
		#endregion

		
	}
}