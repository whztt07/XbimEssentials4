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

namespace Xbim.Ifc2x3.GeometryResource
{
	[IndexedClass]
	[ExpressType("IFCCARTESIANTRANSFORMATIONOPERATOR3D", 337)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcCartesianTransformationOperator3D : IfcCartesianTransformationOperator, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcCartesianTransformationOperator3D(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcDirection _axis3;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcDirection @Axis3 
		{ 
			get 
			{
				if(Activated) return _axis3;
				
				Model.Activate(this, true);
				Activated = true;
				return _axis3;
			} 
			set
			{
				SetValue( v =>  _axis3 = v, _axis3, value,  "Axis3");
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
				case 3: 
					base.Parse(propIndex, value); 
					return;
				case 4: 
					_axis3 = (IfcDirection)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR1:	WR1 : SELF\IfcCartesianTransformationOperator.Dim = 3;*/
		/*WR2:            (SELF\IfcCartesianTransformationOperator.Axis1.Dim = 3);*/
		/*WR3:            (SELF\IfcCartesianTransformationOperator.Axis2.Dim = 3);*/
		/*WR4:	WR4 : NOT(EXISTS(Axis3)) OR (Axis3.Dim = 3);*/
		}
		#endregion
	}
}