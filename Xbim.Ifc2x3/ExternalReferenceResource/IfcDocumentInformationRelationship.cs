// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.ExternalReferenceResource
{
	[IndexedClass]
	[ExpressType("IFCDOCUMENTINFORMATIONRELATIONSHIP", 491)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcDocumentInformationRelationship : INotifyPropertyChanged, IInstantiableEntity, IEqualityComparer<@IfcDocumentInformationRelationship>, IEquatable<@IfcDocumentInformationRelationship>
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
		internal IfcDocumentInformationRelationship(IModel model) 		{ 
			Model = model; 
			_relatedDocuments = new ItemSet<IfcDocumentInformation>( this, 0 );
		}

		#region Explicit attribute fields
		private IfcDocumentInformation _relatingDocument;
		private ItemSet<IfcDocumentInformation> _relatedDocuments;
		private IfcLabel? _relationshipType;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcDocumentInformation @RelatingDocument 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _relatingDocument;
				((IPersistEntity)this).Activate(false);
				return _relatingDocument;
			} 
			set
			{
				SetValue( v =>  _relatingDocument = v, _relatingDocument, value,  "RelatingDocument");
			} 
		}
	
		[IndexedProperty]
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1)]
		public ItemSet<IfcDocumentInformation> @RelatedDocuments 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _relatedDocuments;
				((IPersistEntity)this).Activate(false);
				return _relatedDocuments;
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel? @RelationshipType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _relationshipType;
				((IPersistEntity)this).Activate(false);
				return _relationshipType;
			} 
			set
			{
				SetValue( v =>  _relationshipType = v, _relationshipType, value,  "RelationshipType");
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
					_relatingDocument = (IfcDocumentInformation)(value.EntityVal);
					return;
				case 1: 
					if (_relatedDocuments == null) _relatedDocuments = new ItemSet<IfcDocumentInformation>( this );
					_relatedDocuments.InternalAdd((IfcDocumentInformation)value.EntityVal);
					return;
				case 2: 
					_relationshipType = value.StringVal;
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
        public bool Equals(@IfcDocumentInformationRelationship other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcDocumentInformationRelationship
            var root = (@IfcDocumentInformationRelationship)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcDocumentInformationRelationship left, @IfcDocumentInformationRelationship right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcDocumentInformationRelationship left, @IfcDocumentInformationRelationship right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcDocumentInformationRelationship x, @IfcDocumentInformationRelationship y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcDocumentInformationRelationship obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}