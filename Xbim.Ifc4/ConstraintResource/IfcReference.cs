// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		22.09.2015 04:44:14
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.CostResource;
using Xbim.Ifc4.MeasureResource;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.ConstraintResource
{
	[IndexedClass]
	[ExpressType("IFCREFERENCE", 891)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcReference : IPersistEntity, INotifyPropertyChanged, IfcAppliedValueSelect, IfcMetricValueSelect, IInstantiableEntity
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
		internal IfcReference(IModel model) 		{ 
			Model = model; 
			_listPositions = new OptionalItemSet<long>( this );
		}

		#region Explicit attribute fields
		private IfcIdentifier? _typeIdentifier;
		private IfcIdentifier? _attributeIdentifier;
		private IfcLabel? _instanceName;
		private OptionalItemSet<long> _listPositions;
		private IfcReference _innerReference;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcIdentifier? @TypeIdentifier 
		{ 
			get 
			{
				if(Activated) return _typeIdentifier;
				
				Model.Activate(this, true);
				Activated = true;
				return _typeIdentifier;
			} 
			set
			{
				SetValue( v =>  _typeIdentifier = v, _typeIdentifier, value,  "TypeIdentifier");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcIdentifier? @AttributeIdentifier 
		{ 
			get 
			{
				if(Activated) return _attributeIdentifier;
				
				Model.Activate(this, true);
				Activated = true;
				return _attributeIdentifier;
			} 
			set
			{
				SetValue( v =>  _attributeIdentifier = v, _attributeIdentifier, value,  "AttributeIdentifier");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel? @InstanceName 
		{ 
			get 
			{
				if(Activated) return _instanceName;
				
				Model.Activate(this, true);
				Activated = true;
				return _instanceName;
			} 
			set
			{
				SetValue( v =>  _instanceName = v, _instanceName, value,  "InstanceName");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.None, 1, -1)]
		public OptionalItemSet<long> @ListPositions 
		{ 
			get 
			{
				if(Activated) return _listPositions;
				
				Model.Activate(this, true);
				Activated = true;
				return _listPositions;
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcReference @InnerReference 
		{ 
			get 
			{
				if(Activated) return _innerReference;
				
				Model.Activate(this, true);
				Activated = true;
				return _innerReference;
			} 
			set
			{
				SetValue( v =>  _innerReference = v, _innerReference, value,  "InnerReference");
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
					_typeIdentifier = value.StringVal;
					return;
				case 1: 
					_attributeIdentifier = value.StringVal;
					return;
				case 2: 
					_instanceName = value.StringVal;
					return;
				case 3: 
					if (_listPositions == null) _listPositions = new OptionalItemSet<long>( this );
					_listPositions.InternalAdd(value.IntegerVal);
					return;
				case 4: 
					_innerReference = (IfcReference)(value.EntityVal);
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