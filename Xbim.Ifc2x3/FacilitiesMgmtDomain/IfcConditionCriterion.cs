// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 03:43:55
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.Kernel;
using Xbim.Ifc2x3.UtilityResource;
using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.DateTimeResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.FacilitiesMgmtDomain
{
	[EntityName("IFCCONDITIONCRITERION", 688)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcConditionCriterion : IfcControl, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcConditionCriterion(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcConditionCriterionSelect _criterion;
		private IfcDateTimeSelect _criterionDateTime;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttributee(5, EntityAttributeState.Mandatory)]
		public IfcConditionCriterionSelect @Criterion 
		{ 
			get 
			{
				if(Activated) return _criterion;
				
				Model.Activate(this, true);
				Activated = true;
				return _criterion;
			} 
			set
			{
				SetValue( v =>  _criterion = v, _criterion, value,  "Criterion");
			} 
		}
	
		[EntityAttributee(6, EntityAttributeState.Mandatory)]
		public IfcDateTimeSelect @CriterionDateTime 
		{ 
			get 
			{
				if(Activated) return _criterionDateTime;
				
				Model.Activate(this, true);
				Activated = true;
				return _criterionDateTime;
			} 
			set
			{
				SetValue( v =>  _criterionDateTime = v, _criterionDateTime, value,  "CriterionDateTime");
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
					_criterion = (IfcConditionCriterionSelect)(value.EntityVal);
					return;
				case 6: 
					_criterionDateTime = (IfcDateTimeSelect)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR1:	WR1 : EXISTS(SELF\IfcRoot.Name);*/
		}
		#endregion
	}
}