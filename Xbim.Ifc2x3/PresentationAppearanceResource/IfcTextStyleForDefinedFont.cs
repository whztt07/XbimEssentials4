// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 03:43:58
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
	[EntityName("IFCTEXTSTYLEFORDEFINEDFONT", 611)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcTextStyleForDefinedFont : IPersistEntity, INotifyPropertyChanged, IfcCharacterStyleSelect, IInstantiableEntity
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
		internal IfcTextStyleForDefinedFont(IModel model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcColour _colour;
		private IfcColour _backgroundColour;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttributee(0, EntityAttributeState.Mandatory)]
		public IfcColour @Colour 
		{ 
			get 
			{
				if(Activated) return _colour;
				
				Model.Activate(this, true);
				Activated = true;
				return _colour;
			} 
			set
			{
				SetValue( v =>  _colour = v, _colour, value,  "Colour");
			} 
		}
	
		[EntityAttributee(1, EntityAttributeState.Optional)]
		public IfcColour @BackgroundColour 
		{ 
			get 
			{
				if(Activated) return _backgroundColour;
				
				Model.Activate(this, true);
				Activated = true;
				return _backgroundColour;
			} 
			set
			{
				SetValue( v =>  _backgroundColour = v, _backgroundColour, value,  "BackgroundColour");
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
					_colour = (IfcColour)(value.EntityVal);
					return;
				case 1: 
					_backgroundColour = (IfcColour)(value.EntityVal);
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