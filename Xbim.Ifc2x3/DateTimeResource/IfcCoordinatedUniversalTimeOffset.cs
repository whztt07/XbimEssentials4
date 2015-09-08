// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 02:29:12
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using System.ComponentModel;
using System;
using Xbim.Common;

namespace Xbim.Ifc2x3.DateTimeResource
{
	[EntityName("IFCCOORDINATEDUNIVERSALTIMEOFFSET", 120)]
	public  partial class @IfcCoordinatedUniversalTimeOffset : INotifyPropertyChanged, IInstantiableEntity
	{
		#region Implementation of IPersistEntity
		public int EntityLabel {get; internal set;}
		public IModel Model { get; internal set; }
		public bool Activated { get; internal set; }
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
		[EntityAttribute(0, EntityAttributeState.Mandatory)]
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
	
		[EntityAttribute(1, EntityAttributeState.Optional)]
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
	
		[EntityAttribute(2, EntityAttributeState.Mandatory)]
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
			"HourOffset",
			"MinuteOffset",
			"Sense",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @HourOffset;
				case 1: 
					return @MinuteOffset;
				case 2: 
					return @Sense;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "HourOffset":  
					return @HourOffset;
				case "MinuteOffset":  
					return @MinuteOffset;
				case "Sense":  
					return @Sense;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 if (value != null) @HourOffset = (IfcHourInDay)value;
					 break;
				case 1:
					 @MinuteOffset = (IfcMinuteInHour?)value;
					 break;
				case 2:
					 if (value != null) @Sense = (IfcAheadOrBehind)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "HourOffset":
					 if (value != null) @HourOffset = (IfcHourInDay)value;
					 break;
				case "MinuteOffset":
					 @MinuteOffset = (IfcMinuteInHour?)value;
					 break;
				case "Sense":
					 if (value != null) @Sense = (IfcAheadOrBehind)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion


		#region IPersist implementation
		void IPersist.Set(int propIndex, IPropertyValue value)
		{
            throw new System.NotImplementedException();
		}
		#endregion

	}
}