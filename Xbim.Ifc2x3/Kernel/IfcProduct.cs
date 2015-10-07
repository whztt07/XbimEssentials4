// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.GeometricConstraintResource;
using Xbim.Ifc2x3.RepresentationResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.Kernel
{
	[ExpressType("IFCPRODUCT", 20)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcProduct : IfcObject, IEqualityComparer<@IfcProduct>, IEquatable<@IfcProduct>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcProduct(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcObjectPlacement _objectPlacement;
		private IfcProductRepresentation _representation;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcObjectPlacement @ObjectPlacement 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _objectPlacement;
				((IPersistEntity)this).Activate(false);
				return _objectPlacement;
			} 
			set
			{
				SetValue( v =>  _objectPlacement = v, _objectPlacement, value,  "ObjectPlacement");
			} 
		}
	
		[IndexedProperty]
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcProductRepresentation @Representation 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _representation;
				((IPersistEntity)this).Activate(false);
				return _representation;
			} 
			set
			{
				SetValue( v =>  _representation = v, _representation, value,  "Representation");
			} 
		}
	
		#endregion

		#region Inverse attributes
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcRelAssignsToProduct> @ReferencedBy 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelAssignsToProduct>(e => (e.RelatingProduct as IfcProduct) == this);
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
				case 3: 
				case 4: 
					base.Parse(propIndex, value); 
					return;
				case 5: 
					_objectPlacement = (IfcObjectPlacement)(value.EntityVal);
					return;
				case 6: 
					_representation = (IfcProductRepresentation)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR1:                        OR (NOT(EXISTS(Representation)));*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcProduct other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcProduct
            var root = (@IfcProduct)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcProduct left, @IfcProduct right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcProduct left, @IfcProduct right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcProduct x, @IfcProduct y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcProduct obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}