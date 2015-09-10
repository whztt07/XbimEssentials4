// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		09/09/2015 04:20:42
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.ActorResource;
using Xbim.Ifc4.DateTimeResource;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using Xbim.Common;

namespace Xbim.Ifc4.UtilityResource
{
	[EntityName("IFCOWNERHISTORY", 399)]
	public  partial class @IfcOwnerHistory : INotifyPropertyChanged, IInstantiableEntity
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
		internal IfcOwnerHistory(IModel model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcPersonAndOrganization _owningUser;
		private IfcApplication _owningApplication;
		private IfcStateEnum? _state;
		private IfcChangeActionEnum? _changeAction;
		private IfcTimeStamp? _lastModifiedDate;
		private IfcPersonAndOrganization _lastModifyingUser;
		private IfcApplication _lastModifyingApplication;
		private IfcTimeStamp _creationDate;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(0, EntityAttributeState.Mandatory)]
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
	
		[EntityAttribute(1, EntityAttributeState.Mandatory)]
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
	
		[EntityAttribute(2, EntityAttributeState.Optional)]
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
	
		[EntityAttribute(3, EntityAttributeState.Optional)]
		public IfcChangeActionEnum? @ChangeAction 
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
	
		[EntityAttribute(4, EntityAttributeState.Optional)]
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
	
		[EntityAttribute(5, EntityAttributeState.Optional)]
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
	
		[EntityAttribute(6, EntityAttributeState.Optional)]
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
	
		[EntityAttribute(7, EntityAttributeState.Mandatory)]
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
		private readonly List<string> _attributeNames = new List<string>
		{
			"OwningUser",
			"OwningApplication",
			"State",
			"ChangeAction",
			"LastModifiedDate",
			"LastModifyingUser",
			"LastModifyingApplication",
			"CreationDate",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @OwningUser;
				case 1: 
					return @OwningApplication;
				case 2: 
					return @State;
				case 3: 
					return @ChangeAction;
				case 4: 
					return @LastModifiedDate;
				case 5: 
					return @LastModifyingUser;
				case 6: 
					return @LastModifyingApplication;
				case 7: 
					return @CreationDate;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "OwningUser":  
					return @OwningUser;
				case "OwningApplication":  
					return @OwningApplication;
				case "State":  
					return @State;
				case "ChangeAction":  
					return @ChangeAction;
				case "LastModifiedDate":  
					return @LastModifiedDate;
				case "LastModifyingUser":  
					return @LastModifyingUser;
				case "LastModifyingApplication":  
					return @LastModifyingApplication;
				case "CreationDate":  
					return @CreationDate;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 @OwningUser = (IfcPersonAndOrganization)value;
					 break;
				case 1:
					 @OwningApplication = (IfcApplication)value;
					 break;
				case 2:
					 @State = (IfcStateEnum?)value;
					 break;
				case 3:
					 @ChangeAction = (IfcChangeActionEnum?)value;
					 break;
				case 4:
					 @LastModifiedDate = (IfcTimeStamp?)value;
					 break;
				case 5:
					 @LastModifyingUser = (IfcPersonAndOrganization)value;
					 break;
				case 6:
					 @LastModifyingApplication = (IfcApplication)value;
					 break;
				case 7:
					 if (value != null) @CreationDate = (IfcTimeStamp)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "OwningUser":
					 @OwningUser = (IfcPersonAndOrganization)value;
					 break;
				case "OwningApplication":
					 @OwningApplication = (IfcApplication)value;
					 break;
				case "State":
					 @State = (IfcStateEnum?)value;
					 break;
				case "ChangeAction":
					 @ChangeAction = (IfcChangeActionEnum?)value;
					 break;
				case "LastModifiedDate":
					 @LastModifiedDate = (IfcTimeStamp?)value;
					 break;
				case "LastModifyingUser":
					 @LastModifyingUser = (IfcPersonAndOrganization)value;
					 break;
				case "LastModifyingApplication":
					 @LastModifyingApplication = (IfcApplication)value;
					 break;
				case "CreationDate":
					 if (value != null) @CreationDate = (IfcTimeStamp)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion

		#region Where rules
		/*CorrectChangeAction:                            (NOT(EXISTS(LastModifiedDate)) AND EXISTS(ChangeAction) AND ((ChangeAction = IfcChangeActionEnum.NOTDEFINED) OR (ChangeAction = IfcChangeActionEnum.NOCHANGE)));*/
		#endregion

		#region IPersist implementation
		void IPersist.Set(int propIndex, IPropertyValue value)
		{
            throw new System.NotImplementedException();
		}
		#endregion

		public  string WhereRule() 
		{
			return "";
		}
	}
}