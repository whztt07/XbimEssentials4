// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		22.09.2015 02:31:58
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.ActorResource;
using Xbim.Ifc2x3.DateTimeResource;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.ExternalReferenceResource
{
	[IndexedClass]
	[ExpressType("IFCLIBRARYINFORMATION", 449)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcLibraryInformation : IPersistEntity, INotifyPropertyChanged, IfcLibrarySelect, IInstantiableEntity
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
		internal IfcLibraryInformation(IModel model) 		{ 
			Model = model; 
			_libraryReference = new OptionalItemSet<IfcLibraryReference>( this );
		}

		#region Explicit attribute fields
		private IfcLabel _name;
		private IfcLabel? _version;
		private IfcOrganization _publisher;
		private IfcCalendarDate _versionDate;
		private OptionalItemSet<IfcLibraryReference> _libraryReference;
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
		public IfcLabel? @Version 
		{ 
			get 
			{
				if(Activated) return _version;
				
				Model.Activate(this, true);
				Activated = true;
				return _version;
			} 
			set
			{
				SetValue( v =>  _version = v, _version, value,  "Version");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcOrganization @Publisher 
		{ 
			get 
			{
				if(Activated) return _publisher;
				
				Model.Activate(this, true);
				Activated = true;
				return _publisher;
			} 
			set
			{
				SetValue( v =>  _publisher = v, _publisher, value,  "Publisher");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcCalendarDate @VersionDate 
		{ 
			get 
			{
				if(Activated) return _versionDate;
				
				Model.Activate(this, true);
				Activated = true;
				return _versionDate;
			} 
			set
			{
				SetValue( v =>  _versionDate = v, _versionDate, value,  "VersionDate");
			} 
		}
	
		[IndexedProperty]
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1)]
		public OptionalItemSet<IfcLibraryReference> @LibraryReference 
		{ 
			get 
			{
				if(Activated) return _libraryReference;
				
				Model.Activate(this, true);
				Activated = true;
				return _libraryReference;
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
					_version = value.StringVal;
					return;
				case 2: 
					_publisher = (IfcOrganization)(value.EntityVal);
					return;
				case 3: 
					_versionDate = (IfcCalendarDate)(value.EntityVal);
					return;
				case 4: 
					if (_libraryReference == null) _libraryReference = new OptionalItemSet<IfcLibraryReference>( this );
					_libraryReference.InternalAdd((IfcLibraryReference)value.EntityVal);
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