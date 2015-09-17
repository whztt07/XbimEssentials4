// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 03:43:58
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.GeometryResource;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.PresentationDefinitionResource
{
	[EntityName("IFCVERTEXBASEDTEXTUREMAP", 736)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcVertexBasedTextureMap : IPersistEntity, INotifyPropertyChanged, IInstantiableEntity
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
		internal IfcVertexBasedTextureMap(IModel model) 		{ 
			Model = model; 
			_textureVertices = new ItemSet<IfcTextureVertex>( this );
			_texturePoints = new ItemSet<IfcCartesianPoint>( this );
		}

		#region Explicit attribute fields
		private ItemSet<IfcTextureVertex> _textureVertices;
		private ItemSet<IfcCartesianPoint> _texturePoints;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(0, EntityAttributeState.Mandatory)]
		public ItemSet<IfcTextureVertex> @TextureVertices 
		{ 
			get 
			{
				if(Activated) return _textureVertices;
				
				Model.Activate(this, true);
				Activated = true;
				return _textureVertices;
			} 
			set
			{
				SetValue( v =>  _textureVertices = v, _textureVertices, value,  "TextureVertices");
			} 
		}
	
		[EntityAttribute(1, EntityAttributeState.Mandatory)]
		public ItemSet<IfcCartesianPoint> @TexturePoints 
		{ 
			get 
			{
				if(Activated) return _texturePoints;
				
				Model.Activate(this, true);
				Activated = true;
				return _texturePoints;
			} 
			set
			{
				SetValue( v =>  _texturePoints = v, _texturePoints, value,  "TexturePoints");
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
					if (_textureVertices == null) _textureVertices = new ItemSet<IfcTextureVertex>( this );
					_textureVertices.InternalAdd((IfcTextureVertex)value.EntityVal);
					return;
				case 1: 
					if (_texturePoints == null) _texturePoints = new ItemSet<IfcCartesianPoint>( this );
					_texturePoints.InternalAdd((IfcCartesianPoint)value.EntityVal);
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
	}
}