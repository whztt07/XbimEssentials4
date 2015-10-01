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

namespace Xbim.Ifc2x3.MaterialResource
{
	[IndexedClass]
	[ExpressType("IFCMATERIALLAYERSET", 205)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcMaterialLayerSet : IPersistEntity, INotifyPropertyChanged, IfcMaterialSelect, IInstantiableEntity, System.Collections.Generic.IEqualityComparer<@IfcMaterialLayerSet>, System.IEquatable<@IfcMaterialLayerSet>
	{
		#region Implementation of IPersistEntity
		public int EntityLabel {get; internal set;}
		
		public IModel Model { get; internal set; }

		/// <summary>
        /// This property is deprecated and likely to be removed. Use just 'Model' instead.
        /// </summary>
		[Obsolete("This property is deprecated and likely to be removed. Use just 'Model' instead.")]
        public IModel ModelOf { get { return Model; } }
		
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
		internal IfcMaterialLayerSet(IModel model) 		{ 
			Model = model; 
			_materialLayers = new ItemSet<IfcMaterialLayer>( this );
		}

		#region Explicit attribute fields
		private ItemSet<IfcMaterialLayer> _materialLayers;
		private IfcLabel? _layerSetName;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.Class, 1, -1)]
		public ItemSet<IfcMaterialLayer> @MaterialLayers 
		{ 
			get 
			{
				if(Activated) return _materialLayers;
				
				Model.Activate(this, true);
				Activated = true;
				return _materialLayers;
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel? @LayerSetName 
		{ 
			get 
			{
				if(Activated) return _layerSetName;
				
				Model.Activate(this, true);
				Activated = true;
				return _layerSetName;
			} 
			set
			{
				SetValue( v =>  _layerSetName = v, _layerSetName, value,  "LayerSetName");
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
			setter(newValue);

			//do action and THAN add to transaction so that it gets the object in new state
			txn.AddReversibleAction(doAction, undoAction, this, ChangeType.Modified);
			NotifyPropertyChanged(notifyPropertyName);
		}

		#endregion

		#region IPersist implementation
		public virtual void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
					if (_materialLayers == null) _materialLayers = new ItemSet<IfcMaterialLayer>( this );
					_materialLayers.InternalAdd((IfcMaterialLayer)value.EntityVal);
					return;
				case 1: 
					_layerSetName = value.StringVal;
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

		#region Equality comparers and operators
        public bool Equals(@IfcMaterialLayerSet other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcMaterialLayerSet
            var root = (@IfcMaterialLayerSet)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcMaterialLayerSet left, @IfcMaterialLayerSet right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcMaterialLayerSet left, @IfcMaterialLayerSet right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcMaterialLayerSet x, @IfcMaterialLayerSet y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcMaterialLayerSet obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}