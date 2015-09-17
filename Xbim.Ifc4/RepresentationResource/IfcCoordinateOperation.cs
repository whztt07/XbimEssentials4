// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 10:21:07
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System.ComponentModel;
using System;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.RepresentationResource
{
	[EntityName("IFCCOORDINATEOPERATION", 145)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcCoordinateOperation : IPersistEntity, INotifyPropertyChanged
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
		internal IfcCoordinateOperation(IModel model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcCoordinateReferenceSystemSelect _sourceCRS;
		private IfcCoordinateReferenceSystem _targetCRS;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(0, EntityAttributeState.Mandatory)]
		public IfcCoordinateReferenceSystemSelect @SourceCRS 
		{ 
			get 
			{
				if(Activated) return _sourceCRS;
				
				Model.Activate(this, true);
				Activated = true;
				return _sourceCRS;
			} 
			set
			{
				SetValue( v =>  _sourceCRS = v, _sourceCRS, value,  "SourceCRS");
			} 
		}
	
		[EntityAttribute(1, EntityAttributeState.Mandatory)]
		public IfcCoordinateReferenceSystem @TargetCRS 
		{ 
			get 
			{
				if(Activated) return _targetCRS;
				
				Model.Activate(this, true);
				Activated = true;
				return _targetCRS;
			} 
			set
			{
				SetValue( v =>  _targetCRS = v, _targetCRS, value,  "TargetCRS");
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
					_sourceCRS = (IfcCoordinateReferenceSystemSelect)(value.EntityVal);
					return;
				case 1: 
					_targetCRS = (IfcCoordinateReferenceSystem)(value.EntityVal);
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