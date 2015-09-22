// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		22.09.2015 02:32:07
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.UtilityResource;
using Xbim.Ifc4.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.Kernel
{
	[IndexedClass]
	[ExpressType("IFCRELASSIGNSTOPROCESS", 907)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRelAssignsToProcess : IfcRelAssigns, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelAssignsToProcess(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcProcessSelect _relatingProcess;
		private IfcMeasureWithUnit _quantityInProcess;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcProcessSelect @RelatingProcess 
		{ 
			get 
			{
				if(Activated) return _relatingProcess;
				
				Model.Activate(this, true);
				Activated = true;
				return _relatingProcess;
			} 
			set
			{
				SetValue( v =>  _relatingProcess = v, _relatingProcess, value,  "RelatingProcess");
			} 
		}
	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcMeasureWithUnit @QuantityInProcess 
		{ 
			get 
			{
				if(Activated) return _quantityInProcess;
				
				Model.Activate(this, true);
				Activated = true;
				return _quantityInProcess;
			} 
			set
			{
				SetValue( v =>  _quantityInProcess = v, _quantityInProcess, value,  "QuantityInProcess");
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
				case 5: 
					base.Parse(propIndex, value); 
					return;
				case 6: 
					_relatingProcess = (IfcProcessSelect)(value.EntityVal);
					return;
				case 7: 
					_quantityInProcess = (IfcMeasureWithUnit)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*NoSelfReference:	NoSelfReference : SIZEOF(QUERY(Temp <* SELF\IfcRelAssigns.RelatedObjects | RelatingProcess :=: Temp)) = 0;*/
		}
		#endregion
	}
}