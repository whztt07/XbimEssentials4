// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 03:44:06
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.QuantityResource
{
	[EntityName("IFCQUANTITYLENGTH", 482)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcQuantityLength : IfcPhysicalSimpleQuantity, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcQuantityLength(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcLengthMeasure _lengthValue;
		private IfcLabel? _formula;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttributee(3, EntityAttributeState.Mandatory)]
		public IfcLengthMeasure @LengthValue 
		{ 
			get 
			{
				if(Activated) return _lengthValue;
				
				Model.Activate(this, true);
				Activated = true;
				return _lengthValue;
			} 
			set
			{
				SetValue( v =>  _lengthValue = v, _lengthValue, value,  "LengthValue");
			} 
		}
	
		[EntityAttributee(4, EntityAttributeState.Optional)]
		public IfcLabel? @Formula 
		{ 
			get 
			{
				if(Activated) return _formula;
				
				Model.Activate(this, true);
				Activated = true;
				return _formula;
			} 
			set
			{
				SetValue( v =>  _formula = v, _formula, value,  "Formula");
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
					_lengthValue = value.RealVal;
					return;
				case 4: 
					_formula = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR21:                (SELF\IfcPhysicalSimpleQuantity.Unit.UnitType = IfcUnitEnum.LENGTHUNIT);*/
		/*WR22:	WR22 : LengthValue >= 0.;*/
		}
		#endregion
	}
}