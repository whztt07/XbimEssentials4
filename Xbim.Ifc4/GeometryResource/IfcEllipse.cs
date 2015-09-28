// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.GeometryResource
{
	[ExpressType("IFCELLIPSE", 618)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcEllipse : IfcConic, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcEllipse(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcPositiveLengthMeasure _semiAxis1;
		private IfcPositiveLengthMeasure _semiAxis2;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure @SemiAxis1 
		{ 
			get 
			{
				if(Activated) return _semiAxis1;
				
				Model.Activate(this, true);
				Activated = true;
				return _semiAxis1;
			} 
			set
			{
				SetValue( v =>  _semiAxis1 = v, _semiAxis1, value,  "SemiAxis1");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure @SemiAxis2 
		{ 
			get 
			{
				if(Activated) return _semiAxis2;
				
				Model.Activate(this, true);
				Activated = true;
				return _semiAxis2;
			} 
			set
			{
				SetValue( v =>  _semiAxis2 = v, _semiAxis2, value,  "SemiAxis2");
			} 
		}
	
		#endregion



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
					base.Parse(propIndex, value); 
					return;
				case 1: 
					_semiAxis1 = value.RealVal;
					return;
				case 2: 
					_semiAxis2 = value.RealVal;
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