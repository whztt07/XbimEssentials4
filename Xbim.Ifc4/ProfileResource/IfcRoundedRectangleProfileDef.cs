// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.GeometryResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.ProfileResource
{
	[ExpressType("IFCROUNDEDRECTANGLEPROFILEDEF", 966)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRoundedRectangleProfileDef : IfcRectangleProfileDef, IInstantiableEntity, System.Collections.Generic.IEqualityComparer<@IfcRoundedRectangleProfileDef>, System.IEquatable<@IfcRoundedRectangleProfileDef>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRoundedRectangleProfileDef(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcPositiveLengthMeasure _roundingRadius;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure @RoundingRadius 
		{ 
			get 
			{
				if(Activated) return _roundingRadius;
				
				Model.Activate(this, true);
				Activated = true;
				return _roundingRadius;
			} 
			set
			{
				SetValue( v =>  _roundingRadius = v, _roundingRadius, value,  "RoundingRadius");
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
					_roundingRadius = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*ValidRadius:                     (RoundingRadius <= (SELF\IfcRectangleProfileDef.YDim/2.)));*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcRoundedRectangleProfileDef other)
	    {
	        return this == other;
	    }


        public static bool operator ==(@IfcRoundedRectangleProfileDef left, @IfcRoundedRectangleProfileDef right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcRoundedRectangleProfileDef left, @IfcRoundedRectangleProfileDef right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcRoundedRectangleProfileDef x, @IfcRoundedRectangleProfileDef y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcRoundedRectangleProfileDef obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}