// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		24.09.2015 10:03:45
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
	[IndexedClass]
	[ExpressType("WARRANTY", 23)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @CobieWarranty : IPersistEntity, INotifyPropertyChanged, IInstantiableEntity
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
		internal CobieWarranty(IModel model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private string _description;
		private CobieContact _guarantorParts;
		private double _durationParts;
		private CobieContact _guarantorLabor;
		private double _durationLabor;
		private CobiePickValue _durationUnit;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public string @Description 
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
	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public CobieContact @GuarantorParts 
		{ 
			get 
			{
				if(Activated) return _guarantorParts;
				
				Model.Activate(this, true);
				Activated = true;
				return _guarantorParts;
			} 
			set
			{
				SetValue( v =>  _guarantorParts = v, _guarantorParts, value,  "GuarantorParts");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public double @DurationParts 
		{ 
			get 
			{
				if(Activated) return _durationParts;
				
				Model.Activate(this, true);
				Activated = true;
				return _durationParts;
			} 
			set
			{
				SetValue( v =>  _durationParts = v, _durationParts, value,  "DurationParts");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public CobieContact @GuarantorLabor 
		{ 
			get 
			{
				if(Activated) return _guarantorLabor;
				
				Model.Activate(this, true);
				Activated = true;
				return _guarantorLabor;
			} 
			set
			{
				SetValue( v =>  _guarantorLabor = v, _guarantorLabor, value,  "GuarantorLabor");
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public double @DurationLabor 
		{ 
			get 
			{
				if(Activated) return _durationLabor;
				
				Model.Activate(this, true);
				Activated = true;
				return _durationLabor;
			} 
			set
			{
				SetValue( v =>  _durationLabor = v, _durationLabor, value,  "DurationLabor");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public CobiePickValue @DurationUnit 
		{ 
			get 
			{
				if(Activated) return _durationUnit;
				
				Model.Activate(this, true);
				Activated = true;
				return _durationUnit;
			} 
			set
			{
				SetValue( v =>  _durationUnit = v, _durationUnit, value,  "DurationUnit");
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
					_description = value.StringVal;
					return;
				case 1: 
					_guarantorParts = (CobieContact)(value.EntityVal);
					return;
				case 2: 
					_durationParts = value.RealVal;
					return;
				case 3: 
					_guarantorLabor = (CobieContact)(value.EntityVal);
					return;
				case 4: 
					_durationLabor = value.RealVal;
					return;
				case 5: 
					_durationUnit = (CobiePickValue)(value.EntityVal);
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