// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		22.09.2015 04:44:05
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
	[ExpressType("IFCRECTANGLEHOLLOWPROFILEDEF", 562)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRectangleHollowProfileDef : IfcRectangleProfileDef, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRectangleHollowProfileDef(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcPositiveLengthMeasure _wallThickness;
		private IfcPositiveLengthMeasure? _innerFilletRadius;
		private IfcPositiveLengthMeasure? _outerFilletRadius;
		#endregion
	
		#region Explicit attribute properties
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
	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure? @InnerFilletRadius 
		{ 
			get 
			{
				if(Activated) return _innerFilletRadius;
				
				Model.Activate(this, true);
				Activated = true;
				return _innerFilletRadius;
			} 
			set
			{
				SetValue( v =>  _innerFilletRadius = v, _innerFilletRadius, value,  "InnerFilletRadius");
			} 
		}
	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure? @OuterFilletRadius 
		{ 
			get 
			{
				if(Activated) return _outerFilletRadius;
				
				Model.Activate(this, true);
				Activated = true;
				return _outerFilletRadius;
			} 
			set
			{
				SetValue( v =>  _outerFilletRadius = v, _outerFilletRadius, value,  "OuterFilletRadius");
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
				case 4: 
					base.Parse(propIndex, value); 
					return;
				case 5: 
					_wallThickness = value.RealVal;
					return;
				case 6: 
					_innerFilletRadius = value.RealVal;
					return;
				case 7: 
					_outerFilletRadius = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR31:             (WallThickness < (SELF\IfcRectangleProfileDef.YDim/2.));*/
		/*WR32:              (OuterFilletRadius <= (SELF\IfcRectangleProfileDef.YDim/2.)));*/
		/*WR33:              (InnerFilletRadius <= (SELF\IfcRectangleProfileDef.YDim/2. - WallThickness)));*/
		}
		#endregion
	}
}