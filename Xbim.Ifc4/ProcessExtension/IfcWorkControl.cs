// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		15.09.2015 07:03:42
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Kernel;
using Xbim.Ifc4.DateTimeResource;
using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.ActorResource;
using Xbim.Common;

namespace Xbim.Ifc4.ProcessExtension
{
	[EntityName("IFCWORKCONTROL", 760)]
	public abstract partial class @IfcWorkControl : IfcControl
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcWorkControl(IModel model) : base(model) 		{ 
			Model = model; 
			_creators = new ItemSet<IfcPerson>( model );
		}

		#region Explicit attribute fields
		private IfcDateTime _creationDate;
		private ItemSet<IfcPerson> _creators;
		private IfcLabel? _purpose;
		private IfcDuration? _duration;
		private IfcDuration? _totalFloat;
		private IfcDateTime _startTime;
		private IfcDateTime? _finishTime;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(6, EntityAttributeState.Mandatory)]
		public IfcDateTime @CreationDate 
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
		public IfcDuration? @Duration 
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
		public IfcDuration? @TotalFloat 
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
		public IfcDateTime @StartTime 
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
		public IfcDateTime? @FinishTime 
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
	
		#endregion

		#region Inverse attributes

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