// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		23.09.2015 10:21:52
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.PresentationDefinitionResource;
using Xbim.Ifc4.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.PresentationAppearanceResource
{
	[IndexedClass]
	[ExpressType("IFCSURFACESTYLEREFRACTION", 1061)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcSurfaceStyleRefraction : IfcPresentationItem, IfcSurfaceStyleElementSelect, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcSurfaceStyleRefraction(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcReal? _refractionIndex;
		private IfcReal? _dispersionFactor;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcReal? @RefractionIndex 
		{ 
			get 
			{
				if(Activated) return _refractionIndex;
				
				Model.Activate(this, true);
				Activated = true;
				return _refractionIndex;
			} 
			set
			{
				SetValue( v =>  _refractionIndex = v, _refractionIndex, value,  "RefractionIndex");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcReal? @DispersionFactor 
		{ 
			get 
			{
				if(Activated) return _dispersionFactor;
				
				Model.Activate(this, true);
				Activated = true;
				return _dispersionFactor;
			} 
			set
			{
				SetValue( v =>  _dispersionFactor = v, _dispersionFactor, value,  "DispersionFactor");
			} 
		}
	
		#endregion



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
					_refractionIndex = value.RealVal;
					return;
				case 1: 
					_dispersionFactor = value.RealVal;
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