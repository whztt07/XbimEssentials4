// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 03:44:05
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.GeometryResource;
using Xbim.Ifc4.ProductExtension;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.GeometricConstraintResource
{
	[EntityName("IFCGRIDAXIS", 306)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcGridAxis : IPersistEntity, INotifyPropertyChanged, IInstantiableEntity
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
		internal IfcGridAxis(IModel model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcLabel? _axisTag;
		private IfcCurve _axisCurve;
		private IfcBoolean _sameSense;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttributee(0, EntityAttributeState.Optional)]
		public IfcLabel? @AxisTag 
		{ 
			get 
			{
				if(Activated) return _axisTag;
				
				Model.Activate(this, true);
				Activated = true;
				return _axisTag;
			} 
			set
			{
				SetValue( v =>  _axisTag = v, _axisTag, value,  "AxisTag");
			} 
		}
	
		[EntityAttributee(1, EntityAttributeState.Mandatory)]
		public IfcCurve @AxisCurve 
		{ 
			get 
			{
				if(Activated) return _axisCurve;
				
				Model.Activate(this, true);
				Activated = true;
				return _axisCurve;
			} 
			set
			{
				SetValue( v =>  _axisCurve = v, _axisCurve, value,  "AxisCurve");
			} 
		}
	
		[EntityAttributee(2, EntityAttributeState.Mandatory)]
		public IfcBoolean @SameSense 
		{ 
			get 
			{
				if(Activated) return _sameSense;
				
				Model.Activate(this, true);
				Activated = true;
				return _sameSense;
			} 
			set
			{
				SetValue( v =>  _sameSense = v, _sameSense, value,  "SameSense");
			} 
		}
	
		#endregion

		#region Inverse attributes
		public IEnumerable<IfcGrid> @PartOfW 
		{ 
			get 
			{
				return Model.Instances.Where<IfcGrid>(e => e.WAxes != null &&  e.WAxes.Contains(this));
			} 
		}
	
		public IEnumerable<IfcGrid> @PartOfV 
		{ 
			get 
			{
				return Model.Instances.Where<IfcGrid>(e => e.VAxes != null &&  e.VAxes.Contains(this));
			} 
		}
	
		public IEnumerable<IfcGrid> @PartOfU 
		{ 
			get 
			{
				return Model.Instances.Where<IfcGrid>(e => e.UAxes != null &&  e.UAxes.Contains(this));
			} 
		}
	
		public IEnumerable<IfcVirtualGridIntersection> @HasIntersections 
		{ 
			get 
			{
				return Model.Instances.Where<IfcVirtualGridIntersection>(e => e.IntersectingAxes != null &&  e.IntersectingAxes.Contains(this));
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
					_axisTag = value.StringVal;
					return;
				case 1: 
					_axisCurve = (IfcCurve)(value.EntityVal);
					return;
				case 2: 
					_sameSense = value.BooleanVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public virtual string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR1:	WR1 : AxisCurve.Dim = 2;*/
		/*WR2:	WR2 : (SIZEOF(PartOfU) = 1) XOR (SIZEOF(PartOfV) = 1) XOR (SIZEOF(PartOfW) = 1);*/
		}
		#endregion
	}
}