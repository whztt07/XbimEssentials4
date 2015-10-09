// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.ProductExtension;
using Xbim.Ifc2x3.UtilityResource;
using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.GeometricConstraintResource;
using Xbim.Ifc2x3.RepresentationResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.SharedBldgElements
{
	[ExpressType("IFCSTAIR", 346)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcStair : IfcBuildingElement, IInstantiableEntity, IEqualityComparer<@IfcStair>, IEquatable<@IfcStair>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcStair(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcStairTypeEnum _shapeType;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(9, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcStairTypeEnum @ShapeType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _shapeType;
				((IPersistEntity)this).Activate(false);
				return _shapeType;
			} 
			set
			{
				SetValue( v =>  _shapeType = v, _shapeType, value,  "ShapeType");
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
				case 2: 
				case 3: 
				case 4: 
				case 5: 
				case 6: 
				case 7: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 8: 
                    _shapeType = (IfcStairTypeEnum) System.Enum.Parse(typeof (IfcStairTypeEnum), value.EnumVal, true);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR1:            ((HIINDEX(SELF\IfcObjectDefinition.IsDecomposedBy) = 1) AND (NOT(EXISTS(SELF\IfcProduct.Representation))));*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcStair other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcStair
            var root = (@IfcStair)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcStair left, @IfcStair right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcStair left, @IfcStair right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcStair x, @IfcStair y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcStair obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}