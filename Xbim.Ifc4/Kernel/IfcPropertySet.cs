// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.UtilityResource;
using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.PropertyResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.Kernel
{
	[ExpressType("IFCPROPERTYSET", 857)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcPropertySet : IfcPropertySetDefinition, IInstantiableEntity, IEqualityComparer<@IfcPropertySet>, IEquatable<@IfcPropertySet>
	{
		public static int LoadDepth = 1;

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPropertySet(IModel model) : base(model) 		{ 
			Model = model; 
			_hasProperties = new ItemSet<IfcProperty>( this );
		}

		#region Explicit attribute fields
		private ItemSet<IfcProperty> _hasProperties;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1)]
		public ItemSet<IfcProperty> @HasProperties 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _hasProperties;
				((IPersistEntity)this).Activate(false);
				return _hasProperties;
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
					if (_hasProperties == null) _hasProperties = new ItemSet<IfcProperty>( this );
					_hasProperties.InternalAdd((IfcProperty)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*ExistsName:	ExistsName : EXISTS(SELF\IfcRoot.Name);*/
		/*UniquePropertyNames:	UniquePropertyNames : IfcUniquePropertyName(HasProperties);*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcPropertySet other)
	    {
	        return this == other;
	    }


        public static bool operator ==(@IfcPropertySet left, @IfcPropertySet right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcPropertySet left, @IfcPropertySet right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcPropertySet x, @IfcPropertySet y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcPropertySet obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}