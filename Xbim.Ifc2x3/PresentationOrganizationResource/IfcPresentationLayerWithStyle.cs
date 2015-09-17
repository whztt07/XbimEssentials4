// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 10:20:59
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.PresentationAppearanceResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.PresentationOrganizationResource
{
	[EntityName("IFCPRESENTATIONLAYERWITHSTYLE", 259)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcPresentationLayerWithStyle : IfcPresentationLayerAssignment, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPresentationLayerWithStyle(IModel model) : base(model) 		{ 
			Model = model; 
			_layerStyles = new ItemSet<IfcPresentationStyleSelect>( this );
		}

		#region Explicit attribute fields
		private bool? _layerOn;
		private bool? _layerFrozen;
		private bool? _layerBlocked;
		private ItemSet<IfcPresentationStyleSelect> _layerStyles;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Mandatory)]
		public bool? @LayerOn 
		{ 
			get 
			{
				if(Activated) return _layerOn;
				
				Model.Activate(this, true);
				Activated = true;
				return _layerOn;
			} 
			set
			{
				SetValue( v =>  _layerOn = v, _layerOn, value,  "LayerOn");
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Mandatory)]
		public bool? @LayerFrozen 
		{ 
			get 
			{
				if(Activated) return _layerFrozen;
				
				Model.Activate(this, true);
				Activated = true;
				return _layerFrozen;
			} 
			set
			{
				SetValue( v =>  _layerFrozen = v, _layerFrozen, value,  "LayerFrozen");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Mandatory)]
		public bool? @LayerBlocked 
		{ 
			get 
			{
				if(Activated) return _layerBlocked;
				
				Model.Activate(this, true);
				Activated = true;
				return _layerBlocked;
			} 
			set
			{
				SetValue( v =>  _layerBlocked = v, _layerBlocked, value,  "LayerBlocked");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Mandatory)]
		public ItemSet<IfcPresentationStyleSelect> @LayerStyles 
		{ 
			get 
			{
				if(Activated) return _layerStyles;
				
				Model.Activate(this, true);
				Activated = true;
				return _layerStyles;
			} 
			set
			{
				SetValue( v =>  _layerStyles = v, _layerStyles, value,  "LayerStyles");
			} 
		}
	
		#endregion

		#region Inverse attributes

		#endregion

		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
				case 3: 
					base.Parse(propIndex, value); 
					return;
				case 4: 
					_layerOn = value.BooleanVal;
					return;
				case 5: 
					_layerFrozen = value.BooleanVal;
					return;
				case 6: 
					_layerBlocked = value.BooleanVal;
					return;
				case 7: 
					if (_layerStyles == null) _layerStyles = new ItemSet<IfcPresentationStyleSelect>( this );
					_layerStyles.InternalAdd((IfcPresentationStyleSelect)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
			return "";
		}
		#endregion
	}
}