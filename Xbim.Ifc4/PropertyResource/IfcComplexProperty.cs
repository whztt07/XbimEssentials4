// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		22.09.2015 04:44:11
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
	[IndexedClass]
	[ExpressType("IFCCOMPLEXPROPERTY", 498)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcComplexProperty : IfcProperty, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcComplexProperty(IModel model) : base(model) 		{ 
			Model = model; 
			_hasProperties = new ItemSet<IfcProperty>( this );
		}

		#region Explicit attribute fields
		private IfcIdentifier _usageName;
		private ItemSet<IfcProperty> _hasProperties;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcIdentifier @UsageName 
		{ 
			get 
			{
				if(Activated) return _usageName;
				
				Model.Activate(this, true);
				Activated = true;
				return _usageName;
			} 
			set
			{
				SetValue( v =>  _usageName = v, _usageName, value,  "UsageName");
			} 
		}
	
		[IndexedProperty]
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1)]
		public ItemSet<IfcProperty> @HasProperties 
		{ 
			get 
			{
				if(Activated) return _hasProperties;
				
				Model.Activate(this, true);
				Activated = true;
				return _hasProperties;
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
					_usageName = value.StringVal;
					return;
				case 3: 
					if (_hasProperties == null) _hasProperties = new ItemSet<IfcProperty>( this );
					_hasProperties.InternalAdd((IfcProperty)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR21:	WR21 : SIZEOF(QUERY(temp <* HasProperties | SELF :=: temp)) = 0;*/
		/*WR22:	WR22 : IfcUniquePropertyName(HasProperties);*/
		}
		#endregion
	}
}