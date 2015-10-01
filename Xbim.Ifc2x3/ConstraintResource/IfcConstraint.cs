// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.ActorResource;
using Xbim.Ifc2x3.DateTimeResource;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.ConstraintResource
{
	[IndexedClass]
	[ExpressType("IFCCONSTRAINT", 81)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcConstraint : IPersistEntity, INotifyPropertyChanged, System.Collections.Generic.IEqualityComparer<@IfcConstraint>, System.IEquatable<@IfcConstraint>
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
		internal IfcConstraint(IModel model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcLabel _name;
		private IfcText? _description;
		private IfcConstraintEnum _constraintGrade;
		private IfcLabel? _constraintSource;
		private IfcActorSelect _creatingActor;
		private IfcDateTimeSelect _creationTime;
		private IfcLabel? _userDefinedGrade;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel @Name 
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
	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcConstraintEnum @ConstraintGrade 
		{ 
			get 
			{
				if(Activated) return _constraintGrade;
				
				Model.Activate(this, true);
				Activated = true;
				return _constraintGrade;
			} 
			set
			{
				SetValue( v =>  _constraintGrade = v, _constraintGrade, value,  "ConstraintGrade");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel? @ConstraintSource 
		{ 
			get 
			{
				if(Activated) return _constraintSource;
				
				Model.Activate(this, true);
				Activated = true;
				return _constraintSource;
			} 
			set
			{
				SetValue( v =>  _constraintSource = v, _constraintSource, value,  "ConstraintSource");
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcActorSelect @CreatingActor 
		{ 
			get 
			{
				if(Activated) return _creatingActor;
				
				Model.Activate(this, true);
				Activated = true;
				return _creatingActor;
			} 
			set
			{
				SetValue( v =>  _creatingActor = v, _creatingActor, value,  "CreatingActor");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcDateTimeSelect @CreationTime 
		{ 
			get 
			{
				if(Activated) return _creationTime;
				
				Model.Activate(this, true);
				Activated = true;
				return _creationTime;
			} 
			set
			{
				SetValue( v =>  _creationTime = v, _creationTime, value,  "CreationTime");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel? @UserDefinedGrade 
		{ 
			get 
			{
				if(Activated) return _userDefinedGrade;
				
				Model.Activate(this, true);
				Activated = true;
				return _userDefinedGrade;
			} 
			set
			{
				SetValue( v =>  _userDefinedGrade = v, _userDefinedGrade, value,  "UserDefinedGrade");
			} 
		}
	
		#endregion

		#region Inverse attributes
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcConstraintClassificationRelationship> @ClassifiedAs 
		{ 
			get 
			{
				return Model.Instances.Where<IfcConstraintClassificationRelationship>(e => e.ClassifiedConstraint == this);
			} 
		}
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcConstraintRelationship> @RelatesConstraints 
		{ 
			get 
			{
				return Model.Instances.Where<IfcConstraintRelationship>(e => e.RelatingConstraint == this);
			} 
		}
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcConstraintRelationship> @IsRelatedWith 
		{ 
			get 
			{
				return Model.Instances.Where<IfcConstraintRelationship>(e => e.RelatedConstraints != null &&  e.RelatedConstraints.Contains(this));
			} 
		}
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcPropertyConstraintRelationship> @PropertiesForConstraint 
		{ 
			get 
			{
				return Model.Instances.Where<IfcPropertyConstraintRelationship>(e => e.RelatingConstraint == this);
			} 
		}
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcConstraintAggregationRelationship> @Aggregates 
		{ 
			get 
			{
				return Model.Instances.Where<IfcConstraintAggregationRelationship>(e => e.RelatingConstraint == this);
			} 
		}
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcConstraintAggregationRelationship> @IsAggregatedIn 
		{ 
			get 
			{
				return Model.Instances.Where<IfcConstraintAggregationRelationship>(e => e.RelatedConstraints != null &&  e.RelatedConstraints.Contains(this));
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
                    _constraintGrade = (IfcConstraintEnum) System.Enum.Parse(typeof (IfcConstraintEnum), value.EnumVal, true);
					return;
				case 3: 
					_constraintSource = value.StringVal;
					return;
				case 4: 
					_creatingActor = (IfcActorSelect)(value.EntityVal);
					return;
				case 5: 
					_creationTime = (IfcDateTimeSelect)(value.EntityVal);
					return;
				case 6: 
					_userDefinedGrade = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public virtual string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR11:             ((ConstraintGrade = IfcConstraintEnum.USERDEFINED) AND EXISTS(SELF\IfcConstraint.UserDefinedGrade));*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcConstraint other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcConstraint
            var root = (@IfcConstraint)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcConstraint left, @IfcConstraint right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcConstraint left, @IfcConstraint right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcConstraint x, @IfcConstraint y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcConstraint obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}