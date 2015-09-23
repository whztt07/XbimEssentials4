// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		23.09.2015 10:21:43
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.SharedBldgServiceElements;
using Xbim.Ifc2x3.UtilityResource;
using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.GeometricConstraintResource;
using Xbim.Ifc2x3.RepresentationResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.ElectricalDomain
{
	[IndexedClass]
	[ExpressType("IFCELECTRICDISTRIBUTIONPOINT", 242)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcElectricDistributionPoint : IfcFlowController, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcElectricDistributionPoint(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcElectricDistributionPointFunctionEnum _distributionPointFunction;
		private IfcLabel? _userDefinedFunction;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(9, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcElectricDistributionPointFunctionEnum @DistributionPointFunction 
		{ 
			get 
			{
				if(Activated) return _distributionPointFunction;
				
				Model.Activate(this, true);
				Activated = true;
				return _distributionPointFunction;
			} 
			set
			{
				SetValue( v =>  _distributionPointFunction = v, _distributionPointFunction, value,  "DistributionPointFunction");
			} 
		}
	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel? @UserDefinedFunction 
		{ 
			get 
			{
				if(Activated) return _userDefinedFunction;
				
				Model.Activate(this, true);
				Activated = true;
				return _userDefinedFunction;
			} 
			set
			{
				SetValue( v =>  _userDefinedFunction = v, _userDefinedFunction, value,  "UserDefinedFunction");
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
				case 4: 
				case 5: 
				case 6: 
				case 7: 
					base.Parse(propIndex, value); 
					return;
				case 8: 
                    _distributionPointFunction = (IfcElectricDistributionPointFunctionEnum) System.Enum.Parse(typeof (IfcElectricDistributionPointFunctionEnum), value.EnumVal, true);
					return;
				case 9: 
					_userDefinedFunction = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR31:             ((DistributionPointFunction = IfcElectricDistributionPointFunctionEnum.USERDEFINED) AND EXISTS(SELF\IfcElectricDistributionPoint.UserDefinedFunction));*/
		}
		#endregion
	}
}