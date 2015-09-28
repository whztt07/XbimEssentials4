// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.UtilityResource;
using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.PropertyResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.Kernel
{
	[ExpressType("IFCRELOVERRIDESPROPERTIES", 248)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRelOverridesProperties : IfcRelDefinesByProperties, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelOverridesProperties(IModel model) : base(model) 		{ 
			Model = model; 
			_overridingProperties = new ItemSet<IfcProperty>( this );
		}

		#region Explicit attribute fields
		private ItemSet<IfcProperty> _overridingProperties;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1)]
		public ItemSet<IfcProperty> @OverridingProperties 
		{ 
			get 
			{
				if(Activated) return _overridingProperties;
				
				Model.Activate(this, true);
				Activated = true;
				return _overridingProperties;
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
				case 5: 
					base.Parse(propIndex, value); 
					return;
				case 6: 
					if (_overridingProperties == null) _overridingProperties = new ItemSet<IfcProperty>( this );
					_overridingProperties.InternalAdd((IfcProperty)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR1:	WR1 : SIZEOF(SELF\IfcRelDefines.RelatedObjects) = 1;*/
		}
		#endregion
	}
}