// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		24.09.2015 10:03:34
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
	[ExpressType("IFCSERVICELIFEFACTOR", 770)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcServiceLifeFactor : IfcPropertySetDefinition, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcServiceLifeFactor(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcServiceLifeFactorTypeEnum _predefinedType;
		private IfcMeasureValue _upperValue;
		private IfcMeasureValue _mostUsedValue;
		private IfcMeasureValue _lowerValue;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcServiceLifeFactorTypeEnum @PredefinedType 
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
	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcMeasureValue @UpperValue 
		{ 
			get 
			{
				if(Activated) return _upperValue;
				
				Model.Activate(this, true);
				Activated = true;
				return _upperValue;
			} 
			set
			{
				SetValue( v =>  _upperValue = v, _upperValue, value,  "UpperValue");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcMeasureValue @MostUsedValue 
		{ 
			get 
			{
				if(Activated) return _mostUsedValue;
				
				Model.Activate(this, true);
				Activated = true;
				return _mostUsedValue;
			} 
			set
			{
				SetValue( v =>  _mostUsedValue = v, _mostUsedValue, value,  "MostUsedValue");
			} 
		}
	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcMeasureValue @LowerValue 
		{ 
			get 
			{
				if(Activated) return _lowerValue;
				
				Model.Activate(this, true);
				Activated = true;
				return _lowerValue;
			} 
			set
			{
				SetValue( v =>  _lowerValue = v, _lowerValue, value,  "LowerValue");
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
                    _predefinedType = (IfcServiceLifeFactorTypeEnum) System.Enum.Parse(typeof (IfcServiceLifeFactorTypeEnum), value.EnumVal, true);
					return;
				case 5: 
					_upperValue = (IfcMeasureValue)(value.EntityVal);
					return;
				case 6: 
					_mostUsedValue = (IfcMeasureValue)(value.EntityVal);
					return;
				case 7: 
					_lowerValue = (IfcMeasureValue)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR31:             OR EXISTS(SELF\IfcObject.ObjectType);*/
		}
		#endregion
	}
}