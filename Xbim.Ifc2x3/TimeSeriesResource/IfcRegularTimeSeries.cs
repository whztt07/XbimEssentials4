// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 10:21:00
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.DateTimeResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.TimeSeriesResource
{
	[EntityName("IFCREGULARTIMESERIES", 417)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRegularTimeSeries : IfcTimeSeries, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRegularTimeSeries(IModel model) : base(model) 		{ 
			Model = model; 
			_values = new ItemSet<IfcTimeSeriesValue>( this );
		}

		#region Explicit attribute fields
		private IfcTimeMeasure _timeStep;
		private ItemSet<IfcTimeSeriesValue> _values;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(8, EntityAttributeState.Mandatory)]
		public IfcTimeMeasure @TimeStep 
		{ 
			get 
			{
				if(Activated) return _timeStep;
				
				Model.Activate(this, true);
				Activated = true;
				return _timeStep;
			} 
			set
			{
				SetValue( v =>  _timeStep = v, _timeStep, value,  "TimeStep");
			} 
		}
	
		[EntityAttribute(9, EntityAttributeState.Mandatory)]
		public ItemSet<IfcTimeSeriesValue> @Values 
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
					_timeStep = value.RealVal;
					return;
				case 9: 
					if (_values == null) _values = new ItemSet<IfcTimeSeriesValue>( this );
					_values.InternalAdd((IfcTimeSeriesValue)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
			return "";
		}
		#endregion
	}
}