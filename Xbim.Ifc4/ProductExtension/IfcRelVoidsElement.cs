// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		22.09.2015 02:32:07
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

namespace Xbim.Ifc4.ProductExtension
{
	[IndexedClass]
	[ExpressType("IFCRELVOIDSELEMENT", 947)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRelVoidsElement : IfcRelDecomposes, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelVoidsElement(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcElement _relatingBuildingElement;
		private IfcFeatureElementSubtraction _relatedOpeningElement;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcElement @RelatingBuildingElement 
		{ 
			get 
			{
				if(Activated) return _relatingBuildingElement;
				
				Model.Activate(this, true);
				Activated = true;
				return _relatingBuildingElement;
			} 
			set
			{
				SetValue( v =>  _relatingBuildingElement = v, _relatingBuildingElement, value,  "RelatingBuildingElement");
			} 
		}
	
		[IndexedProperty]
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcFeatureElementSubtraction @RelatedOpeningElement 
		{ 
			get 
			{
				if(Activated) return _relatedOpeningElement;
				
				Model.Activate(this, true);
				Activated = true;
				return _relatedOpeningElement;
			} 
			set
			{
				SetValue( v =>  _relatedOpeningElement = v, _relatedOpeningElement, value,  "RelatedOpeningElement");
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
					_relatingBuildingElement = (IfcElement)(value.EntityVal);
					return;
				case 5: 
					_relatedOpeningElement = (IfcFeatureElementSubtraction)(value.EntityVal);
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