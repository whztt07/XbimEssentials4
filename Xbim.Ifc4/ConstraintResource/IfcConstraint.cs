// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		22.09.2015 04:44:11
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.ExternalReferenceResource;
using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.ActorResource;
using Xbim.Ifc4.DateTimeResource;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.ConstraintResource
{
	[IndexedClass]
	[ExpressType("IFCCONSTRAINT", 516)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcConstraint : IPersistEntity, INotifyPropertyChanged, IfcResourceObjectSelect
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
		internal IfcConstraint(IModel model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcLabel _name;
		private IfcText? _description;
		private IfcConstraintEnum _constraintGrade;
		private IfcLabel? _constraintSource;
		private IfcActorSelect _creatingActor;
		private IfcDateTime? _creationTime;
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
	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcDateTime? @CreationTime 
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
		public IEnumerable<IfcExternalReferenceRelationship> @HasExternalReferences 
		{ 
			get 
			{
				return Model.Instances.Where<IfcExternalReferenceRelationship>(e => e.RelatedResourceObjects != null &&  e.RelatedResourceObjects.Contains(this));
			} 
		}
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcResourceConstraintRelationship> @PropertiesForConstraint 
		{ 
			get 
			{
				return Model.Instances.Where<IfcResourceConstraintRelationship>(e => e.RelatingConstraint == this);
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
					_creationTime = value.StringVal;
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
	}
}