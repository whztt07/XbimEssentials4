// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 03:44:06
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.PropertyResource
{
	[EntityName("IFCPROPERTYLISTVALUE", 464)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcPropertyListValue : IfcSimpleProperty, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPropertyListValue(IModel model) : base(model) 		{ 
			Model = model; 
			_listValues = new ItemSet<IfcValue>( this );
		}

		#region Explicit attribute fields
		private ItemSet<IfcValue> _listValues;
		private IfcUnit _unit;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Optional)]
		public ItemSet<IfcValue> @ListValues 
		{ 
			get 
			{
				if(Activated) return _listValues;
				
				Model.Activate(this, true);
				Activated = true;
				return _listValues;
			} 
			set
			{
				SetValue( v =>  _listValues = v, _listValues, value,  "ListValues");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Optional)]
		public IfcUnit @Unit 
		{ 
			get 
			{
				if(Activated) return _unit;
				
				Model.Activate(this, true);
				Activated = true;
				return _unit;
			} 
			set
			{
				SetValue( v =>  _unit = v, _unit, value,  "Unit");
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
					base.Parse(propIndex, value); 
					return;
				case 2: 
					if (_listValues == null) _listValues = new ItemSet<IfcValue>( this );
					_listValues.InternalAdd((IfcValue)value.EntityVal);
					return;
				case 3: 
					_unit = (IfcUnit)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR31:               )) = 0;*/
		}
		#endregion
	}
}