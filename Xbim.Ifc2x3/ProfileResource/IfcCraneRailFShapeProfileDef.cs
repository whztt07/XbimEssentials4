// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		22.09.2015 02:31:57
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.GeometryResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.ProfileResource
{
	[IndexedClass]
	[ExpressType("IFCCRANERAILFSHAPEPROFILEDEF", 112)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcCraneRailFShapeProfileDef : IfcParameterizedProfileDef, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcCraneRailFShapeProfileDef(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcPositiveLengthMeasure _overallHeight;
		private IfcPositiveLengthMeasure _headWidth;
		private IfcPositiveLengthMeasure? _radius;
		private IfcPositiveLengthMeasure _headDepth2;
		private IfcPositiveLengthMeasure _headDepth3;
		private IfcPositiveLengthMeasure _webThickness;
		private IfcPositiveLengthMeasure _baseDepth1;
		private IfcPositiveLengthMeasure _baseDepth2;
		private IfcPositiveLengthMeasure? _centreOfGravityInY;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure @OverallHeight 
		{ 
			get 
			{
				if(Activated) return _overallHeight;
				
				Model.Activate(this, true);
				Activated = true;
				return _overallHeight;
			} 
			set
			{
				SetValue( v =>  _overallHeight = v, _overallHeight, value,  "OverallHeight");
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure @HeadWidth 
		{ 
			get 
			{
				if(Activated) return _headWidth;
				
				Model.Activate(this, true);
				Activated = true;
				return _headWidth;
			} 
			set
			{
				SetValue( v =>  _headWidth = v, _headWidth, value,  "HeadWidth");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure? @Radius 
		{ 
			get 
			{
				if(Activated) return _radius;
				
				Model.Activate(this, true);
				Activated = true;
				return _radius;
			} 
			set
			{
				SetValue( v =>  _radius = v, _radius, value,  "Radius");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure @HeadDepth2 
		{ 
			get 
			{
				if(Activated) return _headDepth2;
				
				Model.Activate(this, true);
				Activated = true;
				return _headDepth2;
			} 
			set
			{
				SetValue( v =>  _headDepth2 = v, _headDepth2, value,  "HeadDepth2");
			} 
		}
	
		[EntityAttribute(8, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure @HeadDepth3 
		{ 
			get 
			{
				if(Activated) return _headDepth3;
				
				Model.Activate(this, true);
				Activated = true;
				return _headDepth3;
			} 
			set
			{
				SetValue( v =>  _headDepth3 = v, _headDepth3, value,  "HeadDepth3");
			} 
		}
	
		[EntityAttribute(9, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure @WebThickness 
		{ 
			get 
			{
				if(Activated) return _webThickness;
				
				Model.Activate(this, true);
				Activated = true;
				return _webThickness;
			} 
			set
			{
				SetValue( v =>  _webThickness = v, _webThickness, value,  "WebThickness");
			} 
		}
	
		[EntityAttribute(10, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure @BaseDepth1 
		{ 
			get 
			{
				if(Activated) return _baseDepth1;
				
				Model.Activate(this, true);
				Activated = true;
				return _baseDepth1;
			} 
			set
			{
				SetValue( v =>  _baseDepth1 = v, _baseDepth1, value,  "BaseDepth1");
			} 
		}
	
		[EntityAttribute(11, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure @BaseDepth2 
		{ 
			get 
			{
				if(Activated) return _baseDepth2;
				
				Model.Activate(this, true);
				Activated = true;
				return _baseDepth2;
			} 
			set
			{
				SetValue( v =>  _baseDepth2 = v, _baseDepth2, value,  "BaseDepth2");
			} 
		}
	
		[EntityAttribute(12, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure? @CentreOfGravityInY 
		{ 
			get 
			{
				if(Activated) return _centreOfGravityInY;
				
				Model.Activate(this, true);
				Activated = true;
				return _centreOfGravityInY;
			} 
			set
			{
				SetValue( v =>  _centreOfGravityInY = v, _centreOfGravityInY, value,  "CentreOfGravityInY");
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
					base.Parse(propIndex, value); 
					return;
				case 3: 
					_overallHeight = value.RealVal;
					return;
				case 4: 
					_headWidth = value.RealVal;
					return;
				case 5: 
					_radius = value.RealVal;
					return;
				case 6: 
					_headDepth2 = value.RealVal;
					return;
				case 7: 
					_headDepth3 = value.RealVal;
					return;
				case 8: 
					_webThickness = value.RealVal;
					return;
				case 9: 
					_baseDepth1 = value.RealVal;
					return;
				case 10: 
					_baseDepth2 = value.RealVal;
					return;
				case 11: 
					_centreOfGravityInY = value.RealVal;
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