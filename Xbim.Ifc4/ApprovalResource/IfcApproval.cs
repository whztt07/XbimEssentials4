// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		24.09.2015 10:03:39
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.ExternalReferenceResource;
using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.DateTimeResource;
using Xbim.Ifc4.ActorResource;
using Xbim.Ifc4.ControlExtension;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.ApprovalResource
{
	[IndexedClass]
	[ExpressType("IFCAPPROVAL", 412)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcApproval : IPersistEntity, INotifyPropertyChanged, IfcResourceObjectSelect, IInstantiableEntity
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
		internal IfcApproval(IModel model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcIdentifier? _identifier;
		private IfcLabel? _name;
		private IfcText? _description;
		private IfcDateTime? _timeOfApproval;
		private IfcLabel? _status;
		private IfcLabel? _level;
		private IfcText? _qualifier;
		private IfcActorSelect _requestingApproval;
		private IfcActorSelect _givingApproval;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcIdentifier? @Identifier 
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
	
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
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
	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
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
	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcDateTime? @TimeOfApproval 
		{ 
			get 
			{
				if(Activated) return _timeOfApproval;
				
				Model.Activate(this, true);
				Activated = true;
				return _timeOfApproval;
			} 
			set
			{
				SetValue( v =>  _timeOfApproval = v, _timeOfApproval, value,  "TimeOfApproval");
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel? @Status 
		{ 
			get 
			{
				if(Activated) return _status;
				
				Model.Activate(this, true);
				Activated = true;
				return _status;
			} 
			set
			{
				SetValue( v =>  _status = v, _status, value,  "Status");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel? @Level 
		{ 
			get 
			{
				if(Activated) return _level;
				
				Model.Activate(this, true);
				Activated = true;
				return _level;
			} 
			set
			{
				SetValue( v =>  _level = v, _level, value,  "Level");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcText? @Qualifier 
		{ 
			get 
			{
				if(Activated) return _qualifier;
				
				Model.Activate(this, true);
				Activated = true;
				return _qualifier;
			} 
			set
			{
				SetValue( v =>  _qualifier = v, _qualifier, value,  "Qualifier");
			} 
		}
	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcActorSelect @RequestingApproval 
		{ 
			get 
			{
				if(Activated) return _requestingApproval;
				
				Model.Activate(this, true);
				Activated = true;
				return _requestingApproval;
			} 
			set
			{
				SetValue( v =>  _requestingApproval = v, _requestingApproval, value,  "RequestingApproval");
			} 
		}
	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcActorSelect @GivingApproval 
		{ 
			get 
			{
				if(Activated) return _givingApproval;
				
				Model.Activate(this, true);
				Activated = true;
				return _givingApproval;
			} 
			set
			{
				SetValue( v =>  _givingApproval = v, _givingApproval, value,  "GivingApproval");
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
		public IEnumerable<IfcRelAssociatesApproval> @ApprovedObjects 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelAssociatesApproval>(e => e.RelatingApproval == this);
			} 
		}
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcResourceApprovalRelationship> @ApprovedResources 
		{ 
			get 
			{
				return Model.Instances.Where<IfcResourceApprovalRelationship>(e => e.RelatingApproval == this);
			} 
		}
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcApprovalRelationship> @IsRelatedWith 
		{ 
			get 
			{
				return Model.Instances.Where<IfcApprovalRelationship>(e => e.RelatedApprovals != null &&  e.RelatedApprovals.Contains(this));
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
					_identifier = value.StringVal;
					return;
				case 1: 
					_name = value.StringVal;
					return;
				case 2: 
					_description = value.StringVal;
					return;
				case 3: 
					_timeOfApproval = value.StringVal;
					return;
				case 4: 
					_status = value.StringVal;
					return;
				case 5: 
					_level = value.StringVal;
					return;
				case 6: 
					_qualifier = value.StringVal;
					return;
				case 7: 
					_requestingApproval = (IfcActorSelect)(value.EntityVal);
					return;
				case 8: 
					_givingApproval = (IfcActorSelect)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public virtual string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*HasIdentifierOrName:	HasIdentifierOrName : EXISTS (Identifier) OR EXISTS (Name);*/
		}
		#endregion
	}
}