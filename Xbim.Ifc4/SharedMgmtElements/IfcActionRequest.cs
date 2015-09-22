// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		22.09.2015 04:44:10
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Kernel;
using Xbim.Ifc4.UtilityResource;
using Xbim.Ifc4.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.SharedMgmtElements
{
	[IndexedClass]
	[ExpressType("IFCACTIONREQUEST", 391)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcActionRequest : IfcControl, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcActionRequest(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcActionRequestTypeEnum? _predefinedType;
		private IfcLabel? _status;
		private IfcText? _longDescription;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcActionRequestTypeEnum? @PredefinedType 
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
	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcText? @LongDescription 
		{ 
			get 
			{
				if(Activated) return _longDescription;
				
				Model.Activate(this, true);
				Activated = true;
				return _longDescription;
			} 
			set
			{
				SetValue( v =>  _longDescription = v, _longDescription, value,  "LongDescription");
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
					base.Parse(propIndex, value); 
					return;
				case 6: 
                    _predefinedType = (IfcActionRequestTypeEnum) System.Enum.Parse(typeof (IfcActionRequestTypeEnum), value.EnumVal, true);
					return;
				case 7: 
					_status = value.StringVal;
					return;
				case 8: 
					_longDescription = value.StringVal;
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