// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 09:16:39
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.ProfileResource;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using Xbim.Common;

namespace Xbim.Ifc2x3.ProfilePropertyResource
{
	[EntityName("IFCSECTIONPROPERTIES")]
	public  partial class @IfcSectionProperties : INotifyPropertyChanged, IInstantiableEntity
	{
		#region Implementation of IPersistEntity
		public int EntityLabel {get; set;}
		public IModel Model { get; internal set; }

		protected bool IsActivated = false;

		public bool Activated { get { return IsActivated; } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcSectionProperties(IModel model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcSectionTypeEnum _sectionType;
		private IfcProfileDef _startProfile;
		private IfcProfileDef _endProfile;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(0, EntityAttributeState.Mandatory)]
		public IfcSectionTypeEnum @SectionType 
		{ 
			get 
			{
				if(IsActivated) return _sectionType;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _sectionType;
			} 
			set
			{
				SetValue( v =>  _sectionType = v, _sectionType, value,  "SectionType");
			} 
		}
	
		[EntityAttribute(1, EntityAttributeState.Mandatory)]
		public IfcProfileDef @StartProfile 
		{ 
			get 
			{
				if(IsActivated) return _startProfile;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _startProfile;
			} 
			set
			{
				SetValue( v =>  _startProfile = v, _startProfile, value,  "StartProfile");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Optional)]
		public IfcProfileDef @EndProfile 
		{ 
			get 
			{
				if(IsActivated) return _endProfile;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _endProfile;
			} 
			set
			{
				SetValue( v =>  _endProfile = v, _endProfile, value,  "EndProfile");
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
			"SectionType",
			"StartProfile",
			"EndProfile",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @SectionType;
				case 1: 
					return @StartProfile;
				case 2: 
					return @EndProfile;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "SectionType":  
					return @SectionType;
				case "StartProfile":  
					return @StartProfile;
				case "EndProfile":  
					return @EndProfile;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 if (value != null) @SectionType = (IfcSectionTypeEnum)value;
					 break;
				case 1:
					 @StartProfile = (IfcProfileDef)value;
					 break;
				case 2:
					 @EndProfile = (IfcProfileDef)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "SectionType":
					 if (value != null) @SectionType = (IfcSectionTypeEnum)value;
					 break;
				case "StartProfile":
					 @StartProfile = (IfcProfileDef)value;
					 break;
				case "EndProfile":
					 @EndProfile = (IfcProfileDef)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion


		#region IPersist implementation
		public void Set(int propIndex, IPropertyValue value)
		{
            throw new System.NotImplementedException();
		}
		#endregion

	}
}