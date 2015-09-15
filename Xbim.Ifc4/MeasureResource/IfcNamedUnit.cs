// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		15.09.2015 07:03:39
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System.ComponentModel;
using System;
using Xbim.Common;

namespace Xbim.Ifc4.MeasureResource
{
	[EntityName("IFCNAMEDUNIT", 382)]
	public abstract partial class @IfcNamedUnit : IPersistEntity, INotifyPropertyChanged, IfcUnit
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
		internal IfcNamedUnit(IModel model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcDimensionalExponents _dimensions;
		private IfcUnitEnum _unitType;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(0, EntityAttributeState.Mandatory)]
		public IfcDimensionalExponents @Dimensions 
		{ 
			get 
			{
				if(Activated) return _dimensions;
				
				Model.Activate(this, true);
				Activated = true;
				return _dimensions;
			} 
			set
			{
				SetValue( v =>  _dimensions = v, _dimensions, value,  "Dimensions");
			} 
		}
	
		[EntityAttribute(1, EntityAttributeState.Mandatory)]
		public IfcUnitEnum @UnitType 
		{ 
			get 
			{
				if(Activated) return _unitType;
				
				Model.Activate(this, true);
				Activated = true;
				return _unitType;
			} 
			set
			{
				SetValue( v =>  _unitType = v, _unitType, value,  "UnitType");
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

		#region Where rules
		/*WR1:	WR1 : IfcCorrectDimensions (SELF.UnitType, SELF.Dimensions);*/
		#endregion

		#region IPersist implementation
		public virtual void Parse(int propIndex, IPropertyValue value)
		{
            throw new System.NotImplementedException();
		}
		
		public virtual string WhereRule() 
		{
            throw new System.NotImplementedException();
		}
		#endregion

		
	}
}