// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.GeometricModelResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.PresentationAppearanceResource
{
	[ExpressType("IFCINDEXEDTEXTUREMAP", 708)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcIndexedTextureMap : IfcTextureCoordinate, IEqualityComparer<@IfcIndexedTextureMap>, IEquatable<@IfcIndexedTextureMap>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcIndexedTextureMap(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcTessellatedFaceSet _mappedTo;
		private IfcTextureVertexList _texCoords;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcTessellatedFaceSet @MappedTo 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _mappedTo;
				((IPersistEntity)this).Activate(false);
				return _mappedTo;
			} 
			set
			{
				SetValue( v =>  _mappedTo = v, _mappedTo, value,  "MappedTo");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcTextureVertexList @TexCoords 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _texCoords;
				((IPersistEntity)this).Activate(false);
				return _texCoords;
			} 
			set
			{
				SetValue( v =>  _texCoords = v, _texCoords, value,  "TexCoords");
			} 
		}
	
		#endregion



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
					base.Parse(propIndex, value); 
					return;
				case 1: 
					_mappedTo = (IfcTessellatedFaceSet)(value.EntityVal);
					return;
				case 2: 
					_texCoords = (IfcTextureVertexList)(value.EntityVal);
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
        public bool Equals(@IfcIndexedTextureMap other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcIndexedTextureMap
            var root = (@IfcIndexedTextureMap)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcIndexedTextureMap left, @IfcIndexedTextureMap right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcIndexedTextureMap left, @IfcIndexedTextureMap right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcIndexedTextureMap x, @IfcIndexedTextureMap y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcIndexedTextureMap obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}