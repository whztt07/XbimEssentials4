// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		24.09.2015 10:03:34
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
	[ExpressType("IFCRECTANGLEPROFILEDEF", 103)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRectangleProfileDef : IfcParameterizedProfileDef, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRectangleProfileDef(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcPositiveLengthMeasure _xDim;
		private IfcPositiveLengthMeasure _yDim;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
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
	
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
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
					_xDim = value.RealVal;
					return;
				case 4: 
					_yDim = value.RealVal;
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