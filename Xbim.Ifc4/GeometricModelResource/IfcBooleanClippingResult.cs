// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		22.09.2015 02:32:04
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.GeometricModelResource
{
	[IndexedClass]
	[ExpressType("IFCBOOLEANCLIPPINGRESULT", 435)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcBooleanClippingResult : IfcBooleanResult, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcBooleanClippingResult(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		#endregion
	
		#region Explicit attribute properties
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
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*FirstOperandType:                          ('IFC4.IFCBOOLEANCLIPPINGRESULT' IN TYPEOF(FirstOperand));*/
		/*SecondOperandType:	SecondOperandType : ('IFC4.IFCHALFSPACESOLID' IN TYPEOF(SecondOperand));*/
		/*OperatorType:	OperatorType : Operator = DIFFERENCE;*/
		}
		#endregion
	}
}