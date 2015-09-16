// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		16.09.2015 10:12:17
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.ActorResource;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.ApprovalResource
{
	[EntityName("IFCAPPROVALACTORRELATIONSHIP", 442)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcApprovalActorRelationship : INotifyPropertyChanged, IInstantiableEntity
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
		internal IfcApprovalActorRelationship(IModel model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcActorSelect _actor;
		private IfcApproval _approval;
		private IfcActorRole _role;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(0, EntityAttributeState.Mandatory)]
		public IfcActorSelect @Actor 
		{ 
			get 
			{
				if(Activated) return _actor;
				
				Model.Activate(this, true);
				Activated = true;
				return _actor;
			} 
			set
			{
				SetValue( v =>  _actor = v, _actor, value,  "Actor");
			} 
		}
	
		[EntityAttribute(1, EntityAttributeState.Mandatory)]
		public IfcApproval @Approval 
		{ 
			get 
			{
				if(Activated) return _approval;
				
				Model.Activate(this, true);
				Activated = true;
				return _approval;
			} 
			set
			{
				SetValue( v =>  _approval = v, _approval, value,  "Approval");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Mandatory)]
		public IfcActorRole @Role 
		{ 
			get 
			{
				if(Activated) return _role;
				
				Model.Activate(this, true);
				Activated = true;
				return _role;
			} 
			set
			{
				SetValue( v =>  _role = v, _role, value,  "Role");
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
			"Actor",
			"Approval",
			"Role",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return AttributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @Actor;
				case 1: 
					return @Approval;
				case 2: 
					return @Role;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "Actor":  
					return @Actor;
				case "Approval":  
					return @Approval;
				case "Role":  
					return @Role;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 @Actor = (IfcActorSelect)value;
					 break;
				case 1:
					 @Approval = (IfcApproval)value;
					 break;
				case 2:
					 @Role = (IfcActorRole)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "Actor":
					 @Actor = (IfcActorSelect)value;
					 break;
				case "Approval":
					 @Approval = (IfcApproval)value;
					 break;
				case "Role":
					 @Role = (IfcActorRole)value;
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
					_actor = (IfcActorSelect)(value.EntityVal);
					return;
				case 1: 
					_approval = (IfcApproval)(value.EntityVal);
					return;
				case 2: 
					_role = (IfcActorRole)(value.EntityVal);
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