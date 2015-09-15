// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		15.09.2015 07:04:17
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

namespace Xbim.Ifc2x3.ActorResource
{
	[EntityName("IFCORGANIZATION", 276)]
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
			_roles = new ItemSet<IfcActorRole>( model );
			_addresses = new ItemSet<IfcAddress>( model );
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

			Action undo = () => setter(oldValue);
			txn.AddReversibleAction(undo);
			setter(newValue);
			NotifyPropertyChanged(notifyPropertyName);
		}

		#endregion

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"Id",
			"Name",
			"Description",
			"Roles",
			"Addresses",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @Id;
				case 1: 
					return @Name;
				case 2: 
					return @Description;
				case 3: 
					return @Roles;
				case 4: 
					return @Addresses;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "Id":  
					return @Id;
				case "Name":  
					return @Name;
				case "Description":  
					return @Description;
				case "Roles":  
					return @Roles;
				case "Addresses":  
					return @Addresses;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 @Id = (IfcIdentifier?)value;
					 break;
				case 1:
					 if (value != null) @Name = (IfcLabel)value;
					 break;
				case 2:
					 @Description = (IfcText?)value;
					 break;
				case 3:
					 @Roles.Add((IfcActorRole)value);
					 break;
				case 4:
					 @Addresses.Add((IfcAddress)value);
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "Id":
					 @Id = (IfcIdentifier?)value;
					 break;
				case "Name":
					 if (value != null) @Name = (IfcLabel)value;
					 break;
				case "Description":
					 @Description = (IfcText?)value;
					 break;
				case "Roles":
					 @Roles.Add((IfcActorRole)value);
					 break;
				case "Addresses":
					 @Addresses.Add((IfcAddress)value);
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion


		#region IPersist implementation
		public virtual void Parse(int propIndex, IPropertyValue value)
		{
            throw new System.NotImplementedException();
		}
		
		public virtual string WhereRule() 
		{
            throw new System.NotImplementedException();
		}
		#endregion

		
	}
}