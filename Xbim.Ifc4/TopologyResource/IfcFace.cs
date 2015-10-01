// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.PresentationAppearanceResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.TopologyResource
{
	[ExpressType("IFCFACE", 642)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcFace : IfcTopologicalRepresentationItem, IInstantiableEntity, System.Collections.Generic.IEqualityComparer<@IfcFace>, System.IEquatable<@IfcFace>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcFace(IModel model) : base(model) 		{ 
			Model = model; 
			_bounds = new ItemSet<IfcFaceBound>( this );
		}

		#region Explicit attribute fields
		private ItemSet<IfcFaceBound> _bounds;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1)]
		public ItemSet<IfcFaceBound> @Bounds 
		{ 
			get 
			{
				if(Activated) return _bounds;
				
				Model.Activate(this, true);
				Activated = true;
				return _bounds;
			} 
		}
	
		#endregion

		#region Inverse attributes
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcTextureMap> @HasTextureMaps 
		{ 
			get 
			{
				return Model.Instances.Where<IfcTextureMap>(e => e.MappedTo == this);
			} 
		}
		#endregion


		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
					if (_bounds == null) _bounds = new ItemSet<IfcFaceBound>( this );
					_bounds.InternalAdd((IfcFaceBound)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*HasOuterBound:	HasOuterBound : SIZEOF(QUERY(temp <* Bounds | 'IFC4.IFCFACEOUTERBOUND' IN TYPEOF(temp))) <= 1;*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcFace other)
	    {
	        return this == other;
	    }


        public static bool operator ==(@IfcFace left, @IfcFace right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcFace left, @IfcFace right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcFace x, @IfcFace y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcFace obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}