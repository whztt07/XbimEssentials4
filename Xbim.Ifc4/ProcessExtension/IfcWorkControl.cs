// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Kernel;
using Xbim.Ifc4.DateTimeResource;
using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.ActorResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.ProcessExtension
{
	[ExpressType("IFCWORKCONTROL", 1151)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcWorkControl : IfcControl, IEqualityComparer<@IfcWorkControl>, IEquatable<@IfcWorkControl>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcWorkControl(IModel model) : base(model) 		{ 
			Model = model; 
			_creators = new OptionalItemSet<IfcPerson>( this, 0 );
		}

		#region Explicit attribute fields
		private IfcDateTime _creationDate;
		private OptionalItemSet<IfcPerson> _creators;
		private IfcLabel? _purpose;
		private IfcDuration? _duration;
		private IfcDuration? _totalFloat;
		private IfcDateTime _startTime;
		private IfcDateTime? _finishTime;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcDateTime @CreationDate 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _creationDate;
				((IPersistEntity)this).Activate(false);
				return _creationDate;
			} 
			set
			{
				SetValue( v =>  _creationDate = v, _creationDate, value,  "CreationDate");
			} 
		}
	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1)]
		public OptionalItemSet<IfcPerson> @Creators 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _creators;
				((IPersistEntity)this).Activate(false);
				return _creators;
			} 
		}
	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel? @Purpose 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _purpose;
				((IPersistEntity)this).Activate(false);
				return _purpose;
			} 
			set
			{
				SetValue( v =>  _purpose = v, _purpose, value,  "Purpose");
			} 
		}
	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcDuration? @Duration 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _duration;
				((IPersistEntity)this).Activate(false);
				return _duration;
			} 
			set
			{
				SetValue( v =>  _duration = v, _duration, value,  "Duration");
			} 
		}
	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcDuration? @TotalFloat 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _totalFloat;
				((IPersistEntity)this).Activate(false);
				return _totalFloat;
			} 
			set
			{
				SetValue( v =>  _totalFloat = v, _totalFloat, value,  "TotalFloat");
			} 
		}
	
		[EntityAttribute(12, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcDateTime @StartTime 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _startTime;
				((IPersistEntity)this).Activate(false);
				return _startTime;
			} 
			set
			{
				SetValue( v =>  _startTime = v, _startTime, value,  "StartTime");
			} 
		}
	
		[EntityAttribute(13, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcDateTime? @FinishTime 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _finishTime;
				((IPersistEntity)this).Activate(false);
				return _finishTime;
			} 
			set
			{
				SetValue( v =>  _finishTime = v, _finishTime, value,  "FinishTime");
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
					base.Parse(propIndex, value); 
					return;
				case 6: 
					_creationDate = value.StringVal;
					return;
				case 7: 
					if (_creators == null) _creators = new OptionalItemSet<IfcPerson>( this );
					_creators.InternalAdd((IfcPerson)value.EntityVal);
					return;
				case 8: 
					_purpose = value.StringVal;
					return;
				case 9: 
					_duration = value.StringVal;
					return;
				case 10: 
					_totalFloat = value.StringVal;
					return;
				case 11: 
					_startTime = value.StringVal;
					return;
				case 12: 
					_finishTime = value.StringVal;
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

		#region Equality comparers and operators
        public bool Equals(@IfcWorkControl other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcWorkControl
            var root = (@IfcWorkControl)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcWorkControl left, @IfcWorkControl right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcWorkControl left, @IfcWorkControl right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcWorkControl x, @IfcWorkControl y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcWorkControl obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}