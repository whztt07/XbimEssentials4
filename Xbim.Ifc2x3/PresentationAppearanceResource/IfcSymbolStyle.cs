// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		21.09.2015 05:11:14
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.PresentationAppearanceResource
{
	[IndexedClass]
	[ExpressType("IFCSYMBOLSTYLE", 729)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcSymbolStyle : IfcPresentationStyle, IfcPresentationStyleSelect, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcSymbolStyle(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcSymbolStyleSelect _styleOfSymbol;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcSymbolStyleSelect @StyleOfSymbol 
		{ 
			get 
			{
				if(Activated) return _styleOfSymbol;
				
				Model.Activate(this, true);
				Activated = true;
				return _styleOfSymbol;
			} 
			set
			{
				SetValue( v =>  _styleOfSymbol = v, _styleOfSymbol, value,  "StyleOfSymbol");
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
					base.Parse(propIndex, value); 
					return;
				case 1: 
					_styleOfSymbol = (IfcSymbolStyleSelect)(value.EntityVal);
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