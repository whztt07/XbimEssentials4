// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		09/09/2015 04:20:36
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.GeometryResource;
using System.ComponentModel;
using System;
using Xbim.Common;

namespace Xbim.Ifc2x3.PresentationAppearanceResource
{
	[EntityName("IFCSURFACETEXTURE", 722)]
	public abstract partial class @IfcSurfaceTexture : IPersistEntity, INotifyPropertyChanged
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
		internal IfcSurfaceTexture(IModel model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private bool _repeatS;
		private bool _repeatT;
		private IfcSurfaceTextureEnum _textureType;
		private IfcCartesianTransformationOperator2D _textureTransform;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(0, EntityAttributeState.Mandatory)]
		public bool @RepeatS 
		{ 
			get 
			{
				if(Activated) return _repeatS;
				
				Model.Activate(this, true);
				Activated = true;
				return _repeatS;
			} 
			set
			{
				SetValue( v =>  _repeatS = v, _repeatS, value,  "RepeatS");
			} 
		}
	
		[EntityAttribute(1, EntityAttributeState.Mandatory)]
		public bool @RepeatT 
		{ 
			get 
			{
				if(Activated) return _repeatT;
				
				Model.Activate(this, true);
				Activated = true;
				return _repeatT;
			} 
			set
			{
				SetValue( v =>  _repeatT = v, _repeatT, value,  "RepeatT");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Mandatory)]
		public IfcSurfaceTextureEnum @TextureType 
		{ 
			get 
			{
				if(Activated) return _textureType;
				
				Model.Activate(this, true);
				Activated = true;
				return _textureType;
			} 
			set
			{
				SetValue( v =>  _textureType = v, _textureType, value,  "TextureType");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Optional)]
		public IfcCartesianTransformationOperator2D @TextureTransform 
		{ 
			get 
			{
				if(Activated) return _textureTransform;
				
				Model.Activate(this, true);
				Activated = true;
				return _textureTransform;
			} 
			set
			{
				SetValue( v =>  _textureTransform = v, _textureTransform, value,  "TextureTransform");
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


		#region IPersist implementation
		#endregion

		public virtual string WhereRule() 
		{
			return "";
		}
	}
}