// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		09/09/2015 04:20:33
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

namespace Xbim.Ifc2x3.UtilityResource
{
	[EntityName("IFCAPPLICATION", 627)]
	public  partial class @IfcApplication : INotifyPropertyChanged, IInstantiableEntity
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
		[EntityAttribute(0, EntityAttributeState.Mandatory)]
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
	
		[EntityAttribute(1, EntityAttributeState.Mandatory)]
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
	
		[EntityAttribute(2, EntityAttributeState.Mandatory)]
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
	
		[EntityAttribute(3, EntityAttributeState.Mandatory)]
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
			"ApplicationDeveloper",
			"Version",
			"ApplicationFullName",
			"ApplicationIdentifier",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @ApplicationDeveloper;
				case 1: 
					return @Version;
				case 2: 
					return @ApplicationFullName;
				case 3: 
					return @ApplicationIdentifier;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "ApplicationDeveloper":  
					return @ApplicationDeveloper;
				case "Version":  
					return @Version;
				case "ApplicationFullName":  
					return @ApplicationFullName;
				case "ApplicationIdentifier":  
					return @ApplicationIdentifier;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 @ApplicationDeveloper = (IfcOrganization)value;
					 break;
				case 1:
					 if (value != null) @Version = (IfcLabel)value;
					 break;
				case 2:
					 if (value != null) @ApplicationFullName = (IfcLabel)value;
					 break;
				case 3:
					 if (value != null) @ApplicationIdentifier = (IfcIdentifier)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "ApplicationDeveloper":
					 @ApplicationDeveloper = (IfcOrganization)value;
					 break;
				case "Version":
					 if (value != null) @Version = (IfcLabel)value;
					 break;
				case "ApplicationFullName":
					 if (value != null) @ApplicationFullName = (IfcLabel)value;
					 break;
				case "ApplicationIdentifier":
					 if (value != null) @ApplicationIdentifier = (IfcIdentifier)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
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