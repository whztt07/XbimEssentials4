// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 09:16:38
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.PresentationOrganizationResource;
using Xbim.Ifc2x3.PropertyResource;
using Xbim.Ifc2x3.MeasureResource;
using System.ComponentModel;
using System;
using Xbim.Common;

namespace Xbim.Ifc2x3.ExternalReferenceResource
{
	[EntityName("IFCEXTERNALREFERENCE")]
	public abstract partial class @IfcExternalReference : IPersistEntity, INotifyPropertyChanged, IfcLightDistributionDataSourceSelect, IfcObjectReferenceSelect
	{
		#region Implementation of IPersistEntity
		public int EntityLabel {get; set;}
		public IModel Model { get; internal set; }

		protected bool IsActivated = false;

		public bool Activated { get { return IsActivated; } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcExternalReference(IModel model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcLabel? _location;
		private IfcIdentifier? _itemReference;
		private IfcLabel? _name;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(0, EntityAttributeState.Optional)]
		public IfcLabel? @Location 
		{ 
			get 
			{
				if(IsActivated) return _location;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _location;
			} 
			set
			{
				SetValue( v =>  _location = v, _location, value,  "Location");
			} 
		}
	
		[EntityAttribute(1, EntityAttributeState.Optional)]
		public IfcIdentifier? @ItemReference 
		{ 
			get 
			{
				if(IsActivated) return _itemReference;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _itemReference;
			} 
			set
			{
				SetValue( v =>  _itemReference = v, _itemReference, value,  "ItemReference");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Optional)]
		public IfcLabel? @Name 
		{ 
			get 
			{
				if(IsActivated) return _name;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _name;
			} 
			set
			{
				SetValue( v =>  _name = v, _name, value,  "Name");
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

		#region Where rules
		/*WR1:	WR1 : EXISTS(ItemReference) OR EXISTS(Location) OR EXISTS(Name);*/
		#endregion

		#region IPersist implementation
		#endregion

	}
}