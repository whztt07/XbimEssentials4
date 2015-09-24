// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		24.09.2015 10:03:40
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.DateTimeResource
{
	[IndexedClass]
	[ExpressType("IFCEVENTTIME", 629)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcEventTime : IfcSchedulingTime, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcEventTime(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcDateTime? _actualDate;
		private IfcDateTime? _earlyDate;
		private IfcDateTime? _lateDate;
		private IfcDateTime? _scheduleDate;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcDateTime? @ActualDate 
		{ 
			get 
			{
				if(Activated) return _actualDate;
				
				Model.Activate(this, true);
				Activated = true;
				return _actualDate;
			} 
			set
			{
				SetValue( v =>  _actualDate = v, _actualDate, value,  "ActualDate");
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcDateTime? @EarlyDate 
		{ 
			get 
			{
				if(Activated) return _earlyDate;
				
				Model.Activate(this, true);
				Activated = true;
				return _earlyDate;
			} 
			set
			{
				SetValue( v =>  _earlyDate = v, _earlyDate, value,  "EarlyDate");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcDateTime? @LateDate 
		{ 
			get 
			{
				if(Activated) return _lateDate;
				
				Model.Activate(this, true);
				Activated = true;
				return _lateDate;
			} 
			set
			{
				SetValue( v =>  _lateDate = v, _lateDate, value,  "LateDate");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcDateTime? @ScheduleDate 
		{ 
			get 
			{
				if(Activated) return _scheduleDate;
				
				Model.Activate(this, true);
				Activated = true;
				return _scheduleDate;
			} 
			set
			{
				SetValue( v =>  _scheduleDate = v, _scheduleDate, value,  "ScheduleDate");
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
					base.Parse(propIndex, value); 
					return;
				case 3: 
					_actualDate = value.StringVal;
					return;
				case 4: 
					_earlyDate = value.StringVal;
					return;
				case 5: 
					_lateDate = value.StringVal;
					return;
				case 6: 
					_scheduleDate = value.StringVal;
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