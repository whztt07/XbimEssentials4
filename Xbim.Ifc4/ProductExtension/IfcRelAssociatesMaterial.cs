// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Kernel;
using Xbim.Ifc4.UtilityResource;
using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.MaterialResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.ProductExtension
{
	[ExpressType("IFCRELASSOCIATESMATERIAL", 916)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRelAssociatesMaterial : IfcRelAssociates, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelAssociatesMaterial(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcMaterialSelect _relatingMaterial;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcMaterialSelect @RelatingMaterial 
		{ 
			get 
			{
				if(Activated) return _relatingMaterial;
				
				Model.Activate(this, true);
				Activated = true;
				return _relatingMaterial;
			} 
			set
			{
				SetValue( v =>  _relatingMaterial = v, _relatingMaterial, value,  "RelatingMaterial");
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
					base.Parse(propIndex, value); 
					return;
				case 5: 
					_relatingMaterial = (IfcMaterialSelect)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*NoVoidElement:                        )) = 0;*/
		/*AllowedElements:                        )) = 0;*/
		}
		#endregion
	}
}