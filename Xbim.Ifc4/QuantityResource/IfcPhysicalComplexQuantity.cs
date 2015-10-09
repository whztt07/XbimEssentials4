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

namespace Xbim.Ifc4.QuantityResource
{
	[ExpressType("IFCPHYSICALCOMPLEXQUANTITY", 799)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcPhysicalComplexQuantity : IfcPhysicalQuantity, IInstantiableEntity, IEqualityComparer<@IfcPhysicalComplexQuantity>, IEquatable<@IfcPhysicalComplexQuantity>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPhysicalComplexQuantity(IModel model) : base(model) 		{ 
			Model = model; 
			_hasQuantities = new ItemSet<IfcPhysicalQuantity>( this, 0 );
		}

		#region Explicit attribute fields
		private ItemSet<IfcPhysicalQuantity> _hasQuantities;
		private IfcLabel _discrimination;
		private IfcLabel? _quality;
		private IfcLabel? _usage;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1)]
		public ItemSet<IfcPhysicalQuantity> @HasQuantities 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _hasQuantities;
				((IPersistEntity)this).Activate(false);
				return _hasQuantities;
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel @Discrimination 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _discrimination;
				((IPersistEntity)this).Activate(false);
				return _discrimination;
			} 
			set
			{
				SetValue( v =>  _discrimination = v, _discrimination, value,  "Discrimination");
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel? @Quality 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _quality;
				((IPersistEntity)this).Activate(false);
				return _quality;
			} 
			set
			{
				SetValue( v =>  _quality = v, _quality, value,  "Quality");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel? @Usage 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _usage;
				((IPersistEntity)this).Activate(false);
				return _usage;
			} 
			set
			{
				SetValue( v =>  _usage = v, _usage, value,  "Usage");
			} 
		}
	
		#endregion



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 2: 
					if (_hasQuantities == null) _hasQuantities = new ItemSet<IfcPhysicalQuantity>( this );
					_hasQuantities.InternalAdd((IfcPhysicalQuantity)value.EntityVal);
					return;
				case 3: 
					_discrimination = value.StringVal;
					return;
				case 4: 
					_quality = value.StringVal;
					return;
				case 5: 
					_usage = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*NoSelfReference:	NoSelfReference : SIZEOF(QUERY(temp <* HasQuantities | SELF :=: temp)) = 0;*/
		/*UniqueQuantityNames:	UniqueQuantityNames : IfcUniqueQuantityNames(HasQuantities);*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcPhysicalComplexQuantity other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcPhysicalComplexQuantity
            var root = (@IfcPhysicalComplexQuantity)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcPhysicalComplexQuantity left, @IfcPhysicalComplexQuantity right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcPhysicalComplexQuantity left, @IfcPhysicalComplexQuantity right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcPhysicalComplexQuantity x, @IfcPhysicalComplexQuantity y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcPhysicalComplexQuantity obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}