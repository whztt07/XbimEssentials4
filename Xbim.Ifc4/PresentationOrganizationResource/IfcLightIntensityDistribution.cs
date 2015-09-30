// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
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

namespace Xbim.Ifc4.PresentationOrganizationResource
{
	[ExpressType("IFCLIGHTINTENSITYDISTRIBUTION", 728)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcLightIntensityDistribution : IPersistEntity, INotifyPropertyChanged, IfcLightDistributionDataSourceSelect, IInstantiableEntity
	{
		#region Implementation of IPersistEntity
		public int EntityLabel {get; internal set;}
		
		public IModel Model { get; internal set; }

		/// <summary>
        /// This property is deprecated and likely to be removed. Use just 'Model' instead.
        /// </summary>
		[Obsolete("This property is deprecated and likely to be removed. Use just 'Model' instead.")]
        public IModel ModelOf { get { return Model; } }
		
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
		internal IfcLightIntensityDistribution(IModel model) 		{ 
			Model = model; 
			_distributionData = new ItemSet<IfcLightDistributionData>( this );
		}

		#region Explicit attribute fields
		private IfcLightDistributionCurveEnum _lightDistributionCurve;
		private ItemSet<IfcLightDistributionData> _distributionData;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
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
	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.Class, 1, -1)]
		public ItemSet<IfcLightDistributionData> @DistributionData 
		{ 
			get 
			{
				if(Activated) return _distributionData;
				
				Model.Activate(this, true);
				Activated = true;
				return _distributionData;
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
                    _lightDistributionCurve = (IfcLightDistributionCurveEnum) System.Enum.Parse(typeof (IfcLightDistributionCurveEnum), value.EnumVal, true);
					return;
				case 1: 
					if (_distributionData == null) _distributionData = new ItemSet<IfcLightDistributionData>( this );
					_distributionData.InternalAdd((IfcLightDistributionData)value.EntityVal);
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