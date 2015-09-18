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
	[EntityName("IFCARBITRARYOPENPROFILEDEF", 24)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcArbitraryOpenProfileDef : IfcProfileDef, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcArbitraryOpenProfileDef(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcBoundedCurve _curve;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttributee(2, EntityAttributeState.Mandatory)]
		public IfcBoundedCurve @Curve 
		{ 
			get 
			{
				if(Activated) return _curve;
				
				Model.Activate(this, true);
				Activated = true;
				return _curve;
			} 
			set
			{
				SetValue( v =>  _curve = v, _curve, value,  "Curve");
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
					base.Parse(propIndex, value); 
					return;
				case 2: 
					_curve = (IfcBoundedCurve)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR11:              (SELF\IfcProfileDef.ProfileType = IfcProfileTypeEnum.CURVE);*/
		/*WR12:	WR12 : Curve.Dim = 2;*/
		}
		#endregion
	}
}