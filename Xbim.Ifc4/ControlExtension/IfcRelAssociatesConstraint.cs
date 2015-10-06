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
using Xbim.Ifc4.ConstraintResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.ControlExtension
{
	[ExpressType("IFCRELASSOCIATESCONSTRAINT", 913)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRelAssociatesConstraint : IfcRelAssociates, IInstantiableEntity, IEqualityComparer<@IfcRelAssociatesConstraint>, IEquatable<@IfcRelAssociatesConstraint>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelAssociatesConstraint(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcLabel? _intent;
		private IfcConstraint _relatingConstraint;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel? @Intent 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _intent;
				((IPersistEntity)this).Activate(false);
				return _intent;
			} 
			set
			{
				SetValue( v =>  _intent = v, _intent, value,  "Intent");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcConstraint @RelatingConstraint 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _relatingConstraint;
				((IPersistEntity)this).Activate(false);
				return _relatingConstraint;
			} 
			set
			{
				SetValue( v =>  _relatingConstraint = v, _relatingConstraint, value,  "RelatingConstraint");
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
					_intent = value.StringVal;
					return;
				case 6: 
					_relatingConstraint = (IfcConstraint)(value.EntityVal);
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
        public bool Equals(@IfcRelAssociatesConstraint other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcRelAssociatesConstraint
            var root = (@IfcRelAssociatesConstraint)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcRelAssociatesConstraint left, @IfcRelAssociatesConstraint right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcRelAssociatesConstraint left, @IfcRelAssociatesConstraint right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcRelAssociatesConstraint x, @IfcRelAssociatesConstraint y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcRelAssociatesConstraint obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}