// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 03:43:56
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
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.DateTimeResource
{
	[EntityName("IFCLOCALTIME", 483)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcLocalTime : IPersistEntity, INotifyPropertyChanged, IfcDateTimeSelect, IfcObjectReferenceSelect, IInstantiableEntity
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
		internal IfcLocalTime(IModel model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcHourInDay _hourComponent;
		private IfcMinuteInHour? _minuteComponent;
		private IfcSecondInMinute? _secondComponent;
		private IfcCoordinatedUniversalTimeOffset _zone;
		private IfcDaylightSavingHour? _daylightSavingOffset;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(0, EntityAttributeState.Mandatory)]
		public IfcHourInDay @HourComponent 
		{ 
			get 
			{
				if(Activated) return _hourComponent;
				
				Model.Activate(this, true);
				Activated = true;
				return _hourComponent;
			} 
			set
			{
				SetValue( v =>  _hourComponent = v, _hourComponent, value,  "HourComponent");
			} 
		}
	
		[EntityAttribute(1, EntityAttributeState.Optional)]
		public IfcMinuteInHour? @MinuteComponent 
		{ 
			get 
			{
				if(Activated) return _minuteComponent;
				
				Model.Activate(this, true);
				Activated = true;
				return _minuteComponent;
			} 
			set
			{
				SetValue( v =>  _minuteComponent = v, _minuteComponent, value,  "MinuteComponent");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Optional)]
		public IfcSecondInMinute? @SecondComponent 
		{ 
			get 
			{
				if(Activated) return _secondComponent;
				
				Model.Activate(this, true);
				Activated = true;
				return _secondComponent;
			} 
			set
			{
				SetValue( v =>  _secondComponent = v, _secondComponent, value,  "SecondComponent");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Optional)]
		public IfcCoordinatedUniversalTimeOffset @Zone 
		{ 
			get 
			{
				if(Activated) return _zone;
				
				Model.Activate(this, true);
				Activated = true;
				return _zone;
			} 
			set
			{
				SetValue( v =>  _zone = v, _zone, value,  "Zone");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Optional)]
		public IfcDaylightSavingHour? @DaylightSavingOffset 
		{ 
			get 
			{
				if(Activated) return _daylightSavingOffset;
				
				Model.Activate(this, true);
				Activated = true;
				return _daylightSavingOffset;
			} 
			set
			{
				SetValue( v =>  _daylightSavingOffset = v, _daylightSavingOffset, value,  "DaylightSavingOffset");
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
					_hourComponent = value.IntegerVal;
					return;
				case 1: 
					_minuteComponent = value.IntegerVal;
					return;
				case 2: 
					_secondComponent = value.RealVal;
					return;
				case 3: 
					_zone = (IfcCoordinatedUniversalTimeOffset)(value.EntityVal);
					return;
				case 4: 
					_daylightSavingOffset = value.IntegerVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public virtual string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR21:	WR21 : IfcValidTime (SELF);*/
		}
		#endregion
	}
}