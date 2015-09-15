// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		15.09.2015 07:03:39
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc4.RepresentationResource
{
	[EntityName("IFCPROJECTEDCRS", 455)]
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

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"Name",
			"Description",
			"GeodeticDatum",
			"VerticalDatum",
			"MapProjection",
			"MapZone",
			"MapUnit",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @Name;
				case 1: 
					return @Description;
				case 2: 
					return @GeodeticDatum;
				case 3: 
					return @VerticalDatum;
				case 4: 
					return @MapProjection;
				case 5: 
					return @MapZone;
				case 6: 
					return @MapUnit;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "Name":  
					return @Name;
				case "Description":  
					return @Description;
				case "GeodeticDatum":  
					return @GeodeticDatum;
				case "VerticalDatum":  
					return @VerticalDatum;
				case "MapProjection":  
					return @MapProjection;
				case "MapZone":  
					return @MapZone;
				case "MapUnit":  
					return @MapUnit;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 @Name = (IfcLabel?)value;
					 break;
				case 1:
					 @Description = (IfcText?)value;
					 break;
				case 2:
					 if (value != null) @GeodeticDatum = (IfcIdentifier)value;
					 break;
				case 3:
					 @VerticalDatum = (IfcIdentifier?)value;
					 break;
				case 4:
					 @MapProjection = (IfcIdentifier?)value;
					 break;
				case 5:
					 @MapZone = (IfcIdentifier?)value;
					 break;
				case 6:
					 @MapUnit = (IfcNamedUnit)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "Name":
					 @Name = (IfcLabel?)value;
					 break;
				case "Description":
					 @Description = (IfcText?)value;
					 break;
				case "GeodeticDatum":
					 if (value != null) @GeodeticDatum = (IfcIdentifier)value;
					 break;
				case "VerticalDatum":
					 @VerticalDatum = (IfcIdentifier?)value;
					 break;
				case "MapProjection":
					 @MapProjection = (IfcIdentifier?)value;
					 break;
				case "MapZone":
					 @MapZone = (IfcIdentifier?)value;
					 break;
				case "MapUnit":
					 @MapUnit = (IfcNamedUnit)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion

		#region Where rules
		/*WR11:	WR11 : NOT(EXISTS(MapUnit)) OR (MapUnit.UnitType = IfcUnitEnum.LENGTHUNIT);*/
		#endregion

		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
            throw new System.NotImplementedException();
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		}
		#endregion

		
	}
}