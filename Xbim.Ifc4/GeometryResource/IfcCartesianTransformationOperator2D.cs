// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		22.09.2015 04:44:11
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.GeometryResource
{
	[IndexedClass]
	[ExpressType("IFCCARTESIANTRANSFORMATIONOPERATOR2D", 471)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcCartesianTransformationOperator2D : IfcCartesianTransformationOperator, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcCartesianTransformationOperator2D(IModel model) : base(model) 		{ 
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
					base.Parse(propIndex, value); 
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*DimEqual2:	DimEqual2 : SELF\IfcCartesianTransformationOperator.Dim = 2;*/
		/*Axis1Is2D:                  (SELF\IfcCartesianTransformationOperator.Axis1.Dim = 2);*/
		/*Axis2Is2D:                  (SELF\IfcCartesianTransformationOperator.Axis2.Dim = 2);*/
		}
		#endregion
	}
}