// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		09/09/2015 04:20:40
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

namespace Xbim.Ifc4.CostResource
{
	[EntityName("IFCAPPLIEDVALUE", 20)]
	public  partial class @IfcAppliedValue : INotifyPropertyChanged, IfcMetricValueSelect, IfcObjectReferenceSelect, IfcResourceObjectSelect, IInstantiableEntity
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
		internal IfcAppliedValue(IModel model) 		{ 
			Model = model; 
			_components = new ItemSet<IfcAppliedValue>( model );
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
		private ItemSet<IfcAppliedValue> _components;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(0, EntityAttributeState.Optional)]
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
	
		[EntityAttribute(1, EntityAttributeState.Optional)]
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
	
		[EntityAttribute(2, EntityAttributeState.Optional)]
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
	
		[EntityAttribute(3, EntityAttributeState.Optional)]
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
	
		[EntityAttribute(4, EntityAttributeState.Optional)]
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
	
		[EntityAttribute(5, EntityAttributeState.Optional)]
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
	
		[EntityAttribute(6, EntityAttributeState.Optional)]
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
	
		[EntityAttribute(7, EntityAttributeState.Optional)]
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
	
		[EntityAttribute(8, EntityAttributeState.Optional)]
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
	
		[EntityAttribute(9, EntityAttributeState.Optional)]
		public ItemSet<IfcAppliedValue> @Components 
		{ 
			get 
			{
				if(Activated) return _components;
				
				Model.Activate(this, true);
				Activated = true;
				return _components;
			} 
			set
			{
				SetValue( v =>  _components = v, _components, value,  "Components");
			} 
		}
	
		#endregion

		#region Inverse attributes
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

			Action undo = () => setter(oldValue);
			txn.AddReversibleAction(undo);
			setter(newValue);
			NotifyPropertyChanged(notifyPropertyName);
		}

		#endregion

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"Name",
			"Description",
			"AppliedValue",
			"UnitBasis",
			"ApplicableDate",
			"FixedUntilDate",
			"Category",
			"Condition",
			"ArithmeticOperator",
			"Components",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @Name;
				case 1: 
					return @Description;
				case 2: 
					return @AppliedValue;
				case 3: 
					return @UnitBasis;
				case 4: 
					return @ApplicableDate;
				case 5: 
					return @FixedUntilDate;
				case 6: 
					return @Category;
				case 7: 
					return @Condition;
				case 8: 
					return @ArithmeticOperator;
				case 9: 
					return @Components;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "Name":  
					return @Name;
				case "Description":  
					return @Description;
				case "AppliedValue":  
					return @AppliedValue;
				case "UnitBasis":  
					return @UnitBasis;
				case "ApplicableDate":  
					return @ApplicableDate;
				case "FixedUntilDate":  
					return @FixedUntilDate;
				case "Category":  
					return @Category;
				case "Condition":  
					return @Condition;
				case "ArithmeticOperator":  
					return @ArithmeticOperator;
				case "Components":  
					return @Components;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 @Name = (IfcLabel?)value;
					 break;
				case 1:
					 @Description = (IfcText?)value;
					 break;
				case 2:
					 @AppliedValue = (IfcAppliedValueSelect)value;
					 break;
				case 3:
					 @UnitBasis = (IfcMeasureWithUnit)value;
					 break;
				case 4:
					 @ApplicableDate = (IfcDate?)value;
					 break;
				case 5:
					 @FixedUntilDate = (IfcDate?)value;
					 break;
				case 6:
					 @Category = (IfcLabel?)value;
					 break;
				case 7:
					 @Condition = (IfcLabel?)value;
					 break;
				case 8:
					 @ArithmeticOperator = (IfcArithmeticOperatorEnum?)value;
					 break;
				case 9:
					 @Components.Add((IfcAppliedValue)value);
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "Name":
					 @Name = (IfcLabel?)value;
					 break;
				case "Description":
					 @Description = (IfcText?)value;
					 break;
				case "AppliedValue":
					 @AppliedValue = (IfcAppliedValueSelect)value;
					 break;
				case "UnitBasis":
					 @UnitBasis = (IfcMeasureWithUnit)value;
					 break;
				case "ApplicableDate":
					 @ApplicableDate = (IfcDate?)value;
					 break;
				case "FixedUntilDate":
					 @FixedUntilDate = (IfcDate?)value;
					 break;
				case "Category":
					 @Category = (IfcLabel?)value;
					 break;
				case "Condition":
					 @Condition = (IfcLabel?)value;
					 break;
				case "ArithmeticOperator":
					 @ArithmeticOperator = (IfcArithmeticOperatorEnum?)value;
					 break;
				case "Components":
					 @Components.Add((IfcAppliedValue)value);
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

		public  string WhereRule() 
		{
			return "";
		}
	}
}