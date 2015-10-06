// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.PresentationDefinitionResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.PresentationAppearanceResource
{
	[ExpressType("IFCSURFACESTYLEWITHTEXTURES", 1064)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcSurfaceStyleWithTextures : IfcPresentationItem, IfcSurfaceStyleElementSelect, IInstantiableEntity, IEqualityComparer<@IfcSurfaceStyleWithTextures>, IEquatable<@IfcSurfaceStyleWithTextures>
	{
		public static int LoadDepth = 1;

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcSurfaceStyleWithTextures(IModel model) : base(model) 		{ 
			Model = model; 
			_textures = new ItemSet<IfcSurfaceTexture>( this );
		}

		#region Explicit attribute fields
		private ItemSet<IfcSurfaceTexture> _textures;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.Class, 1, -1)]
		public ItemSet<IfcSurfaceTexture> @Textures 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _textures;
				((IPersistEntity)this).Activate(false);
				return _textures;
			} 
		}
	
		#endregion



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
					if (_textures == null) _textures = new ItemSet<IfcSurfaceTexture>( this );
					_textures.InternalAdd((IfcSurfaceTexture)value.EntityVal);
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
        public bool Equals(@IfcSurfaceStyleWithTextures other)
	    {
	        return this == other;
	    }


        public static bool operator ==(@IfcSurfaceStyleWithTextures left, @IfcSurfaceStyleWithTextures right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcSurfaceStyleWithTextures left, @IfcSurfaceStyleWithTextures right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcSurfaceStyleWithTextures x, @IfcSurfaceStyleWithTextures y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcSurfaceStyleWithTextures obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}