// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 10:21:10
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Kernel;
using Xbim.Ifc4.UtilityResource;
using Xbim.Ifc4.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.SharedBldgServiceElements
{
	[EntityName("IFCRELFLOWCONTROLELEMENTS", 546)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRelFlowControlElements : IfcRelConnects, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelFlowControlElements(IModel model) : base(model) 		{ 
			Model = model; 
			_relatedControlElements = new ItemSet<IfcDistributionControlElement>( this );
		}

		#region Explicit attribute fields
		private ItemSet<IfcDistributionControlElement> _relatedControlElements;
		private IfcDistributionFlowElement _relatingFlowElement;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Mandatory)]
		public ItemSet<IfcDistributionControlElement> @RelatedControlElements 
		{ 
			get 
			{
				if(Activated) return _relatedControlElements;
				
				Model.Activate(this, true);
				Activated = true;
				return _relatedControlElements;
			} 
			set
			{
				SetValue( v =>  _relatedControlElements = v, _relatedControlElements, value,  "RelatedControlElements");
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Mandatory)]
		public IfcDistributionFlowElement @RelatingFlowElement 
		{ 
			get 
			{
				if(Activated) return _relatingFlowElement;
				
				Model.Activate(this, true);
				Activated = true;
				return _relatingFlowElement;
			} 
			set
			{
				SetValue( v =>  _relatingFlowElement = v, _relatingFlowElement, value,  "RelatingFlowElement");
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
					base.Parse(propIndex, value); 
					return;
				case 4: 
					if (_relatedControlElements == null) _relatedControlElements = new ItemSet<IfcDistributionControlElement>( this );
					_relatedControlElements.InternalAdd((IfcDistributionControlElement)value.EntityVal);
					return;
				case 5: 
					_relatingFlowElement = (IfcDistributionFlowElement)(value.EntityVal);
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