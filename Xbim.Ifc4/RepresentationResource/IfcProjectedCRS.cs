// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 10:21:09
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.RepresentationResource
{
	[EntityName("IFCPROJECTEDCRS", 455)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcProjectedCRS : IfcCoordinateReferenceSystem, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcProjectedCRS(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcIdentifier? _mapProjection;
		private IfcIdentifier? _mapZone;
		private IfcNamedUnit _mapUnit;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Optional)]
		public IfcIdentifier? @MapProjection 
		{ 
			get 
			{
				if(Activated) return _mapProjection;
				
				Model.Activate(this, true);
				Activated = true;
				return _mapProjection;
			} 
			set
			{
				SetValue( v =>  _mapProjection = v, _mapProjection, value,  "MapProjection");
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Optional)]
		public IfcIdentifier? @MapZone 
		{ 
			get 
			{
				if(Activated) return _mapZone;
				
				Model.Activate(this, true);
				Activated = true;
				return _mapZone;
			} 
			set
			{
				SetValue( v =>  _mapZone = v, _mapZone, value,  "MapZone");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Optional)]
		public IfcNamedUnit @MapUnit 
		{ 
			get 
			{
				if(Activated) return _mapUnit;
				
				Model.Activate(this, true);
				Activated = true;
				return _mapUnit;
			} 
			set
			{
				SetValue( v =>  _mapUnit = v, _mapUnit, value,  "MapUnit");
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
					base.Parse(propIndex, value); 
					return;
				case 4: 
					_mapProjection = value.StringVal;
					return;
				case 5: 
					_mapZone = value.StringVal;
					return;
				case 6: 
					_mapUnit = (IfcNamedUnit)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR11:	WR11 : NOT(EXISTS(MapUnit)) OR (MapUnit.UnitType = IfcUnitEnum.LENGTHUNIT);*/
		}
		#endregion
	}
}