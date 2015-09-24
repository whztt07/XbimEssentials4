// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		24.09.2015 10:03:44
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.GeometricConstraintResource
{
	[IndexedClass]
	[ExpressType("IFCVIRTUALGRIDINTERSECTION", 1136)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcVirtualGridIntersection : IPersistEntity, INotifyPropertyChanged, IfcGridPlacementDirectionSelect, IInstantiableEntity
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
		internal IfcVirtualGridIntersection(IModel model) 		{ 
			Model = model; 
			_intersectingAxes = new ItemSet<IfcGridAxis>( this );
			_offsetDistances = new ItemSet<IfcLengthMeasure>( this );
		}

		#region Explicit attribute fields
		private ItemSet<IfcGridAxis> _intersectingAxes;
		private ItemSet<IfcLengthMeasure> _offsetDistances;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.Class, 2, 2)]
		public ItemSet<IfcGridAxis> @IntersectingAxes 
		{ 
			get 
			{
				if(Activated) return _intersectingAxes;
				
				Model.Activate(this, true);
				Activated = true;
				return _intersectingAxes;
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.None, 2, 3)]
		public ItemSet<IfcLengthMeasure> @OffsetDistances 
		{ 
			get 
			{
				if(Activated) return _offsetDistances;
				
				Model.Activate(this, true);
				Activated = true;
				return _offsetDistances;
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
					if (_intersectingAxes == null) _intersectingAxes = new ItemSet<IfcGridAxis>( this );
					_intersectingAxes.InternalAdd((IfcGridAxis)value.EntityVal);
					return;
				case 1: 
					if (_offsetDistances == null) _offsetDistances = new ItemSet<IfcLengthMeasure>( this );
					_offsetDistances.InternalAdd(value.RealVal);
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