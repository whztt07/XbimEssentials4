// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		09/09/2015 04:20:34
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

namespace Xbim.Ifc2x3.ExternalReferenceResource
{
	[EntityName("IFCDOCUMENTELECTRONICFORMAT", 599)]
	public  partial class @IfcDocumentElectronicFormat : INotifyPropertyChanged, IInstantiableEntity
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
		internal IfcDocumentElectronicFormat(IModel model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcLabel? _fileExtension;
		private IfcLabel? _mimeContentType;
		private IfcLabel? _mimeSubtype;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(0, EntityAttributeState.Optional)]
		public IfcLabel? @FileExtension 
		{ 
			get 
			{
				if(Activated) return _fileExtension;
				
				Model.Activate(this, true);
				Activated = true;
				return _fileExtension;
			} 
			set
			{
				SetValue( v =>  _fileExtension = v, _fileExtension, value,  "FileExtension");
			} 
		}
	
		[EntityAttribute(1, EntityAttributeState.Optional)]
		public IfcLabel? @MimeContentType 
		{ 
			get 
			{
				if(Activated) return _mimeContentType;
				
				Model.Activate(this, true);
				Activated = true;
				return _mimeContentType;
			} 
			set
			{
				SetValue( v =>  _mimeContentType = v, _mimeContentType, value,  "MimeContentType");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Optional)]
		public IfcLabel? @MimeSubtype 
		{ 
			get 
			{
				if(Activated) return _mimeSubtype;
				
				Model.Activate(this, true);
				Activated = true;
				return _mimeSubtype;
			} 
			set
			{
				SetValue( v =>  _mimeSubtype = v, _mimeSubtype, value,  "MimeSubtype");
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
			"FileExtension",
			"MimeContentType",
			"MimeSubtype",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @FileExtension;
				case 1: 
					return @MimeContentType;
				case 2: 
					return @MimeSubtype;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "FileExtension":  
					return @FileExtension;
				case "MimeContentType":  
					return @MimeContentType;
				case "MimeSubtype":  
					return @MimeSubtype;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 @FileExtension = (IfcLabel?)value;
					 break;
				case 1:
					 @MimeContentType = (IfcLabel?)value;
					 break;
				case 2:
					 @MimeSubtype = (IfcLabel?)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "FileExtension":
					 @FileExtension = (IfcLabel?)value;
					 break;
				case "MimeContentType":
					 @MimeContentType = (IfcLabel?)value;
					 break;
				case "MimeSubtype":
					 @MimeSubtype = (IfcLabel?)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion

		#region Where rules
		/*WR1:	WR1 : EXISTS(FileExtension) OR EXISTS(MimeContentType);*/
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