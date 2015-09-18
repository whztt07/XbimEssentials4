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

namespace Xbim.Ifc4.MaterialResource
{
	[EntityName("IFCMATERIALLAYERWITHOFFSETS", 359)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcMaterialLayerWithOffsets : IfcMaterialLayer, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcMaterialLayerWithOffsets(IModel model) : base(model) 		{ 
			Model = model; 
			_offsetValues = new ItemSet<IfcLengthMeasure>( this );
		}

		#region Explicit attribute fields
		private IfcLayerSetDirectionEnum _offsetDirection;
		private ItemSet<IfcLengthMeasure> _offsetValues;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttributee(7, EntityAttributeState.Mandatory)]
		public IfcLayerSetDirectionEnum @OffsetDirection 
		{ 
			get 
			{
				if(Activated) return _offsetDirection;
				
				Model.Activate(this, true);
				Activated = true;
				return _offsetDirection;
			} 
			set
			{
				SetValue( v =>  _offsetDirection = v, _offsetDirection, value,  "OffsetDirection");
			} 
		}
	
		[EntityAttributee(8, EntityAttributeState.Mandatory)]
		public ItemSet<IfcLengthMeasure> @OffsetValues 
		{ 
			get 
			{
				if(Activated) return _offsetValues;
				
				Model.Activate(this, true);
				Activated = true;
				return _offsetValues;
			} 
			set
			{
				SetValue( v =>  _offsetValues = v, _offsetValues, value,  "OffsetValues");
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
				case 6: 
					base.Parse(propIndex, value); 
					return;
				case 7: 
                    _offsetDirection = (IfcLayerSetDirectionEnum) System.Enum.Parse(typeof (IfcLayerSetDirectionEnum), value.EnumVal, true);
					return;
				case 8: 
					if (_offsetValues == null) _offsetValues = new ItemSet<IfcLengthMeasure>( this );
					_offsetValues.InternalAdd(value.RealVal);
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