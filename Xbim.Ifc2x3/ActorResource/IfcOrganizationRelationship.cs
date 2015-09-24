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

namespace Xbim.Ifc2x3.ActorResource
{
	[IndexedClass]
	[ExpressType("IFCORGANIZATIONRELATIONSHIP", 486)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcOrganizationRelationship : IPersistEntity, INotifyPropertyChanged, IInstantiableEntity
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
		internal IfcOrganizationRelationship(IModel model) 		{ 
			Model = model; 
			_relatedOrganizations = new ItemSet<IfcOrganization>( this );
		}

		#region Explicit attribute fields
		private IfcLabel _name;
		private IfcText? _description;
		private IfcOrganization _relatingOrganization;
		private ItemSet<IfcOrganization> _relatedOrganizations;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
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
	
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
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
	
		[IndexedProperty]
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcOrganization @RelatingOrganization 
		{ 
			get 
			{
				if(Activated) return _relatingOrganization;
				
				Model.Activate(this, true);
				Activated = true;
				return _relatingOrganization;
			} 
			set
			{
				SetValue( v =>  _relatingOrganization = v, _relatingOrganization, value,  "RelatingOrganization");
			} 
		}
	
		[IndexedProperty]
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1)]
		public ItemSet<IfcOrganization> @RelatedOrganizations 
		{ 
			get 
			{
				if(Activated) return _relatedOrganizations;
				
				Model.Activate(this, true);
				Activated = true;
				return _relatedOrganizations;
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
					_name = value.StringVal;
					return;
				case 1: 
					_description = value.StringVal;
					return;
				case 2: 
					_relatingOrganization = (IfcOrganization)(value.EntityVal);
					return;
				case 3: 
					if (_relatedOrganizations == null) _relatedOrganizations = new ItemSet<IfcOrganization>( this );
					_relatedOrganizations.InternalAdd((IfcOrganization)value.EntityVal);
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