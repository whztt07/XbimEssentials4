// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.UtilityResource
{
	[IndexedClass]
	[ExpressType("IFCTABLEROW", 1078)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcTableRow : INotifyPropertyChanged, IInstantiableEntity, IEqualityComparer<@IfcTableRow>, IEquatable<@IfcTableRow>
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
		internal IfcTableRow(IModel model) 		{ 
			Model = model; 
			_rowCells = new OptionalItemSet<IfcValue>( this, 0 );
		}

		#region Explicit attribute fields
		private OptionalItemSet<IfcValue> _rowCells;
		private bool? _isHeading;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.Class, 1, -1)]
		public OptionalItemSet<IfcValue> @RowCells 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _rowCells;
				((IPersistEntity)this).Activate(false);
				return _rowCells;
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public bool? @IsHeading 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _isHeading;
				((IPersistEntity)this).Activate(false);
				return _isHeading;
			} 
			set
			{
				SetValue( v =>  _isHeading = v, _isHeading, value,  "IsHeading");
			} 
		}
	
		#endregion

		#region Inverse attributes
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IfcTable @OfTable 
		{ 
			get 
			{
				return Model.Instances.FirstOrDefault<IfcTable>(e => e.Rows != null &&  e.Rows.Contains(this));
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
		public virtual void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					if (_rowCells == null) _rowCells = new OptionalItemSet<IfcValue>( this );
					_rowCells.InternalAdd((IfcValue)value.EntityVal);
					return;
				case 1: 
					_isHeading = value.BooleanVal;
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
        public bool Equals(@IfcTableRow other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcTableRow
            var root = (@IfcTableRow)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcTableRow left, @IfcTableRow right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcTableRow left, @IfcTableRow right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcTableRow x, @IfcTableRow y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcTableRow obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}