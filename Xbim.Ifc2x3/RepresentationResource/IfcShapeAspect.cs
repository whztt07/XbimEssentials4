// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 10:21:00
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

namespace Xbim.Ifc2x3.RepresentationResource
{
	[EntityName("IFCSHAPEASPECT", 665)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcShapeAspect : INotifyPropertyChanged, IInstantiableEntity
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
		internal IfcShapeAspect(IModel model) 		{ 
			Model = model; 
			_shapeRepresentations = new ItemSet<IfcShapeModel>( this );
		}

		#region Explicit attribute fields
		private ItemSet<IfcShapeModel> _shapeRepresentations;
		private IfcLabel? _name;
		private IfcText? _description;
		private bool? _productDefinitional;
		private IfcProductDefinitionShape _partOfProductDefinitionShape;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(0, EntityAttributeState.Mandatory)]
		public ItemSet<IfcShapeModel> @ShapeRepresentations 
		{ 
			get 
			{
				if(Activated) return _shapeRepresentations;
				
				Model.Activate(this, true);
				Activated = true;
				return _shapeRepresentations;
			} 
			set
			{
				SetValue( v =>  _shapeRepresentations = v, _shapeRepresentations, value,  "ShapeRepresentations");
			} 
		}
	
		[EntityAttribute(1, EntityAttributeState.Optional)]
		public IfcLabel? @Name 
		{ 
			get 
			{
				if(Activated) return _name;
				
				Model.Activate(this, true);
				Activated = true;
				return _name;
			} 
			set
			{
				SetValue( v =>  _name = v, _name, value,  "Name");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Optional)]
		public IfcText? @Description 
		{ 
			get 
			{
				if(Activated) return _description;
				
				Model.Activate(this, true);
				Activated = true;
				return _description;
			} 
			set
			{
				SetValue( v =>  _description = v, _description, value,  "Description");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Mandatory)]
		public bool? @ProductDefinitional 
		{ 
			get 
			{
				if(Activated) return _productDefinitional;
				
				Model.Activate(this, true);
				Activated = true;
				return _productDefinitional;
			} 
			set
			{
				SetValue( v =>  _productDefinitional = v, _productDefinitional, value,  "ProductDefinitional");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Mandatory)]
		public IfcProductDefinitionShape @PartOfProductDefinitionShape 
		{ 
			get 
			{
				if(Activated) return _partOfProductDefinitionShape;
				
				Model.Activate(this, true);
				Activated = true;
				return _partOfProductDefinitionShape;
			} 
			set
			{
				SetValue( v =>  _partOfProductDefinitionShape = v, _partOfProductDefinitionShape, value,  "PartOfProductDefinitionShape");
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
					if (_shapeRepresentations == null) _shapeRepresentations = new ItemSet<IfcShapeModel>( this );
					_shapeRepresentations.InternalAdd((IfcShapeModel)value.EntityVal);
					return;
				case 1: 
					_name = value.StringVal;
					return;
				case 2: 
					_description = value.StringVal;
					return;
				case 3: 
					_productDefinitional = value.BooleanVal;
					return;
				case 4: 
					_partOfProductDefinitionShape = (IfcProductDefinitionShape)(value.EntityVal);
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