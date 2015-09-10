// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		09/09/2015 04:20:34
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.PropertyResource;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using Xbim.Common;

namespace Xbim.Ifc2x3.DateTimeResource
{
	[EntityName("IFCCALENDARDATE", 407)]
	public  partial class @IfcCalendarDate : INotifyPropertyChanged, IfcDateTimeSelect, IfcObjectReferenceSelect, IInstantiableEntity
	{
		#region Implementation of IPersistEntity
		public int EntityLabel {get; internal set;}
		
		public IModel Model { get; internal set; }
		
		public bool Activated { get; internal set; }

		public void Activate(bool write)
		{
			if (Activated) return; //activation can only happen once in a lifetime of the object

			Model.Activate(this, write);
			Activated = true;
		}

		public void Activate (Action activation)
		{
			activation();
			Activated = true;
		}
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcCalendarDate(IModel model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcDayInMonthNumber _dayComponent;
		private IfcMonthInYearNumber _monthComponent;
		private IfcYearNumber _yearComponent;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(0, EntityAttributeState.Mandatory)]
		public IfcDayInMonthNumber @DayComponent 
		{ 
			get 
			{
				if(Activated) return _dayComponent;
				
				Model.Activate(this, true);
				Activated = true;
				return _dayComponent;
			} 
			set
			{
				SetValue( v =>  _dayComponent = v, _dayComponent, value,  "DayComponent");
			} 
		}
	
		[EntityAttribute(1, EntityAttributeState.Mandatory)]
		public IfcMonthInYearNumber @MonthComponent 
		{ 
			get 
			{
				if(Activated) return _monthComponent;
				
				Model.Activate(this, true);
				Activated = true;
				return _monthComponent;
			} 
			set
			{
				SetValue( v =>  _monthComponent = v, _monthComponent, value,  "MonthComponent");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Mandatory)]
		public IfcYearNumber @YearComponent 
		{ 
			get 
			{
				if(Activated) return _yearComponent;
				
				Model.Activate(this, true);
				Activated = true;
				return _yearComponent;
			} 
			set
			{
				SetValue( v =>  _yearComponent = v, _yearComponent, value,  "YearComponent");
			} 
		}
	
		#endregion

		#region Inverse attributes

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

			Action undo = () => setter(oldValue);
			txn.AddReversibleAction(undo);
			setter(newValue);
			NotifyPropertyChanged(notifyPropertyName);
		}

		#endregion

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"DayComponent",
			"MonthComponent",
			"YearComponent",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @DayComponent;
				case 1: 
					return @MonthComponent;
				case 2: 
					return @YearComponent;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "DayComponent":  
					return @DayComponent;
				case "MonthComponent":  
					return @MonthComponent;
				case "YearComponent":  
					return @YearComponent;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 if (value != null) @DayComponent = (IfcDayInMonthNumber)value;
					 break;
				case 1:
					 if (value != null) @MonthComponent = (IfcMonthInYearNumber)value;
					 break;
				case 2:
					 if (value != null) @YearComponent = (IfcYearNumber)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "DayComponent":
					 if (value != null) @DayComponent = (IfcDayInMonthNumber)value;
					 break;
				case "MonthComponent":
					 if (value != null) @MonthComponent = (IfcMonthInYearNumber)value;
					 break;
				case "YearComponent":
					 if (value != null) @YearComponent = (IfcYearNumber)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion

		#region Where rules
		/*WR21:	WR21 : IfcValidCalendarDate (SELF);*/
		#endregion

		#region IPersist implementation
		void IPersist.Set(int propIndex, IPropertyValue value)
		{
            throw new System.NotImplementedException();
		}
		#endregion

		public  string WhereRule() 
		{
			return "";
		}
	}
}