// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 03:44:03
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
	[EntityName("IFCCSHAPEPROFILEDEF", 67)]
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
		private IfcNonNegativeLengthMeasure? _internalFilletRadius;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttributee(3, EntityAttributeState.Mandatory)]
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
	
		[EntityAttributee(4, EntityAttributeState.Mandatory)]
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
	
		[EntityAttributee(5, EntityAttributeState.Mandatory)]
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
	
		[EntityAttributee(6, EntityAttributeState.Mandatory)]
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
	
		[EntityAttributee(7, EntityAttributeState.Optional)]
		public IfcNonNegativeLengthMeasure? @InternalFilletRadius 
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
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*ValidGirth:	ValidGirth : Girth < (Depth / 2.);*/
		/*ValidInternalFilletRadius:                                  ((InternalFilletRadius <= Width/2. - WallThickness) AND (InternalFilletRadius <= Depth/2. - WallThickness));*/
		/*ValidWallThickness:	ValidWallThickness : (WallThickness < Width/2.) AND (WallThickness < Depth/2.);*/
		}
		#endregion
	}
}