// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		22.09.2015 02:32:11
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.CobieExpress
{
	[IndexedClass]
	[ExpressType("JOB", 29)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @CobieJob : CobieReferencedObject, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal CobieJob(IModel model) : base(model) 		{ 
			Model = model; 
			_resources = new ItemSet<CobieResource>( this );
		}

		#region Explicit attribute fields
		private string _taskNumber;
		private string _name;
		private string _description;
		private CobiePickValue _jobType;
		private CobiePickValue _jobStatusType;
		private double _duration;
		private CobiePickValue _durationUnit;
		private double _start;
		private CobiePickValue _startUnit;
		private double _frequency;
		private CobiePickValue _frequencyUnit;
		private CobieJob _priors;
		private ItemSet<CobieResource> _resources;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public string @TaskNumber 
		{ 
			get 
			{
				if(Activated) return _taskNumber;
				
				Model.Activate(this, true);
				Activated = true;
				return _taskNumber;
			} 
			set
			{
				SetValue( v =>  _taskNumber = v, _taskNumber, value,  "TaskNumber");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public string @Name 
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
	
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public string @Description 
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
	
		[EntityAttribute(8, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public CobiePickValue @JobType 
		{ 
			get 
			{
				if(Activated) return _jobType;
				
				Model.Activate(this, true);
				Activated = true;
				return _jobType;
			} 
			set
			{
				SetValue( v =>  _jobType = v, _jobType, value,  "JobType");
			} 
		}
	
		[EntityAttribute(9, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public CobiePickValue @JobStatusType 
		{ 
			get 
			{
				if(Activated) return _jobStatusType;
				
				Model.Activate(this, true);
				Activated = true;
				return _jobStatusType;
			} 
			set
			{
				SetValue( v =>  _jobStatusType = v, _jobStatusType, value,  "JobStatusType");
			} 
		}
	
		[EntityAttribute(10, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public double @Duration 
		{ 
			get 
			{
				if(Activated) return _duration;
				
				Model.Activate(this, true);
				Activated = true;
				return _duration;
			} 
			set
			{
				SetValue( v =>  _duration = v, _duration, value,  "Duration");
			} 
		}
	
		[EntityAttribute(11, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public CobiePickValue @DurationUnit 
		{ 
			get 
			{
				if(Activated) return _durationUnit;
				
				Model.Activate(this, true);
				Activated = true;
				return _durationUnit;
			} 
			set
			{
				SetValue( v =>  _durationUnit = v, _durationUnit, value,  "DurationUnit");
			} 
		}
	
		[EntityAttribute(12, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public double @Start 
		{ 
			get 
			{
				if(Activated) return _start;
				
				Model.Activate(this, true);
				Activated = true;
				return _start;
			} 
			set
			{
				SetValue( v =>  _start = v, _start, value,  "Start");
			} 
		}
	
		[EntityAttribute(13, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public CobiePickValue @StartUnit 
		{ 
			get 
			{
				if(Activated) return _startUnit;
				
				Model.Activate(this, true);
				Activated = true;
				return _startUnit;
			} 
			set
			{
				SetValue( v =>  _startUnit = v, _startUnit, value,  "StartUnit");
			} 
		}
	
		[EntityAttribute(14, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public double @Frequency 
		{ 
			get 
			{
				if(Activated) return _frequency;
				
				Model.Activate(this, true);
				Activated = true;
				return _frequency;
			} 
			set
			{
				SetValue( v =>  _frequency = v, _frequency, value,  "Frequency");
			} 
		}
	
		[EntityAttribute(15, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public CobiePickValue @FrequencyUnit 
		{ 
			get 
			{
				if(Activated) return _frequencyUnit;
				
				Model.Activate(this, true);
				Activated = true;
				return _frequencyUnit;
			} 
			set
			{
				SetValue( v =>  _frequencyUnit = v, _frequencyUnit, value,  "FrequencyUnit");
			} 
		}
	
		[EntityAttribute(16, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public CobieJob @Priors 
		{ 
			get 
			{
				if(Activated) return _priors;
				
				Model.Activate(this, true);
				Activated = true;
				return _priors;
			} 
			set
			{
				SetValue( v =>  _priors = v, _priors, value,  "Priors");
			} 
		}
	
		[EntityAttribute(17, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.Class, 0, -1)]
		public ItemSet<CobieResource> @Resources 
		{ 
			get 
			{
				if(Activated) return _resources;
				
				Model.Activate(this, true);
				Activated = true;
				return _resources;
			} 
		}
	
		#endregion

		#region Inverse attributes
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<CobieType> @ForTypes 
		{ 
			get 
			{
				return Model.Instances.Where<CobieType>(e => e.Jobs != null &&  e.Jobs.Contains(this));
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
					base.Parse(propIndex, value); 
					return;
				case 4: 
					_taskNumber = value.StringVal;
					return;
				case 5: 
					_name = value.StringVal;
					return;
				case 6: 
					_description = value.StringVal;
					return;
				case 7: 
					_jobType = (CobiePickValue)(value.EntityVal);
					return;
				case 8: 
					_jobStatusType = (CobiePickValue)(value.EntityVal);
					return;
				case 9: 
					_duration = value.RealVal;
					return;
				case 10: 
					_durationUnit = (CobiePickValue)(value.EntityVal);
					return;
				case 11: 
					_start = value.RealVal;
					return;
				case 12: 
					_startUnit = (CobiePickValue)(value.EntityVal);
					return;
				case 13: 
					_frequency = value.RealVal;
					return;
				case 14: 
					_frequencyUnit = (CobiePickValue)(value.EntityVal);
					return;
				case 15: 
					_priors = (CobieJob)(value.EntityVal);
					return;
				case 16: 
					if (_resources == null) _resources = new ItemSet<CobieResource>( this );
					_resources.InternalAdd((CobieResource)value.EntityVal);
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