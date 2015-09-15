// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		15.09.2015 07:04:18
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.RepresentationResource;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using Xbim.Common;

namespace Xbim.Ifc2x3.GeometryResource
{
	[EntityName("IFCREPRESENTATIONMAP", 95)]
	public  partial class @IfcRepresentationMap : INotifyPropertyChanged, IInstantiableEntity
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
		internal IfcRepresentationMap(IModel model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcAxis2Placement _mappingOrigin;
		private IfcRepresentation _mappedRepresentation;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(0, EntityAttributeState.Mandatory)]
		public IfcAxis2Placement @MappingOrigin 
		{ 
			get 
			{
				if(Activated) return _mappingOrigin;
				
				Model.Activate(this, true);
				Activated = true;
				return _mappingOrigin;
			} 
			set
			{
				SetValue( v =>  _mappingOrigin = v, _mappingOrigin, value,  "MappingOrigin");
			} 
		}
	
		[EntityAttribute(1, EntityAttributeState.Mandatory)]
		public IfcRepresentation @MappedRepresentation 
		{ 
			get 
			{
				if(Activated) return _mappedRepresentation;
				
				Model.Activate(this, true);
				Activated = true;
				return _mappedRepresentation;
			} 
			set
			{
				SetValue( v =>  _mappedRepresentation = v, _mappedRepresentation, value,  "MappedRepresentation");
			} 
		}
	
		#endregion

		#region Inverse attributes
		public IEnumerable<IfcMappedItem> @MapUsage 
		{ 
			get 
			{
				return Model.Instances.Where<IfcMappedItem>(e => e.MappingSource == this);
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

			Action undo = () => setter(oldValue);
			txn.AddReversibleAction(undo);
			setter(newValue);
			NotifyPropertyChanged(notifyPropertyName);
		}

		#endregion

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"MappingOrigin",
			"MappedRepresentation",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @MappingOrigin;
				case 1: 
					return @MappedRepresentation;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "MappingOrigin":  
					return @MappingOrigin;
				case "MappedRepresentation":  
					return @MappedRepresentation;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 @MappingOrigin = (IfcAxis2Placement)value;
					 break;
				case 1:
					 @MappedRepresentation = (IfcRepresentation)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "MappingOrigin":
					 @MappingOrigin = (IfcAxis2Placement)value;
					 break;
				case "MappedRepresentation":
					 @MappedRepresentation = (IfcRepresentation)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion


		#region IPersist implementation
		public virtual void Parse(int propIndex, IPropertyValue value)
		{
            throw new System.NotImplementedException();
		}
		
		public virtual string WhereRule() 
		{
            throw new System.NotImplementedException();
		}
		#endregion

		
	}
}