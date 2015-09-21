// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		21.09.2015 05:11:11
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
	[ExpressType("IFCASYMMETRICISHAPEPROFILEDEF", 672)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcAsymmetricIShapeProfileDef : IfcIShapeProfileDef, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcAsymmetricIShapeProfileDef(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcPositiveLengthMeasure _topFlangeWidth;
		private IfcPositiveLengthMeasure? _topFlangeThickness;
		private IfcPositiveLengthMeasure? _topFlangeFilletRadius;
		private IfcPositiveLengthMeasure? _centreOfGravityInY;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(9, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure @TopFlangeWidth 
		{ 
			get 
			{
				if(Activated) return _topFlangeWidth;
				
				Model.Activate(this, true);
				Activated = true;
				return _topFlangeWidth;
			} 
			set
			{
				SetValue( v =>  _topFlangeWidth = v, _topFlangeWidth, value,  "TopFlangeWidth");
			} 
		}
	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure? @TopFlangeThickness 
		{ 
			get 
			{
				if(Activated) return _topFlangeThickness;
				
				Model.Activate(this, true);
				Activated = true;
				return _topFlangeThickness;
			} 
			set
			{
				SetValue( v =>  _topFlangeThickness = v, _topFlangeThickness, value,  "TopFlangeThickness");
			} 
		}
	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure? @TopFlangeFilletRadius 
		{ 
			get 
			{
				if(Activated) return _topFlangeFilletRadius;
				
				Model.Activate(this, true);
				Activated = true;
				return _topFlangeFilletRadius;
			} 
			set
			{
				SetValue( v =>  _topFlangeFilletRadius = v, _topFlangeFilletRadius, value,  "TopFlangeFilletRadius");
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
				case 3: 
				case 4: 
				case 5: 
				case 6: 
				case 7: 
					base.Parse(propIndex, value); 
					return;
				case 8: 
					_topFlangeWidth = value.RealVal;
					return;
				case 9: 
					_topFlangeThickness = value.RealVal;
					return;
				case 10: 
					_topFlangeFilletRadius = value.RealVal;
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