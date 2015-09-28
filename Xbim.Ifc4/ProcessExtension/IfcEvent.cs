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
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.ProcessExtension
{
	[ExpressType("IFCEVENT", 628)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcEvent : IfcProcess, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcEvent(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcEventTypeEnum? _predefinedType;
		private IfcEventTriggerTypeEnum? _eventTriggerType;
		private IfcLabel? _userDefinedEventTriggerType;
		private IfcEventTime _eventOccurenceTime;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcEventTypeEnum? @PredefinedType 
		{ 
			get 
			{
				if(Activated) return _predefinedType;
				
				Model.Activate(this, true);
				Activated = true;
				return _predefinedType;
			} 
			set
			{
				SetValue( v =>  _predefinedType = v, _predefinedType, value,  "PredefinedType");
			} 
		}
	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcEventTriggerTypeEnum? @EventTriggerType 
		{ 
			get 
			{
				if(Activated) return _eventTriggerType;
				
				Model.Activate(this, true);
				Activated = true;
				return _eventTriggerType;
			} 
			set
			{
				SetValue( v =>  _eventTriggerType = v, _eventTriggerType, value,  "EventTriggerType");
			} 
		}
	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel? @UserDefinedEventTriggerType 
		{ 
			get 
			{
				if(Activated) return _userDefinedEventTriggerType;
				
				Model.Activate(this, true);
				Activated = true;
				return _userDefinedEventTriggerType;
			} 
			set
			{
				SetValue( v =>  _userDefinedEventTriggerType = v, _userDefinedEventTriggerType, value,  "UserDefinedEventTriggerType");
			} 
		}
	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcEventTime @EventOccurenceTime 
		{ 
			get 
			{
				if(Activated) return _eventOccurenceTime;
				
				Model.Activate(this, true);
				Activated = true;
				return _eventOccurenceTime;
			} 
			set
			{
				SetValue( v =>  _eventOccurenceTime = v, _eventOccurenceTime, value,  "EventOccurenceTime");
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
                    _predefinedType = (IfcEventTypeEnum) System.Enum.Parse(typeof (IfcEventTypeEnum), value.EnumVal, true);
					return;
				case 8: 
                    _eventTriggerType = (IfcEventTriggerTypeEnum) System.Enum.Parse(typeof (IfcEventTriggerTypeEnum), value.EnumVal, true);
					return;
				case 9: 
					_userDefinedEventTriggerType = value.StringVal;
					return;
				case 10: 
					_eventOccurenceTime = (IfcEventTime)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*CorrectPredefinedType:	CorrectPredefinedType : NOT(EXISTS(PredefinedType)) OR (PredefinedType <> IfcEventTypeEnum.USERDEFINED) OR ((PredefinedType = IfcEventTypeEnum.USERDEFINED) AND EXISTS(SELF\IfcObject.ObjectType));*/
		/*CorrectTypeAssigned:	CorrectTypeAssigned : NOT(EXISTS(EventTriggerType)) OR (EventTriggerType <> IfcEventTriggerTypeEnum.USERDEFINED) OR ((EventTriggerType = IfcEventTriggerTypeEnum.USERDEFINED) AND EXISTS(UserDefinedEventTriggerType));*/
		}
		#endregion
	}
}