// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		09/09/2015 04:20:35
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.PropertyResource;
using Xbim.Ifc2x3.MeasureResource;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using Xbim.Common;

namespace Xbim.Ifc2x3.MaterialResource
{
	[EntityName("IFCMATERIALLAYER", 446)]
	public  partial class @IfcMaterialLayer : INotifyPropertyChanged, IfcMaterialSelect, IfcObjectReferenceSelect, IInstantiableEntity
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
		internal IfcMaterialLayer(IModel model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcMaterial _material;
		private IfcPositiveLengthMeasure _layerThickness;
		private IfcLogical? _isVentilated;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(0, EntityAttributeState.Optional)]
		public IfcMaterial @Material 
		{ 
			get 
			{
				if(Activated) return _material;
				
				Model.Activate(this, true);
				Activated = true;
				return _material;
			} 
			set
			{
				SetValue( v =>  _material = v, _material, value,  "Material");
			} 
		}
	
		[EntityAttribute(1, EntityAttributeState.Mandatory)]
		public IfcPositiveLengthMeasure @LayerThickness 
		{ 
			get 
			{
				if(Activated) return _layerThickness;
				
				Model.Activate(this, true);
				Activated = true;
				return _layerThickness;
			} 
			set
			{
				SetValue( v =>  _layerThickness = v, _layerThickness, value,  "LayerThickness");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Optional)]
		public IfcLogical? @IsVentilated 
		{ 
			get 
			{
				if(Activated) return _isVentilated;
				
				Model.Activate(this, true);
				Activated = true;
				return _isVentilated;
			} 
			set
			{
				SetValue( v =>  _isVentilated = v, _isVentilated, value,  "IsVentilated");
			} 
		}
	
		#endregion

		#region Inverse attributes
		public IEnumerable<IfcMaterialLayerSet> @ToMaterialLayerSet 
		{ 
			get 
			{
				return Model.Instances.Where<IfcMaterialLayerSet>(e => e.MaterialLayers != null &&  e.MaterialLayers.Contains(this));
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

			Action undo = () => setter(oldValue);
			txn.AddReversibleAction(undo);
			setter(newValue);
			NotifyPropertyChanged(notifyPropertyName);
		}

		#endregion

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"Material",
			"LayerThickness",
			"IsVentilated",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @Material;
				case 1: 
					return @LayerThickness;
				case 2: 
					return @IsVentilated;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "Material":  
					return @Material;
				case "LayerThickness":  
					return @LayerThickness;
				case "IsVentilated":  
					return @IsVentilated;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 @Material = (IfcMaterial)value;
					 break;
				case 1:
					 if (value != null) @LayerThickness = (IfcPositiveLengthMeasure)value;
					 break;
				case 2:
					 @IsVentilated = (IfcLogical?)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "Material":
					 @Material = (IfcMaterial)value;
					 break;
				case "LayerThickness":
					 if (value != null) @LayerThickness = (IfcPositiveLengthMeasure)value;
					 break;
				case "IsVentilated":
					 @IsVentilated = (IfcLogical?)value;
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