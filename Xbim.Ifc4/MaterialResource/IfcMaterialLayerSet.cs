// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		21.09.2015 05:11:19
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.MaterialResource
{
	[IndexedClass]
	[ExpressType("IFCMATERIALLAYERSET", 748)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcMaterialLayerSet : IfcMaterialDefinition, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcMaterialLayerSet(IModel model) : base(model) 		{ 
			Model = model; 
			_materialLayers = new ItemSet<IfcMaterialLayer>( this );
		}

		#region Explicit attribute fields
		private ItemSet<IfcMaterialLayer> _materialLayers;
		private IfcLabel? _layerSetName;
		private IfcText? _description;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.Class, 1, -1)]
		public ItemSet<IfcMaterialLayer> @MaterialLayers 
		{ 
			get 
			{
				if(Activated) return _materialLayers;
				
				Model.Activate(this, true);
				Activated = true;
				return _materialLayers;
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel? @LayerSetName 
		{ 
			get 
			{
				if(Activated) return _layerSetName;
				
				Model.Activate(this, true);
				Activated = true;
				return _layerSetName;
			} 
			set
			{
				SetValue( v =>  _layerSetName = v, _layerSetName, value,  "LayerSetName");
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
	
		#endregion

		#region Inverse attributes

		#endregion

		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
					if (_materialLayers == null) _materialLayers = new ItemSet<IfcMaterialLayer>( this );
					_materialLayers.InternalAdd((IfcMaterialLayer)value.EntityVal);
					return;
				case 1: 
					_layerSetName = value.StringVal;
					return;
				case 2: 
					_description = value.StringVal;
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