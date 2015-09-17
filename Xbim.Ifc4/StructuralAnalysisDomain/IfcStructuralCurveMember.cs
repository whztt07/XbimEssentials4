// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 03:44:07
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.UtilityResource;
using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.GeometricConstraintResource;
using Xbim.Ifc4.RepresentationResource;
using Xbim.Ifc4.GeometryResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.StructuralAnalysisDomain
{
	[EntityName("IFCSTRUCTURALCURVEMEMBER", 626)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcStructuralCurveMember : IfcStructuralMember, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcStructuralCurveMember(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcStructuralCurveMemberTypeEnum _predefinedType;
		private IfcDirection _axis;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(7, EntityAttributeState.Mandatory)]
		public IfcStructuralCurveMemberTypeEnum @PredefinedType 
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
	
		[EntityAttribute(8, EntityAttributeState.Mandatory)]
		public IfcDirection @Axis 
		{ 
			get 
			{
				if(Activated) return _axis;
				
				Model.Activate(this, true);
				Activated = true;
				return _axis;
			} 
			set
			{
				SetValue( v =>  _axis = v, _axis, value,  "Axis");
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
					base.Parse(propIndex, value); 
					return;
				case 7: 
                    _predefinedType = (IfcStructuralCurveMemberTypeEnum) System.Enum.Parse(typeof (IfcStructuralCurveMemberTypeEnum), value.EnumVal, true);
					return;
				case 8: 
					_axis = (IfcDirection)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*HasObjectType:	HasObjectType : (PredefinedType <> IfcStructuralCurveMemberTypeEnum.USERDEFINED) OR EXISTS(SELF\IfcObject.ObjectType);*/
		}
		#endregion
	}
}