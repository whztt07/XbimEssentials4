// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		22.09.2015 02:32:04
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.PresentationAppearanceResource
{
	[IndexedClass]
	[ExpressType("IFCCOLOURRGB", 490)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcColourRgb : IfcColourSpecification, IfcColourOrFactor, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcColourRgb(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcNormalisedRatioMeasure _red;
		private IfcNormalisedRatioMeasure _green;
		private IfcNormalisedRatioMeasure _blue;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcNormalisedRatioMeasure @Red 
		{ 
			get 
			{
				if(Activated) return _red;
				
				Model.Activate(this, true);
				Activated = true;
				return _red;
			} 
			set
			{
				SetValue( v =>  _red = v, _red, value,  "Red");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcNormalisedRatioMeasure @Green 
		{ 
			get 
			{
				if(Activated) return _green;
				
				Model.Activate(this, true);
				Activated = true;
				return _green;
			} 
			set
			{
				SetValue( v =>  _green = v, _green, value,  "Green");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcNormalisedRatioMeasure @Blue 
		{ 
			get 
			{
				if(Activated) return _blue;
				
				Model.Activate(this, true);
				Activated = true;
				return _blue;
			} 
			set
			{
				SetValue( v =>  _blue = v, _blue, value,  "Blue");
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
					_red = value.RealVal;
					return;
				case 2: 
					_green = value.RealVal;
					return;
				case 3: 
					_blue = value.RealVal;
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