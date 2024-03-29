// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		24.09.2015 10:03:42
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.DateTimeResource
{
	[IndexedClass]
	[ExpressType("IFCRECURRENCEPATTERN", 890)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRecurrencePattern : IPersistEntity, INotifyPropertyChanged, IInstantiableEntity
	{
		#region Implementation of IPersistEntity
		public int EntityLabel {get; internal set;}
		
		public IModel Model { get; internal set; }
		
		public bool Activated { get; internal set; }

		void IPersistEntity.Activate(bool write)
		{
			if (Activated) return; //activation can only happen once in a lifetime of the object

			Model.Activate(this, write);
			Activated = true;
		}

		void IPersistEntity.Activate (Action activation)
		{
			if (Activated) return; //activation can only happen once in a lifetime of the object
			
			activation();
			Activated = true;
		}
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRecurrencePattern(IModel model) 		{ 
			Model = model; 
			_dayComponent = new OptionalItemSet<IfcDayInMonthNumber>( this );
			_weekdayComponent = new OptionalItemSet<IfcDayInWeekNumber>( this );
			_monthComponent = new OptionalItemSet<IfcMonthInYearNumber>( this );
			_timePeriods = new OptionalItemSet<IfcTimePeriod>( this );
		}

		#region Explicit attribute fields
		private IfcRecurrenceTypeEnum _recurrenceType;
		private OptionalItemSet<IfcDayInMonthNumber> _dayComponent;
		private OptionalItemSet<IfcDayInWeekNumber> _weekdayComponent;
		private OptionalItemSet<IfcMonthInYearNumber> _monthComponent;
		private IfcInteger? _position;
		private IfcInteger? _interval;
		private IfcInteger? _occurrences;
		private OptionalItemSet<IfcTimePeriod> _timePeriods;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcRecurrenceTypeEnum @RecurrenceType 
		{ 
			get 
			{
				if(Activated) return _recurrenceType;
				
				Model.Activate(this, true);
				Activated = true;
				return _recurrenceType;
			} 
			set
			{
				SetValue( v =>  _recurrenceType = v, _recurrenceType, value,  "RecurrenceType");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.Set, EntityAttributeType.None, 1, -1)]
		public OptionalItemSet<IfcDayInMonthNumber> @DayComponent 
		{ 
			get 
			{
				if(Activated) return _dayComponent;
				
				Model.Activate(this, true);
				Activated = true;
				return _dayComponent;
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.Set, EntityAttributeType.None, 1, -1)]
		public OptionalItemSet<IfcDayInWeekNumber> @WeekdayComponent 
		{ 
			get 
			{
				if(Activated) return _weekdayComponent;
				
				Model.Activate(this, true);
				Activated = true;
				return _weekdayComponent;
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.Set, EntityAttributeType.None, 1, -1)]
		public OptionalItemSet<IfcMonthInYearNumber> @MonthComponent 
		{ 
			get 
			{
				if(Activated) return _monthComponent;
				
				Model.Activate(this, true);
				Activated = true;
				return _monthComponent;
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcInteger? @Position 
		{ 
			get 
			{
				if(Activated) return _position;
				
				Model.Activate(this, true);
				Activated = true;
				return _position;
			} 
			set
			{
				SetValue( v =>  _position = v, _position, value,  "Position");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcInteger? @Interval 
		{ 
			get 
			{
				if(Activated) return _interval;
				
				Model.Activate(this, true);
				Activated = true;
				return _interval;
			} 
			set
			{
				SetValue( v =>  _interval = v, _interval, value,  "Interval");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcInteger? @Occurrences 
		{ 
			get 
			{
				if(Activated) return _occurrences;
				
				Model.Activate(this, true);
				Activated = true;
				return _occurrences;
			} 
			set
			{
				SetValue( v =>  _occurrences = v, _occurrences, value,  "Occurrences");
			} 
		}
	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.Class, 1, -1)]
		public OptionalItemSet<IfcTimePeriod> @TimePeriods 
		{ 
			get 
			{
				if(Activated) return _timePeriods;
				
				Model.Activate(this, true);
				Activated = true;
				return _timePeriods;
			} 
		}
	
		#endregion


		#region INotifyPropertyChanged implementation
		 
		public event PropertyChangedEventHandler PropertyChanged;

		protected void NotifyPropertyChanged( string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

		#endregion

		#region Transactional property setting

		protected void SetValue<TProperty>(Action<TProperty> setter, TProperty oldValue, TProperty newValue, string notifyPropertyName)
		{

			if (!Model.IsTransactional)
			{
				setter(newValue);
				NotifyPropertyChanged(notifyPropertyName);
				return;
			}

			//check there is a transaction
			var txn = Model.CurrentTransaction;
			if (txn == null) throw new Exception("Operation out of transaction.");

			Action doAction = () => setter(newValue);
			Action undoAction = () => setter(oldValue);
			txn.AddReversibleAction(doAction, undoAction, this);
			setter(newValue);
			NotifyPropertyChanged(notifyPropertyName);
		}

		#endregion

		#region IPersist implementation
		public virtual void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
                    _recurrenceType = (IfcRecurrenceTypeEnum) System.Enum.Parse(typeof (IfcRecurrenceTypeEnum), value.EnumVal, true);
					return;
				case 1: 
					if (_dayComponent == null) _dayComponent = new OptionalItemSet<IfcDayInMonthNumber>( this );
					_dayComponent.InternalAdd(value.IntegerVal);
					return;
				case 2: 
					if (_weekdayComponent == null) _weekdayComponent = new OptionalItemSet<IfcDayInWeekNumber>( this );
					_weekdayComponent.InternalAdd(value.IntegerVal);
					return;
				case 3: 
					if (_monthComponent == null) _monthComponent = new OptionalItemSet<IfcMonthInYearNumber>( this );
					_monthComponent.InternalAdd(value.IntegerVal);
					return;
				case 4: 
					_position = value.IntegerVal;
					return;
				case 5: 
					_interval = value.IntegerVal;
					return;
				case 6: 
					_occurrences = value.IntegerVal;
					return;
				case 7: 
					if (_timePeriods == null) _timePeriods = new OptionalItemSet<IfcTimePeriod>( this );
					_timePeriods.InternalAdd((IfcTimePeriod)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public virtual string WhereRule() 
		{
			return "";
		}
		#endregion
	}
}