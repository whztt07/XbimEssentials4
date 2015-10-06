// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.PresentationDefinitionResource;
using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.PresentationAppearanceResource
{
	[ExpressType("IFCTEXTUREVERTEXLIST", 1102)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcTextureVertexList : IfcPresentationItem, IInstantiableEntity, IEqualityComparer<@IfcTextureVertexList>, IEquatable<@IfcTextureVertexList>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTextureVertexList(IModel model) : base(model) 		{ 
			Model = model; 
			_texCoordsList = new ItemSet<ItemSet<IfcParameterValue>>( this );
		}

		#region Explicit attribute fields
		private ItemSet<ItemSet<IfcParameterValue>> _texCoordsList;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.List, 1, -1)]
		public ItemSet<ItemSet<IfcParameterValue>> @TexCoordsList 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _texCoordsList;
				((IPersistEntity)this).Activate(false);
				return _texCoordsList;
			} 
		}
	
		#endregion



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
					//this is a special case which has to be handled in a partial class which is not generated.
					//ParseTexCoordsList(propIndex, value);
					//return;
					throw new System.NotImplementedException("TexCoordsList in IfcTextureVertexList is a special case of nested lists. It is not implemented for now.");
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
        public bool Equals(@IfcTextureVertexList other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcTextureVertexList
            var root = (@IfcTextureVertexList)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcTextureVertexList left, @IfcTextureVertexList right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcTextureVertexList left, @IfcTextureVertexList right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcTextureVertexList x, @IfcTextureVertexList y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcTextureVertexList obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}