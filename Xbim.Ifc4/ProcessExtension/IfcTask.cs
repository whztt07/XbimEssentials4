// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Kernel;
using Xbim.Ifc4.UtilityResource;
using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.DateTimeResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.ProcessExtension
{
	[ExpressType("IFCTASK", 1081)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcTask : IfcProcess, IInstantiableEntity, IEqualityComparer<@IfcTask>, IEquatable<@IfcTask>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTask(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcLabel? _status;
		private IfcLabel? _workMethod;
		private bool _isMilestone;
		private long? _priority;
		private IfcTaskTime _taskTime;
		private IfcTaskTypeEnum? _predefinedType;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel? @Status 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _status;
				((IPersistEntity)this).Activate(false);
				return _status;
			} 
			set
			{
				SetValue( v =>  _status = v, _status, value,  "Status");
			} 
		}
	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel? @WorkMethod 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _workMethod;
				((IPersistEntity)this).Activate(false);
				return _workMethod;
			} 
			set
			{
				SetValue( v =>  _workMethod = v, _workMethod, value,  "WorkMethod");
			} 
		}
	
		[EntityAttribute(10, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public bool @IsMilestone 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _isMilestone;
				((IPersistEntity)this).Activate(false);
				return _isMilestone;
			} 
			set
			{
				SetValue( v =>  _isMilestone = v, _isMilestone, value,  "IsMilestone");
			} 
		}
	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public long? @Priority 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _priority;
				((IPersistEntity)this).Activate(false);
				return _priority;
			} 
			set
			{
				SetValue( v =>  _priority = v, _priority, value,  "Priority");
			} 
		}
	
		[EntityAttribute(12, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcTaskTime @TaskTime 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _taskTime;
				((IPersistEntity)this).Activate(false);
				return _taskTime;
			} 
			set
			{
				SetValue( v =>  _taskTime = v, _taskTime, value,  "TaskTime");
			} 
		}
	
		[EntityAttribute(13, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcTaskTypeEnum? @PredefinedType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _predefinedType;
				((IPersistEntity)this).Activate(false);
				return _predefinedType;
			} 
			set
			{
				SetValue( v =>  _predefinedType = v, _predefinedType, value,  "PredefinedType");
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
					_status = value.StringVal;
					return;
				case 8: 
					_workMethod = value.StringVal;
					return;
				case 9: 
					_isMilestone = value.BooleanVal;
					return;
				case 10: 
					_priority = value.IntegerVal;
					return;
				case 11: 
					_taskTime = (IfcTaskTime)(value.EntityVal);
					return;
				case 12: 
                    _predefinedType = (IfcTaskTypeEnum) System.Enum.Parse(typeof (IfcTaskTypeEnum), value.EnumVal, true);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*HasName:	HasName : EXISTS(SELF\IfcRoot.Name);*/
		/*CorrectPredefinedType:	CorrectPredefinedType : NOT(EXISTS(PredefinedType)) OR (PredefinedType <> IfcTaskTypeEnum.USERDEFINED) OR ((PredefinedType = IfcTaskTypeEnum.USERDEFINED) AND EXISTS(SELF\IfcObject.ObjectType));*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcTask other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcTask
            var root = (@IfcTask)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcTask left, @IfcTask right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcTask left, @IfcTask right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcTask x, @IfcTask y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcTask obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}