// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		21.09.2015 05:11:14
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.Kernel;
using Xbim.Ifc2x3.UtilityResource;
using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.TimeSeriesResource;
using Xbim.Ifc2x3.DateTimeResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.ControlExtension
{
	[IndexedClass]
	[ExpressType("IFCTIMESERIESSCHEDULE", 712)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcTimeSeriesSchedule : IfcControl, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTimeSeriesSchedule(IModel model) : base(model) 		{ 
			Model = model; 
			_applicableDates = new OptionalItemSet<IfcDateTimeSelect>( this );
		}

		#region Explicit attribute fields
		private OptionalItemSet<IfcDateTimeSelect> _applicableDates;
		private IfcTimeSeriesScheduleTypeEnum _timeSeriesScheduleType;
		private IfcTimeSeries _timeSeries;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.Class, 1, -1)]
		public OptionalItemSet<IfcDateTimeSelect> @ApplicableDates 
		{ 
			get 
			{
				if(Activated) return _applicableDates;
				
				Model.Activate(this, true);
				Activated = true;
				return _applicableDates;
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcTimeSeriesScheduleTypeEnum @TimeSeriesScheduleType 
		{ 
			get 
			{
				if(Activated) return _timeSeriesScheduleType;
				
				Model.Activate(this, true);
				Activated = true;
				return _timeSeriesScheduleType;
			} 
			set
			{
				SetValue( v =>  _timeSeriesScheduleType = v, _timeSeriesScheduleType, value,  "TimeSeriesScheduleType");
			} 
		}
	
		[EntityAttribute(8, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcTimeSeries @TimeSeries 
		{ 
			get 
			{
				if(Activated) return _timeSeries;
				
				Model.Activate(this, true);
				Activated = true;
				return _timeSeries;
			} 
			set
			{
				SetValue( v =>  _timeSeries = v, _timeSeries, value,  "TimeSeries");
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
					if (_applicableDates == null) _applicableDates = new OptionalItemSet<IfcDateTimeSelect>( this );
					_applicableDates.InternalAdd((IfcDateTimeSelect)value.EntityVal);
					return;
				case 6: 
                    _timeSeriesScheduleType = (IfcTimeSeriesScheduleTypeEnum) System.Enum.Parse(typeof (IfcTimeSeriesScheduleTypeEnum), value.EnumVal, true);
					return;
				case 7: 
					_timeSeries = (IfcTimeSeries)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR41:	WR41 : NOT(TimeSeriesScheduleType=IfcTimeSeriesScheduleTypeEnum.USERDEFINED) OR EXISTS(SELF\IfcObject.ObjectType);*/
		}
		#endregion
	}
}