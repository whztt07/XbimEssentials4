// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		21.09.2015 05:11:20
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.GeometryResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.GeometricModelResource
{
	[IndexedClass]
	[ExpressType("IFCPOLYGONALBOUNDEDHALFSPACE", 820)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcPolygonalBoundedHalfSpace : IfcHalfSpaceSolid, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPolygonalBoundedHalfSpace(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcAxis2Placement3D _position;
		private IfcBoundedCurve _polygonalBoundary;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcAxis2Placement3D @Position 
		{ 
			get 
			{
				if(Activated) return _position;
				
				Model.Activate(this, true);
				Activated = true;
				return _position;
			} 
			set
			{
				SetValue( v =>  _position = v, _position, value,  "Position");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcBoundedCurve @PolygonalBoundary 
		{ 
			get 
			{
				if(Activated) return _polygonalBoundary;
				
				Model.Activate(this, true);
				Activated = true;
				return _polygonalBoundary;
			} 
			set
			{
				SetValue( v =>  _polygonalBoundary = v, _polygonalBoundary, value,  "PolygonalBoundary");
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
					base.Parse(propIndex, value); 
					return;
				case 2: 
					_position = (IfcAxis2Placement3D)(value.EntityVal);
					return;
				case 3: 
					_polygonalBoundary = (IfcBoundedCurve)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*BoundaryDim:	BoundaryDim : PolygonalBoundary.Dim = 2;*/
		/*BoundaryType:                     ) = 1;*/
		}
		#endregion
	}
}