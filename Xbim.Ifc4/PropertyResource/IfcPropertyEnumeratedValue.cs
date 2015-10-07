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

namespace Xbim.Ifc4.PropertyResource
{
	[ExpressType("IFCPROPERTYENUMERATEDVALUE", 853)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcPropertyEnumeratedValue : IfcSimpleProperty, IInstantiableEntity, IEqualityComparer<@IfcPropertyEnumeratedValue>, IEquatable<@IfcPropertyEnumeratedValue>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPropertyEnumeratedValue(IModel model) : base(model) 		{ 
			Model = model; 
			_enumerationValues = new OptionalItemSet<IfcValue>( this, 0 );
		}

		#region Explicit attribute fields
		private OptionalItemSet<IfcValue> _enumerationValues;
		private IfcPropertyEnumeration _enumerationReference;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.Class, 1, -1)]
		public OptionalItemSet<IfcValue> @EnumerationValues 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _enumerationValues;
				((IPersistEntity)this).Activate(false);
				return _enumerationValues;
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcPropertyEnumeration @EnumerationReference 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _enumerationReference;
				((IPersistEntity)this).Activate(false);
				return _enumerationReference;
			} 
			set
			{
				SetValue( v =>  _enumerationReference = v, _enumerationReference, value,  "EnumerationReference");
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
					base.Parse(propIndex, value); 
					return;
				case 2: 
					if (_enumerationValues == null) _enumerationValues = new OptionalItemSet<IfcValue>( this );
					_enumerationValues.InternalAdd((IfcValue)value.EntityVal);
					return;
				case 3: 
					_enumerationReference = (IfcPropertyEnumeration)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR21:                 = SIZEOF(EnumerationValues));*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcPropertyEnumeratedValue other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcPropertyEnumeratedValue
            var root = (@IfcPropertyEnumeratedValue)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcPropertyEnumeratedValue left, @IfcPropertyEnumeratedValue right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcPropertyEnumeratedValue left, @IfcPropertyEnumeratedValue right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcPropertyEnumeratedValue x, @IfcPropertyEnumeratedValue y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcPropertyEnumeratedValue obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}