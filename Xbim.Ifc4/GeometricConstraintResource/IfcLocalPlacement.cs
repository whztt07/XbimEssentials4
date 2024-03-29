// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		24.09.2015 10:03:41
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.GeometryResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.GeometricConstraintResource
{
	[IndexedClass]
	[ExpressType("IFCLOCALPLACEMENT", 736)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcLocalPlacement : IfcObjectPlacement, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcLocalPlacement(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcObjectPlacement _placementRelTo;
		private IfcAxis2Placement _relativePlacement;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(1, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcObjectPlacement @PlacementRelTo 
		{ 
			get 
			{
				if(Activated) return _placementRelTo;
				
				Model.Activate(this, true);
				Activated = true;
				return _placementRelTo;
			} 
			set
			{
				SetValue( v =>  _placementRelTo = v, _placementRelTo, value,  "PlacementRelTo");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcAxis2Placement @RelativePlacement 
		{ 
			get 
			{
				if(Activated) return _relativePlacement;
				
				Model.Activate(this, true);
				Activated = true;
				return _relativePlacement;
			} 
			set
			{
				SetValue( v =>  _relativePlacement = v, _relativePlacement, value,  "RelativePlacement");
			} 
		}
	
		#endregion



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
					_placementRelTo = (IfcObjectPlacement)(value.EntityVal);
					return;
				case 1: 
					_relativePlacement = (IfcAxis2Placement)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR21:	WR21 : IfcCorrectLocalPlacement(RelativePlacement, PlacementRelTo);*/
		}
		#endregion
	}
}