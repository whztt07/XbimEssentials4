// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 09:16:38
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

namespace Xbim.Ifc2x3.ConstraintResource
{
	[EntityName("IFCOBJECTIVE")]
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
		[EntityAttribute(7, EntityAttributeState.Optional)]
		public IfcMetric @BenchmarkValues 
		{ 
			get 
			{
				if(IsActivated) return _benchmarkValues;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _benchmarkValues;
			} 
			set
			{
				SetValue( v =>  _benchmarkValues = v, _benchmarkValues, value,  "BenchmarkValues");
			} 
		}
	
		[EntityAttribute(8, EntityAttributeState.Optional)]
		public IfcMetric @ResultValues 
		{ 
			get 
			{
				if(IsActivated) return _resultValues;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _resultValues;
			} 
			set
			{
				SetValue( v =>  _resultValues = v, _resultValues, value,  "ResultValues");
			} 
		}
	
		[EntityAttribute(9, EntityAttributeState.Mandatory)]
		public IfcObjectiveEnum @ObjectiveQualifier 
		{ 
			get 
			{
				if(IsActivated) return _objectiveQualifier;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _objectiveQualifier;
			} 
			set
			{
				SetValue( v =>  _objectiveQualifier = v, _objectiveQualifier, value,  "ObjectiveQualifier");
			} 
		}
	
		[EntityAttribute(10, EntityAttributeState.Optional)]
		public IfcLabel? @UserDefinedQualifier 
		{ 
			get 
			{
				if(IsActivated) return _userDefinedQualifier;
				
				Model.Activate(this, true);
				IsActivated = true;
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

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"Name",
			"Description",
			"ConstraintGrade",
			"ConstraintSource",
			"CreatingActor",
			"CreationTime",
			"UserDefinedGrade",
			"BenchmarkValues",
			"ResultValues",
			"ObjectiveQualifier",
			"UserDefinedQualifier",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @Name;
				case 1: 
					return @Description;
				case 2: 
					return @ConstraintGrade;
				case 3: 
					return @ConstraintSource;
				case 4: 
					return @CreatingActor;
				case 5: 
					return @CreationTime;
				case 6: 
					return @UserDefinedGrade;
				case 7: 
					return @BenchmarkValues;
				case 8: 
					return @ResultValues;
				case 9: 
					return @ObjectiveQualifier;
				case 10: 
					return @UserDefinedQualifier;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "Name":  
					return @Name;
				case "Description":  
					return @Description;
				case "ConstraintGrade":  
					return @ConstraintGrade;
				case "ConstraintSource":  
					return @ConstraintSource;
				case "CreatingActor":  
					return @CreatingActor;
				case "CreationTime":  
					return @CreationTime;
				case "UserDefinedGrade":  
					return @UserDefinedGrade;
				case "BenchmarkValues":  
					return @BenchmarkValues;
				case "ResultValues":  
					return @ResultValues;
				case "ObjectiveQualifier":  
					return @ObjectiveQualifier;
				case "UserDefinedQualifier":  
					return @UserDefinedQualifier;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 if (value != null) @Name = (IfcLabel)value;
					 break;
				case 1:
					 @Description = (IfcText?)value;
					 break;
				case 2:
					 if (value != null) @ConstraintGrade = (IfcConstraintEnum)value;
					 break;
				case 3:
					 @ConstraintSource = (IfcLabel?)value;
					 break;
				case 4:
					 @CreatingActor = (IfcActorSelect)value;
					 break;
				case 5:
					 @CreationTime = (IfcDateTimeSelect)value;
					 break;
				case 6:
					 @UserDefinedGrade = (IfcLabel?)value;
					 break;
				case 7:
					 @BenchmarkValues = (IfcMetric)value;
					 break;
				case 8:
					 @ResultValues = (IfcMetric)value;
					 break;
				case 9:
					 if (value != null) @ObjectiveQualifier = (IfcObjectiveEnum)value;
					 break;
				case 10:
					 @UserDefinedQualifier = (IfcLabel?)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "Name":
					 if (value != null) @Name = (IfcLabel)value;
					 break;
				case "Description":
					 @Description = (IfcText?)value;
					 break;
				case "ConstraintGrade":
					 if (value != null) @ConstraintGrade = (IfcConstraintEnum)value;
					 break;
				case "ConstraintSource":
					 @ConstraintSource = (IfcLabel?)value;
					 break;
				case "CreatingActor":
					 @CreatingActor = (IfcActorSelect)value;
					 break;
				case "CreationTime":
					 @CreationTime = (IfcDateTimeSelect)value;
					 break;
				case "UserDefinedGrade":
					 @UserDefinedGrade = (IfcLabel?)value;
					 break;
				case "BenchmarkValues":
					 @BenchmarkValues = (IfcMetric)value;
					 break;
				case "ResultValues":
					 @ResultValues = (IfcMetric)value;
					 break;
				case "ObjectiveQualifier":
					 if (value != null) @ObjectiveQualifier = (IfcObjectiveEnum)value;
					 break;
				case "UserDefinedQualifier":
					 @UserDefinedQualifier = (IfcLabel?)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion

		#region Where rules
		/*WR21:             ((ObjectiveQualifier = IfcObjectiveEnum.USERDEFINED) AND EXISTS(SELF\IfcObjective.UserDefinedQualifier));*/
		#endregion

		#region IPersist implementation
		public void Set(int propIndex, IPropertyValue value)
		{
            throw new System.NotImplementedException();
		}
		#endregion

	}
}