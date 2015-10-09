// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.ProfileResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.GeometryResource
{
	[ExpressType("IFCSURFACEOFREVOLUTION", 109)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcSurfaceOfRevolution : IfcSweptSurface, IInstantiableEntity, IEqualityComparer<@IfcSurfaceOfRevolution>, IEquatable<@IfcSurfaceOfRevolution>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcSurfaceOfRevolution(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcAxis1Placement _axisPosition;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcAxis1Placement @AxisPosition 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _axisPosition;
				((IPersistEntity)this).Activate(false);
				return _axisPosition;
			} 
			set
			{
				SetValue( v =>  _axisPosition = v, _axisPosition, value,  "AxisPosition");
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
					_axisPosition = (IfcAxis1Placement)(value.EntityVal);
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
        public bool Equals(@IfcSurfaceOfRevolution other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcSurfaceOfRevolution
            var root = (@IfcSurfaceOfRevolution)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcSurfaceOfRevolution left, @IfcSurfaceOfRevolution right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcSurfaceOfRevolution left, @IfcSurfaceOfRevolution right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcSurfaceOfRevolution x, @IfcSurfaceOfRevolution y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcSurfaceOfRevolution obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}