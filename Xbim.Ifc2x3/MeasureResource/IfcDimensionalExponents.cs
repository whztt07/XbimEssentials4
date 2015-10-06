// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.MeasureResource
{
	[ExpressType("IFCDIMENSIONALEXPONENTS", 303)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcDimensionalExponents : INotifyPropertyChanged, IInstantiableEntity, IEqualityComparer<@IfcDimensionalExponents>, IEquatable<@IfcDimensionalExponents>
	{
		public static int LoadDepth = 1;

		#region Implementation of IPersistEntity

		public int EntityLabel {get; internal set;}
		
		public IModel Model { get; internal set; }

		/// <summary>
        /// This property is deprecated and likely to be removed. Use just 'Model' instead.
        /// </summary>
		[Obsolete("This property is deprecated and likely to be removed. Use just 'Model' instead.")]
        public IModel ModelOf { get { return Model; } }
		
	    internal ActivationStatus ActivationStatus = ActivationStatus.NotActivated;

	    ActivationStatus IPersistEntity.ActivationStatus { get { return ActivationStatus; } }
		
		void IPersistEntity.Activate(bool write)
		{
			switch (ActivationStatus)
		    {
		        case ActivationStatus.ActivatedReadWrite:
		            return;
		        case ActivationStatus.NotActivated:
		            lock (this)
		            {
                        //check again in the lock
		                if (ActivationStatus == ActivationStatus.NotActivated)
		                {
		                    if (Model.Activate(this, write))
		                    {
		                        ActivationStatus = write
		                            ? ActivationStatus.ActivatedReadWrite
		                            : ActivationStatus.ActivatedRead;
		                    }
		                }
		            }
		            break;
		        case ActivationStatus.ActivatedRead:
		            if (!write) return;
		            if (Model.Activate(this, true))
                        ActivationStatus = ActivationStatus.ActivatedReadWrite;
		            break;
		        default:
		            throw new ArgumentOutOfRangeException();
		    }
		}

		void IPersistEntity.Activate (Action activation)
		{
			if (ActivationStatus != ActivationStatus.NotActivated) return; //activation can only happen once in a lifetime of the object
			
			activation();
			ActivationStatus = ActivationStatus.ActivatedRead;
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
				if(ActivationStatus != ActivationStatus.NotActivated) return _lengthExponent;
				((IPersistEntity)this).Activate(false);
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
				if(ActivationStatus != ActivationStatus.NotActivated) return _massExponent;
				((IPersistEntity)this).Activate(false);
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
				if(ActivationStatus != ActivationStatus.NotActivated) return _timeExponent;
				((IPersistEntity)this).Activate(false);
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
				if(ActivationStatus != ActivationStatus.NotActivated) return _electricCurrentExponent;
				((IPersistEntity)this).Activate(false);
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
				if(ActivationStatus != ActivationStatus.NotActivated) return _thermodynamicTemperatureExponent;
				((IPersistEntity)this).Activate(false);
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
				if(ActivationStatus != ActivationStatus.NotActivated) return _amountOfSubstanceExponent;
				((IPersistEntity)this).Activate(false);
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
				if(ActivationStatus != ActivationStatus.NotActivated) return _luminousIntensityExponent;
				((IPersistEntity)this).Activate(false);
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
			//activate for write if it is not activated yet
			if (ActivationStatus != ActivationStatus.ActivatedReadWrite)
				((IPersistEntity)this).Activate(true);

			//just set the value if the model is marked as non-transactional
			if (!Model.IsTransactional)
			{
				setter(newValue);
				NotifyPropertyChanged(notifyPropertyName);
				return;
			}

			//check there is a transaction
			var txn = Model.CurrentTransaction;
			if (txn == null) throw new Exception("Operation out of transaction.");

			Action doAction = () => {
				setter(newValue);
				NotifyPropertyChanged(notifyPropertyName);
			};
			Action undoAction = () => {
				setter(oldValue);
				NotifyPropertyChanged(notifyPropertyName);
			};
			doAction();

			//do action and THAN add to transaction so that it gets the object in new state
			txn.AddReversibleAction(doAction, undoAction, this, ChangeType.Modified);
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

		#region Equality comparers and operators
        public bool Equals(@IfcDimensionalExponents other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcDimensionalExponents
            var root = (@IfcDimensionalExponents)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcDimensionalExponents left, @IfcDimensionalExponents right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcDimensionalExponents left, @IfcDimensionalExponents right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcDimensionalExponents x, @IfcDimensionalExponents y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcDimensionalExponents obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}