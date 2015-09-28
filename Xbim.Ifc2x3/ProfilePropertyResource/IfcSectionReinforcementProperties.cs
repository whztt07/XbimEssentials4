// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
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

namespace Xbim.Ifc2x3.ProfilePropertyResource
{
	[ExpressType("IFCSECTIONREINFORCEMENTPROPERTIES", 508)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcSectionReinforcementProperties : IPersistEntity, INotifyPropertyChanged, IInstantiableEntity
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
		internal IfcSectionReinforcementProperties(IModel model) 		{ 
			Model = model; 
			_crossSectionReinforcementDefinitions = new ItemSet<IfcReinforcementBarProperties>( this );
		}

		#region Explicit attribute fields
		private IfcLengthMeasure _longitudinalStartPosition;
		private IfcLengthMeasure _longitudinalEndPosition;
		private IfcLengthMeasure? _transversePosition;
		private IfcReinforcingBarRoleEnum _reinforcementRole;
		private IfcSectionProperties _sectionDefinition;
		private ItemSet<IfcReinforcementBarProperties> _crossSectionReinforcementDefinitions;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLengthMeasure @LongitudinalStartPosition 
		{ 
			get 
			{
				if(Activated) return _longitudinalStartPosition;
				
				Model.Activate(this, true);
				Activated = true;
				return _longitudinalStartPosition;
			} 
			set
			{
				SetValue( v =>  _longitudinalStartPosition = v, _longitudinalStartPosition, value,  "LongitudinalStartPosition");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLengthMeasure @LongitudinalEndPosition 
		{ 
			get 
			{
				if(Activated) return _longitudinalEndPosition;
				
				Model.Activate(this, true);
				Activated = true;
				return _longitudinalEndPosition;
			} 
			set
			{
				SetValue( v =>  _longitudinalEndPosition = v, _longitudinalEndPosition, value,  "LongitudinalEndPosition");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLengthMeasure? @TransversePosition 
		{ 
			get 
			{
				if(Activated) return _transversePosition;
				
				Model.Activate(this, true);
				Activated = true;
				return _transversePosition;
			} 
			set
			{
				SetValue( v =>  _transversePosition = v, _transversePosition, value,  "TransversePosition");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcReinforcingBarRoleEnum @ReinforcementRole 
		{ 
			get 
			{
				if(Activated) return _reinforcementRole;
				
				Model.Activate(this, true);
				Activated = true;
				return _reinforcementRole;
			} 
			set
			{
				SetValue( v =>  _reinforcementRole = v, _reinforcementRole, value,  "ReinforcementRole");
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcSectionProperties @SectionDefinition 
		{ 
			get 
			{
				if(Activated) return _sectionDefinition;
				
				Model.Activate(this, true);
				Activated = true;
				return _sectionDefinition;
			} 
			set
			{
				SetValue( v =>  _sectionDefinition = v, _sectionDefinition, value,  "SectionDefinition");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1)]
		public ItemSet<IfcReinforcementBarProperties> @CrossSectionReinforcementDefinitions 
		{ 
			get 
			{
				if(Activated) return _crossSectionReinforcementDefinitions;
				
				Model.Activate(this, true);
				Activated = true;
				return _crossSectionReinforcementDefinitions;
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
					_longitudinalStartPosition = value.RealVal;
					return;
				case 1: 
					_longitudinalEndPosition = value.RealVal;
					return;
				case 2: 
					_transversePosition = value.RealVal;
					return;
				case 3: 
                    _reinforcementRole = (IfcReinforcingBarRoleEnum) System.Enum.Parse(typeof (IfcReinforcingBarRoleEnum), value.EnumVal, true);
					return;
				case 4: 
					_sectionDefinition = (IfcSectionProperties)(value.EntityVal);
					return;
				case 5: 
					if (_crossSectionReinforcementDefinitions == null) _crossSectionReinforcementDefinitions = new ItemSet<IfcReinforcementBarProperties>( this );
					_crossSectionReinforcementDefinitions.InternalAdd((IfcReinforcementBarProperties)value.EntityVal);
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