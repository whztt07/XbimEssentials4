// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.ActorResource;
using Xbim.Ifc2x3.DateTimeResource;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.ExternalReferenceResource
{
	[IndexedClass]
	[ExpressType("IFCLIBRARYINFORMATION", 449)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcLibraryInformation : INotifyPropertyChanged, IfcLibrarySelect, IInstantiableEntity, IEqualityComparer<@IfcLibraryInformation>, IEquatable<@IfcLibraryInformation>
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
		internal IfcLibraryInformation(IModel model) 		{ 
			Model = model; 
			_libraryReference = new OptionalItemSet<IfcLibraryReference>( this );
		}

		#region Explicit attribute fields
		private IfcLabel _name;
		private IfcLabel? _version;
		private IfcOrganization _publisher;
		private IfcCalendarDate _versionDate;
		private OptionalItemSet<IfcLibraryReference> _libraryReference;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel @Name 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _name;
				((IPersistEntity)this).Activate(false);
				return _name;
			} 
			set
			{
				SetValue( v =>  _name = v, _name, value,  "Name");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel? @Version 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _version;
				((IPersistEntity)this).Activate(false);
				return _version;
			} 
			set
			{
				SetValue( v =>  _version = v, _version, value,  "Version");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcOrganization @Publisher 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _publisher;
				((IPersistEntity)this).Activate(false);
				return _publisher;
			} 
			set
			{
				SetValue( v =>  _publisher = v, _publisher, value,  "Publisher");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcCalendarDate @VersionDate 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _versionDate;
				((IPersistEntity)this).Activate(false);
				return _versionDate;
			} 
			set
			{
				SetValue( v =>  _versionDate = v, _versionDate, value,  "VersionDate");
			} 
		}
	
		[IndexedProperty]
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1)]
		public OptionalItemSet<IfcLibraryReference> @LibraryReference 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _libraryReference;
				((IPersistEntity)this).Activate(false);
				return _libraryReference;
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
					_name = value.StringVal;
					return;
				case 1: 
					_version = value.StringVal;
					return;
				case 2: 
					_publisher = (IfcOrganization)(value.EntityVal);
					return;
				case 3: 
					_versionDate = (IfcCalendarDate)(value.EntityVal);
					return;
				case 4: 
					if (_libraryReference == null) _libraryReference = new OptionalItemSet<IfcLibraryReference>( this );
					_libraryReference.InternalAdd((IfcLibraryReference)value.EntityVal);
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
        public bool Equals(@IfcLibraryInformation other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcLibraryInformation
            var root = (@IfcLibraryInformation)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcLibraryInformation left, @IfcLibraryInformation right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcLibraryInformation left, @IfcLibraryInformation right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcLibraryInformation x, @IfcLibraryInformation y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcLibraryInformation obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}