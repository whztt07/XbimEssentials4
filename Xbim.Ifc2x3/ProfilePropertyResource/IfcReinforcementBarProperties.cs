// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 09:16:38
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using Xbim.Common;

namespace Xbim.Ifc2x3.ProfilePropertyResource
{
	[EntityName("IFCREINFORCEMENTBARPROPERTIES")]
	public  partial class @IfcReinforcementBarProperties : INotifyPropertyChanged, IInstantiableEntity
	{
		#region Implementation of IPersistEntity
		public int EntityLabel {get; set;}
		public IModel Model { get; internal set; }

		protected bool IsActivated = false;

		public bool Activated { get { return IsActivated; } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcReinforcementBarProperties(IModel model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcAreaMeasure _totalCrossSectionArea;
		private IfcLabel _steelGrade;
		private IfcReinforcingBarSurfaceEnum _barSurface;
		private IfcLengthMeasure? _effectiveDepth;
		private IfcPositiveLengthMeasure? _nominalBarDiameter;
		private IfcCountMeasure? _barCount;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(0, EntityAttributeState.Mandatory)]
		public IfcAreaMeasure @TotalCrossSectionArea 
		{ 
			get 
			{
				if(IsActivated) return _totalCrossSectionArea;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _totalCrossSectionArea;
			} 
			set
			{
				SetValue( v =>  _totalCrossSectionArea = v, _totalCrossSectionArea, value,  "TotalCrossSectionArea");
			} 
		}
	
		[EntityAttribute(1, EntityAttributeState.Mandatory)]
		public IfcLabel @SteelGrade 
		{ 
			get 
			{
				if(IsActivated) return _steelGrade;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _steelGrade;
			} 
			set
			{
				SetValue( v =>  _steelGrade = v, _steelGrade, value,  "SteelGrade");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Optional)]
		public IfcReinforcingBarSurfaceEnum @BarSurface 
		{ 
			get 
			{
				if(IsActivated) return _barSurface;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _barSurface;
			} 
			set
			{
				SetValue( v =>  _barSurface = v, _barSurface, value,  "BarSurface");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Optional)]
		public IfcLengthMeasure? @EffectiveDepth 
		{ 
			get 
			{
				if(IsActivated) return _effectiveDepth;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _effectiveDepth;
			} 
			set
			{
				SetValue( v =>  _effectiveDepth = v, _effectiveDepth, value,  "EffectiveDepth");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Optional)]
		public IfcPositiveLengthMeasure? @NominalBarDiameter 
		{ 
			get 
			{
				if(IsActivated) return _nominalBarDiameter;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _nominalBarDiameter;
			} 
			set
			{
				SetValue( v =>  _nominalBarDiameter = v, _nominalBarDiameter, value,  "NominalBarDiameter");
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Optional)]
		public IfcCountMeasure? @BarCount 
		{ 
			get 
			{
				if(IsActivated) return _barCount;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _barCount;
			} 
			set
			{
				SetValue( v =>  _barCount = v, _barCount, value,  "BarCount");
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
			"TotalCrossSectionArea",
			"SteelGrade",
			"BarSurface",
			"EffectiveDepth",
			"NominalBarDiameter",
			"BarCount",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @TotalCrossSectionArea;
				case 1: 
					return @SteelGrade;
				case 2: 
					return @BarSurface;
				case 3: 
					return @EffectiveDepth;
				case 4: 
					return @NominalBarDiameter;
				case 5: 
					return @BarCount;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "TotalCrossSectionArea":  
					return @TotalCrossSectionArea;
				case "SteelGrade":  
					return @SteelGrade;
				case "BarSurface":  
					return @BarSurface;
				case "EffectiveDepth":  
					return @EffectiveDepth;
				case "NominalBarDiameter":  
					return @NominalBarDiameter;
				case "BarCount":  
					return @BarCount;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 if (value != null) @TotalCrossSectionArea = (IfcAreaMeasure)value;
					 break;
				case 1:
					 if (value != null) @SteelGrade = (IfcLabel)value;
					 break;
				case 2:
					 @BarSurface = (IfcReinforcingBarSurfaceEnum)value;
					 break;
				case 3:
					 @EffectiveDepth = (IfcLengthMeasure?)value;
					 break;
				case 4:
					 @NominalBarDiameter = (IfcPositiveLengthMeasure?)value;
					 break;
				case 5:
					 @BarCount = (IfcCountMeasure?)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "TotalCrossSectionArea":
					 if (value != null) @TotalCrossSectionArea = (IfcAreaMeasure)value;
					 break;
				case "SteelGrade":
					 if (value != null) @SteelGrade = (IfcLabel)value;
					 break;
				case "BarSurface":
					 @BarSurface = (IfcReinforcingBarSurfaceEnum)value;
					 break;
				case "EffectiveDepth":
					 @EffectiveDepth = (IfcLengthMeasure?)value;
					 break;
				case "NominalBarDiameter":
					 @NominalBarDiameter = (IfcPositiveLengthMeasure?)value;
					 break;
				case "BarCount":
					 @BarCount = (IfcCountMeasure?)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion


		#region IPersist implementation
		public void Set(int propIndex, IPropertyValue value)
		{
            throw new System.NotImplementedException();
		}
		#endregion

	}
}