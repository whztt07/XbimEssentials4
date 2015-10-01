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
using Xbim.Ifc4.ProfileResource;
using Xbim.Ifc4.Kernel;
using Xbim.Ifc4.GeometryResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.StructuralElementsDomain
{
	[ExpressType("IFCREINFORCINGBARTYPE", 896)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcReinforcingBarType : IfcReinforcingElementType, IInstantiableEntity, System.Collections.Generic.IEqualityComparer<@IfcReinforcingBarType>, System.IEquatable<@IfcReinforcingBarType>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcReinforcingBarType(IModel model) : base(model) 		{ 
			Model = model; 
			_bendingParameters = new OptionalItemSet<IfcBendingParameterSelect>( this );
		}

		#region Explicit attribute fields
		private IfcReinforcingBarTypeEnum _predefinedType;
		private IfcPositiveLengthMeasure? _nominalDiameter;
		private IfcAreaMeasure? _crossSectionArea;
		private IfcPositiveLengthMeasure? _barLength;
		private IfcReinforcingBarSurfaceEnum? _barSurface;
		private IfcLabel? _bendingShapeCode;
		private OptionalItemSet<IfcBendingParameterSelect> _bendingParameters;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(10, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcReinforcingBarTypeEnum @PredefinedType 
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
		public IfcPositiveLengthMeasure? @BarLength 
		{ 
			get 
			{
				if(Activated) return _barLength;
				
				Model.Activate(this, true);
				Activated = true;
				return _barLength;
			} 
			set
			{
				SetValue( v =>  _barLength = v, _barLength, value,  "BarLength");
			} 
		}
	
		[EntityAttribute(14, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcReinforcingBarSurfaceEnum? @BarSurface 
		{ 
			get 
			{
				if(Activated) return _barSurface;
				
				Model.Activate(this, true);
				Activated = true;
				return _barSurface;
			} 
			set
			{
				SetValue( v =>  _barSurface = v, _barSurface, value,  "BarSurface");
			} 
		}
	
		[EntityAttribute(15, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel? @BendingShapeCode 
		{ 
			get 
			{
				if(Activated) return _bendingShapeCode;
				
				Model.Activate(this, true);
				Activated = true;
				return _bendingShapeCode;
			} 
			set
			{
				SetValue( v =>  _bendingShapeCode = v, _bendingShapeCode, value,  "BendingShapeCode");
			} 
		}
	
		[EntityAttribute(16, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.Class, 1, -1)]
		public OptionalItemSet<IfcBendingParameterSelect> @BendingParameters 
		{ 
			get 
			{
				if(Activated) return _bendingParameters;
				
				Model.Activate(this, true);
				Activated = true;
				return _bendingParameters;
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
                    _predefinedType = (IfcReinforcingBarTypeEnum) System.Enum.Parse(typeof (IfcReinforcingBarTypeEnum), value.EnumVal, true);
					return;
				case 10: 
					_nominalDiameter = value.RealVal;
					return;
				case 11: 
					_crossSectionArea = value.RealVal;
					return;
				case 12: 
					_barLength = value.RealVal;
					return;
				case 13: 
                    _barSurface = (IfcReinforcingBarSurfaceEnum) System.Enum.Parse(typeof (IfcReinforcingBarSurfaceEnum), value.EnumVal, true);
					return;
				case 14: 
					_bendingShapeCode = value.StringVal;
					return;
				case 15: 
					if (_bendingParameters == null) _bendingParameters = new OptionalItemSet<IfcBendingParameterSelect>( this );
					_bendingParameters.InternalAdd((IfcBendingParameterSelect)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*CorrectPredefinedType:                                 ((PredefinedType = IfcReinforcingBarTypeEnum.USERDEFINED) AND EXISTS(SELF\IfcElementType.ElementType));*/
		/*BendingShapeCodeProvided:	BendingShapeCodeProvided : NOT EXISTS(BendingParameters) OR EXISTS(BendingShapeCode);*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcReinforcingBarType other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcReinforcingBarType
            var root = (@IfcReinforcingBarType)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcReinforcingBarType left, @IfcReinforcingBarType right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcReinforcingBarType left, @IfcReinforcingBarType right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcReinforcingBarType x, @IfcReinforcingBarType y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcReinforcingBarType obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}