// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		22.09.2015 02:32:00
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
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.PresentationAppearanceResource
{
	[IndexedClass]
	[ExpressType("IFCSURFACESTYLELIGHTING", 117)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcSurfaceStyleLighting : IPersistEntity, INotifyPropertyChanged, IfcSurfaceStyleElementSelect, IInstantiableEntity
	{
		#region Implementation of IPersistEntity
		public int EntityLabel {get; internal set;}
		
		public IModel Model { get; internal set; }
		
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
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
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
	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
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
	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
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
	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
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
					_diffuseTransmissionColour = (IfcColourRgb)(value.EntityVal);
					return;
				case 1: 
					_diffuseReflectionColour = (IfcColourRgb)(value.EntityVal);
					return;
				case 2: 
					_transmissionColour = (IfcColourRgb)(value.EntityVal);
					return;
				case 3: 
					_reflectanceColour = (IfcColourRgb)(value.EntityVal);
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