// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 02:29:12
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

namespace Xbim.Ifc2x3.ExternalReferenceResource
{
	[EntityName("IFCCLASSIFICATIONITEM", 79)]
	public  partial class @IfcClassificationItem : INotifyPropertyChanged, IInstantiableEntity
	{
		#region Implementation of IPersistEntity
		public int EntityLabel {get; internal set;}
		public IModel Model { get; internal set; }
		public bool Activated { get; internal set; }
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
		[EntityAttribute(0, EntityAttributeState.Mandatory)]
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
	
		[EntityAttribute(1, EntityAttributeState.Optional)]
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
	
		[EntityAttribute(2, EntityAttributeState.Mandatory)]
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
		public IEnumerable<IfcClassificationItemRelationship> @IsClassifiedItemIn 
		{ 
			get 
			{
				return Model.Instances.Where<IfcClassificationItemRelationship>(e => e.RelatedItems != null &&  e.RelatedItems.Contains(this));
			} 
		}
	
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

			Action undo = () => setter(oldValue);
			txn.AddReversibleAction(undo);
			setter(newValue);
			NotifyPropertyChanged(notifyPropertyName);
		}

		#endregion

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"Notation",
			"ItemOf",
			"Title",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @Notation;
				case 1: 
					return @ItemOf;
				case 2: 
					return @Title;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "Notation":  
					return @Notation;
				case "ItemOf":  
					return @ItemOf;
				case "Title":  
					return @Title;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 @Notation = (IfcClassificationNotationFacet)value;
					 break;
				case 1:
					 @ItemOf = (IfcClassification)value;
					 break;
				case 2:
					 if (value != null) @Title = (IfcLabel)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "Notation":
					 @Notation = (IfcClassificationNotationFacet)value;
					 break;
				case "ItemOf":
					 @ItemOf = (IfcClassification)value;
					 break;
				case "Title":
					 if (value != null) @Title = (IfcLabel)value;
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