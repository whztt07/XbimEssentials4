// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 02:29:23
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

namespace Xbim.Ifc4.ConstraintResource
{
	[EntityName("IFCREFERENCE", 500)]
	public  partial class @IfcReference : INotifyPropertyChanged, IfcAppliedValueSelect, IfcMetricValueSelect, IInstantiableEntity
	{
		#region Implementation of IPersistEntity
		public int EntityLabel {get; internal set;}
		public IModel Model { get; internal set; }
		public bool Activated { get; internal set; }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcReference(IModel model) 		{ 
			Model = model; 
			_listPositions = new ItemSet<int>( model );
		}

		#region Explicit attribute fields
		private IfcIdentifier? _typeIdentifier;
		private IfcIdentifier? _attributeIdentifier;
		private IfcLabel? _instanceName;
		private ItemSet<int> _listPositions;
		private IfcReference _innerReference;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(0, EntityAttributeState.Optional)]
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
	
		[EntityAttribute(1, EntityAttributeState.Optional)]
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
	
		[EntityAttribute(2, EntityAttributeState.Optional)]
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
	
		[EntityAttribute(3, EntityAttributeState.Optional)]
		public ItemSet<int> @ListPositions 
		{ 
			get 
			{
				if(Activated) return _listPositions;
				
				Model.Activate(this, true);
				Activated = true;
				return _listPositions;
			} 
			set
			{
				SetValue( v =>  _listPositions = v, _listPositions, value,  "ListPositions");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Optional)]
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
			"TypeIdentifier",
			"AttributeIdentifier",
			"InstanceName",
			"ListPositions",
			"InnerReference",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @TypeIdentifier;
				case 1: 
					return @AttributeIdentifier;
				case 2: 
					return @InstanceName;
				case 3: 
					return @ListPositions;
				case 4: 
					return @InnerReference;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "TypeIdentifier":  
					return @TypeIdentifier;
				case "AttributeIdentifier":  
					return @AttributeIdentifier;
				case "InstanceName":  
					return @InstanceName;
				case "ListPositions":  
					return @ListPositions;
				case "InnerReference":  
					return @InnerReference;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 @TypeIdentifier = (IfcIdentifier?)value;
					 break;
				case 1:
					 @AttributeIdentifier = (IfcIdentifier?)value;
					 break;
				case 2:
					 @InstanceName = (IfcLabel?)value;
					 break;
				case 3:
					 @ListPositions.Add((int)value);
					 break;
				case 4:
					 @InnerReference = (IfcReference)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "TypeIdentifier":
					 @TypeIdentifier = (IfcIdentifier?)value;
					 break;
				case "AttributeIdentifier":
					 @AttributeIdentifier = (IfcIdentifier?)value;
					 break;
				case "InstanceName":
					 @InstanceName = (IfcLabel?)value;
					 break;
				case "ListPositions":
					 @ListPositions.Add((int)value);
					 break;
				case "InnerReference":
					 @InnerReference = (IfcReference)value;
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

	}
}