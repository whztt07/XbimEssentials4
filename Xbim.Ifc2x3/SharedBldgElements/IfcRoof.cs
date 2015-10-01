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
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.SharedBldgElements
{
	[ExpressType("IFCROOF", 347)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRoof : IfcBuildingElement, IInstantiableEntity, System.Collections.Generic.IEqualityComparer<@IfcRoof>, System.IEquatable<@IfcRoof>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRoof(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcRoofTypeEnum _shapeType;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(9, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcRoofTypeEnum @ShapeType 
		{ 
			get 
			{
				if(Activated) return _shapeType;
				
				Model.Activate(this, true);
				Activated = true;
				return _shapeType;
			} 
			set
			{
				SetValue( v =>  _shapeType = v, _shapeType, value,  "ShapeType");
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
				case 5: 
				case 6: 
				case 7: 
					base.Parse(propIndex, value); 
					return;
				case 8: 
                    _shapeType = (IfcRoofTypeEnum) System.Enum.Parse(typeof (IfcRoofTypeEnum), value.EnumVal, true);
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
        public bool Equals(@IfcRoof other)
	    {
	        return this == other;
	    }


        public static bool operator ==(@IfcRoof left, @IfcRoof right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcRoof left, @IfcRoof right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcRoof x, @IfcRoof y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcRoof obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}