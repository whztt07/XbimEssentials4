// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.GeometryResource
{
	[ExpressType("IFCVECTOR", 652)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcVector : IfcGeometricRepresentationItem, IfcVectorOrDirection, IInstantiableEntity, System.Collections.Generic.IEqualityComparer<@IfcVector>, System.IEquatable<@IfcVector>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcVector(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcDirection _orientation;
		private IfcLengthMeasure _magnitude;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcDirection @Orientation 
		{ 
			get 
			{
				if(Activated) return _orientation;
				
				Model.Activate(this, true);
				Activated = true;
				return _orientation;
			} 
			set
			{
				SetValue( v =>  _orientation = v, _orientation, value,  "Orientation");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLengthMeasure @Magnitude 
		{ 
			get 
			{
				if(Activated) return _magnitude;
				
				Model.Activate(this, true);
				Activated = true;
				return _magnitude;
			} 
			set
			{
				SetValue( v =>  _magnitude = v, _magnitude, value,  "Magnitude");
			} 
		}
	
		#endregion



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
					_orientation = (IfcDirection)(value.EntityVal);
					return;
				case 1: 
					_magnitude = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR1:	WR1 : Magnitude >= 0.0;*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcVector other)
	    {
	        return this == other;
	    }


        public static bool operator ==(@IfcVector left, @IfcVector right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcVector left, @IfcVector right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcVector x, @IfcVector y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcVector obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}