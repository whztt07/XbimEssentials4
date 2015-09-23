// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		23.09.2015 10:21:53
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
	[IndexedClass]
	[ExpressType("IFCWORKCALENDAR", 1150)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcWorkCalendar : IfcControl, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcWorkCalendar(IModel model) : base(model) 		{ 
			Model = model; 
			_workingTimes = new OptionalItemSet<IfcWorkTime>( this );
			_exceptionTimes = new OptionalItemSet<IfcWorkTime>( this );
		}

		#region Explicit attribute fields
		private OptionalItemSet<IfcWorkTime> _workingTimes;
		private OptionalItemSet<IfcWorkTime> _exceptionTimes;
		private IfcWorkCalendarTypeEnum? _predefinedType;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1)]
		public OptionalItemSet<IfcWorkTime> @WorkingTimes 
		{ 
			get 
			{
				if(Activated) return _workingTimes;
				
				Model.Activate(this, true);
				Activated = true;
				return _workingTimes;
			} 
		}
	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1)]
		public OptionalItemSet<IfcWorkTime> @ExceptionTimes 
		{ 
			get 
			{
				if(Activated) return _exceptionTimes;
				
				Model.Activate(this, true);
				Activated = true;
				return _exceptionTimes;
			} 
		}
	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcWorkCalendarTypeEnum? @PredefinedType 
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
					if (_workingTimes == null) _workingTimes = new OptionalItemSet<IfcWorkTime>( this );
					_workingTimes.InternalAdd((IfcWorkTime)value.EntityVal);
					return;
				case 7: 
					if (_exceptionTimes == null) _exceptionTimes = new OptionalItemSet<IfcWorkTime>( this );
					_exceptionTimes.InternalAdd((IfcWorkTime)value.EntityVal);
					return;
				case 8: 
                    _predefinedType = (IfcWorkCalendarTypeEnum) System.Enum.Parse(typeof (IfcWorkCalendarTypeEnum), value.EnumVal, true);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*CorrectPredefinedType:                              ((PredefinedType = IfcWorkCalendarTypeEnum.USERDEFINED) AND EXISTS(SELF\IfcObject.ObjectType));*/
		}
		#endregion
	}
}