// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System.ComponentModel;
using System;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.CobieExpress
{
	[IndexedClass]
	[ExpressType("REFERENCEDOBJECT", 13)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @CobieReferencedObject : IPersistEntity, INotifyPropertyChanged
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
		internal CobieReferencedObject(IModel model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private string _externalId;
		private CobieCreatedInfo _created;
		private CobieExternalSystem _externalSystem;
		private string _externalObject;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public string @ExternalId 
		{ 
			get 
			{
				if(Activated) return _externalId;
				
				Model.Activate(this, true);
				Activated = true;
				return _externalId;
			} 
			set
			{
				SetValue( v =>  _externalId = v, _externalId, value,  "ExternalId");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public CobieCreatedInfo @Created 
		{ 
			get 
			{
				if(Activated) return _created;
				
				Model.Activate(this, true);
				Activated = true;
				return _created;
			} 
			set
			{
				SetValue( v =>  _created = v, _created, value,  "Created");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public CobieExternalSystem @ExternalSystem 
		{ 
			get 
			{
				if(Activated) return _externalSystem;
				
				Model.Activate(this, true);
				Activated = true;
				return _externalSystem;
			} 
			set
			{
				SetValue( v =>  _externalSystem = v, _externalSystem, value,  "ExternalSystem");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public string @ExternalObject 
		{ 
			get 
			{
				if(Activated) return _externalObject;
				
				Model.Activate(this, true);
				Activated = true;
				return _externalObject;
			} 
			set
			{
				SetValue( v =>  _externalObject = v, _externalObject, value,  "ExternalObject");
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
					_externalId = value.StringVal;
					return;
				case 1: 
					_created = (CobieCreatedInfo)(value.EntityVal);
					return;
				case 2: 
					_externalSystem = (CobieExternalSystem)(value.EntityVal);
					return;
				case 3: 
					_externalObject = value.StringVal;
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