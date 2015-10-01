// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.DateTimeResource;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.ApprovalResource
{
	[IndexedClass]
	[ExpressType("IFCAPPROVAL", 626)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcApproval : IPersistEntity, INotifyPropertyChanged, IInstantiableEntity, System.Collections.Generic.IEqualityComparer<@IfcApproval>, System.IEquatable<@IfcApproval>
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
		internal IfcApproval(IModel model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcText? _description;
		private IfcDateTimeSelect _approvalDateTime;
		private IfcLabel? _approvalStatus;
		private IfcLabel? _approvalLevel;
		private IfcText? _approvalQualifier;
		private IfcLabel _name;
		private IfcIdentifier _identifier;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
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
	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcDateTimeSelect @ApprovalDateTime 
		{ 
			get 
			{
				if(Activated) return _approvalDateTime;
				
				Model.Activate(this, true);
				Activated = true;
				return _approvalDateTime;
			} 
			set
			{
				SetValue( v =>  _approvalDateTime = v, _approvalDateTime, value,  "ApprovalDateTime");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel? @ApprovalStatus 
		{ 
			get 
			{
				if(Activated) return _approvalStatus;
				
				Model.Activate(this, true);
				Activated = true;
				return _approvalStatus;
			} 
			set
			{
				SetValue( v =>  _approvalStatus = v, _approvalStatus, value,  "ApprovalStatus");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel? @ApprovalLevel 
		{ 
			get 
			{
				if(Activated) return _approvalLevel;
				
				Model.Activate(this, true);
				Activated = true;
				return _approvalLevel;
			} 
			set
			{
				SetValue( v =>  _approvalLevel = v, _approvalLevel, value,  "ApprovalLevel");
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcText? @ApprovalQualifier 
		{ 
			get 
			{
				if(Activated) return _approvalQualifier;
				
				Model.Activate(this, true);
				Activated = true;
				return _approvalQualifier;
			} 
			set
			{
				SetValue( v =>  _approvalQualifier = v, _approvalQualifier, value,  "ApprovalQualifier");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
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
	
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcIdentifier @Identifier 
		{ 
			get 
			{
				if(Activated) return _identifier;
				
				Model.Activate(this, true);
				Activated = true;
				return _identifier;
			} 
			set
			{
				SetValue( v =>  _identifier = v, _identifier, value,  "Identifier");
			} 
		}
	
		#endregion

		#region Inverse attributes
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcApprovalActorRelationship> @Actors 
		{ 
			get 
			{
				return Model.Instances.Where<IfcApprovalActorRelationship>(e => e.Approval == this);
			} 
		}
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcApprovalRelationship> @IsRelatedWith 
		{ 
			get 
			{
				return Model.Instances.Where<IfcApprovalRelationship>(e => e.RelatedApproval == this);
			} 
		}
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcApprovalRelationship> @Relates 
		{ 
			get 
			{
				return Model.Instances.Where<IfcApprovalRelationship>(e => e.RelatingApproval == this);
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
					_description = value.StringVal;
					return;
				case 1: 
					_approvalDateTime = (IfcDateTimeSelect)(value.EntityVal);
					return;
				case 2: 
					_approvalStatus = value.StringVal;
					return;
				case 3: 
					_approvalLevel = value.StringVal;
					return;
				case 4: 
					_approvalQualifier = value.StringVal;
					return;
				case 5: 
					_name = value.StringVal;
					return;
				case 6: 
					_identifier = value.StringVal;
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
        public bool Equals(@IfcApproval other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcApproval
            var root = (@IfcApproval)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcApproval left, @IfcApproval right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcApproval left, @IfcApproval right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcApproval x, @IfcApproval y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcApproval obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}