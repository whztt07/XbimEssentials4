// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		24.09.2015 10:03:32
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.GeometryResource;
using Xbim.Ifc2x3.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.GeometricModelResource
{
	[IndexedClass]
	[ExpressType("IFCBOUNDINGBOX", 151)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcBoundingBox : IfcGeometricRepresentationItem, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcBoundingBox(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcCartesianPoint _corner;
		private IfcPositiveLengthMeasure _xDim;
		private IfcPositiveLengthMeasure _yDim;
		private IfcPositiveLengthMeasure _zDim;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcCartesianPoint @Corner 
		{ 
			get 
			{
				if(Activated) return _corner;
				
				Model.Activate(this, true);
				Activated = true;
				return _corner;
			} 
			set
			{
				SetValue( v =>  _corner = v, _corner, value,  "Corner");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure @XDim 
		{ 
			get 
			{
				if(Activated) return _xDim;
				
				Model.Activate(this, true);
				Activated = true;
				return _xDim;
			} 
			set
			{
				SetValue( v =>  _xDim = v, _xDim, value,  "XDim");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
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
	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure @ZDim 
		{ 
			get 
			{
				if(Activated) return _zDim;
				
				Model.Activate(this, true);
				Activated = true;
				return _zDim;
			} 
			set
			{
				SetValue( v =>  _zDim = v, _zDim, value,  "ZDim");
			} 
		}
	
		#endregion



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
					_corner = (IfcCartesianPoint)(value.EntityVal);
					return;
				case 1: 
					_xDim = value.RealVal;
					return;
				case 2: 
					_yDim = value.RealVal;
					return;
				case 3: 
					_zDim = value.RealVal;
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