// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.GeometricModelResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.PresentationAppearanceResource
{
	[ExpressType("IFCINDEXEDTRIANGLETEXTUREMAP", 709)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcIndexedTriangleTextureMap : IfcIndexedTextureMap, IInstantiableEntity, System.Collections.Generic.IEqualityComparer<@IfcIndexedTriangleTextureMap>, System.IEquatable<@IfcIndexedTriangleTextureMap>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcIndexedTriangleTextureMap(IModel model) : base(model) 		{ 
			Model = model; 
			_texCoordIndex = new OptionalItemSet<ItemSet<long>>( this );
		}

		#region Explicit attribute fields
		private OptionalItemSet<ItemSet<long>> _texCoordIndex;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.List, 1, -1)]
		public OptionalItemSet<ItemSet<long>> @TexCoordIndex 
		{ 
			get 
			{
				if(Activated) return _texCoordIndex;
				
				Model.Activate(this, true);
				Activated = true;
				return _texCoordIndex;
			} 
		}
	
		#endregion



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
					base.Parse(propIndex, value); 
					return;
				case 3: 
					//this is a special case which has to be handled in a partial class which is not generated.
					//ParseTexCoordIndex(propIndex, value);
					//return;
					throw new System.NotImplementedException("TexCoordIndex in IfcIndexedTriangleTextureMap is a special case of nested lists. It is not implemented for now.");
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
        public bool Equals(@IfcIndexedTriangleTextureMap other)
	    {
	        return this == other;
	    }


        public static bool operator ==(@IfcIndexedTriangleTextureMap left, @IfcIndexedTriangleTextureMap right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcIndexedTriangleTextureMap left, @IfcIndexedTriangleTextureMap right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcIndexedTriangleTextureMap x, @IfcIndexedTriangleTextureMap y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcIndexedTriangleTextureMap obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}