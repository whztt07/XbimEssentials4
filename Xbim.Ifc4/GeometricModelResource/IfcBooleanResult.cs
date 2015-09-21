// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		21.09.2015 05:11:18
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.GeometryResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.GeometricModelResource
{
	[IndexedClass]
	[ExpressType("IFCBOOLEANRESULT", 436)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcBooleanResult : IfcGeometricRepresentationItem, IfcBooleanOperand, IfcCsgSelect, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcBooleanResult(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcBooleanOperator _operator;
		private IfcBooleanOperand _firstOperand;
		private IfcBooleanOperand _secondOperand;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcBooleanOperator @Operator 
		{ 
			get 
			{
				if(Activated) return _operator;
				
				Model.Activate(this, true);
				Activated = true;
				return _operator;
			} 
			set
			{
				SetValue( v =>  _operator = v, _operator, value,  "Operator");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcBooleanOperand @FirstOperand 
		{ 
			get 
			{
				if(Activated) return _firstOperand;
				
				Model.Activate(this, true);
				Activated = true;
				return _firstOperand;
			} 
			set
			{
				SetValue( v =>  _firstOperand = v, _firstOperand, value,  "FirstOperand");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcBooleanOperand @SecondOperand 
		{ 
			get 
			{
				if(Activated) return _secondOperand;
				
				Model.Activate(this, true);
				Activated = true;
				return _secondOperand;
			} 
			set
			{
				SetValue( v =>  _secondOperand = v, _secondOperand, value,  "SecondOperand");
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
                    _operator = (IfcBooleanOperator) System.Enum.Parse(typeof (IfcBooleanOperator), value.EnumVal, true);
					return;
				case 1: 
					_firstOperand = (IfcBooleanOperand)(value.EntityVal);
					return;
				case 2: 
					_secondOperand = (IfcBooleanOperand)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*SameDim:	SameDim : FirstOperand.Dim = SecondOperand.Dim;*/
		}
		#endregion
	}
}