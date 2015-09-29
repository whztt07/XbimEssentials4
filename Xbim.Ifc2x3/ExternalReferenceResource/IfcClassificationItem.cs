// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.ExternalReferenceResource
{
	[IndexedClass]
	[ExpressType("IFCCLASSIFICATIONITEM", 14)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcClassificationItem : IPersistEntity, INotifyPropertyChanged, IInstantiableEntity
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
		internal IfcClassificationItem(IModel model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcClassificationNotationFacet _notation;
		private IfcClassification _itemOf;
		private IfcLabel _title;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcClassificationNotationFacet @Notation 
		{ 
			get 
			{
				if(Activated) return _notation;
				
				Model.Activate(this, true);
				Activated = true;
				return _notation;
			} 
			set
			{
				SetValue( v =>  _notation = v, _notation, value,  "Notation");
			} 
		}
	
		[IndexedProperty]
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcClassification @ItemOf 
		{ 
			get 
			{
				if(Activated) return _itemOf;
				
				Model.Activate(this, true);
				Activated = true;
				return _itemOf;
			} 
			set
			{
				SetValue( v =>  _itemOf = v, _itemOf, value,  "ItemOf");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel @Title 
		{ 
			get 
			{
				if(Activated) return _title;
				
				Model.Activate(this, true);
				Activated = true;
				return _title;
			} 
			set
			{
				SetValue( v =>  _title = v, _title, value,  "Title");
			} 
		}
	
		#endregion

		#region Inverse attributes
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcClassificationItemRelationship> @IsClassifiedItemIn 
		{ 
			get 
			{
				return Model.Instances.Where<IfcClassificationItemRelationship>(e => e.RelatedItems != null &&  e.RelatedItems.Contains(this));
			} 
		}
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcClassificationItemRelationship> @IsClassifyingItemIn 
		{ 
			get 
			{
				return Model.Instances.Where<IfcClassificationItemRelationship>(e => e.RelatingItem == this);
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
			setter(newValue);

			//do action and THAN add to transaction so that it gets the object in new state
			txn.AddReversibleAction(doAction, undoAction, this, ChangeType.Modified);
			NotifyPropertyChanged(notifyPropertyName);
		}

		#endregion

		#region IPersist implementation
		public virtual void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
					_notation = (IfcClassificationNotationFacet)(value.EntityVal);
					return;
				case 1: 
					_itemOf = (IfcClassification)(value.EntityVal);
					return;
				case 2: 
					_title = value.StringVal;
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