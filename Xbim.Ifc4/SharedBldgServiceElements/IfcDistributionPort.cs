// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		21.09.2015 05:11:19
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.ProductExtension;
using Xbim.Ifc4.UtilityResource;
using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.GeometricConstraintResource;
using Xbim.Ifc4.RepresentationResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.SharedBldgServiceElements
{
	[IndexedClass]
	[ExpressType("IFCDISTRIBUTIONPORT", 576)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcDistributionPort : IfcPort, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcDistributionPort(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcFlowDirectionEnum? _flowDirection;
		private IfcDistributionPortTypeEnum? _predefinedType;
		private IfcDistributionSystemEnum? _systemType;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcFlowDirectionEnum? @FlowDirection 
		{ 
			get 
			{
				if(Activated) return _flowDirection;
				
				Model.Activate(this, true);
				Activated = true;
				return _flowDirection;
			} 
			set
			{
				SetValue( v =>  _flowDirection = v, _flowDirection, value,  "FlowDirection");
			} 
		}
	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcDistributionPortTypeEnum? @PredefinedType 
		{ 
			get 
			{
				if(Activated) return _predefinedType;
				
				Model.Activate(this, true);
				Activated = true;
				return _predefinedType;
			} 
			set
			{
				SetValue( v =>  _predefinedType = v, _predefinedType, value,  "PredefinedType");
			} 
		}
	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcDistributionSystemEnum? @SystemType 
		{ 
			get 
			{
				if(Activated) return _systemType;
				
				Model.Activate(this, true);
				Activated = true;
				return _systemType;
			} 
			set
			{
				SetValue( v =>  _systemType = v, _systemType, value,  "SystemType");
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
				case 3: 
				case 4: 
				case 5: 
				case 6: 
					base.Parse(propIndex, value); 
					return;
				case 7: 
                    _flowDirection = (IfcFlowDirectionEnum) System.Enum.Parse(typeof (IfcFlowDirectionEnum), value.EnumVal, true);
					return;
				case 8: 
                    _predefinedType = (IfcDistributionPortTypeEnum) System.Enum.Parse(typeof (IfcDistributionPortTypeEnum), value.EnumVal, true);
					return;
				case 9: 
                    _systemType = (IfcDistributionSystemEnum) System.Enum.Parse(typeof (IfcDistributionSystemEnum), value.EnumVal, true);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
			return "";
		}
		#endregion
	}
}