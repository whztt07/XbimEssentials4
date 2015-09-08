// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 02:29:11
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.PropertyResource;
using Xbim.Ifc2x3.MeasureResource;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using Xbim.Common;

namespace Xbim.Ifc2x3.ActorResource
{
	[EntityName("IFCADDRESS", 5)]
	public abstract partial class @IfcAddress : IPersistEntity, INotifyPropertyChanged, IfcObjectReferenceSelect
	{
		#region Implementation of IPersistEntity
		public int EntityLabel {get; internal set;}
		public IModel Model { get; internal set; }
		public bool Activated { get; internal set; }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcAddress(IModel model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcAddressTypeEnum _purpose;
		private IfcText? _description;
		private IfcLabel? _userDefinedPurpose;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(0, EntityAttributeState.Optional)]
		public IfcAddressTypeEnum @Purpose 
		{ 
			get 
			{
				if(Activated) return _purpose;
				
				Model.Activate(this, true);
				Activated = true;
				return _purpose;
			} 
			set
			{
				SetValue( v =>  _purpose = v, _purpose, value,  "Purpose");
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
		public IfcLabel? @UserDefinedPurpose 
		{ 
			get 
			{
				if(Activated) return _userDefinedPurpose;
				
				Model.Activate(this, true);
				Activated = true;
				return _userDefinedPurpose;
			} 
			set
			{
				SetValue( v =>  _userDefinedPurpose = v, _userDefinedPurpose, value,  "UserDefinedPurpose");
			} 
		}
	
		#endregion

		#region Inverse attributes
		public IEnumerable<IfcPerson> @OfPerson 
		{ 
			get 
			{
				return Model.Instances.Where<IfcPerson>(e => e.Addresses != null &&  e.Addresses.Contains(this));
			} 
		}
	
		public IEnumerable<IfcOrganization> @OfOrganization 
		{ 
			get 
			{
				return Model.Instances.Where<IfcOrganization>(e => e.Addresses != null &&  e.Addresses.Contains(this));
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

		#region Where rules
		/*WR1:              EXISTS(SELF.UserDefinedPurpose)));*/
		#endregion

		#region IPersist implementation
		#endregion

	}
}