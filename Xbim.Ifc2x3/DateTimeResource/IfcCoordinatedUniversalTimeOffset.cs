// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		24.09.2015 10:03:32
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using System.ComponentModel;
using System;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.DateTimeResource
{
	[IndexedClass]
	[ExpressType("IFCCOORDINATEDUNIVERSALTIMEOFFSET", 690)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcCoordinatedUniversalTimeOffset : IPersistEntity, INotifyPropertyChanged, IInstantiableEntity
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
		internal IfcCoordinatedUniversalTimeOffset(IModel model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcHourInDay _hourOffset;
		private IfcMinuteInHour? _minuteOffset;
		private IfcAheadOrBehind _sense;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcHourInDay @HourOffset 
		{ 
			get 
			{
				if(Activated) return _hourOffset;
				
				Model.Activate(this, true);
				Activated = true;
				return _hourOffset;
			} 
			set
			{
				SetValue( v =>  _hourOffset = v, _hourOffset, value,  "HourOffset");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcMinuteInHour? @MinuteOffset 
		{ 
			get 
			{
				if(Activated) return _minuteOffset;
				
				Model.Activate(this, true);
				Activated = true;
				return _minuteOffset;
			} 
			set
			{
				SetValue( v =>  _minuteOffset = v, _minuteOffset, value,  "MinuteOffset");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcAheadOrBehind @Sense 
		{ 
			get 
			{
				if(Activated) return _sense;
				
				Model.Activate(this, true);
				Activated = true;
				return _sense;
			} 
			set
			{
				SetValue( v =>  _sense = v, _sense, value,  "Sense");
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
					_hourOffset = value.IntegerVal;
					return;
				case 1: 
					_minuteOffset = value.IntegerVal;
					return;
				case 2: 
                    _sense = (IfcAheadOrBehind) System.Enum.Parse(typeof (IfcAheadOrBehind), value.EnumVal, true);
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