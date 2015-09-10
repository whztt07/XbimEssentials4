// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		09/09/2015 04:20:42
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using System.ComponentModel;
using System;
using Xbim.Common;

namespace Xbim.Ifc4.PresentationOrganizationResource
{
	[EntityName("IFCLIGHTINTENSITYDISTRIBUTION", 337)]
	public  partial class @IfcLightIntensityDistribution : INotifyPropertyChanged, IfcLightDistributionDataSourceSelect, IInstantiableEntity
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
		internal IfcLightIntensityDistribution(IModel model) 		{ 
			Model = model; 
			_distributionData = new ItemSet<IfcLightDistributionData>( model );
		}

		#region Explicit attribute fields
		private IfcLightDistributionCurveEnum _lightDistributionCurve;
		private ItemSet<IfcLightDistributionData> _distributionData;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(0, EntityAttributeState.Mandatory)]
		public IfcLightDistributionCurveEnum @LightDistributionCurve 
		{ 
			get 
			{
				if(Activated) return _lightDistributionCurve;
				
				Model.Activate(this, true);
				Activated = true;
				return _lightDistributionCurve;
			} 
			set
			{
				SetValue( v =>  _lightDistributionCurve = v, _lightDistributionCurve, value,  "LightDistributionCurve");
			} 
		}
	
		[EntityAttribute(1, EntityAttributeState.Mandatory)]
		public ItemSet<IfcLightDistributionData> @DistributionData 
		{ 
			get 
			{
				if(Activated) return _distributionData;
				
				Model.Activate(this, true);
				Activated = true;
				return _distributionData;
			} 
			set
			{
				SetValue( v =>  _distributionData = v, _distributionData, value,  "DistributionData");
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
			"LightDistributionCurve",
			"DistributionData",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @LightDistributionCurve;
				case 1: 
					return @DistributionData;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "LightDistributionCurve":  
					return @LightDistributionCurve;
				case "DistributionData":  
					return @DistributionData;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 if (value != null) @LightDistributionCurve = (IfcLightDistributionCurveEnum)value;
					 break;
				case 1:
					 @DistributionData.Add((IfcLightDistributionData)value);
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "LightDistributionCurve":
					 if (value != null) @LightDistributionCurve = (IfcLightDistributionCurveEnum)value;
					 break;
				case "DistributionData":
					 @DistributionData.Add((IfcLightDistributionData)value);
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

		public  string WhereRule() 
		{
			return "";
		}
	}
}