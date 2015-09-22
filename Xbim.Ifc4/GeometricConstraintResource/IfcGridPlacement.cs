// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		22.09.2015 04:44:12
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.GeometricConstraintResource
{
	[IndexedClass]
	[ExpressType("IFCGRIDPLACEMENT", 698)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcGridPlacement : IfcObjectPlacement, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcGridPlacement(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcVirtualGridIntersection _placementLocation;
		private IfcGridPlacementDirectionSelect _placementRefDirection;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcVirtualGridIntersection @PlacementLocation 
		{ 
			get 
			{
				if(Activated) return _placementLocation;
				
				Model.Activate(this, true);
				Activated = true;
				return _placementLocation;
			} 
			set
			{
				SetValue( v =>  _placementLocation = v, _placementLocation, value,  "PlacementLocation");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcGridPlacementDirectionSelect @PlacementRefDirection 
		{ 
			get 
			{
				if(Activated) return _placementRefDirection;
				
				Model.Activate(this, true);
				Activated = true;
				return _placementRefDirection;
			} 
			set
			{
				SetValue( v =>  _placementRefDirection = v, _placementRefDirection, value,  "PlacementRefDirection");
			} 
		}
	
		#endregion



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
					_placementLocation = (IfcVirtualGridIntersection)(value.EntityVal);
					return;
				case 1: 
					_placementRefDirection = (IfcGridPlacementDirectionSelect)(value.EntityVal);
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