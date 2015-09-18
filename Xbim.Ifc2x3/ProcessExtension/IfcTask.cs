// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 03:43:58
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.Kernel;
using Xbim.Ifc2x3.UtilityResource;
using Xbim.Ifc2x3.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.ProcessExtension
{
	[EntityName("IFCTASK", 72)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcTask : IfcProcess, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTask(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcIdentifier _taskId;
		private IfcLabel? _status;
		private IfcLabel? _workMethod;
		private bool _isMilestone;
		private long? _priority;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttributee(5, EntityAttributeState.Mandatory)]
		public IfcIdentifier @TaskId 
		{ 
			get 
			{
				if(Activated) return _taskId;
				
				Model.Activate(this, true);
				Activated = true;
				return _taskId;
			} 
			set
			{
				SetValue( v =>  _taskId = v, _taskId, value,  "TaskId");
			} 
		}
	
		[EntityAttributee(6, EntityAttributeState.Optional)]
		public IfcLabel? @Status 
		{ 
			get 
			{
				if(Activated) return _status;
				
				Model.Activate(this, true);
				Activated = true;
				return _status;
			} 
			set
			{
				SetValue( v =>  _status = v, _status, value,  "Status");
			} 
		}
	
		[EntityAttributee(7, EntityAttributeState.Optional)]
		public IfcLabel? @WorkMethod 
		{ 
			get 
			{
				if(Activated) return _workMethod;
				
				Model.Activate(this, true);
				Activated = true;
				return _workMethod;
			} 
			set
			{
				SetValue( v =>  _workMethod = v, _workMethod, value,  "WorkMethod");
			} 
		}
	
		[EntityAttributee(8, EntityAttributeState.Mandatory)]
		public bool @IsMilestone 
		{ 
			get 
			{
				if(Activated) return _isMilestone;
				
				Model.Activate(this, true);
				Activated = true;
				return _isMilestone;
			} 
			set
			{
				SetValue( v =>  _isMilestone = v, _isMilestone, value,  "IsMilestone");
			} 
		}
	
		[EntityAttributee(9, EntityAttributeState.Optional)]
		public long? @Priority 
		{ 
			get 
			{
				if(Activated) return _priority;
				
				Model.Activate(this, true);
				Activated = true;
				return _priority;
			} 
			set
			{
				SetValue( v =>  _priority = v, _priority, value,  "Priority");
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
					base.Parse(propIndex, value); 
					return;
				case 5: 
					_taskId = value.StringVal;
					return;
				case 6: 
					_status = value.StringVal;
					return;
				case 7: 
					_workMethod = value.StringVal;
					return;
				case 8: 
					_isMilestone = value.BooleanVal;
					return;
				case 9: 
					_priority = value.IntegerVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR1:	WR1 : SIZEOF(QUERY(temp <* SELF\IfcObjectDefinition.Decomposes | NOT('IFC2X3.IFCRELNESTS' IN TYPEOF(temp)))) = 0;*/
		/*WR2:	WR2 : SIZEOF(QUERY(temp <* SELF\IfcObjectDefinition.IsDecomposedBy | NOT('IFC2X3.IFCRELNESTS' IN TYPEOF(temp)))) = 0;*/
		/*WR3:	WR3 : EXISTS(SELF\IfcRoot.Name);*/
		}
		#endregion
	}
}