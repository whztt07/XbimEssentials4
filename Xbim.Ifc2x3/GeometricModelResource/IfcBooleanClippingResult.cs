// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		24.09.2015 10:03:32
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.GeometricModelResource
{
	[IndexedClass]
	[ExpressType("IFCBOOLEANCLIPPINGRESULT", 340)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcBooleanClippingResult : IfcBooleanResult, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcBooleanClippingResult(IModel model) : base(model) 		{ 
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
					base.Parse(propIndex, value); 
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR1:	WR1 : ('IFC2X3.IFCSWEPTAREASOLID' IN TYPEOF(FirstOperand)) OR ('IFC2X3.IFCBOOLEANCLIPPINGRESULT' IN TYPEOF(FirstOperand));*/
		/*WR2:	WR2 : ('IFC2X3.IFCHALFSPACESOLID' IN TYPEOF(SecondOperand));*/
		/*WR3:	WR3 : Operator = DIFFERENCE;*/
		}
		#endregion
	}
}