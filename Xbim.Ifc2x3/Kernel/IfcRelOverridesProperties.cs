// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.UtilityResource;
using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.PropertyResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.Kernel
{
	[ExpressType("IFCRELOVERRIDESPROPERTIES", 248)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRelOverridesProperties : IfcRelDefinesByProperties, IInstantiableEntity, IEqualityComparer<@IfcRelOverridesProperties>, IEquatable<@IfcRelOverridesProperties>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelOverridesProperties(IModel model) : base(model) 		{ 
			Model = model; 
			_overridingProperties = new ItemSet<IfcProperty>( this );
		}

		#region Explicit attribute fields
		private ItemSet<IfcProperty> _overridingProperties;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1)]
		public ItemSet<IfcProperty> @OverridingProperties 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _overridingProperties;
				((IPersistEntity)this).Activate(false);
				return _overridingProperties;
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
				case 5: 
					base.Parse(propIndex, value); 
					return;
				case 6: 
					if (_overridingProperties == null) _overridingProperties = new ItemSet<IfcProperty>( this );
					_overridingProperties.InternalAdd((IfcProperty)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR1:	WR1 : SIZEOF(SELF\IfcRelDefines.RelatedObjects) = 1;*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcRelOverridesProperties other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcRelOverridesProperties
            var root = (@IfcRelOverridesProperties)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcRelOverridesProperties left, @IfcRelOverridesProperties right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcRelOverridesProperties left, @IfcRelOverridesProperties right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcRelOverridesProperties x, @IfcRelOverridesProperties y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcRelOverridesProperties obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}