// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		22.09.2015 04:44:05
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.ActorResource;
using Xbim.Ifc2x3.MeasureResource;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.UtilityResource
{
	[IndexedClass]
	[ExpressType("IFCOWNERHISTORY", 519)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcOwnerHistory : IPersistEntity, INotifyPropertyChanged, IInstantiableEntity
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
		internal IfcOwnerHistory(IModel model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcPersonAndOrganization _owningUser;
		private IfcApplication _owningApplication;
		private IfcStateEnum? _state;
		private IfcChangeActionEnum _changeAction;
		private IfcTimeStamp? _lastModifiedDate;
		private IfcPersonAndOrganization _lastModifyingUser;
		private IfcApplication _lastModifyingApplication;
		private IfcTimeStamp _creationDate;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcPersonAndOrganization @OwningUser 
		{ 
			get 
			{
				if(Activated) return _owningUser;
				
				Model.Activate(this, true);
				Activated = true;
				return _owningUser;
			} 
			set
			{
				SetValue( v =>  _owningUser = v, _owningUser, value,  "OwningUser");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcApplication @OwningApplication 
		{ 
			get 
			{
				if(Activated) return _owningApplication;
				
				Model.Activate(this, true);
				Activated = true;
				return _owningApplication;
			} 
			set
			{
				SetValue( v =>  _owningApplication = v, _owningApplication, value,  "OwningApplication");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcStateEnum? @State 
		{ 
			get 
			{
				if(Activated) return _state;
				
				Model.Activate(this, true);
				Activated = true;
				return _state;
			} 
			set
			{
				SetValue( v =>  _state = v, _state, value,  "State");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcChangeActionEnum @ChangeAction 
		{ 
			get 
			{
				if(Activated) return _changeAction;
				
				Model.Activate(this, true);
				Activated = true;
				return _changeAction;
			} 
			set
			{
				SetValue( v =>  _changeAction = v, _changeAction, value,  "ChangeAction");
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcTimeStamp? @LastModifiedDate 
		{ 
			get 
			{
				if(Activated) return _lastModifiedDate;
				
				Model.Activate(this, true);
				Activated = true;
				return _lastModifiedDate;
			} 
			set
			{
				SetValue( v =>  _lastModifiedDate = v, _lastModifiedDate, value,  "LastModifiedDate");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcPersonAndOrganization @LastModifyingUser 
		{ 
			get 
			{
				if(Activated) return _lastModifyingUser;
				
				Model.Activate(this, true);
				Activated = true;
				return _lastModifyingUser;
			} 
			set
			{
				SetValue( v =>  _lastModifyingUser = v, _lastModifyingUser, value,  "LastModifyingUser");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcApplication @LastModifyingApplication 
		{ 
			get 
			{
				if(Activated) return _lastModifyingApplication;
				
				Model.Activate(this, true);
				Activated = true;
				return _lastModifyingApplication;
			} 
			set
			{
				SetValue( v =>  _lastModifyingApplication = v, _lastModifyingApplication, value,  "LastModifyingApplication");
			} 
		}
	
		[EntityAttribute(8, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcTimeStamp @CreationDate 
		{ 
			get 
			{
				if(Activated) return _creationDate;
				
				Model.Activate(this, true);
				Activated = true;
				return _creationDate;
			} 
			set
			{
				SetValue( v =>  _creationDate = v, _creationDate, value,  "CreationDate");
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
					_owningUser = (IfcPersonAndOrganization)(value.EntityVal);
					return;
				case 1: 
					_owningApplication = (IfcApplication)(value.EntityVal);
					return;
				case 2: 
                    _state = (IfcStateEnum) System.Enum.Parse(typeof (IfcStateEnum), value.EnumVal, true);
					return;
				case 3: 
                    _changeAction = (IfcChangeActionEnum) System.Enum.Parse(typeof (IfcChangeActionEnum), value.EnumVal, true);
					return;
				case 4: 
					_lastModifiedDate = value.IntegerVal;
					return;
				case 5: 
					_lastModifyingUser = (IfcPersonAndOrganization)(value.EntityVal);
					return;
				case 6: 
					_lastModifyingApplication = (IfcApplication)(value.EntityVal);
					return;
				case 7: 
					_creationDate = value.IntegerVal;
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