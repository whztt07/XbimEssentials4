// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.GeometryResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.PresentationAppearanceResource
{
	[ExpressType("IFCONEDIRECTIONREPEATFACTOR", 32)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcOneDirectionRepeatFactor : IfcGeometricRepresentationItem, IfcHatchLineDistanceSelect, IInstantiableEntity, IEqualityComparer<@IfcOneDirectionRepeatFactor>, IEquatable<@IfcOneDirectionRepeatFactor>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcOneDirectionRepeatFactor(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcVector _repeatFactor;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcVector @RepeatFactor 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _repeatFactor;
				((IPersistEntity)this).Activate(false);
				return _repeatFactor;
			} 
			set
			{
				SetValue( v =>  _repeatFactor = v, _repeatFactor, value,  "RepeatFactor");
			} 
		}
	
		#endregion



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
					_repeatFactor = (IfcVector)(value.EntityVal);
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
        public bool Equals(@IfcOneDirectionRepeatFactor other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcOneDirectionRepeatFactor
            var root = (@IfcOneDirectionRepeatFactor)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcOneDirectionRepeatFactor left, @IfcOneDirectionRepeatFactor right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcOneDirectionRepeatFactor left, @IfcOneDirectionRepeatFactor right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcOneDirectionRepeatFactor x, @IfcOneDirectionRepeatFactor y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcOneDirectionRepeatFactor obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}