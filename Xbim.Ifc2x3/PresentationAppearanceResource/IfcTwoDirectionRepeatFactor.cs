// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		22.09.2015 04:44:06
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.GeometryResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.PresentationAppearanceResource
{
	[IndexedClass]
	[ExpressType("IFCTWODIRECTIONREPEATFACTOR", 315)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcTwoDirectionRepeatFactor : IfcOneDirectionRepeatFactor, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTwoDirectionRepeatFactor(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcVector _secondRepeatFactor;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcVector @SecondRepeatFactor 
		{ 
			get 
			{
				if(Activated) return _secondRepeatFactor;
				
				Model.Activate(this, true);
				Activated = true;
				return _secondRepeatFactor;
			} 
			set
			{
				SetValue( v =>  _secondRepeatFactor = v, _secondRepeatFactor, value,  "SecondRepeatFactor");
			} 
		}
	
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
					_secondRepeatFactor = (IfcVector)(value.EntityVal);
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