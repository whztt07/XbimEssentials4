// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.ConstraintResource;
using Xbim.Ifc2x3.PropertyResource;
using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.DateTimeResource;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.TimeSeriesResource
{
	[IndexedClass]
	[ExpressType("IFCTIMESERIES", 418)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcTimeSeries : IPersistEntity, INotifyPropertyChanged, IfcMetricValueSelect, IfcObjectReferenceSelect
	{
		#region Implementation of IPersistEntity
		public int EntityLabel {get; internal set;}
		
		public IModel Model { get; internal set; }
		
		public bool Activated { get; internal set; }

		void IPersistEntity.Activate(bool write)
		{
			if (Activated) return; //activation can only happen once in a lifetime of the object

			Model.Activate(this, write);
			Activated = true;
		}

		void IPersistEntity.Activate (Action activation)
		{
			if (Activated) return; //activation can only happen once in a lifetime of the object
			
			activation();
			Activated = true;
		}
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTimeSeries(IModel model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcLabel _name;
		private IfcText? _description;
		private IfcDateTimeSelect _startTime;
		private IfcDateTimeSelect _endTime;
		private IfcTimeSeriesDataTypeEnum _timeSeriesDataType;
		private IfcDataOriginEnum _dataOrigin;
		private IfcLabel? _userDefinedDataOrigin;
		private IfcUnit _unit;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel @Name 
		{ 
			get 
			{
				if(Activated) return _name;
				
				Model.Activate(this, true);
				Activated = true;
				return _name;
			} 
			set
			{
				SetValue( v =>  _name = v, _name, value,  "Name");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcText? @Description 
		{ 
			get 
			{
				if(Activated) return _description;
				
				Model.Activate(this, true);
				Activated = true;
				return _description;
			} 
			set
			{
				SetValue( v =>  _description = v, _description, value,  "Description");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcDateTimeSelect @StartTime 
		{ 
			get 
			{
				if(Activated) return _startTime;
				
				Model.Activate(this, true);
				Activated = true;
				return _startTime;
			} 
			set
			{
				SetValue( v =>  _startTime = v, _startTime, value,  "StartTime");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcDateTimeSelect @EndTime 
		{ 
			get 
			{
				if(Activated) return _endTime;
				
				Model.Activate(this, true);
				Activated = true;
				return _endTime;
			} 
			set
			{
				SetValue( v =>  _endTime = v, _endTime, value,  "EndTime");
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcTimeSeriesDataTypeEnum @TimeSeriesDataType 
		{ 
			get 
			{
				if(Activated) return _timeSeriesDataType;
				
				Model.Activate(this, true);
				Activated = true;
				return _timeSeriesDataType;
			} 
			set
			{
				SetValue( v =>  _timeSeriesDataType = v, _timeSeriesDataType, value,  "TimeSeriesDataType");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcDataOriginEnum @DataOrigin 
		{ 
			get 
			{
				if(Activated) return _dataOrigin;
				
				Model.Activate(this, true);
				Activated = true;
				return _dataOrigin;
			} 
			set
			{
				SetValue( v =>  _dataOrigin = v, _dataOrigin, value,  "DataOrigin");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel? @UserDefinedDataOrigin 
		{ 
			get 
			{
				if(Activated) return _userDefinedDataOrigin;
				
				Model.Activate(this, true);
				Activated = true;
				return _userDefinedDataOrigin;
			} 
			set
			{
				SetValue( v =>  _userDefinedDataOrigin = v, _userDefinedDataOrigin, value,  "UserDefinedDataOrigin");
			} 
		}
	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcUnit @Unit 
		{ 
			get 
			{
				if(Activated) return _unit;
				
				Model.Activate(this, true);
				Activated = true;
				return _unit;
			} 
			set
			{
				SetValue( v =>  _unit = v, _unit, value,  "Unit");
			} 
		}
	
		#endregion

		#region Inverse attributes
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcTimeSeriesReferenceRelationship> @DocumentedBy 
		{ 
			get 
			{
				return Model.Instances.Where<IfcTimeSeriesReferenceRelationship>(e => e.ReferencedTimeSeries == this);
			} 
		}
		#endregion

		#region INotifyPropertyChanged implementation
		 
		public event PropertyChangedEventHandler PropertyChanged;

		protected void NotifyPropertyChanged( string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

		#endregion

		#region Transactional property setting

		protected void SetValue<TProperty>(Action<TProperty> setter, TProperty oldValue, TProperty newValue, string notifyPropertyName)
		{

			if (!Model.IsTransactional)
			{
				setter(newValue);
				NotifyPropertyChanged(notifyPropertyName);
				return;
			}

			//check there is a transaction
			var txn = Model.CurrentTransaction;
			if (txn == null) throw new Exception("Operation out of transaction.");

			Action doAction = () => setter(newValue);
			Action undoAction = () => setter(oldValue);
			txn.AddReversibleAction(doAction, undoAction, this);
			setter(newValue);
			NotifyPropertyChanged(notifyPropertyName);
		}

		#endregion

		#region IPersist implementation
		public virtual void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
					_name = value.StringVal;
					return;
				case 1: 
					_description = value.StringVal;
					return;
				case 2: 
					_startTime = (IfcDateTimeSelect)(value.EntityVal);
					return;
				case 3: 
					_endTime = (IfcDateTimeSelect)(value.EntityVal);
					return;
				case 4: 
                    _timeSeriesDataType = (IfcTimeSeriesDataTypeEnum) System.Enum.Parse(typeof (IfcTimeSeriesDataTypeEnum), value.EnumVal, true);
					return;
				case 5: 
                    _dataOrigin = (IfcDataOriginEnum) System.Enum.Parse(typeof (IfcDataOriginEnum), value.EnumVal, true);
					return;
				case 6: 
					_userDefinedDataOrigin = value.StringVal;
					return;
				case 7: 
					_unit = (IfcUnit)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public virtual string WhereRule() 
		{
			return "";
		}
		#endregion
	}
}