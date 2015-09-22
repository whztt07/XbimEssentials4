// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		22.09.2015 04:44:05
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.PropertyResource
{
	[IndexedClass]
	[ExpressType("IFCPROPERTYENUMERATEDVALUE", 629)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcPropertyEnumeratedValue : IfcSimpleProperty, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPropertyEnumeratedValue(IModel model) : base(model) 		{ 
			Model = model; 
			_enumerationValues = new ItemSet<IfcValue>( this );
		}

		#region Explicit attribute fields
		private ItemSet<IfcValue> _enumerationValues;
		private IfcPropertyEnumeration _enumerationReference;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.Class, 1, -1)]
		public ItemSet<IfcValue> @EnumerationValues 
		{ 
			get 
			{
				if(Activated) return _enumerationValues;
				
				Model.Activate(this, true);
				Activated = true;
				return _enumerationValues;
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcPropertyEnumeration @EnumerationReference 
		{ 
			get 
			{
				if(Activated) return _enumerationReference;
				
				Model.Activate(this, true);
				Activated = true;
				return _enumerationReference;
			} 
			set
			{
				SetValue( v =>  _enumerationReference = v, _enumerationReference, value,  "EnumerationReference");
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
					if (_enumerationValues == null) _enumerationValues = new ItemSet<IfcValue>( this );
					_enumerationValues.InternalAdd((IfcValue)value.EntityVal);
					return;
				case 3: 
					_enumerationReference = (IfcPropertyEnumeration)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR1:                = SIZEOF(EnumerationValues));*/
		}
		#endregion
	}
}