// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.CostResource;
using Xbim.Ifc2x3.FacilitiesMgmtDomain;
using Xbim.Ifc2x3.ConstraintResource;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.MeasureResource
{
	[ExpressType("IFCMEASUREWITHUNIT", 7)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcMeasureWithUnit : IPersistEntity, INotifyPropertyChanged, IfcAppliedValueSelect, IfcConditionCriterionSelect, IfcMetricValueSelect, IInstantiableEntity
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
		internal IfcMeasureWithUnit(IModel model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcValue _valueComponent;
		private IfcUnit _unitComponent;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcValue @ValueComponent 
		{ 
			get 
			{
				if(Activated) return _valueComponent;
				
				Model.Activate(this, true);
				Activated = true;
				return _valueComponent;
			} 
			set
			{
				SetValue( v =>  _valueComponent = v, _valueComponent, value,  "ValueComponent");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcUnit @UnitComponent 
		{ 
			get 
			{
				if(Activated) return _unitComponent;
				
				Model.Activate(this, true);
				Activated = true;
				return _unitComponent;
			} 
			set
			{
				SetValue( v =>  _unitComponent = v, _unitComponent, value,  "UnitComponent");
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
			setter(newValue);

			//do action and THAN add to transaction so that it gets the object in new state
			txn.AddReversibleAction(doAction, undoAction, this, ChangeType.Modified);
			NotifyPropertyChanged(notifyPropertyName);
		}

		#endregion

		#region IPersist implementation
		public virtual void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
					_valueComponent = (IfcValue)(value.EntityVal);
					return;
				case 1: 
					_unitComponent = (IfcUnit)(value.EntityVal);
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