// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 10:21:10
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.ProductExtension;
using Xbim.Ifc4.UtilityResource;
using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.GeometricConstraintResource;
using Xbim.Ifc4.RepresentationResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.SharedBldgElements
{
	[EntityName("IFCSTAIRFLIGHT", 616)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcStairFlight : IfcBuildingElement, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcStairFlight(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private long? _numberOfRiser;
		private long? _numberOfTreads;
		private IfcPositiveLengthMeasure? _riserHeight;
		private IfcPositiveLengthMeasure? _treadLength;
		private IfcStairFlightTypeEnum? _predefinedType;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(8, EntityAttributeState.Optional)]
		public long? @NumberOfRiser 
		{ 
			get 
			{
				if(Activated) return _numberOfRiser;
				
				Model.Activate(this, true);
				Activated = true;
				return _numberOfRiser;
			} 
			set
			{
				SetValue( v =>  _numberOfRiser = v, _numberOfRiser, value,  "NumberOfRiser");
			} 
		}
	
		[EntityAttribute(9, EntityAttributeState.Optional)]
		public long? @NumberOfTreads 
		{ 
			get 
			{
				if(Activated) return _numberOfTreads;
				
				Model.Activate(this, true);
				Activated = true;
				return _numberOfTreads;
			} 
			set
			{
				SetValue( v =>  _numberOfTreads = v, _numberOfTreads, value,  "NumberOfTreads");
			} 
		}
	
		[EntityAttribute(10, EntityAttributeState.Optional)]
		public IfcPositiveLengthMeasure? @RiserHeight 
		{ 
			get 
			{
				if(Activated) return _riserHeight;
				
				Model.Activate(this, true);
				Activated = true;
				return _riserHeight;
			} 
			set
			{
				SetValue( v =>  _riserHeight = v, _riserHeight, value,  "RiserHeight");
			} 
		}
	
		[EntityAttribute(11, EntityAttributeState.Optional)]
		public IfcPositiveLengthMeasure? @TreadLength 
		{ 
			get 
			{
				if(Activated) return _treadLength;
				
				Model.Activate(this, true);
				Activated = true;
				return _treadLength;
			} 
			set
			{
				SetValue( v =>  _treadLength = v, _treadLength, value,  "TreadLength");
			} 
		}
	
		[EntityAttribute(12, EntityAttributeState.Optional)]
		public IfcStairFlightTypeEnum? @PredefinedType 
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

		#region Inverse attributes

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
					_numberOfRiser = value.IntegerVal;
					return;
				case 9: 
					_numberOfTreads = value.IntegerVal;
					return;
				case 10: 
					_riserHeight = value.RealVal;
					return;
				case 11: 
					_treadLength = value.RealVal;
					return;
				case 12: 
                    _predefinedType = (IfcStairFlightTypeEnum) System.Enum.Parse(typeof (IfcStairFlightTypeEnum), value.EnumVal, true);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*CorrectPredefinedType:                               ((PredefinedType = IfcStairFlightTypeEnum.USERDEFINED) AND EXISTS (SELF\IfcObject.ObjectType));*/
		/*CorrectTypeAssigned:                                ('IFC4.IFCSTAIRFLIGHTTYPE' IN TYPEOF(SELF\IfcObject.IsTypedBy[1].RelatingType));*/
		}
		#endregion
	}
}