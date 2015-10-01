// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.GeometryResource;
using Xbim.Ifc2x3.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.PresentationAppearanceResource
{
	[ExpressType("IFCFILLAREASTYLETILES", 725)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcFillAreaStyleTiles : IfcGeometricRepresentationItem, IfcFillStyleSelect, IInstantiableEntity, System.Collections.Generic.IEqualityComparer<@IfcFillAreaStyleTiles>, System.IEquatable<@IfcFillAreaStyleTiles>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcFillAreaStyleTiles(IModel model) : base(model) 		{ 
			Model = model; 
			_tiles = new ItemSet<IfcFillAreaStyleTileShapeSelect>( this );
		}

		#region Explicit attribute fields
		private IfcOneDirectionRepeatFactor _tilingPattern;
		private ItemSet<IfcFillAreaStyleTileShapeSelect> _tiles;
		private IfcPositiveRatioMeasure _tilingScale;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcOneDirectionRepeatFactor @TilingPattern 
		{ 
			get 
			{
				if(Activated) return _tilingPattern;
				
				Model.Activate(this, true);
				Activated = true;
				return _tilingPattern;
			} 
			set
			{
				SetValue( v =>  _tilingPattern = v, _tilingPattern, value,  "TilingPattern");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1)]
		public ItemSet<IfcFillAreaStyleTileShapeSelect> @Tiles 
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
					_tilingPattern = (IfcOneDirectionRepeatFactor)(value.EntityVal);
					return;
				case 1: 
					if (_tiles == null) _tiles = new ItemSet<IfcFillAreaStyleTileShapeSelect>( this );
					_tiles.InternalAdd((IfcFillAreaStyleTileShapeSelect)value.EntityVal);
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

		#region Equality comparers and operators
        public bool Equals(@IfcFillAreaStyleTiles other)
	    {
	        return this == other;
	    }


        public static bool operator ==(@IfcFillAreaStyleTiles left, @IfcFillAreaStyleTiles right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcFillAreaStyleTiles left, @IfcFillAreaStyleTiles right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcFillAreaStyleTiles x, @IfcFillAreaStyleTiles y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcFillAreaStyleTiles obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}