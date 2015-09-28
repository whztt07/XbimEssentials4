// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
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

namespace Xbim.Ifc4.MeasureResource
{
	[ExpressType("IFCDIMENSIONALEXPONENTS", 563)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcDimensionalExponents : IPersistEntity, INotifyPropertyChanged, IInstantiableEntity
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
		internal IfcDimensionalExponents(IModel model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private long _lengthExponent;
		private long _massExponent;
		private long _timeExponent;
		private long _electricCurrentExponent;
		private long _thermodynamicTemperatureExponent;
		private long _amountOfSubstanceExponent;
		private long _luminousIntensityExponent;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public long @LengthExponent 
		{ 
			get 
			{
				if(Activated) return _lengthExponent;
				
				Model.Activate(this, true);
				Activated = true;
				return _lengthExponent;
			} 
			set
			{
				SetValue( v =>  _lengthExponent = v, _lengthExponent, value,  "LengthExponent");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public long @MassExponent 
		{ 
			get 
			{
				if(Activated) return _massExponent;
				
				Model.Activate(this, true);
				Activated = true;
				return _massExponent;
			} 
			set
			{
				SetValue( v =>  _massExponent = v, _massExponent, value,  "MassExponent");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public long @TimeExponent 
		{ 
			get 
			{
				if(Activated) return _timeExponent;
				
				Model.Activate(this, true);
				Activated = true;
				return _timeExponent;
			} 
			set
			{
				SetValue( v =>  _timeExponent = v, _timeExponent, value,  "TimeExponent");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public long @ElectricCurrentExponent 
		{ 
			get 
			{
				if(Activated) return _electricCurrentExponent;
				
				Model.Activate(this, true);
				Activated = true;
				return _electricCurrentExponent;
			} 
			set
			{
				SetValue( v =>  _electricCurrentExponent = v, _electricCurrentExponent, value,  "ElectricCurrentExponent");
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public long @ThermodynamicTemperatureExponent 
		{ 
			get 
			{
				if(Activated) return _thermodynamicTemperatureExponent;
				
				Model.Activate(this, true);
				Activated = true;
				return _thermodynamicTemperatureExponent;
			} 
			set
			{
				SetValue( v =>  _thermodynamicTemperatureExponent = v, _thermodynamicTemperatureExponent, value,  "ThermodynamicTemperatureExponent");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public long @AmountOfSubstanceExponent 
		{ 
			get 
			{
				if(Activated) return _amountOfSubstanceExponent;
				
				Model.Activate(this, true);
				Activated = true;
				return _amountOfSubstanceExponent;
			} 
			set
			{
				SetValue( v =>  _amountOfSubstanceExponent = v, _amountOfSubstanceExponent, value,  "AmountOfSubstanceExponent");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public long @LuminousIntensityExponent 
		{ 
			get 
			{
				if(Activated) return _luminousIntensityExponent;
				
				Model.Activate(this, true);
				Activated = true;
				return _luminousIntensityExponent;
			} 
			set
			{
				SetValue( v =>  _luminousIntensityExponent = v, _luminousIntensityExponent, value,  "LuminousIntensityExponent");
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
					_lengthExponent = value.IntegerVal;
					return;
				case 1: 
					_massExponent = value.IntegerVal;
					return;
				case 2: 
					_timeExponent = value.IntegerVal;
					return;
				case 3: 
					_electricCurrentExponent = value.IntegerVal;
					return;
				case 4: 
					_thermodynamicTemperatureExponent = value.IntegerVal;
					return;
				case 5: 
					_amountOfSubstanceExponent = value.IntegerVal;
					return;
				case 6: 
					_luminousIntensityExponent = value.IntegerVal;
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