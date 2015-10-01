// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.ConstraintResource;
using Xbim.Ifc4.PropertyResource;
using Xbim.Ifc4.ExternalReferenceResource;
using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.DateTimeResource;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.CostResource
{
	[IndexedClass]
	[ExpressType("IFCAPPLIEDVALUE", 411)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcAppliedValue : IPersistEntity, INotifyPropertyChanged, IfcMetricValueSelect, IfcObjectReferenceSelect, IfcResourceObjectSelect, IInstantiableEntity, System.Collections.Generic.IEqualityComparer<@IfcAppliedValue>, System.IEquatable<@IfcAppliedValue>
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
		internal IfcAppliedValue(IModel model) 		{ 
			Model = model; 
			_components = new OptionalItemSet<IfcAppliedValue>( this );
		}

		#region Explicit attribute fields
		private IfcLabel? _name;
		private IfcText? _description;
		private IfcAppliedValueSelect _appliedValue;
		private IfcMeasureWithUnit _unitBasis;
		private IfcDate? _applicableDate;
		private IfcDate? _fixedUntilDate;
		private IfcLabel? _category;
		private IfcLabel? _condition;
		private IfcArithmeticOperatorEnum? _arithmeticOperator;
		private OptionalItemSet<IfcAppliedValue> _components;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
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
	
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
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
	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcAppliedValueSelect @AppliedValue 
		{ 
			get 
			{
				if(Activated) return _appliedValue;
				
				Model.Activate(this, true);
				Activated = true;
				return _appliedValue;
			} 
			set
			{
				SetValue( v =>  _appliedValue = v, _appliedValue, value,  "AppliedValue");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcMeasureWithUnit @UnitBasis 
		{ 
			get 
			{
				if(Activated) return _unitBasis;
				
				Model.Activate(this, true);
				Activated = true;
				return _unitBasis;
			} 
			set
			{
				SetValue( v =>  _unitBasis = v, _unitBasis, value,  "UnitBasis");
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcDate? @ApplicableDate 
		{ 
			get 
			{
				if(Activated) return _applicableDate;
				
				Model.Activate(this, true);
				Activated = true;
				return _applicableDate;
			} 
			set
			{
				SetValue( v =>  _applicableDate = v, _applicableDate, value,  "ApplicableDate");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcDate? @FixedUntilDate 
		{ 
			get 
			{
				if(Activated) return _fixedUntilDate;
				
				Model.Activate(this, true);
				Activated = true;
				return _fixedUntilDate;
			} 
			set
			{
				SetValue( v =>  _fixedUntilDate = v, _fixedUntilDate, value,  "FixedUntilDate");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel? @Category 
		{ 
			get 
			{
				if(Activated) return _category;
				
				Model.Activate(this, true);
				Activated = true;
				return _category;
			} 
			set
			{
				SetValue( v =>  _category = v, _category, value,  "Category");
			} 
		}
	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel? @Condition 
		{ 
			get 
			{
				if(Activated) return _condition;
				
				Model.Activate(this, true);
				Activated = true;
				return _condition;
			} 
			set
			{
				SetValue( v =>  _condition = v, _condition, value,  "Condition");
			} 
		}
	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcArithmeticOperatorEnum? @ArithmeticOperator 
		{ 
			get 
			{
				if(Activated) return _arithmeticOperator;
				
				Model.Activate(this, true);
				Activated = true;
				return _arithmeticOperator;
			} 
			set
			{
				SetValue( v =>  _arithmeticOperator = v, _arithmeticOperator, value,  "ArithmeticOperator");
			} 
		}
	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.Class, 1, -1)]
		public OptionalItemSet<IfcAppliedValue> @Components 
		{ 
			get 
			{
				if(Activated) return _components;
				
				Model.Activate(this, true);
				Activated = true;
				return _components;
			} 
		}
	
		#endregion

		#region Inverse attributes
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcExternalReferenceRelationship> @HasExternalReference 
		{ 
			get 
			{
				return Model.Instances.Where<IfcExternalReferenceRelationship>(e => e.RelatedResourceObjects != null &&  e.RelatedResourceObjects.Contains(this));
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
					_name = value.StringVal;
					return;
				case 1: 
					_description = value.StringVal;
					return;
				case 2: 
					_appliedValue = (IfcAppliedValueSelect)(value.EntityVal);
					return;
				case 3: 
					_unitBasis = (IfcMeasureWithUnit)(value.EntityVal);
					return;
				case 4: 
					_applicableDate = value.StringVal;
					return;
				case 5: 
					_fixedUntilDate = value.StringVal;
					return;
				case 6: 
					_category = value.StringVal;
					return;
				case 7: 
					_condition = value.StringVal;
					return;
				case 8: 
                    _arithmeticOperator = (IfcArithmeticOperatorEnum) System.Enum.Parse(typeof (IfcArithmeticOperatorEnum), value.EnumVal, true);
					return;
				case 9: 
					if (_components == null) _components = new OptionalItemSet<IfcAppliedValue>( this );
					_components.InternalAdd((IfcAppliedValue)value.EntityVal);
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
        public bool Equals(@IfcAppliedValue other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcAppliedValue
            var root = (@IfcAppliedValue)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcAppliedValue left, @IfcAppliedValue right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcAppliedValue left, @IfcAppliedValue right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcAppliedValue x, @IfcAppliedValue y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcAppliedValue obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}