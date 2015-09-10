// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		09/09/2015 04:20:36
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.PresentationResource;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using Xbim.Common;

namespace Xbim.Ifc2x3.PresentationAppearanceResource
{
	[EntityName("IFCSURFACESTYLELIGHTING", 117)]
	public  partial class @IfcSurfaceStyleLighting : INotifyPropertyChanged, IfcSurfaceStyleElementSelect, IInstantiableEntity
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
		internal IfcSurfaceStyleLighting(IModel model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcColourRgb _diffuseTransmissionColour;
		private IfcColourRgb _diffuseReflectionColour;
		private IfcColourRgb _transmissionColour;
		private IfcColourRgb _reflectanceColour;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(0, EntityAttributeState.Mandatory)]
		public IfcColourRgb @DiffuseTransmissionColour 
		{ 
			get 
			{
				if(Activated) return _diffuseTransmissionColour;
				
				Model.Activate(this, true);
				Activated = true;
				return _diffuseTransmissionColour;
			} 
			set
			{
				SetValue( v =>  _diffuseTransmissionColour = v, _diffuseTransmissionColour, value,  "DiffuseTransmissionColour");
			} 
		}
	
		[EntityAttribute(1, EntityAttributeState.Mandatory)]
		public IfcColourRgb @DiffuseReflectionColour 
		{ 
			get 
			{
				if(Activated) return _diffuseReflectionColour;
				
				Model.Activate(this, true);
				Activated = true;
				return _diffuseReflectionColour;
			} 
			set
			{
				SetValue( v =>  _diffuseReflectionColour = v, _diffuseReflectionColour, value,  "DiffuseReflectionColour");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Mandatory)]
		public IfcColourRgb @TransmissionColour 
		{ 
			get 
			{
				if(Activated) return _transmissionColour;
				
				Model.Activate(this, true);
				Activated = true;
				return _transmissionColour;
			} 
			set
			{
				SetValue( v =>  _transmissionColour = v, _transmissionColour, value,  "TransmissionColour");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Mandatory)]
		public IfcColourRgb @ReflectanceColour 
		{ 
			get 
			{
				if(Activated) return _reflectanceColour;
				
				Model.Activate(this, true);
				Activated = true;
				return _reflectanceColour;
			} 
			set
			{
				SetValue( v =>  _reflectanceColour = v, _reflectanceColour, value,  "ReflectanceColour");
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
			"DiffuseTransmissionColour",
			"DiffuseReflectionColour",
			"TransmissionColour",
			"ReflectanceColour",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @DiffuseTransmissionColour;
				case 1: 
					return @DiffuseReflectionColour;
				case 2: 
					return @TransmissionColour;
				case 3: 
					return @ReflectanceColour;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "DiffuseTransmissionColour":  
					return @DiffuseTransmissionColour;
				case "DiffuseReflectionColour":  
					return @DiffuseReflectionColour;
				case "TransmissionColour":  
					return @TransmissionColour;
				case "ReflectanceColour":  
					return @ReflectanceColour;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 @DiffuseTransmissionColour = (IfcColourRgb)value;
					 break;
				case 1:
					 @DiffuseReflectionColour = (IfcColourRgb)value;
					 break;
				case 2:
					 @TransmissionColour = (IfcColourRgb)value;
					 break;
				case 3:
					 @ReflectanceColour = (IfcColourRgb)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "DiffuseTransmissionColour":
					 @DiffuseTransmissionColour = (IfcColourRgb)value;
					 break;
				case "DiffuseReflectionColour":
					 @DiffuseReflectionColour = (IfcColourRgb)value;
					 break;
				case "TransmissionColour":
					 @TransmissionColour = (IfcColourRgb)value;
					 break;
				case "ReflectanceColour":
					 @ReflectanceColour = (IfcColourRgb)value;
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