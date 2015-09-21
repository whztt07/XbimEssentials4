// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		21.09.2015 05:11:13
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
	[ExpressType("IFCONEDIRECTIONREPEATFACTOR", 32)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcOneDirectionRepeatFactor : IfcGeometricRepresentationItem, IfcHatchLineDistanceSelect, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcOneDirectionRepeatFactor(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcVector _repeatFactor;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcVector @RepeatFactor 
		{ 
			get 
			{
				if(Activated) return _repeatFactor;
				
				Model.Activate(this, true);
				Activated = true;
				return _repeatFactor;
			} 
			set
			{
				SetValue( v =>  _repeatFactor = v, _repeatFactor, value,  "RepeatFactor");
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
					_repeatFactor = (IfcVector)(value.EntityVal);
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