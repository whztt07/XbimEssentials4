// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.UtilityResource;
using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.Kernel;
using Xbim.Ifc4.GeometryResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.StructuralElementsDomain
{
	[ExpressType("IFCTENDONTYPE", 1089)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcTendonType : IfcReinforcingElementType, IInstantiableEntity, System.Collections.Generic.IEqualityComparer<@IfcTendonType>, System.IEquatable<@IfcTendonType>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTendonType(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcTendonTypeEnum _predefinedType;
		private IfcPositiveLengthMeasure? _nominalDiameter;
		private IfcAreaMeasure? _crossSectionArea;
		private IfcPositiveLengthMeasure? _sheethDiameter;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(10, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcTendonTypeEnum @PredefinedType 
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
	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure? @NominalDiameter 
		{ 
			get 
			{
				if(Activated) return _nominalDiameter;
				
				Model.Activate(this, true);
				Activated = true;
				return _nominalDiameter;
			} 
			set
			{
				SetValue( v =>  _nominalDiameter = v, _nominalDiameter, value,  "NominalDiameter");
			} 
		}
	
		[EntityAttribute(12, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcAreaMeasure? @CrossSectionArea 
		{ 
			get 
			{
				if(Activated) return _crossSectionArea;
				
				Model.Activate(this, true);
				Activated = true;
				return _crossSectionArea;
			} 
			set
			{
				SetValue( v =>  _crossSectionArea = v, _crossSectionArea, value,  "CrossSectionArea");
			} 
		}
	
		[EntityAttribute(13, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure? @SheethDiameter 
		{ 
			get 
			{
				if(Activated) return _sheethDiameter;
				
				Model.Activate(this, true);
				Activated = true;
				return _sheethDiameter;
			} 
			set
			{
				SetValue( v =>  _sheethDiameter = v, _sheethDiameter, value,  "SheethDiameter");
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
				case 8: 
					base.Parse(propIndex, value); 
					return;
				case 9: 
                    _predefinedType = (IfcTendonTypeEnum) System.Enum.Parse(typeof (IfcTendonTypeEnum), value.EnumVal, true);
					return;
				case 10: 
					_nominalDiameter = value.RealVal;
					return;
				case 11: 
					_crossSectionArea = value.RealVal;
					return;
				case 12: 
					_sheethDiameter = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*CorrectPredefinedType:                              ((PredefinedType = IfcTendonTypeEnum.USERDEFINED) AND EXISTS(SELF\IfcElementType.ElementType));*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcTendonType other)
	    {
	        return this == other;
	    }


        public static bool operator ==(@IfcTendonType left, @IfcTendonType right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcTendonType left, @IfcTendonType right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcTendonType x, @IfcTendonType y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcTendonType obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}