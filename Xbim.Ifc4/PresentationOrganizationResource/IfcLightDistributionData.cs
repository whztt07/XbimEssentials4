// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 03:44:05
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.PresentationOrganizationResource
{
	[EntityName("IFCLIGHTDISTRIBUTIONDATA", 334)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcLightDistributionData : IPersistEntity, INotifyPropertyChanged, IInstantiableEntity
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
		internal IfcLightDistributionData(IModel model) 		{ 
			Model = model; 
			_secondaryPlaneAngle = new ItemSet<IfcPlaneAngleMeasure>( this );
			_luminousIntensity = new ItemSet<IfcLuminousIntensityDistributionMeasure>( this );
		}

		#region Explicit attribute fields
		private IfcPlaneAngleMeasure _mainPlaneAngle;
		private ItemSet<IfcPlaneAngleMeasure> _secondaryPlaneAngle;
		private ItemSet<IfcLuminousIntensityDistributionMeasure> _luminousIntensity;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(0, EntityAttributeState.Mandatory)]
		public IfcPlaneAngleMeasure @MainPlaneAngle 
		{ 
			get 
			{
				if(Activated) return _mainPlaneAngle;
				
				Model.Activate(this, true);
				Activated = true;
				return _mainPlaneAngle;
			} 
			set
			{
				SetValue( v =>  _mainPlaneAngle = v, _mainPlaneAngle, value,  "MainPlaneAngle");
			} 
		}
	
		[EntityAttribute(1, EntityAttributeState.Mandatory)]
		public ItemSet<IfcPlaneAngleMeasure> @SecondaryPlaneAngle 
		{ 
			get 
			{
				if(Activated) return _secondaryPlaneAngle;
				
				Model.Activate(this, true);
				Activated = true;
				return _secondaryPlaneAngle;
			} 
			set
			{
				SetValue( v =>  _secondaryPlaneAngle = v, _secondaryPlaneAngle, value,  "SecondaryPlaneAngle");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Mandatory)]
		public ItemSet<IfcLuminousIntensityDistributionMeasure> @LuminousIntensity 
		{ 
			get 
			{
				if(Activated) return _luminousIntensity;
				
				Model.Activate(this, true);
				Activated = true;
				return _luminousIntensity;
			} 
			set
			{
				SetValue( v =>  _luminousIntensity = v, _luminousIntensity, value,  "LuminousIntensity");
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

		#region IPersist implementation
		public virtual void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
					_mainPlaneAngle = value.RealVal;
					return;
				case 1: 
					if (_secondaryPlaneAngle == null) _secondaryPlaneAngle = new ItemSet<IfcPlaneAngleMeasure>( this );
					_secondaryPlaneAngle.InternalAdd(value.RealVal);
					return;
				case 2: 
					if (_luminousIntensity == null) _luminousIntensity = new ItemSet<IfcLuminousIntensityDistributionMeasure>( this );
					_luminousIntensity.InternalAdd(value.RealVal);
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