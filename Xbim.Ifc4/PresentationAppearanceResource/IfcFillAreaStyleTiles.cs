// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.GeometryResource;
using Xbim.Ifc4.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.PresentationAppearanceResource
{
	[ExpressType("IFCFILLAREASTYLETILES", 659)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcFillAreaStyleTiles : IfcGeometricRepresentationItem, IfcFillStyleSelect, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcFillAreaStyleTiles(IModel model) : base(model) 		{ 
			Model = model; 
			_tilingPattern = new ItemSet<IfcVector>( this );
			_tiles = new ItemSet<IfcStyledItem>( this );
		}

		#region Explicit attribute fields
		private ItemSet<IfcVector> _tilingPattern;
		private ItemSet<IfcStyledItem> _tiles;
		private IfcPositiveRatioMeasure _tilingScale;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.Class, 2, 2)]
		public ItemSet<IfcVector> @TilingPattern 
		{ 
			get 
			{
				if(Activated) return _tilingPattern;
				
				Model.Activate(this, true);
				Activated = true;
				return _tilingPattern;
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1)]
		public ItemSet<IfcStyledItem> @Tiles 
		{ 
			get 
			{
				if(Activated) return _tiles;
				
				Model.Activate(this, true);
				Activated = true;
				return _tiles;
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveRatioMeasure @TilingScale 
		{ 
			get 
			{
				if(Activated) return _tilingScale;
				
				Model.Activate(this, true);
				Activated = true;
				return _tilingScale;
			} 
			set
			{
				SetValue( v =>  _tilingScale = v, _tilingScale, value,  "TilingScale");
			} 
		}
	
		#endregion



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
					if (_tilingPattern == null) _tilingPattern = new ItemSet<IfcVector>( this );
					_tilingPattern.InternalAdd((IfcVector)value.EntityVal);
					return;
				case 1: 
					if (_tiles == null) _tiles = new ItemSet<IfcStyledItem>( this );
					_tiles.InternalAdd((IfcStyledItem)value.EntityVal);
					return;
				case 2: 
					_tilingScale = value.RealVal;
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