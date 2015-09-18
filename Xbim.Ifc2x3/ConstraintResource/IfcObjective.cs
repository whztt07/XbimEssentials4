// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 03:43:56
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.ActorResource;
using Xbim.Ifc2x3.DateTimeResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.ConstraintResource
{
	[EntityName("IFCOBJECTIVE", 518)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcObjective : IfcConstraint, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcObjective(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcMetric _benchmarkValues;
		private IfcMetric _resultValues;
		private IfcObjectiveEnum _objectiveQualifier;
		private IfcLabel? _userDefinedQualifier;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttributee(7, EntityAttributeState.Optional)]
		public IfcMetric @BenchmarkValues 
		{ 
			get 
			{
				if(Activated) return _benchmarkValues;
				
				Model.Activate(this, true);
				Activated = true;
				return _benchmarkValues;
			} 
			set
			{
				SetValue( v =>  _benchmarkValues = v, _benchmarkValues, value,  "BenchmarkValues");
			} 
		}
	
		[EntityAttributee(8, EntityAttributeState.Optional)]
		public IfcMetric @ResultValues 
		{ 
			get 
			{
				if(Activated) return _resultValues;
				
				Model.Activate(this, true);
				Activated = true;
				return _resultValues;
			} 
			set
			{
				SetValue( v =>  _resultValues = v, _resultValues, value,  "ResultValues");
			} 
		}
	
		[EntityAttributee(9, EntityAttributeState.Mandatory)]
		public IfcObjectiveEnum @ObjectiveQualifier 
		{ 
			get 
			{
				if(Activated) return _objectiveQualifier;
				
				Model.Activate(this, true);
				Activated = true;
				return _objectiveQualifier;
			} 
			set
			{
				SetValue( v =>  _objectiveQualifier = v, _objectiveQualifier, value,  "ObjectiveQualifier");
			} 
		}
	
		[EntityAttributee(10, EntityAttributeState.Optional)]
		public IfcLabel? @UserDefinedQualifier 
		{ 
			get 
			{
				if(Activated) return _userDefinedQualifier;
				
				Model.Activate(this, true);
				Activated = true;
				return _userDefinedQualifier;
			} 
			set
			{
				SetValue( v =>  _userDefinedQualifier = v, _userDefinedQualifier, value,  "UserDefinedQualifier");
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
					_benchmarkValues = (IfcMetric)(value.EntityVal);
					return;
				case 8: 
					_resultValues = (IfcMetric)(value.EntityVal);
					return;
				case 9: 
                    _objectiveQualifier = (IfcObjectiveEnum) System.Enum.Parse(typeof (IfcObjectiveEnum), value.EnumVal, true);
					return;
				case 10: 
					_userDefinedQualifier = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR21:             ((ObjectiveQualifier = IfcObjectiveEnum.USERDEFINED) AND EXISTS(SELF\IfcObjective.UserDefinedQualifier));*/
		}
		#endregion
	}
}