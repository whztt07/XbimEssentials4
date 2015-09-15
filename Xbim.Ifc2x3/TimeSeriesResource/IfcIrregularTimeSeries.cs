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
using Xbim.Ifc2x3.DateTimeResource;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc2x3.TimeSeriesResource
{
	[EntityName("IFCIRREGULARTIMESERIES", 570)]
	public  partial class @IfcIrregularTimeSeries : IfcTimeSeries, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcIrregularTimeSeries(IModel model) : base(model) 		{ 
			Model = model; 
			_values = new ItemSet<IfcIrregularTimeSeriesValue>( model );
		}

		#region Explicit attribute fields
		private ItemSet<IfcIrregularTimeSeriesValue> _values;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(8, EntityAttributeState.Mandatory)]
		public ItemSet<IfcIrregularTimeSeriesValue> @Values 
		{ 
			get 
			{
				if(Activated) return _values;
				
				Model.Activate(this, true);
				Activated = true;
				return _values;
			} 
			set
			{
				SetValue( v =>  _values = v, _values, value,  "Values");
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
			"StartTime",
			"EndTime",
			"TimeSeriesDataType",
			"DataOrigin",
			"UserDefinedDataOrigin",
			"Unit",
			"Values",
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
					return @StartTime;
				case 3: 
					return @EndTime;
				case 4: 
					return @TimeSeriesDataType;
				case 5: 
					return @DataOrigin;
				case 6: 
					return @UserDefinedDataOrigin;
				case 7: 
					return @Unit;
				case 8: 
					return @Values;
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
				case "StartTime":  
					return @StartTime;
				case "EndTime":  
					return @EndTime;
				case "TimeSeriesDataType":  
					return @TimeSeriesDataType;
				case "DataOrigin":  
					return @DataOrigin;
				case "UserDefinedDataOrigin":  
					return @UserDefinedDataOrigin;
				case "Unit":  
					return @Unit;
				case "Values":  
					return @Values;
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
					 @StartTime = (IfcDateTimeSelect)value;
					 break;
				case 3:
					 @EndTime = (IfcDateTimeSelect)value;
					 break;
				case 4:
					 if (value != null) @TimeSeriesDataType = (IfcTimeSeriesDataTypeEnum)value;
					 break;
				case 5:
					 if (value != null) @DataOrigin = (IfcDataOriginEnum)value;
					 break;
				case 6:
					 @UserDefinedDataOrigin = (IfcLabel?)value;
					 break;
				case 7:
					 @Unit = (IfcUnit)value;
					 break;
				case 8:
					 @Values.Add((IfcIrregularTimeSeriesValue)value);
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
				case "StartTime":
					 @StartTime = (IfcDateTimeSelect)value;
					 break;
				case "EndTime":
					 @EndTime = (IfcDateTimeSelect)value;
					 break;
				case "TimeSeriesDataType":
					 if (value != null) @TimeSeriesDataType = (IfcTimeSeriesDataTypeEnum)value;
					 break;
				case "DataOrigin":
					 if (value != null) @DataOrigin = (IfcDataOriginEnum)value;
					 break;
				case "UserDefinedDataOrigin":
					 @UserDefinedDataOrigin = (IfcLabel?)value;
					 break;
				case "Unit":
					 @Unit = (IfcUnit)value;
					 break;
				case "Values":
					 @Values.Add((IfcIrregularTimeSeriesValue)value);
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