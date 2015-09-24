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
using Xbim.Ifc4.QuantityResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.ProductExtension
{
	[IndexedClass]
	[ExpressType("IFCELEMENTQUANTITY", 615)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcElementQuantity : IfcQuantitySet, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcElementQuantity(IModel model) : base(model) 		{ 
			Model = model; 
			_quantities = new ItemSet<IfcPhysicalQuantity>( this );
		}

		#region Explicit attribute fields
		private IfcLabel? _methodOfMeasurement;
		private ItemSet<IfcPhysicalQuantity> _quantities;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel? @MethodOfMeasurement 
		{ 
			get 
			{
				if(Activated) return _methodOfMeasurement;
				
				Model.Activate(this, true);
				Activated = true;
				return _methodOfMeasurement;
			} 
			set
			{
				SetValue( v =>  _methodOfMeasurement = v, _methodOfMeasurement, value,  "MethodOfMeasurement");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1)]
		public ItemSet<IfcPhysicalQuantity> @Quantities 
		{ 
			get 
			{
				if(Activated) return _quantities;
				
				Model.Activate(this, true);
				Activated = true;
				return _quantities;
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
					base.Parse(propIndex, value); 
					return;
				case 4: 
					_methodOfMeasurement = value.StringVal;
					return;
				case 5: 
					if (_quantities == null) _quantities = new ItemSet<IfcPhysicalQuantity>( this );
					_quantities.InternalAdd((IfcPhysicalQuantity)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*UniqueQuantityNames:	UniqueQuantityNames : IfcUniqueQuantityNames(Quantities);*/
		}
		#endregion
	}
}