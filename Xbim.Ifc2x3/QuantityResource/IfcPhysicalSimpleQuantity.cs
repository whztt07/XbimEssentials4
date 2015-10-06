// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.QuantityResource
{
	[ExpressType("IFCPHYSICALSIMPLEQUANTITY", 101)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcPhysicalSimpleQuantity : IfcPhysicalQuantity, IEqualityComparer<@IfcPhysicalSimpleQuantity>, IEquatable<@IfcPhysicalSimpleQuantity>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPhysicalSimpleQuantity(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcNamedUnit _unit;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcNamedUnit @Unit 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _unit;
				((IPersistEntity)this).Activate(false);
				return _unit;
			} 
			set
			{
				SetValue( v =>  _unit = v, _unit, value,  "Unit");
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
					_unit = (IfcNamedUnit)(value.EntityVal);
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
        public bool Equals(@IfcPhysicalSimpleQuantity other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcPhysicalSimpleQuantity
            var root = (@IfcPhysicalSimpleQuantity)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcPhysicalSimpleQuantity left, @IfcPhysicalSimpleQuantity right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcPhysicalSimpleQuantity left, @IfcPhysicalSimpleQuantity right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcPhysicalSimpleQuantity x, @IfcPhysicalSimpleQuantity y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcPhysicalSimpleQuantity obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}