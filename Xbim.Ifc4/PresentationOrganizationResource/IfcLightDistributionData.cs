// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 02:29:22
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

namespace Xbim.Ifc4.PresentationOrganizationResource
{
	[EntityName("IFCLIGHTDISTRIBUTIONDATA", 334)]
	public  partial class @IfcLightDistributionData : INotifyPropertyChanged, IInstantiableEntity
	{
		#region Implementation of IPersistEntity
		public int EntityLabel {get; internal set;}
		public IModel Model { get; internal set; }
		public bool Activated { get; internal set; }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcLightDistributionData(IModel model) 		{ 
			Model = model; 
			_secondaryPlaneAngle = new ItemSet<IfcPlaneAngleMeasure>( model );
			_luminousIntensity = new ItemSet<IfcLuminousIntensityDistributionMeasure>( model );
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

			Action undo = () => setter(oldValue);
			txn.AddReversibleAction(undo);
			setter(newValue);
			NotifyPropertyChanged(notifyPropertyName);
		}

		#endregion

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"MainPlaneAngle",
			"SecondaryPlaneAngle",
			"LuminousIntensity",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @MainPlaneAngle;
				case 1: 
					return @SecondaryPlaneAngle;
				case 2: 
					return @LuminousIntensity;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "MainPlaneAngle":  
					return @MainPlaneAngle;
				case "SecondaryPlaneAngle":  
					return @SecondaryPlaneAngle;
				case "LuminousIntensity":  
					return @LuminousIntensity;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 if (value != null) @MainPlaneAngle = (IfcPlaneAngleMeasure)value;
					 break;
				case 1:
					 @SecondaryPlaneAngle = (ItemSet<IfcPlaneAngleMeasure>)value;
					 break;
				case 2:
					 @LuminousIntensity = (ItemSet<IfcLuminousIntensityDistributionMeasure>)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "MainPlaneAngle":
					 if (value != null) @MainPlaneAngle = (IfcPlaneAngleMeasure)value;
					 break;
				case "SecondaryPlaneAngle":
					 @SecondaryPlaneAngle = (ItemSet<IfcPlaneAngleMeasure>)value;
					 break;
				case "LuminousIntensity":
					 @LuminousIntensity = (ItemSet<IfcLuminousIntensityDistributionMeasure>)value;
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