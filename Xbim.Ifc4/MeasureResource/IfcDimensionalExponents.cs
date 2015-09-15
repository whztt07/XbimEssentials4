// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		15.09.2015 07:03:38
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using System.ComponentModel;
using System;
using Xbim.Common;

namespace Xbim.Ifc4.MeasureResource
{
	[EntityName("IFCDIMENSIONALEXPONENTS", 172)]
	public  partial class @IfcDimensionalExponents : INotifyPropertyChanged, IInstantiableEntity
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
		[EntityAttribute(0, EntityAttributeState.Mandatory)]
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
	
		[EntityAttribute(1, EntityAttributeState.Mandatory)]
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
	
		[EntityAttribute(2, EntityAttributeState.Mandatory)]
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
	
		[EntityAttribute(3, EntityAttributeState.Mandatory)]
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
	
		[EntityAttribute(4, EntityAttributeState.Mandatory)]
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
	
		[EntityAttribute(5, EntityAttributeState.Mandatory)]
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
	
		[EntityAttribute(6, EntityAttributeState.Mandatory)]
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
			"LengthExponent",
			"MassExponent",
			"TimeExponent",
			"ElectricCurrentExponent",
			"ThermodynamicTemperatureExponent",
			"AmountOfSubstanceExponent",
			"LuminousIntensityExponent",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @LengthExponent;
				case 1: 
					return @MassExponent;
				case 2: 
					return @TimeExponent;
				case 3: 
					return @ElectricCurrentExponent;
				case 4: 
					return @ThermodynamicTemperatureExponent;
				case 5: 
					return @AmountOfSubstanceExponent;
				case 6: 
					return @LuminousIntensityExponent;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "LengthExponent":  
					return @LengthExponent;
				case "MassExponent":  
					return @MassExponent;
				case "TimeExponent":  
					return @TimeExponent;
				case "ElectricCurrentExponent":  
					return @ElectricCurrentExponent;
				case "ThermodynamicTemperatureExponent":  
					return @ThermodynamicTemperatureExponent;
				case "AmountOfSubstanceExponent":  
					return @AmountOfSubstanceExponent;
				case "LuminousIntensityExponent":  
					return @LuminousIntensityExponent;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 if (value != null) @LengthExponent = (long)value;
					 break;
				case 1:
					 if (value != null) @MassExponent = (long)value;
					 break;
				case 2:
					 if (value != null) @TimeExponent = (long)value;
					 break;
				case 3:
					 if (value != null) @ElectricCurrentExponent = (long)value;
					 break;
				case 4:
					 if (value != null) @ThermodynamicTemperatureExponent = (long)value;
					 break;
				case 5:
					 if (value != null) @AmountOfSubstanceExponent = (long)value;
					 break;
				case 6:
					 if (value != null) @LuminousIntensityExponent = (long)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "LengthExponent":
					 if (value != null) @LengthExponent = (long)value;
					 break;
				case "MassExponent":
					 if (value != null) @MassExponent = (long)value;
					 break;
				case "TimeExponent":
					 if (value != null) @TimeExponent = (long)value;
					 break;
				case "ElectricCurrentExponent":
					 if (value != null) @ElectricCurrentExponent = (long)value;
					 break;
				case "ThermodynamicTemperatureExponent":
					 if (value != null) @ThermodynamicTemperatureExponent = (long)value;
					 break;
				case "AmountOfSubstanceExponent":
					 if (value != null) @AmountOfSubstanceExponent = (long)value;
					 break;
				case "LuminousIntensityExponent":
					 if (value != null) @LuminousIntensityExponent = (long)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion


		#region IPersist implementation
		public virtual void Parse(int propIndex, IPropertyValue value)
		{
            throw new System.NotImplementedException();
		}
		
		public virtual string WhereRule() 
		{
            throw new System.NotImplementedException();
		}
		#endregion

		
	}
}