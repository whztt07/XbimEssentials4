// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		16.09.2015 10:12:22
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

namespace Xbim.Ifc2x3.GeometricConstraintResource
{
	[EntityName("IFCVIRTUALGRIDINTERSECTION", 589)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcVirtualGridIntersection : INotifyPropertyChanged, IInstantiableEntity
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
		internal IfcVirtualGridIntersection(IModel model) 		{ 
			Model = model; 
			_intersectingAxes = new ItemSet<IfcGridAxis>( model );
			_offsetDistances = new ItemSet<IfcLengthMeasure>( model );
		}

		#region Explicit attribute fields
		private ItemSet<IfcGridAxis> _intersectingAxes;
		private ItemSet<IfcLengthMeasure> _offsetDistances;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(0, EntityAttributeState.Mandatory)]
		public ItemSet<IfcGridAxis> @IntersectingAxes 
		{ 
			get 
			{
				if(Activated) return _intersectingAxes;
				
				Model.Activate(this, true);
				Activated = true;
				return _intersectingAxes;
			} 
			set
			{
				SetValue( v =>  _intersectingAxes = v, _intersectingAxes, value,  "IntersectingAxes");
			} 
		}
	
		[EntityAttribute(1, EntityAttributeState.Mandatory)]
		public ItemSet<IfcLengthMeasure> @OffsetDistances 
		{ 
			get 
			{
				if(Activated) return _offsetDistances;
				
				Model.Activate(this, true);
				Activated = true;
				return _offsetDistances;
			} 
			set
			{
				SetValue( v =>  _offsetDistances = v, _offsetDistances, value,  "OffsetDistances");
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
		private static readonly List<string> AttributeNames = new List<string>
		{
			"IntersectingAxes",
			"OffsetDistances",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return AttributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @IntersectingAxes;
				case 1: 
					return @OffsetDistances;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "IntersectingAxes":  
					return @IntersectingAxes;
				case "OffsetDistances":  
					return @OffsetDistances;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 @IntersectingAxes.Add((IfcGridAxis)value);
					 break;
				case 1:
					 @OffsetDistances = (ItemSet<IfcLengthMeasure>)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "IntersectingAxes":
					 @IntersectingAxes.Add((IfcGridAxis)value);
					 break;
				case "OffsetDistances":
					 @OffsetDistances = (ItemSet<IfcLengthMeasure>)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion



		#region IPersist implementation
		public virtual void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
					if (_intersectingAxes == null) _intersectingAxes = new ItemSet<IfcGridAxis>( Model );
					_intersectingAxes.Add((IfcGridAxis)value.EntityVal);
					return;
				case 1: 
					if (_offsetDistances == null) _offsetDistances = new ItemSet<IfcLengthMeasure>( Model );
					_offsetDistances.Add(value.RealVal);
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