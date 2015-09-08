// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 09:16:41
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using System.ComponentModel;
using System;
using Xbim.Common;

namespace Xbim.Ifc4.MeasureResource
{
	[EntityName("IFCDERIVEDUNIT")]
	public  partial class @IfcDerivedUnit : INotifyPropertyChanged, IfcUnit, IInstantiableEntity
	{
		#region Implementation of IPersistEntity
		public int EntityLabel {get; set;}
		public IModel Model { get; internal set; }

		protected bool IsActivated = false;

		public bool Activated { get { return IsActivated; } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcDerivedUnit(IModel model) 		{ 
			Model = model; 
			_elements = new ItemSet<IfcDerivedUnitElement>( model );
		}

		#region Explicit attribute fields
		private ItemSet<IfcDerivedUnitElement> _elements;
		private IfcDerivedUnitEnum _unitType;
		private IfcLabel? _userDefinedType;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(0, EntityAttributeState.Mandatory)]
		public ItemSet<IfcDerivedUnitElement> @Elements 
		{ 
			get 
			{
				if(IsActivated) return _elements;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _elements;
			} 
			set
			{
				SetValue( v =>  _elements = v, _elements, value,  "Elements");
			} 
		}
	
		[EntityAttribute(1, EntityAttributeState.Mandatory)]
		public IfcDerivedUnitEnum @UnitType 
		{ 
			get 
			{
				if(IsActivated) return _unitType;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _unitType;
			} 
			set
			{
				SetValue( v =>  _unitType = v, _unitType, value,  "UnitType");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Optional)]
		public IfcLabel? @UserDefinedType 
		{ 
			get 
			{
				if(IsActivated) return _userDefinedType;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _userDefinedType;
			} 
			set
			{
				SetValue( v =>  _userDefinedType = v, _userDefinedType, value,  "UserDefinedType");
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
			"Elements",
			"UnitType",
			"UserDefinedType",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @Elements;
				case 1: 
					return @UnitType;
				case 2: 
					return @UserDefinedType;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "Elements":  
					return @Elements;
				case "UnitType":  
					return @UnitType;
				case "UserDefinedType":  
					return @UserDefinedType;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 @Elements.Add((IfcDerivedUnitElement)value);
					 break;
				case 1:
					 if (value != null) @UnitType = (IfcDerivedUnitEnum)value;
					 break;
				case 2:
					 @UserDefinedType = (IfcLabel?)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "Elements":
					 @Elements.Add((IfcDerivedUnitElement)value);
					 break;
				case "UnitType":
					 if (value != null) @UnitType = (IfcDerivedUnitEnum)value;
					 break;
				case "UserDefinedType":
					 @UserDefinedType = (IfcLabel?)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion

		#region Where rules
		/*WR1:	WR1 : (SIZEOF (Elements) > 1) OR ((SIZEOF (Elements) = 1) AND (Elements[1].Exponent <> 1 ));*/
		/*WR2:             (EXISTS(SELF.UserDefinedType)));*/
		#endregion

		#region IPersist implementation
		public void Set(int propIndex, IPropertyValue value)
		{
            throw new System.NotImplementedException();
		}
		#endregion

	}
}