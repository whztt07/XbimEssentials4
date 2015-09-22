// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		22.09.2015 04:44:03
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
	[ExpressType("IFCARBITRARYCLOSEDPROFILEDEF", 115)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcArbitraryClosedProfileDef : IfcProfileDef, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcArbitraryClosedProfileDef(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcCurve _outerCurve;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcCurve @OuterCurve 
		{ 
			get 
			{
				if(Activated) return _outerCurve;
				
				Model.Activate(this, true);
				Activated = true;
				return _outerCurve;
			} 
			set
			{
				SetValue( v =>  _outerCurve = v, _outerCurve, value,  "OuterCurve");
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
					base.Parse(propIndex, value); 
					return;
				case 2: 
					_outerCurve = (IfcCurve)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR1:	WR1 : OuterCurve.Dim = 2;*/
		/*WR2:	WR2 : NOT('IFC2X3.IFCLINE' IN TYPEOF(OuterCurve));*/
		/*WR3:	WR3 : NOT('IFC2X3.IFCOFFSETCURVE2D' IN TYPEOF(OuterCurve));*/
		}
		#endregion
	}
}