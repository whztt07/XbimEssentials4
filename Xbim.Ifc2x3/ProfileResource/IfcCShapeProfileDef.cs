// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
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
	[ExpressType("IFCCSHAPEPROFILEDEF", 501)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcCShapeProfileDef : IfcParameterizedProfileDef, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcCShapeProfileDef(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcPositiveLengthMeasure _depth;
		private IfcPositiveLengthMeasure _width;
		private IfcPositiveLengthMeasure _wallThickness;
		private IfcPositiveLengthMeasure _girth;
		private IfcPositiveLengthMeasure? _internalFilletRadius;
		private IfcPositiveLengthMeasure? _centreOfGravityInX;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
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
	
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure @Width 
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
	
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure @WallThickness 
		{ 
			get 
			{
				if(Activated) return _wallThickness;
				
				Model.Activate(this, true);
				Activated = true;
				return _wallThickness;
			} 
			set
			{
				SetValue( v =>  _wallThickness = v, _wallThickness, value,  "WallThickness");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure @Girth 
		{ 
			get 
			{
				if(Activated) return _girth;
				
				Model.Activate(this, true);
				Activated = true;
				return _girth;
			} 
			set
			{
				SetValue( v =>  _girth = v, _girth, value,  "Girth");
			} 
		}
	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure? @InternalFilletRadius 
		{ 
			get 
			{
				if(Activated) return _internalFilletRadius;
				
				Model.Activate(this, true);
				Activated = true;
				return _internalFilletRadius;
			} 
			set
			{
				SetValue( v =>  _internalFilletRadius = v, _internalFilletRadius, value,  "InternalFilletRadius");
			} 
		}
	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure? @CentreOfGravityInX 
		{ 
			get 
			{
				if(Activated) return _centreOfGravityInX;
				
				Model.Activate(this, true);
				Activated = true;
				return _centreOfGravityInX;
			} 
			set
			{
				SetValue( v =>  _centreOfGravityInX = v, _centreOfGravityInX, value,  "CentreOfGravityInX");
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
					base.Parse(propIndex, value); 
					return;
				case 3: 
					_depth = value.RealVal;
					return;
				case 4: 
					_width = value.RealVal;
					return;
				case 5: 
					_wallThickness = value.RealVal;
					return;
				case 6: 
					_girth = value.RealVal;
					return;
				case 7: 
					_internalFilletRadius = value.RealVal;
					return;
				case 8: 
					_centreOfGravityInX = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR1:	WR1 : Girth < (Depth / 2.);*/
		/*WR2:            ((InternalFilletRadius <= Width/2.) AND (InternalFilletRadius <= Depth/2.));*/
		/*WR3:	WR3 : (WallThickness < Width/2.) AND (WallThickness < Depth/2.);*/
		}
		#endregion
	}
}