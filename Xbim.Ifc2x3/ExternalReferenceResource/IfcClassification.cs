// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 03:43:55
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.DateTimeResource;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.ExternalReferenceResource
{
	[EntityName("IFCCLASSIFICATION", 412)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcClassification : IPersistEntity, INotifyPropertyChanged, IInstantiableEntity
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
		internal IfcClassification(IModel model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcLabel _source;
		private IfcLabel _edition;
		private IfcCalendarDate _editionDate;
		private IfcLabel _name;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttributee(0, EntityAttributeState.Mandatory)]
		public IfcLabel @Source 
		{ 
			get 
			{
				if(Activated) return _source;
				
				Model.Activate(this, true);
				Activated = true;
				return _source;
			} 
			set
			{
				SetValue( v =>  _source = v, _source, value,  "Source");
			} 
		}
	
		[EntityAttributee(1, EntityAttributeState.Mandatory)]
		public IfcLabel @Edition 
		{ 
			get 
			{
				if(Activated) return _edition;
				
				Model.Activate(this, true);
				Activated = true;
				return _edition;
			} 
			set
			{
				SetValue( v =>  _edition = v, _edition, value,  "Edition");
			} 
		}
	
		[EntityAttributee(2, EntityAttributeState.Optional)]
		public IfcCalendarDate @EditionDate 
		{ 
			get 
			{
				if(Activated) return _editionDate;
				
				Model.Activate(this, true);
				Activated = true;
				return _editionDate;
			} 
			set
			{
				SetValue( v =>  _editionDate = v, _editionDate, value,  "EditionDate");
			} 
		}
	
		[EntityAttributee(3, EntityAttributeState.Mandatory)]
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
	
		#endregion

		#region Inverse attributes
		public IEnumerable<IfcClassificationItem> @Contains 
		{ 
			get 
			{
				return Model.Instances.Where<IfcClassificationItem>(e => e.ItemOf == this);
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
					_source = value.StringVal;
					return;
				case 1: 
					_edition = value.StringVal;
					return;
				case 2: 
					_editionDate = (IfcCalendarDate)(value.EntityVal);
					return;
				case 3: 
					_name = value.StringVal;
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