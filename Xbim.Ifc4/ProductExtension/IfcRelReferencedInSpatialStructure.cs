// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Kernel;
using Xbim.Ifc4.UtilityResource;
using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.ProductExtension
{
	[ExpressType("IFCRELREFERENCEDINSPATIALSTRUCTURE", 941)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRelReferencedInSpatialStructure : IfcRelConnects, IInstantiableEntity, IEqualityComparer<@IfcRelReferencedInSpatialStructure>, IEquatable<@IfcRelReferencedInSpatialStructure>
	{
		public static int LoadDepth = 1;

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelReferencedInSpatialStructure(IModel model) : base(model) 		{ 
			Model = model; 
			_relatedElements = new ItemSet<IfcProduct>( this );
		}

		#region Explicit attribute fields
		private ItemSet<IfcProduct> _relatedElements;
		private IfcSpatialElement _relatingStructure;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1)]
		public ItemSet<IfcProduct> @RelatedElements 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _relatedElements;
				((IPersistEntity)this).Activate(false);
				return _relatedElements;
			} 
		}
	
		[IndexedProperty]
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcSpatialElement @RelatingStructure 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _relatingStructure;
				((IPersistEntity)this).Activate(false);
				return _relatingStructure;
			} 
			set
			{
				SetValue( v =>  _relatingStructure = v, _relatingStructure, value,  "RelatingStructure");
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
					base.Parse(propIndex, value); 
					return;
				case 4: 
					if (_relatedElements == null) _relatedElements = new ItemSet<IfcProduct>( this );
					_relatedElements.InternalAdd((IfcProduct)value.EntityVal);
					return;
				case 5: 
					_relatingStructure = (IfcSpatialElement)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR31:	WR31 : SIZEOF(QUERY(temp <* RelatedElements | 'IFC4.IFCSPATIALSTRUCTUREELEMENT' IN TYPEOF(temp))) = 0;*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcRelReferencedInSpatialStructure other)
	    {
	        return this == other;
	    }


        public static bool operator ==(@IfcRelReferencedInSpatialStructure left, @IfcRelReferencedInSpatialStructure right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcRelReferencedInSpatialStructure left, @IfcRelReferencedInSpatialStructure right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcRelReferencedInSpatialStructure x, @IfcRelReferencedInSpatialStructure y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcRelReferencedInSpatialStructure obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}