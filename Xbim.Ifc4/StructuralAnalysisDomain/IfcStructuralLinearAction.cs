// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		24.09.2015 10:03:43
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.UtilityResource;
using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.GeometricConstraintResource;
using Xbim.Ifc4.RepresentationResource;
using Xbim.Ifc4.StructuralLoadResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.StructuralAnalysisDomain
{
	[IndexedClass]
	[ExpressType("IFCSTRUCTURALLINEARACTION", 1021)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcStructuralLinearAction : IfcStructuralCurveAction, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcStructuralLinearAction(IModel model) : base(model) 		{ 
			Model = model; 
		}




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
				case 5: 
				case 6: 
				case 7: 
				case 8: 
				case 9: 
				case 10: 
				case 11: 
					base.Parse(propIndex, value); 
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*SuitableLoadType:	SuitableLoadType : SIZEOF(['IFC4.IFCSTRUCTURALLOADLINEARFORCE', 'IFC4.IFCSTRUCTURALLOADTEMPERATURE'] * TYPEOF(SELF\IfcStructuralActivity.AppliedLoad)) = 1;*/
		/*ConstPredefinedType:	ConstPredefinedType : SELF\IfcStructuralCurveAction.PredefinedType = IfcStructuralCurveActivityTypeEnum.CONST;*/
		}
		#endregion
	}
}