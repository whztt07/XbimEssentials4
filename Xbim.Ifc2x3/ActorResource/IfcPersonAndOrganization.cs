// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		23.09.2015 10:21:44
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.PropertyResource;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.ActorResource
{
	[IndexedClass]
	[ExpressType("IFCPERSONANDORGANIZATION", 663)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcPersonAndOrganization : IPersistEntity, INotifyPropertyChanged, IfcActorSelect, IfcObjectReferenceSelect, IInstantiableEntity
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
		internal IfcPersonAndOrganization(IModel model) 		{ 
			Model = model; 
			_roles = new OptionalItemSet<IfcActorRole>( this );
		}

		#region Explicit attribute fields
		private IfcPerson _thePerson;
		private IfcOrganization _theOrganization;
		private OptionalItemSet<IfcActorRole> _roles;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcPerson @ThePerson 
		{ 
			get 
			{
				if(Activated) return _thePerson;
				
				Model.Activate(this, true);
				Activated = true;
				return _thePerson;
			} 
			set
			{
				SetValue( v =>  _thePerson = v, _thePerson, value,  "ThePerson");
			} 
		}
	
		[IndexedProperty]
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcOrganization @TheOrganization 
		{ 
			get 
			{
				if(Activated) return _theOrganization;
				
				Model.Activate(this, true);
				Activated = true;
				return _theOrganization;
			} 
			set
			{
				SetValue( v =>  _theOrganization = v, _theOrganization, value,  "TheOrganization");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.Class, 1, -1)]
		public OptionalItemSet<IfcActorRole> @Roles 
		{ 
			get 
			{
				if(Activated) return _roles;
				
				Model.Activate(this, true);
				Activated = true;
				return _roles;
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
					_thePerson = (IfcPerson)(value.EntityVal);
					return;
				case 1: 
					_theOrganization = (IfcOrganization)(value.EntityVal);
					return;
				case 2: 
					if (_roles == null) _roles = new OptionalItemSet<IfcActorRole>( this );
					_roles.InternalAdd((IfcActorRole)value.EntityVal);
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