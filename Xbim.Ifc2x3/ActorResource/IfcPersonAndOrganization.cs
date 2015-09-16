// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		16.09.2015 10:12:19
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
	[EntityName("IFCPERSONANDORGANIZATION", 663)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcPersonAndOrganization : INotifyPropertyChanged, IfcActorSelect, IfcObjectReferenceSelect, IInstantiableEntity
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
		internal IfcPersonAndOrganization(IModel model) 		{ 
			Model = model; 
			_roles = new ItemSet<IfcActorRole>( model );
		}

		#region Explicit attribute fields
		private IfcPerson _thePerson;
		private IfcOrganization _theOrganization;
		private ItemSet<IfcActorRole> _roles;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(0, EntityAttributeState.Mandatory)]
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
	
		[EntityAttribute(1, EntityAttributeState.Mandatory)]
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
	
		[EntityAttribute(2, EntityAttributeState.Optional)]
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

		#region Index access
		private static readonly List<string> AttributeNames = new List<string>
		{
			"ThePerson",
			"TheOrganization",
			"Roles",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return AttributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @ThePerson;
				case 1: 
					return @TheOrganization;
				case 2: 
					return @Roles;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "ThePerson":  
					return @ThePerson;
				case "TheOrganization":  
					return @TheOrganization;
				case "Roles":  
					return @Roles;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 @ThePerson = (IfcPerson)value;
					 break;
				case 1:
					 @TheOrganization = (IfcOrganization)value;
					 break;
				case 2:
					 @Roles.Add((IfcActorRole)value);
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "ThePerson":
					 @ThePerson = (IfcPerson)value;
					 break;
				case "TheOrganization":
					 @TheOrganization = (IfcOrganization)value;
					 break;
				case "Roles":
					 @Roles.Add((IfcActorRole)value);
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
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
					if (_roles == null) _roles = new ItemSet<IfcActorRole>( Model );
					_roles.Add((IfcActorRole)value.EntityVal);
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