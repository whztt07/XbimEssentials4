// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.SharedBldgServiceElements;
using Xbim.Ifc4.UtilityResource;
using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.GeometricConstraintResource;
using Xbim.Ifc4.RepresentationResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.HvacDomain
{
	[ExpressType("IFCUNITARYEQUIPMENT", 1125)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcUnitaryEquipment : IfcEnergyConversionDevice, IInstantiableEntity, System.Collections.Generic.IEqualityComparer<@IfcUnitaryEquipment>, System.IEquatable<@IfcUnitaryEquipment>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcUnitaryEquipment(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcUnitaryEquipmentTypeEnum? _predefinedType;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcUnitaryEquipmentTypeEnum? @PredefinedType 
		{ 
			get 
			{
				if(Activated) return _predefinedType;
				
				Model.Activate(this, true);
				Activated = true;
				return _predefinedType;
			} 
			set
			{
				SetValue( v =>  _predefinedType = v, _predefinedType, value,  "PredefinedType");
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
                    _predefinedType = (IfcUnitaryEquipmentTypeEnum) System.Enum.Parse(typeof (IfcUnitaryEquipmentTypeEnum), value.EnumVal, true);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*CorrectPredefinedType:                               ((PredefinedType = IfcUnitaryEquipmentTypeEnum.USERDEFINED) AND EXISTS (SELF\IfcObject.ObjectType));*/
		/*CorrectTypeAssigned:                                ('IFC4.IFCUNITARYEQUIPMENTTYPE' IN TYPEOF(SELF\IfcObject.IsTypedBy[1].RelatingType));*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcUnitaryEquipment other)
	    {
	        return this == other;
	    }


        public static bool operator ==(@IfcUnitaryEquipment left, @IfcUnitaryEquipment right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcUnitaryEquipment left, @IfcUnitaryEquipment right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcUnitaryEquipment x, @IfcUnitaryEquipment y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcUnitaryEquipment obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}