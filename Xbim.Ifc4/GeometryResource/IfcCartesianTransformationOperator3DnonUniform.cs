// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.GeometryResource
{
	[ExpressType("IFCCARTESIANTRANSFORMATIONOPERATOR3DNONUNIFORM", 474)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcCartesianTransformationOperator3DnonUniform : IfcCartesianTransformationOperator3D, IInstantiableEntity, System.Collections.Generic.IEqualityComparer<@IfcCartesianTransformationOperator3DnonUniform>, System.IEquatable<@IfcCartesianTransformationOperator3DnonUniform>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcCartesianTransformationOperator3DnonUniform(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private double? _scale2;
		private double? _scale3;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public double? @Scale2 
		{ 
			get 
			{
				if(Activated) return _scale2;
				
				Model.Activate(this, true);
				Activated = true;
				return _scale2;
			} 
			set
			{
				SetValue( v =>  _scale2 = v, _scale2, value,  "Scale2");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public double? @Scale3 
		{ 
			get 
			{
				if(Activated) return _scale3;
				
				Model.Activate(this, true);
				Activated = true;
				return _scale3;
			} 
			set
			{
				SetValue( v =>  _scale3 = v, _scale3, value,  "Scale3");
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
					_scale2 = value.RealVal;
					return;
				case 6: 
					_scale3 = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*Scale2GreaterZero:	Scale2GreaterZero : Scl2 > 0.0;*/
		/*Scale3GreaterZero:	Scale3GreaterZero : Scl3 > 0.0;*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcCartesianTransformationOperator3DnonUniform other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcCartesianTransformationOperator3DnonUniform
            var root = (@IfcCartesianTransformationOperator3DnonUniform)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcCartesianTransformationOperator3DnonUniform left, @IfcCartesianTransformationOperator3DnonUniform right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcCartesianTransformationOperator3DnonUniform left, @IfcCartesianTransformationOperator3DnonUniform right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcCartesianTransformationOperator3DnonUniform x, @IfcCartesianTransformationOperator3DnonUniform y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcCartesianTransformationOperator3DnonUniform obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}