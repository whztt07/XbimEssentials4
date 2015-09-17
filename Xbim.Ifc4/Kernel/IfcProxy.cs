// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 10:21:09
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.UtilityResource;
using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.GeometricConstraintResource;
using Xbim.Ifc4.RepresentationResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.Kernel
{
	[EntityName("IFCPROXY", 477)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcProxy : IfcProduct, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcProxy(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcObjectTypeEnum _proxyType;
		private IfcLabel? _tag;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(7, EntityAttributeState.Mandatory)]
		public IfcObjectTypeEnum @ProxyType 
		{ 
			get 
			{
				if(Activated) return _proxyType;
				
				Model.Activate(this, true);
				Activated = true;
				return _proxyType;
			} 
			set
			{
				SetValue( v =>  _proxyType = v, _proxyType, value,  "ProxyType");
			} 
		}
	
		[EntityAttribute(8, EntityAttributeState.Optional)]
		public IfcLabel? @Tag 
		{ 
			get 
			{
				if(Activated) return _tag;
				
				Model.Activate(this, true);
				Activated = true;
				return _tag;
			} 
			set
			{
				SetValue( v =>  _tag = v, _tag, value,  "Tag");
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
                    _proxyType = (IfcObjectTypeEnum) System.Enum.Parse(typeof (IfcObjectTypeEnum), value.EnumVal, true);
					return;
				case 8: 
					_tag = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR1:	WR1 : EXISTS(SELF\IfcRoot.Name);*/
		}
		#endregion
	}
}