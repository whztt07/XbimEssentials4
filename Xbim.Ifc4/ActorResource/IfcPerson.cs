// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		22.09.2015 04:44:13
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.PropertyResource;
using Xbim.Ifc4.ExternalReferenceResource;
using Xbim.Ifc4.MeasureResource;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.ActorResource
{
	[IndexedClass]
	[ExpressType("IFCPERSON", 797)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcPerson : IPersistEntity, INotifyPropertyChanged, IfcActorSelect, IfcObjectReferenceSelect, IfcResourceObjectSelect, IInstantiableEntity
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
		internal IfcPerson(IModel model) 		{ 
			Model = model; 
			_middleNames = new OptionalItemSet<IfcLabel>( this );
			_prefixTitles = new OptionalItemSet<IfcLabel>( this );
			_suffixTitles = new OptionalItemSet<IfcLabel>( this );
			_roles = new OptionalItemSet<IfcActorRole>( this );
			_addresses = new OptionalItemSet<IfcAddress>( this );
		}

		#region Explicit attribute fields
		private IfcIdentifier? _identification;
		private IfcLabel? _familyName;
		private IfcLabel? _givenName;
		private OptionalItemSet<IfcLabel> _middleNames;
		private OptionalItemSet<IfcLabel> _prefixTitles;
		private OptionalItemSet<IfcLabel> _suffixTitles;
		private OptionalItemSet<IfcActorRole> _roles;
		private OptionalItemSet<IfcAddress> _addresses;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcIdentifier? @Identification 
		{ 
			get 
			{
				if(Activated) return _identification;
				
				Model.Activate(this, true);
				Activated = true;
				return _identification;
			} 
			set
			{
				SetValue( v =>  _identification = v, _identification, value,  "Identification");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel? @FamilyName 
		{ 
			get 
			{
				if(Activated) return _familyName;
				
				Model.Activate(this, true);
				Activated = true;
				return _familyName;
			} 
			set
			{
				SetValue( v =>  _familyName = v, _familyName, value,  "FamilyName");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel? @GivenName 
		{ 
			get 
			{
				if(Activated) return _givenName;
				
				Model.Activate(this, true);
				Activated = true;
				return _givenName;
			} 
			set
			{
				SetValue( v =>  _givenName = v, _givenName, value,  "GivenName");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.None, 1, -1)]
		public OptionalItemSet<IfcLabel> @MiddleNames 
		{ 
			get 
			{
				if(Activated) return _middleNames;
				
				Model.Activate(this, true);
				Activated = true;
				return _middleNames;
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.None, 1, -1)]
		public OptionalItemSet<IfcLabel> @PrefixTitles 
		{ 
			get 
			{
				if(Activated) return _prefixTitles;
				
				Model.Activate(this, true);
				Activated = true;
				return _prefixTitles;
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.None, 1, -1)]
		public OptionalItemSet<IfcLabel> @SuffixTitles 
		{ 
			get 
			{
				if(Activated) return _suffixTitles;
				
				Model.Activate(this, true);
				Activated = true;
				return _suffixTitles;
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.Class, 1, -1)]
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
	
		[IndexedProperty]
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.Class, 1, -1)]
		public OptionalItemSet<IfcAddress> @Addresses 
		{ 
			get 
			{
				if(Activated) return _addresses;
				
				Model.Activate(this, true);
				Activated = true;
				return _addresses;
			} 
		}
	
		#endregion

		#region Inverse attributes
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcPersonAndOrganization> @EngagedIn 
		{ 
			get 
			{
				return Model.Instances.Where<IfcPersonAndOrganization>(e => e.ThePerson == this);
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
					_identification = value.StringVal;
					return;
				case 1: 
					_familyName = value.StringVal;
					return;
				case 2: 
					_givenName = value.StringVal;
					return;
				case 3: 
					if (_middleNames == null) _middleNames = new OptionalItemSet<IfcLabel>( this );
					_middleNames.InternalAdd(value.StringVal);
					return;
				case 4: 
					if (_prefixTitles == null) _prefixTitles = new OptionalItemSet<IfcLabel>( this );
					_prefixTitles.InternalAdd(value.StringVal);
					return;
				case 5: 
					if (_suffixTitles == null) _suffixTitles = new OptionalItemSet<IfcLabel>( this );
					_suffixTitles.InternalAdd(value.StringVal);
					return;
				case 6: 
					if (_roles == null) _roles = new OptionalItemSet<IfcActorRole>( this );
					_roles.InternalAdd((IfcActorRole)value.EntityVal);
					return;
				case 7: 
					if (_addresses == null) _addresses = new OptionalItemSet<IfcAddress>( this );
					_addresses.InternalAdd((IfcAddress)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public virtual string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*IdentifiablePerson:	IdentifiablePerson : EXISTS(Identification) OR EXISTS(FamilyName) OR EXISTS(GivenName);*/
		/*ValidSetOfNames:	ValidSetOfNames : NOT EXISTS(MiddleNames) OR EXISTS(FamilyName) OR EXISTS(GivenName);*/
		}
		#endregion
	}
}