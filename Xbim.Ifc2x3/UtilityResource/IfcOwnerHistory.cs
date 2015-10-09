// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.ActorResource;
using Xbim.Ifc2x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.UtilityResource
{
	[IndexedClass]
	[ExpressType("IFCOWNERHISTORY", 519)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcOwnerHistory : INotifyPropertyChanged, IInstantiableEntity, IEqualityComparer<@IfcOwnerHistory>, IEquatable<@IfcOwnerHistory>
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
		internal IfcOwnerHistory(IModel model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcPersonAndOrganization _owningUser;
		private IfcApplication _owningApplication;
		private IfcStateEnum? _state;
		private IfcChangeActionEnum _changeAction;
		private IfcTimeStamp? _lastModifiedDate;
		private IfcPersonAndOrganization _lastModifyingUser;
		private IfcApplication _lastModifyingApplication;
		private IfcTimeStamp _creationDate;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcPersonAndOrganization @OwningUser 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _owningUser;
				((IPersistEntity)this).Activate(false);
				return _owningUser;
			} 
			set
			{
				SetValue( v =>  _owningUser = v, _owningUser, value,  "OwningUser");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcApplication @OwningApplication 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _owningApplication;
				((IPersistEntity)this).Activate(false);
				return _owningApplication;
			} 
			set
			{
				SetValue( v =>  _owningApplication = v, _owningApplication, value,  "OwningApplication");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcStateEnum? @State 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _state;
				((IPersistEntity)this).Activate(false);
				return _state;
			} 
			set
			{
				SetValue( v =>  _state = v, _state, value,  "State");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcChangeActionEnum @ChangeAction 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _changeAction;
				((IPersistEntity)this).Activate(false);
				return _changeAction;
			} 
			set
			{
				SetValue( v =>  _changeAction = v, _changeAction, value,  "ChangeAction");
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcTimeStamp? @LastModifiedDate 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _lastModifiedDate;
				((IPersistEntity)this).Activate(false);
				return _lastModifiedDate;
			} 
			set
			{
				SetValue( v =>  _lastModifiedDate = v, _lastModifiedDate, value,  "LastModifiedDate");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcPersonAndOrganization @LastModifyingUser 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _lastModifyingUser;
				((IPersistEntity)this).Activate(false);
				return _lastModifyingUser;
			} 
			set
			{
				SetValue( v =>  _lastModifyingUser = v, _lastModifyingUser, value,  "LastModifyingUser");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcApplication @LastModifyingApplication 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _lastModifyingApplication;
				((IPersistEntity)this).Activate(false);
				return _lastModifyingApplication;
			} 
			set
			{
				SetValue( v =>  _lastModifyingApplication = v, _lastModifyingApplication, value,  "LastModifyingApplication");
			} 
		}
	
		[EntityAttribute(8, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcTimeStamp @CreationDate 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _creationDate;
				((IPersistEntity)this).Activate(false);
				return _creationDate;
			} 
			set
			{
				SetValue( v =>  _creationDate = v, _creationDate, value,  "CreationDate");
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
					_owningUser = (IfcPersonAndOrganization)(value.EntityVal);
					return;
				case 1: 
					_owningApplication = (IfcApplication)(value.EntityVal);
					return;
				case 2: 
                    _state = (IfcStateEnum) System.Enum.Parse(typeof (IfcStateEnum), value.EnumVal, true);
					return;
				case 3: 
                    _changeAction = (IfcChangeActionEnum) System.Enum.Parse(typeof (IfcChangeActionEnum), value.EnumVal, true);
					return;
				case 4: 
					_lastModifiedDate = value.IntegerVal;
					return;
				case 5: 
					_lastModifyingUser = (IfcPersonAndOrganization)(value.EntityVal);
					return;
				case 6: 
					_lastModifyingApplication = (IfcApplication)(value.EntityVal);
					return;
				case 7: 
					_creationDate = value.IntegerVal;
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
        public bool Equals(@IfcOwnerHistory other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcOwnerHistory
            var root = (@IfcOwnerHistory)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcOwnerHistory left, @IfcOwnerHistory right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcOwnerHistory left, @IfcOwnerHistory right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcOwnerHistory x, @IfcOwnerHistory y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcOwnerHistory obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}