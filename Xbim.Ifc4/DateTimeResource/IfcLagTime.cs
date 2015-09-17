// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 03:44:05
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.DateTimeResource
{
	[EntityName("IFCLAGTIME", 329)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcLagTime : IfcSchedulingTime, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcLagTime(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcTimeOrRatioSelect _lagValue;
		private IfcTaskDurationEnum _durationType;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(3, EntityAttributeState.Mandatory)]
		public IfcTimeOrRatioSelect @LagValue 
		{ 
			get 
			{
				if(Activated) return _lagValue;
				
				Model.Activate(this, true);
				Activated = true;
				return _lagValue;
			} 
			set
			{
				SetValue( v =>  _lagValue = v, _lagValue, value,  "LagValue");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Mandatory)]
		public IfcTaskDurationEnum @DurationType 
		{ 
			get 
			{
				if(Activated) return _durationType;
				
				Model.Activate(this, true);
				Activated = true;
				return _durationType;
			} 
			set
			{
				SetValue( v =>  _durationType = v, _durationType, value,  "DurationType");
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
					base.Parse(propIndex, value); 
					return;
				case 3: 
					_lagValue = (IfcTimeOrRatioSelect)(value.EntityVal);
					return;
				case 4: 
                    _durationType = (IfcTaskDurationEnum) System.Enum.Parse(typeof (IfcTaskDurationEnum), value.EnumVal, true);
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