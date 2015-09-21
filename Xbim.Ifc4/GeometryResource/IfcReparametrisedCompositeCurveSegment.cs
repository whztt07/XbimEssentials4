// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		21.09.2015 05:11:20
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
	[IndexedClass]
	[ExpressType("IFCREPARAMETRISEDCOMPOSITECURVESEGMENT", 949)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcReparametrisedCompositeCurveSegment : IfcCompositeCurveSegment, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcReparametrisedCompositeCurveSegment(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcParameterValue _paramLength;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcParameterValue @ParamLength 
		{ 
			get 
			{
				if(Activated) return _paramLength;
				
				Model.Activate(this, true);
				Activated = true;
				return _paramLength;
			} 
			set
			{
				SetValue( v =>  _paramLength = v, _paramLength, value,  "ParamLength");
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
					_paramLength = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*PositiveLengthParameter:	PositiveLengthParameter : ParamLength > 0.0;*/
		}
		#endregion
	}
}