// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.GeometricModelResource
{
	[ExpressType("IFCTRIANGULATEDFACESET", 1113)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcTriangulatedFaceSet : IfcTessellatedFaceSet, IInstantiableEntity, IEqualityComparer<@IfcTriangulatedFaceSet>, IEquatable<@IfcTriangulatedFaceSet>
	{
		public static int LoadDepth = 1;

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTriangulatedFaceSet(IModel model) : base(model) 		{ 
			Model = model; 
			_coordIndex = new ItemSet<ItemSet<long>>( this );
			_normalIndex = new OptionalItemSet<ItemSet<long>>( this );
		}

		#region Explicit attribute fields
		private ItemSet<ItemSet<long>> _coordIndex;
		private OptionalItemSet<ItemSet<long>> _normalIndex;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.List, 1, -1)]
		public ItemSet<ItemSet<long>> @CoordIndex 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _coordIndex;
				((IPersistEntity)this).Activate(false);
				return _coordIndex;
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.List, 1, -1)]
		public OptionalItemSet<ItemSet<long>> @NormalIndex 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _normalIndex;
				((IPersistEntity)this).Activate(false);
				return _normalIndex;
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
					//ParseCoordIndex(propIndex, value);
					//return;
					throw new System.NotImplementedException("CoordIndex in IfcTriangulatedFaceSet is a special case of nested lists. It is not implemented for now.");
				case 4: 
					//this is a special case which has to be handled in a partial class which is not generated.
					//ParseNormalIndex(propIndex, value);
					//return;
					throw new System.NotImplementedException("NormalIndex in IfcTriangulatedFaceSet is a special case of nested lists. It is not implemented for now.");
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
        public bool Equals(@IfcTriangulatedFaceSet other)
	    {
	        return this == other;
	    }


        public static bool operator ==(@IfcTriangulatedFaceSet left, @IfcTriangulatedFaceSet right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcTriangulatedFaceSet left, @IfcTriangulatedFaceSet right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcTriangulatedFaceSet x, @IfcTriangulatedFaceSet y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcTriangulatedFaceSet obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}