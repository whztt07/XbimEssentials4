// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.StructuralLoadResource
{
	[ExpressType("IFCSTRUCTURALLOADCONFIGURATION", 1024)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcStructuralLoadConfiguration : IfcStructuralLoad, IInstantiableEntity, System.Collections.Generic.IEqualityComparer<@IfcStructuralLoadConfiguration>, System.IEquatable<@IfcStructuralLoadConfiguration>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcStructuralLoadConfiguration(IModel model) : base(model) 		{ 
			Model = model; 
			_values = new ItemSet<IfcStructuralLoadOrResult>( this );
			_locations = new OptionalItemSet<ItemSet<IfcLengthMeasure>>( this );
		}

		#region Explicit attribute fields
		private ItemSet<IfcStructuralLoadOrResult> _values;
		private OptionalItemSet<ItemSet<IfcLengthMeasure>> _locations;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.Class, 1, -1)]
		public ItemSet<IfcStructuralLoadOrResult> @Values 
		{ 
			get 
			{
				if(Activated) return _values;
				
				Model.Activate(this, true);
				Activated = true;
				return _values;
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.List, 1, -1)]
		public OptionalItemSet<ItemSet<IfcLengthMeasure>> @Locations 
		{ 
			get 
			{
				if(Activated) return _locations;
				
				Model.Activate(this, true);
				Activated = true;
				return _locations;
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
					if (_values == null) _values = new ItemSet<IfcStructuralLoadOrResult>( this );
					_values.InternalAdd((IfcStructuralLoadOrResult)value.EntityVal);
					return;
				case 2: 
					//this is a special case which has to be handled in a partial class which is not generated.
					//ParseLocations(propIndex, value);
					//return;
					throw new System.NotImplementedException("Locations in IfcStructuralLoadConfiguration is a special case of nested lists. It is not implemented for now.");
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*ValidListSize:	ValidListSize : NOT EXISTS(Locations) OR (SIZEOF(Locations) = SIZEOF(Values));*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcStructuralLoadConfiguration other)
	    {
	        return this == other;
	    }


        public static bool operator ==(@IfcStructuralLoadConfiguration left, @IfcStructuralLoadConfiguration right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcStructuralLoadConfiguration left, @IfcStructuralLoadConfiguration right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcStructuralLoadConfiguration x, @IfcStructuralLoadConfiguration y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcStructuralLoadConfiguration obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}