// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 03:43:58
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
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.PresentationAppearanceResource
{
	[EntityName("IFCTEXTSTYLEWITHBOXCHARACTERISTICS", 730)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcTextStyleWithBoxCharacteristics : IPersistEntity, INotifyPropertyChanged, IfcTextStyleSelect, IInstantiableEntity
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
		internal IfcTextStyleWithBoxCharacteristics(IModel model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcPositiveLengthMeasure? _boxHeight;
		private IfcPositiveLengthMeasure? _boxWidth;
		private IfcPlaneAngleMeasure? _boxSlantAngle;
		private IfcPlaneAngleMeasure? _boxRotateAngle;
		private IfcSizeSelect _characterSpacing;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttributee(0, EntityAttributeState.Optional)]
		public IfcPositiveLengthMeasure? @BoxHeight 
		{ 
			get 
			{
				if(Activated) return _boxHeight;
				
				Model.Activate(this, true);
				Activated = true;
				return _boxHeight;
			} 
			set
			{
				SetValue( v =>  _boxHeight = v, _boxHeight, value,  "BoxHeight");
			} 
		}
	
		[EntityAttributee(1, EntityAttributeState.Optional)]
		public IfcPositiveLengthMeasure? @BoxWidth 
		{ 
			get 
			{
				if(Activated) return _boxWidth;
				
				Model.Activate(this, true);
				Activated = true;
				return _boxWidth;
			} 
			set
			{
				SetValue( v =>  _boxWidth = v, _boxWidth, value,  "BoxWidth");
			} 
		}
	
		[EntityAttributee(2, EntityAttributeState.Optional)]
		public IfcPlaneAngleMeasure? @BoxSlantAngle 
		{ 
			get 
			{
				if(Activated) return _boxSlantAngle;
				
				Model.Activate(this, true);
				Activated = true;
				return _boxSlantAngle;
			} 
			set
			{
				SetValue( v =>  _boxSlantAngle = v, _boxSlantAngle, value,  "BoxSlantAngle");
			} 
		}
	
		[EntityAttributee(3, EntityAttributeState.Optional)]
		public IfcPlaneAngleMeasure? @BoxRotateAngle 
		{ 
			get 
			{
				if(Activated) return _boxRotateAngle;
				
				Model.Activate(this, true);
				Activated = true;
				return _boxRotateAngle;
			} 
			set
			{
				SetValue( v =>  _boxRotateAngle = v, _boxRotateAngle, value,  "BoxRotateAngle");
			} 
		}
	
		[EntityAttributee(4, EntityAttributeState.Optional)]
		public IfcSizeSelect @CharacterSpacing 
		{ 
			get 
			{
				if(Activated) return _characterSpacing;
				
				Model.Activate(this, true);
				Activated = true;
				return _characterSpacing;
			} 
			set
			{
				SetValue( v =>  _characterSpacing = v, _characterSpacing, value,  "CharacterSpacing");
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
					_boxHeight = value.RealVal;
					return;
				case 1: 
					_boxWidth = value.RealVal;
					return;
				case 2: 
					_boxSlantAngle = value.RealVal;
					return;
				case 3: 
					_boxRotateAngle = value.RealVal;
					return;
				case 4: 
					_characterSpacing = (IfcSizeSelect)(value.EntityVal);
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