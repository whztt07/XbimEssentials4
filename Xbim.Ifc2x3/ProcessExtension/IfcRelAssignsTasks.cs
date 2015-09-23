// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		23.09.2015 10:21:44
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
	[IndexedClass]
	[ExpressType("IFCRELASSIGNSTASKS", 618)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRelAssignsTasks : IfcRelAssignsToControl, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelAssignsTasks(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcScheduleTimeControl _timeForTask;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcScheduleTimeControl @TimeForTask 
		{ 
			get 
			{
				if(Activated) return _timeForTask;
				
				Model.Activate(this, true);
				Activated = true;
				return _timeForTask;
			} 
			set
			{
				SetValue( v =>  _timeForTask = v, _timeForTask, value,  "TimeForTask");
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
					_timeForTask = (IfcScheduleTimeControl)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR1:	WR1 : HIINDEX(SELF\IfcRelAssigns.RelatedObjects) = 1;*/
		/*WR2:	WR2 : 'IFC2X3.IFCTASK' IN TYPEOF(SELF\IfcRelAssigns.RelatedObjects[1]);*/
		/*WR3:	WR3 : 'IFC2X3.IFCWORKCONTROL' IN TYPEOF(SELF\IfcRelAssignsToControl.RelatingControl);*/
		}
		#endregion
	}
}