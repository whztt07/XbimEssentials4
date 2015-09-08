// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 02:29:15
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.Kernel;
using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.DateTimeResource;
using Xbim.Ifc2x3.ActorResource;
using Xbim.Common;

namespace Xbim.Ifc2x3.ProcessExtension
{
	[EntityName("IFCWORKCONTROL", 648)]
	public abstract partial class @IfcWorkControl : IfcControl
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcWorkControl(IModel model) : base(model) 		{ 
			Model = model; 
			_creators = new ItemSet<IfcPerson>( model );
		}

		#region Explicit attribute fields
		private IfcIdentifier _identifier;
		private IfcDateTimeSelect _creationDate;
		private ItemSet<IfcPerson> _creators;
		private IfcLabel? _purpose;
		private IfcTimeMeasure? _duration;
		private IfcTimeMeasure? _totalFloat;
		private IfcDateTimeSelect _startTime;
		private IfcDateTimeSelect _finishTime;
		private IfcWorkControlTypeEnum _workControlType;
		private IfcLabel? _userDefinedControlType;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(5, EntityAttributeState.Mandatory)]
		public IfcIdentifier @Identifier 
		{ 
			get 
			{
				if(Activated) return _identifier;
				
				Model.Activate(this, true);
				Activated = true;
				return _identifier;
			} 
			set
			{
				SetValue( v =>  _identifier = v, _identifier, value,  "Identifier");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Mandatory)]
		public IfcDateTimeSelect @CreationDate 
		{ 
			get 
			{
				if(Activated) return _creationDate;
				
				Model.Activate(this, true);
				Activated = true;
				return _creationDate;
			} 
			set
			{
				SetValue( v =>  _creationDate = v, _creationDate, value,  "CreationDate");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Optional)]
		public ItemSet<IfcPerson> @Creators 
		{ 
			get 
			{
				if(Activated) return _creators;
				
				Model.Activate(this, true);
				Activated = true;
				return _creators;
			} 
			set
			{
				SetValue( v =>  _creators = v, _creators, value,  "Creators");
			} 
		}
	
		[EntityAttribute(8, EntityAttributeState.Optional)]
		public IfcLabel? @Purpose 
		{ 
			get 
			{
				if(Activated) return _purpose;
				
				Model.Activate(this, true);
				Activated = true;
				return _purpose;
			} 
			set
			{
				SetValue( v =>  _purpose = v, _purpose, value,  "Purpose");
			} 
		}
	
		[EntityAttribute(9, EntityAttributeState.Optional)]
		public IfcTimeMeasure? @Duration 
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
	
		[EntityAttribute(10, EntityAttributeState.Optional)]
		public IfcTimeMeasure? @TotalFloat 
		{ 
			get 
			{
				if(Activated) return _totalFloat;
				
				Model.Activate(this, true);
				Activated = true;
				return _totalFloat;
			} 
			set
			{
				SetValue( v =>  _totalFloat = v, _totalFloat, value,  "TotalFloat");
			} 
		}
	
		[EntityAttribute(11, EntityAttributeState.Mandatory)]
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
	
		[EntityAttribute(12, EntityAttributeState.Optional)]
		public IfcDateTimeSelect @FinishTime 
		{ 
			get 
			{
				if(Activated) return _finishTime;
				
				Model.Activate(this, true);
				Activated = true;
				return _finishTime;
			} 
			set
			{
				SetValue( v =>  _finishTime = v, _finishTime, value,  "FinishTime");
			} 
		}
	
		[EntityAttribute(13, EntityAttributeState.Optional)]
		public IfcWorkControlTypeEnum @WorkControlType 
		{ 
			get 
			{
				if(Activated) return _workControlType;
				
				Model.Activate(this, true);
				Activated = true;
				return _workControlType;
			} 
			set
			{
				SetValue( v =>  _workControlType = v, _workControlType, value,  "WorkControlType");
			} 
		}
	
		[EntityAttribute(14, EntityAttributeState.Optional)]
		public IfcLabel? @UserDefinedControlType 
		{ 
			get 
			{
				if(Activated) return _userDefinedControlType;
				
				Model.Activate(this, true);
				Activated = true;
				return _userDefinedControlType;
			} 
			set
			{
				SetValue( v =>  _userDefinedControlType = v, _userDefinedControlType, value,  "UserDefinedControlType");
			} 
		}
	
		#endregion

		#region Inverse attributes

		#endregion

		#region Where rules
		/*WR1:            ((WorkControlType = IfcWorkControlTypeEnum.USERDEFINED) AND EXISTS(SELF\IfcWorkControl.UserDefinedControlType));*/
		#endregion

		#region IPersist implementation
		#endregion

	}
}