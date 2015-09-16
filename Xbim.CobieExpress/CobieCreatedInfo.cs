// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		16.09.2015 04:23:02
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using System.ComponentModel;
using System;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.CobieExpress
{
	[EntityName("CREATEDINFO", 5)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @CobieCreatedInfo : INotifyPropertyChanged, IInstantiableEntity
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
		internal CobieCreatedInfo(IModel model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private CobieContact _createdBy;
		private DateTimeValue _createdOn;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(0, EntityAttributeState.Mandatory)]
		public CobieContact @CreatedBy 
		{ 
			get 
			{
				if(Activated) return _createdBy;
				
				Model.Activate(this, true);
				Activated = true;
				return _createdBy;
			} 
			set
			{
				SetValue( v =>  _createdBy = v, _createdBy, value,  "CreatedBy");
			} 
		}
	
		[EntityAttribute(1, EntityAttributeState.Mandatory)]
		public DateTimeValue @CreatedOn 
		{ 
			get 
			{
				if(Activated) return _createdOn;
				
				Model.Activate(this, true);
				Activated = true;
				return _createdOn;
			} 
			set
			{
				SetValue( v =>  _createdOn = v, _createdOn, value,  "CreatedOn");
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

		#region Index access
		private static readonly List<string> AttributeNames = new List<string>
		{
			"CreatedBy",
			"CreatedOn",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return AttributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @CreatedBy;
				case 1: 
					return @CreatedOn;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "CreatedBy":  
					return @CreatedBy;
				case "CreatedOn":  
					return @CreatedOn;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 @CreatedBy = (CobieContact)value;
					 break;
				case 1:
					 if (value != null) @CreatedOn = (DateTimeValue)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "CreatedBy":
					 @CreatedBy = (CobieContact)value;
					 break;
				case "CreatedOn":
					 if (value != null) @CreatedOn = (DateTimeValue)value;
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
					_createdBy = (CobieContact)(value.EntityVal);
					return;
				case 1: 
					_createdOn = value.StringVal;
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