// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		21.09.2015 05:11:20
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.PresentationOrganizationResource;
using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.GeometryResource;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.RepresentationResource
{
	[IndexedClass]
	[ExpressType("IFCREPRESENTATION", 950)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcRepresentation : IPersistEntity, INotifyPropertyChanged, IfcLayeredItem
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
		internal IfcRepresentation(IModel model) 		{ 
			Model = model; 
			_items = new ItemSet<IfcRepresentationItem>( this );
		}

		#region Explicit attribute fields
		private IfcRepresentationContext _contextOfItems;
		private IfcLabel? _representationIdentifier;
		private IfcLabel? _representationType;
		private ItemSet<IfcRepresentationItem> _items;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcRepresentationContext @ContextOfItems 
		{ 
			get 
			{
				if(Activated) return _contextOfItems;
				
				Model.Activate(this, true);
				Activated = true;
				return _contextOfItems;
			} 
			set
			{
				SetValue( v =>  _contextOfItems = v, _contextOfItems, value,  "ContextOfItems");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel? @RepresentationIdentifier 
		{ 
			get 
			{
				if(Activated) return _representationIdentifier;
				
				Model.Activate(this, true);
				Activated = true;
				return _representationIdentifier;
			} 
			set
			{
				SetValue( v =>  _representationIdentifier = v, _representationIdentifier, value,  "RepresentationIdentifier");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel? @RepresentationType 
		{ 
			get 
			{
				if(Activated) return _representationType;
				
				Model.Activate(this, true);
				Activated = true;
				return _representationType;
			} 
			set
			{
				SetValue( v =>  _representationType = v, _representationType, value,  "RepresentationType");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1)]
		public ItemSet<IfcRepresentationItem> @Items 
		{ 
			get 
			{
				if(Activated) return _items;
				
				Model.Activate(this, true);
				Activated = true;
				return _items;
			} 
		}
	
		#endregion

		#region Inverse attributes
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcRepresentationMap> @RepresentationMap 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRepresentationMap>(e => e.MappedRepresentation == this);
			} 
		}
	
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcPresentationLayerAssignment> @LayerAssignments 
		{ 
			get 
			{
				return Model.Instances.Where<IfcPresentationLayerAssignment>(e => e.AssignedItems != null &&  e.AssignedItems.Contains(this));
			} 
		}
	
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcProductRepresentation> @OfProductRepresentation 
		{ 
			get 
			{
				return Model.Instances.Where<IfcProductRepresentation>(e => e.Representations != null &&  e.Representations.Contains(this));
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
					_contextOfItems = (IfcRepresentationContext)(value.EntityVal);
					return;
				case 1: 
					_representationIdentifier = value.StringVal;
					return;
				case 2: 
					_representationType = value.StringVal;
					return;
				case 3: 
					if (_items == null) _items = new ItemSet<IfcRepresentationItem>( this );
					_items.InternalAdd((IfcRepresentationItem)value.EntityVal);
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