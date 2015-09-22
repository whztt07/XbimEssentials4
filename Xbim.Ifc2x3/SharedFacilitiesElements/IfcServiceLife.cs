// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		22.09.2015 04:44:06
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.Kernel;
using Xbim.Ifc2x3.UtilityResource;
using Xbim.Ifc2x3.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.SharedFacilitiesElements
{
	[IndexedClass]
	[ExpressType("IFCSERVICELIFE", 769)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcServiceLife : IfcControl, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcServiceLife(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcServiceLifeTypeEnum _serviceLifeType;
		private IfcTimeMeasure _serviceLifeDuration;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcServiceLifeTypeEnum @ServiceLifeType 
		{ 
			get 
			{
				if(Activated) return _serviceLifeType;
				
				Model.Activate(this, true);
				Activated = true;
				return _serviceLifeType;
			} 
			set
			{
				SetValue( v =>  _serviceLifeType = v, _serviceLifeType, value,  "ServiceLifeType");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcTimeMeasure @ServiceLifeDuration 
		{ 
			get 
			{
				if(Activated) return _serviceLifeDuration;
				
				Model.Activate(this, true);
				Activated = true;
				return _serviceLifeDuration;
			} 
			set
			{
				SetValue( v =>  _serviceLifeDuration = v, _serviceLifeDuration, value,  "ServiceLifeDuration");
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
					base.Parse(propIndex, value); 
					return;
				case 5: 
                    _serviceLifeType = (IfcServiceLifeTypeEnum) System.Enum.Parse(typeof (IfcServiceLifeTypeEnum), value.EnumVal, true);
					return;
				case 6: 
					_serviceLifeDuration = value.RealVal;
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