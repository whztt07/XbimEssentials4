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

namespace Xbim.Ifc4.ElectricalDomain
{
	[ExpressType("IFCELECTRICFLOWSTORAGEDEVICE", 602)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcElectricFlowStorageDevice : IfcFlowStorageDevice, IInstantiableEntity, System.Collections.Generic.IEqualityComparer<@IfcElectricFlowStorageDevice>, System.IEquatable<@IfcElectricFlowStorageDevice>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcElectricFlowStorageDevice(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcElectricFlowStorageDeviceTypeEnum? _predefinedType;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcElectricFlowStorageDeviceTypeEnum? @PredefinedType 
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
                    _predefinedType = (IfcElectricFlowStorageDeviceTypeEnum) System.Enum.Parse(typeof (IfcElectricFlowStorageDeviceTypeEnum), value.EnumVal, true);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*CorrectPredefinedType:                               ((PredefinedType = IfcElectricFlowStorageDeviceTypeEnum.USERDEFINED) AND EXISTS (SELF\IfcObject.ObjectType));*/
		/*CorrectTypeAssigned:                                ('IFC4.IFCELECTRICFLOWSTORAGEDEVICETYPE' IN TYPEOF(SELF\IfcObject.IsTypedBy[1].RelatingType));*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcElectricFlowStorageDevice other)
	    {
	        return this == other;
	    }


        public static bool operator ==(@IfcElectricFlowStorageDevice left, @IfcElectricFlowStorageDevice right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcElectricFlowStorageDevice left, @IfcElectricFlowStorageDevice right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcElectricFlowStorageDevice x, @IfcElectricFlowStorageDevice y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcElectricFlowStorageDevice obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}