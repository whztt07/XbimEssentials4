// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		24.09.2015 10:03:44
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
	[IndexedClass]
	[ExpressType("IFCTRAPEZIUMPROFILEDEF", 1112)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcTrapeziumProfileDef : IfcParameterizedProfileDef, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTrapeziumProfileDef(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcPositiveLengthMeasure _bottomXDim;
		private IfcPositiveLengthMeasure _topXDim;
		private IfcPositiveLengthMeasure _yDim;
		private IfcLengthMeasure _topXOffset;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure @BottomXDim 
		{ 
			get 
			{
				if(Activated) return _bottomXDim;
				
				Model.Activate(this, true);
				Activated = true;
				return _bottomXDim;
			} 
			set
			{
				SetValue( v =>  _bottomXDim = v, _bottomXDim, value,  "BottomXDim");
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure @TopXDim 
		{ 
			get 
			{
				if(Activated) return _topXDim;
				
				Model.Activate(this, true);
				Activated = true;
				return _topXDim;
			} 
			set
			{
				SetValue( v =>  _topXDim = v, _topXDim, value,  "TopXDim");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure @YDim 
		{ 
			get 
			{
				if(Activated) return _yDim;
				
				Model.Activate(this, true);
				Activated = true;
				return _yDim;
			} 
			set
			{
				SetValue( v =>  _yDim = v, _yDim, value,  "YDim");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLengthMeasure @TopXOffset 
		{ 
			get 
			{
				if(Activated) return _topXOffset;
				
				Model.Activate(this, true);
				Activated = true;
				return _topXOffset;
			} 
			set
			{
				SetValue( v =>  _topXOffset = v, _topXOffset, value,  "TopXOffset");
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
					_bottomXDim = value.RealVal;
					return;
				case 4: 
					_topXDim = value.RealVal;
					return;
				case 5: 
					_yDim = value.RealVal;
					return;
				case 6: 
					_topXOffset = value.RealVal;
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