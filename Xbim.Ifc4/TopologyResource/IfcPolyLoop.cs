// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		22.09.2015 02:32:06
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.GeometryResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.TopologyResource
{
	[IndexedClass]
	[ExpressType("IFCPOLYLOOP", 819)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcPolyLoop : IfcLoop, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPolyLoop(IModel model) : base(model) 		{ 
			Model = model; 
			_polygon = new ItemSet<IfcCartesianPoint>( this );
		}

		#region Explicit attribute fields
		private ItemSet<IfcCartesianPoint> _polygon;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.Class, 3, -1)]
		public ItemSet<IfcCartesianPoint> @Polygon 
		{ 
			get 
			{
				if(Activated) return _polygon;
				
				Model.Activate(this, true);
				Activated = true;
				return _polygon;
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
					if (_polygon == null) _polygon = new ItemSet<IfcCartesianPoint>( this );
					_polygon.InternalAdd((IfcCartesianPoint)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*AllPointsSameDim:	AllPointsSameDim : SIZEOF(QUERY(Temp <* Polygon | Temp.Dim <> Polygon[1].Dim)) = 0;*/
		}
		#endregion
	}
}