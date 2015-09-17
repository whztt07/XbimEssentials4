// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 03:44:07
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.GeometryResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.ProfileResource
{
	[EntityName("IFCTSHAPEPROFILEDEF", 684)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcTShapeProfileDef : IfcParameterizedProfileDef, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTShapeProfileDef(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcPositiveLengthMeasure _depth;
		private IfcPositiveLengthMeasure _flangeWidth;
		private IfcPositiveLengthMeasure _webThickness;
		private IfcPositiveLengthMeasure _flangeThickness;
		private IfcNonNegativeLengthMeasure? _filletRadius;
		private IfcNonNegativeLengthMeasure? _flangeEdgeRadius;
		private IfcNonNegativeLengthMeasure? _webEdgeRadius;
		private IfcPlaneAngleMeasure? _webSlope;
		private IfcPlaneAngleMeasure? _flangeSlope;
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
	
		[EntityAttribute(4, EntityAttributeState.Mandatory)]
		public IfcPositiveLengthMeasure @FlangeWidth 
		{ 
			get 
			{
				if(Activated) return _flangeWidth;
				
				Model.Activate(this, true);
				Activated = true;
				return _flangeWidth;
			} 
			set
			{
				SetValue( v =>  _flangeWidth = v, _flangeWidth, value,  "FlangeWidth");
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Mandatory)]
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
	
		[EntityAttribute(6, EntityAttributeState.Mandatory)]
		public IfcPositiveLengthMeasure @FlangeThickness 
		{ 
			get 
			{
				if(Activated) return _flangeThickness;
				
				Model.Activate(this, true);
				Activated = true;
				return _flangeThickness;
			} 
			set
			{
				SetValue( v =>  _flangeThickness = v, _flangeThickness, value,  "FlangeThickness");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Optional)]
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
	
		[EntityAttribute(8, EntityAttributeState.Optional)]
		public IfcNonNegativeLengthMeasure? @FlangeEdgeRadius 
		{ 
			get 
			{
				if(Activated) return _flangeEdgeRadius;
				
				Model.Activate(this, true);
				Activated = true;
				return _flangeEdgeRadius;
			} 
			set
			{
				SetValue( v =>  _flangeEdgeRadius = v, _flangeEdgeRadius, value,  "FlangeEdgeRadius");
			} 
		}
	
		[EntityAttribute(9, EntityAttributeState.Optional)]
		public IfcNonNegativeLengthMeasure? @WebEdgeRadius 
		{ 
			get 
			{
				if(Activated) return _webEdgeRadius;
				
				Model.Activate(this, true);
				Activated = true;
				return _webEdgeRadius;
			} 
			set
			{
				SetValue( v =>  _webEdgeRadius = v, _webEdgeRadius, value,  "WebEdgeRadius");
			} 
		}
	
		[EntityAttribute(10, EntityAttributeState.Optional)]
		public IfcPlaneAngleMeasure? @WebSlope 
		{ 
			get 
			{
				if(Activated) return _webSlope;
				
				Model.Activate(this, true);
				Activated = true;
				return _webSlope;
			} 
			set
			{
				SetValue( v =>  _webSlope = v, _webSlope, value,  "WebSlope");
			} 
		}
	
		[EntityAttribute(11, EntityAttributeState.Optional)]
		public IfcPlaneAngleMeasure? @FlangeSlope 
		{ 
			get 
			{
				if(Activated) return _flangeSlope;
				
				Model.Activate(this, true);
				Activated = true;
				return _flangeSlope;
			} 
			set
			{
				SetValue( v =>  _flangeSlope = v, _flangeSlope, value,  "FlangeSlope");
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
					_depth = value.RealVal;
					return;
				case 4: 
					_flangeWidth = value.RealVal;
					return;
				case 5: 
					_webThickness = value.RealVal;
					return;
				case 6: 
					_flangeThickness = value.RealVal;
					return;
				case 7: 
					_filletRadius = value.RealVal;
					return;
				case 8: 
					_flangeEdgeRadius = value.RealVal;
					return;
				case 9: 
					_webEdgeRadius = value.RealVal;
					return;
				case 10: 
					_webSlope = value.RealVal;
					return;
				case 11: 
					_flangeSlope = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*ValidFlangeThickness:	ValidFlangeThickness : FlangeThickness < Depth;*/
		/*ValidWebThickness:	ValidWebThickness : WebThickness < FlangeWidth;*/
		}
		#endregion
	}
}