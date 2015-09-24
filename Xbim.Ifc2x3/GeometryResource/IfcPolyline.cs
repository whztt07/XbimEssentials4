// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		24.09.2015 10:03:34
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.GeometryResource
{
	[IndexedClass]
	[ExpressType("IFCPOLYLINE", 500)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcPolyline : IfcBoundedCurve, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPolyline(IModel model) : base(model) 		{ 
			Model = model; 
			_points = new ItemSet<IfcCartesianPoint>( this );
		}

		#region Explicit attribute fields
		private ItemSet<IfcCartesianPoint> _points;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.Class, 2, -1)]
		public ItemSet<IfcCartesianPoint> @Points 
		{ 
			get 
			{
				if(Activated) return _points;
				
				Model.Activate(this, true);
				Activated = true;
				return _points;
			} 
		}
	
		#endregion



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
					if (_points == null) _points = new ItemSet<IfcCartesianPoint>( this );
					_points.InternalAdd((IfcCartesianPoint)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR41:	WR41 : SIZEOF(QUERY(Temp <* Points | Temp.Dim <> Points[1].Dim)) = 0;*/
		}
		#endregion
	}
}