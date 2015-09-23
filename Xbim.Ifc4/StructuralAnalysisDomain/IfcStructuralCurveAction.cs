// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		23.09.2015 10:21:52
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.UtilityResource;
using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.GeometricConstraintResource;
using Xbim.Ifc4.RepresentationResource;
using Xbim.Ifc4.StructuralLoadResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.StructuralAnalysisDomain
{
	[IndexedClass]
	[ExpressType("IFCSTRUCTURALCURVEACTION", 1015)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcStructuralCurveAction : IfcStructuralAction, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcStructuralCurveAction(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcProjectedOrTrueLengthEnum? _projectedOrTrue;
		private IfcStructuralCurveActivityTypeEnum _predefinedType;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcProjectedOrTrueLengthEnum? @ProjectedOrTrue 
		{ 
			get 
			{
				if(Activated) return _projectedOrTrue;
				
				Model.Activate(this, true);
				Activated = true;
				return _projectedOrTrue;
			} 
			set
			{
				SetValue( v =>  _projectedOrTrue = v, _projectedOrTrue, value,  "ProjectedOrTrue");
			} 
		}
	
		[EntityAttribute(12, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcStructuralCurveActivityTypeEnum @PredefinedType 
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
				case 8: 
				case 9: 
					base.Parse(propIndex, value); 
					return;
				case 10: 
                    _projectedOrTrue = (IfcProjectedOrTrueLengthEnum) System.Enum.Parse(typeof (IfcProjectedOrTrueLengthEnum), value.EnumVal, true);
					return;
				case 11: 
                    _predefinedType = (IfcStructuralCurveActivityTypeEnum) System.Enum.Parse(typeof (IfcStructuralCurveActivityTypeEnum), value.EnumVal, true);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*ProjectedIsGlobal:                                (SELF\IfcStructuralActivity.GlobalOrLocal = GLOBAL_COORDS));*/
		/*HasObjectType:	HasObjectType : (PredefinedType <> IfcStructuralCurveActivityTypeEnum.USERDEFINED) OR EXISTS(SELF\IfcObject.ObjectType);*/
		/*SuitablePredefinedType:	SuitablePredefinedType : PredefinedType <> IfcStructuralCurveActivityTypeEnum.EQUIDISTANT;*/
		}
		#endregion
	}
}