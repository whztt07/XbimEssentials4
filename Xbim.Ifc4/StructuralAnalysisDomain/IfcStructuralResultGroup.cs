// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		24.09.2015 10:03:43
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Kernel;
using Xbim.Ifc4.UtilityResource;
using Xbim.Ifc4.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.StructuralAnalysisDomain
{
	[IndexedClass]
	[ExpressType("IFCSTRUCTURALRESULTGROUP", 1041)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcStructuralResultGroup : IfcGroup, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcStructuralResultGroup(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcAnalysisTheoryTypeEnum _theoryType;
		private IfcStructuralLoadGroup _resultForLoadGroup;
		private bool _isLinear;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcAnalysisTheoryTypeEnum @TheoryType 
		{ 
			get 
			{
				if(Activated) return _theoryType;
				
				Model.Activate(this, true);
				Activated = true;
				return _theoryType;
			} 
			set
			{
				SetValue( v =>  _theoryType = v, _theoryType, value,  "TheoryType");
			} 
		}
	
		[IndexedProperty]
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcStructuralLoadGroup @ResultForLoadGroup 
		{ 
			get 
			{
				if(Activated) return _resultForLoadGroup;
				
				Model.Activate(this, true);
				Activated = true;
				return _resultForLoadGroup;
			} 
			set
			{
				SetValue( v =>  _resultForLoadGroup = v, _resultForLoadGroup, value,  "ResultForLoadGroup");
			} 
		}
	
		[EntityAttribute(8, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public bool @IsLinear 
		{ 
			get 
			{
				if(Activated) return _isLinear;
				
				Model.Activate(this, true);
				Activated = true;
				return _isLinear;
			} 
			set
			{
				SetValue( v =>  _isLinear = v, _isLinear, value,  "IsLinear");
			} 
		}
	
		#endregion

		#region Inverse attributes
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcStructuralAnalysisModel> @ResultGroupFor 
		{ 
			get 
			{
				return Model.Instances.Where<IfcStructuralAnalysisModel>(e => e.HasResults != null &&  e.HasResults.Contains(this));
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
                    _theoryType = (IfcAnalysisTheoryTypeEnum) System.Enum.Parse(typeof (IfcAnalysisTheoryTypeEnum), value.EnumVal, true);
					return;
				case 6: 
					_resultForLoadGroup = (IfcStructuralLoadGroup)(value.EntityVal);
					return;
				case 7: 
					_isLinear = value.BooleanVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*HasObjectType:	HasObjectType : (TheoryType <> IfcAnalysisTheoryTypeEnum.USERDEFINED) OR EXISTS(SELF\IfcObject.ObjectType);*/
		}
		#endregion
	}
}