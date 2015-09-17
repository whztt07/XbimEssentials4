// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 10:20:59
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
	[EntityName("IFCPROJECTORDERRECORD", 697)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcProjectOrderRecord : IfcControl, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcProjectOrderRecord(IModel model) : base(model) 		{ 
			Model = model; 
			_records = new ItemSet<IfcRelAssignsToProjectOrder>( this );
		}

		#region Explicit attribute fields
		private ItemSet<IfcRelAssignsToProjectOrder> _records;
		private IfcProjectOrderRecordTypeEnum _predefinedType;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(5, EntityAttributeState.Mandatory)]
		public ItemSet<IfcRelAssignsToProjectOrder> @Records 
		{ 
			get 
			{
				if(Activated) return _records;
				
				Model.Activate(this, true);
				Activated = true;
				return _records;
			} 
			set
			{
				SetValue( v =>  _records = v, _records, value,  "Records");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Mandatory)]
		public IfcProjectOrderRecordTypeEnum @PredefinedType 
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
					base.Parse(propIndex, value); 
					return;
				case 5: 
					if (_records == null) _records = new ItemSet<IfcRelAssignsToProjectOrder>( this );
					_records.InternalAdd((IfcRelAssignsToProjectOrder)value.EntityVal);
					return;
				case 6: 
                    _predefinedType = (IfcProjectOrderRecordTypeEnum) System.Enum.Parse(typeof (IfcProjectOrderRecordTypeEnum), value.EnumVal, true);
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