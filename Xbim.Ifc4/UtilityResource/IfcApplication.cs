// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		22.09.2015 04:44:10
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.ActorResource;
using Xbim.Ifc4.MeasureResource;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.UtilityResource
{
	[IndexedClass]
	[ExpressType("IFCAPPLICATION", 410)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcApplication : IPersistEntity, INotifyPropertyChanged, IInstantiableEntity
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
		internal IfcApplication(IModel model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcOrganization _applicationDeveloper;
		private IfcLabel _version;
		private IfcLabel _applicationFullName;
		private IfcIdentifier _applicationIdentifier;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcOrganization @ApplicationDeveloper 
		{ 
			get 
			{
				if(Activated) return _applicationDeveloper;
				
				Model.Activate(this, true);
				Activated = true;
				return _applicationDeveloper;
			} 
			set
			{
				SetValue( v =>  _applicationDeveloper = v, _applicationDeveloper, value,  "ApplicationDeveloper");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel @Version 
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
	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel @ApplicationFullName 
		{ 
			get 
			{
				if(Activated) return _applicationFullName;
				
				Model.Activate(this, true);
				Activated = true;
				return _applicationFullName;
			} 
			set
			{
				SetValue( v =>  _applicationFullName = v, _applicationFullName, value,  "ApplicationFullName");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcIdentifier @ApplicationIdentifier 
		{ 
			get 
			{
				if(Activated) return _applicationIdentifier;
				
				Model.Activate(this, true);
				Activated = true;
				return _applicationIdentifier;
			} 
			set
			{
				SetValue( v =>  _applicationIdentifier = v, _applicationIdentifier, value,  "ApplicationIdentifier");
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
					_applicationDeveloper = (IfcOrganization)(value.EntityVal);
					return;
				case 1: 
					_version = value.StringVal;
					return;
				case 2: 
					_applicationFullName = value.StringVal;
					return;
				case 3: 
					_applicationIdentifier = value.StringVal;
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