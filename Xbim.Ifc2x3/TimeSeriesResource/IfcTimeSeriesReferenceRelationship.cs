// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.ExternalReferenceResource;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.TimeSeriesResource
{
	[ExpressType("IFCTIMESERIESREFERENCERELATIONSHIP", 673)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcTimeSeriesReferenceRelationship : INotifyPropertyChanged, IInstantiableEntity, IEqualityComparer<@IfcTimeSeriesReferenceRelationship>, IEquatable<@IfcTimeSeriesReferenceRelationship>
	{
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
		internal IfcTimeSeriesReferenceRelationship(IModel model) 		{ 
			Model = model; 
			_timeSeriesReferences = new ItemSet<IfcDocumentSelect>( this );
		}

		#region Explicit attribute fields
		private IfcTimeSeries _referencedTimeSeries;
		private ItemSet<IfcDocumentSelect> _timeSeriesReferences;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcTimeSeries @ReferencedTimeSeries 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _referencedTimeSeries;
				((IPersistEntity)this).Activate(false);
				return _referencedTimeSeries;
			} 
			set
			{
				SetValue( v =>  _referencedTimeSeries = v, _referencedTimeSeries, value,  "ReferencedTimeSeries");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1)]
		public ItemSet<IfcDocumentSelect> @TimeSeriesReferences 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _timeSeriesReferences;
				((IPersistEntity)this).Activate(false);
				return _timeSeriesReferences;
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
					_referencedTimeSeries = (IfcTimeSeries)(value.EntityVal);
					return;
				case 1: 
					if (_timeSeriesReferences == null) _timeSeriesReferences = new ItemSet<IfcDocumentSelect>( this );
					_timeSeriesReferences.InternalAdd((IfcDocumentSelect)value.EntityVal);
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
        public bool Equals(@IfcTimeSeriesReferenceRelationship other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcTimeSeriesReferenceRelationship
            var root = (@IfcTimeSeriesReferenceRelationship)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcTimeSeriesReferenceRelationship left, @IfcTimeSeriesReferenceRelationship right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcTimeSeriesReferenceRelationship left, @IfcTimeSeriesReferenceRelationship right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcTimeSeriesReferenceRelationship x, @IfcTimeSeriesReferenceRelationship y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcTimeSeriesReferenceRelationship obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}