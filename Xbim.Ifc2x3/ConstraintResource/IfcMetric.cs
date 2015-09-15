// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		15.09.2015 07:04:16
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
	[EntityName("IFCMETRIC", 80)]
	public  partial class @IfcMetric : IfcConstraint, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcMetric(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcBenchmarkEnum _benchmark;
		private IfcLabel? _valueSource;
		private IfcMetricValueSelect _dataValue;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(7, EntityAttributeState.Mandatory)]
		public IfcBenchmarkEnum @Benchmark 
		{ 
			get 
			{
				if(Activated) return _benchmark;
				
				Model.Activate(this, true);
				Activated = true;
				return _benchmark;
			} 
			set
			{
				SetValue( v =>  _benchmark = v, _benchmark, value,  "Benchmark");
			} 
		}
	
		[EntityAttribute(8, EntityAttributeState.Optional)]
		public IfcLabel? @ValueSource 
		{ 
			get 
			{
				if(Activated) return _valueSource;
				
				Model.Activate(this, true);
				Activated = true;
				return _valueSource;
			} 
			set
			{
				SetValue( v =>  _valueSource = v, _valueSource, value,  "ValueSource");
			} 
		}
	
		[EntityAttribute(9, EntityAttributeState.Mandatory)]
		public IfcMetricValueSelect @DataValue 
		{ 
			get 
			{
				if(Activated) return _dataValue;
				
				Model.Activate(this, true);
				Activated = true;
				return _dataValue;
			} 
			set
			{
				SetValue( v =>  _dataValue = v, _dataValue, value,  "DataValue");
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
			"Benchmark",
			"ValueSource",
			"DataValue",
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
					return @Benchmark;
				case 8: 
					return @ValueSource;
				case 9: 
					return @DataValue;
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
				case "Benchmark":  
					return @Benchmark;
				case "ValueSource":  
					return @ValueSource;
				case "DataValue":  
					return @DataValue;
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
					 if (value != null) @Benchmark = (IfcBenchmarkEnum)value;
					 break;
				case 8:
					 @ValueSource = (IfcLabel?)value;
					 break;
				case 9:
					 @DataValue = (IfcMetricValueSelect)value;
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
				case "Benchmark":
					 if (value != null) @Benchmark = (IfcBenchmarkEnum)value;
					 break;
				case "ValueSource":
					 @ValueSource = (IfcLabel?)value;
					 break;
				case "DataValue":
					 @DataValue = (IfcMetricValueSelect)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion


		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
            throw new System.NotImplementedException();
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		}
		#endregion

		
	}
}