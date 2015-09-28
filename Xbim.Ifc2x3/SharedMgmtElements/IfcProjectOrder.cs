// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
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

namespace Xbim.Ifc2x3.SharedMgmtElements
{
	[ExpressType("IFCPROJECTORDER", 696)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcProjectOrder : IfcControl, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcProjectOrder(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcIdentifier _iD;
		private IfcProjectOrderTypeEnum _predefinedType;
		private IfcLabel? _status;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcIdentifier @ID 
		{ 
			get 
			{
				if(Activated) return _iD;
				
				Model.Activate(this, true);
				Activated = true;
				return _iD;
			} 
			set
			{
				SetValue( v =>  _iD = v, _iD, value,  "ID");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcProjectOrderTypeEnum @PredefinedType 
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
	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel? @Status 
		{ 
			get 
			{
				if(Activated) return _status;
				
				Model.Activate(this, true);
				Activated = true;
				return _status;
			} 
			set
			{
				SetValue( v =>  _status = v, _status, value,  "Status");
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
					_iD = value.StringVal;
					return;
				case 6: 
                    _predefinedType = (IfcProjectOrderTypeEnum) System.Enum.Parse(typeof (IfcProjectOrderTypeEnum), value.EnumVal, true);
					return;
				case 7: 
					_status = value.StringVal;
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