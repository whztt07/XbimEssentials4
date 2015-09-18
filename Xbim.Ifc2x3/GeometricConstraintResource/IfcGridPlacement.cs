// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 03:43:56
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.GeometricConstraintResource
{
	[EntityName("IFCGRIDPLACEMENT", 439)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcGridPlacement : IfcObjectPlacement, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcGridPlacement(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcVirtualGridIntersection _placementLocation;
		private IfcVirtualGridIntersection _placementRefDirection;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttributee(0, EntityAttributeState.Mandatory)]
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
	
		[EntityAttributee(1, EntityAttributeState.Optional)]
		public IfcVirtualGridIntersection @PlacementRefDirection 
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

		#region Inverse attributes

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
					_placementRefDirection = (IfcVirtualGridIntersection)(value.EntityVal);
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