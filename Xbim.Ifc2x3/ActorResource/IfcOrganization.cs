// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 10:20:59
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.PropertyResource;
using Xbim.Ifc2x3.MeasureResource;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.ActorResource
{
	[EntityName("IFCORGANIZATION", 276)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcOrganization : INotifyPropertyChanged, IfcActorSelect, IfcObjectReferenceSelect, IInstantiableEntity
	{
		#region Implementation of IPersistEntity
		public int EntityLabel {get; internal set;}
		
		public IModel Model { get; internal set; }
		
		public bool Activated { get; internal set; }

		public void Activate(bool write)
		{
			if (Activated) return; //activation can only happen once in a lifetime of the object

			Model.Activate(this, write);
			Activated = true;
		}

		public void Activate (Action activation)
		{
			activation();
			Activated = true;
		}
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcOrganization(IModel model) 		{ 
			Model = model; 
			_roles = new ItemSet<IfcActorRole>( this );
			_addresses = new ItemSet<IfcAddress>( this );
		}

		#region Explicit attribute fields
		private IfcIdentifier? _id;
		private IfcLabel _name;
		private IfcText? _description;
		private ItemSet<IfcActorRole> _roles;
		private ItemSet<IfcAddress> _addresses;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(0, EntityAttributeState.Optional)]
		public IfcIdentifier? @Id 
		{ 
			get 
			{
				if(Activated) return _id;
				
				Model.Activate(this, true);
				Activated = true;
				return _id;
			} 
			set
			{
				SetValue( v =>  _id = v, _id, value,  "Id");
			} 
		}
	
		[EntityAttribute(1, EntityAttributeState.Mandatory)]
		public IfcLabel @Name 
		{ 
			get 
			{
				if(Activated) return _name;
				
				Model.Activate(this, true);
				Activated = true;
				return _name;
			} 
			set
			{
				SetValue( v =>  _name = v, _name, value,  "Name");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Optional)]
		public IfcText? @Description 
		{ 
			get 
			{
				if(Activated) return _description;
				
				Model.Activate(this, true);
				Activated = true;
				return _description;
			} 
			set
			{
				SetValue( v =>  _description = v, _description, value,  "Description");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Optional)]
		public ItemSet<IfcActorRole> @Roles 
		{ 
			get 
			{
				if(Activated) return _roles;
				
				Model.Activate(this, true);
				Activated = true;
				return _roles;
			} 
			set
			{
				SetValue( v =>  _roles = v, _roles, value,  "Roles");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Optional)]
		public ItemSet<IfcAddress> @Addresses 
		{ 
			get 
			{
				if(Activated) return _addresses;
				
				Model.Activate(this, true);
				Activated = true;
				return _addresses;
			} 
			set
			{
				SetValue( v =>  _addresses = v, _addresses, value,  "Addresses");
			} 
		}
	
		#endregion

		#region Inverse attributes
		public IEnumerable<IfcOrganizationRelationship> @IsRelatedBy 
		{ 
			get 
			{
				return Model.Instances.Where<IfcOrganizationRelationship>(e => e.RelatedOrganizations != null &&  e.RelatedOrganizations.Contains(this));
			} 
		}
	
		public IEnumerable<IfcOrganizationRelationship> @Relates 
		{ 
			get 
			{
				return Model.Instances.Where<IfcOrganizationRelationship>(e => e.RelatingOrganization == this);
			} 
		}
	
		public IEnumerable<IfcPersonAndOrganization> @Engages 
		{ 
			get 
			{
				return Model.Instances.Where<IfcPersonAndOrganization>(e => e.TheOrganization == this);
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
					_id = value.StringVal;
					return;
				case 1: 
					_name = value.StringVal;
					return;
				case 2: 
					_description = value.StringVal;
					return;
				case 3: 
					if (_roles == null) _roles = new ItemSet<IfcActorRole>( this );
					_roles.InternalAdd((IfcActorRole)value.EntityVal);
					return;
				case 4: 
					if (_addresses == null) _addresses = new ItemSet<IfcAddress>( this );
					_addresses.InternalAdd((IfcAddress)value.EntityVal);
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