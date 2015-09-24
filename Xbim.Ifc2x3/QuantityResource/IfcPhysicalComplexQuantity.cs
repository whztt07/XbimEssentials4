// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.QuantityResource
{
	[IndexedClass]
	[ExpressType("IFCPHYSICALCOMPLEXQUANTITY", 604)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcPhysicalComplexQuantity : IfcPhysicalQuantity, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPhysicalComplexQuantity(IModel model) : base(model) 		{ 
			Model = model; 
			_hasQuantities = new ItemSet<IfcPhysicalQuantity>( this );
		}

		#region Explicit attribute fields
		private ItemSet<IfcPhysicalQuantity> _hasQuantities;
		private IfcLabel _discrimination;
		private IfcLabel? _quality;
		private IfcLabel? _usage;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1)]
		public ItemSet<IfcPhysicalQuantity> @HasQuantities 
		{ 
			get 
			{
				if(Activated) return _hasQuantities;
				
				Model.Activate(this, true);
				Activated = true;
				return _hasQuantities;
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel @Discrimination 
		{ 
			get 
			{
				if(Activated) return _discrimination;
				
				Model.Activate(this, true);
				Activated = true;
				return _discrimination;
			} 
			set
			{
				SetValue( v =>  _discrimination = v, _discrimination, value,  "Discrimination");
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel? @Quality 
		{ 
			get 
			{
				if(Activated) return _quality;
				
				Model.Activate(this, true);
				Activated = true;
				return _quality;
			} 
			set
			{
				SetValue( v =>  _quality = v, _quality, value,  "Quality");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel? @Usage 
		{ 
			get 
			{
				if(Activated) return _usage;
				
				Model.Activate(this, true);
				Activated = true;
				return _usage;
			} 
			set
			{
				SetValue( v =>  _usage = v, _usage, value,  "Usage");
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
					base.Parse(propIndex, value); 
					return;
				case 2: 
					if (_hasQuantities == null) _hasQuantities = new ItemSet<IfcPhysicalQuantity>( this );
					_hasQuantities.InternalAdd((IfcPhysicalQuantity)value.EntityVal);
					return;
				case 3: 
					_discrimination = value.StringVal;
					return;
				case 4: 
					_quality = value.StringVal;
					return;
				case 5: 
					_usage = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR21:	WR21 : SIZEOF(QUERY(temp <* HasQuantities | SELF :=: temp)) = 0;*/
		}
		#endregion
	}
}