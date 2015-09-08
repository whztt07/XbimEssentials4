// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 02:29:15
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

namespace Xbim.Ifc2x3.RepresentationResource
{
	[EntityName("IFCSHAPEASPECT", 509)]
	public  partial class @IfcShapeAspect : INotifyPropertyChanged, IInstantiableEntity
	{
		#region Implementation of IPersistEntity
		public int EntityLabel {get; internal set;}
		public IModel Model { get; internal set; }
		public bool Activated { get; internal set; }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcShapeAspect(IModel model) 		{ 
			Model = model; 
			_shapeRepresentations = new ItemSet<IfcShapeModel>( model );
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

			Action undo = () => setter(oldValue);
			txn.AddReversibleAction(undo);
			setter(newValue);
			NotifyPropertyChanged(notifyPropertyName);
		}

		#endregion

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"ShapeRepresentations",
			"Name",
			"Description",
			"ProductDefinitional",
			"PartOfProductDefinitionShape",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @ShapeRepresentations;
				case 1: 
					return @Name;
				case 2: 
					return @Description;
				case 3: 
					return @ProductDefinitional;
				case 4: 
					return @PartOfProductDefinitionShape;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "ShapeRepresentations":  
					return @ShapeRepresentations;
				case "Name":  
					return @Name;
				case "Description":  
					return @Description;
				case "ProductDefinitional":  
					return @ProductDefinitional;
				case "PartOfProductDefinitionShape":  
					return @PartOfProductDefinitionShape;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 @ShapeRepresentations.Add((IfcShapeModel)value);
					 break;
				case 1:
					 @Name = (IfcLabel?)value;
					 break;
				case 2:
					 @Description = (IfcText?)value;
					 break;
				case 3:
					 @ProductDefinitional = (bool?)value;
					 break;
				case 4:
					 @PartOfProductDefinitionShape = (IfcProductDefinitionShape)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "ShapeRepresentations":
					 @ShapeRepresentations.Add((IfcShapeModel)value);
					 break;
				case "Name":
					 @Name = (IfcLabel?)value;
					 break;
				case "Description":
					 @Description = (IfcText?)value;
					 break;
				case "ProductDefinitional":
					 @ProductDefinitional = (bool?)value;
					 break;
				case "PartOfProductDefinitionShape":
					 @PartOfProductDefinitionShape = (IfcProductDefinitionShape)value;
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

	}
}