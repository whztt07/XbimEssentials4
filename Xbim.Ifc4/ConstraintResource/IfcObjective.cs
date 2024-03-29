// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		24.09.2015 10:03:42
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.ActorResource;
using Xbim.Ifc4.DateTimeResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.ConstraintResource
{
	[IndexedClass]
	[ExpressType("IFCOBJECTIVE", 777)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcObjective : IfcConstraint, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcObjective(IModel model) : base(model) 		{ 
			Model = model; 
			_benchmarkValues = new OptionalItemSet<IfcConstraint>( this );
		}

		#region Explicit attribute fields
		private OptionalItemSet<IfcConstraint> _benchmarkValues;
		private IfcLogicalOperatorEnum? _logicalAggregator;
		private IfcObjectiveEnum _objectiveQualifier;
		private IfcLabel? _userDefinedQualifier;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.Class, 1, -1)]
		public OptionalItemSet<IfcConstraint> @BenchmarkValues 
		{ 
			get 
			{
				if(Activated) return _benchmarkValues;
				
				Model.Activate(this, true);
				Activated = true;
				return _benchmarkValues;
			} 
		}
	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcLogicalOperatorEnum? @LogicalAggregator 
		{ 
			get 
			{
				if(Activated) return _logicalAggregator;
				
				Model.Activate(this, true);
				Activated = true;
				return _logicalAggregator;
			} 
			set
			{
				SetValue( v =>  _logicalAggregator = v, _logicalAggregator, value,  "LogicalAggregator");
			} 
		}
	
		[EntityAttribute(10, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
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
	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
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
					if (_benchmarkValues == null) _benchmarkValues = new OptionalItemSet<IfcConstraint>( this );
					_benchmarkValues.InternalAdd((IfcConstraint)value.EntityVal);
					return;
				case 8: 
                    _logicalAggregator = (IfcLogicalOperatorEnum) System.Enum.Parse(typeof (IfcLogicalOperatorEnum), value.EnumVal, true);
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