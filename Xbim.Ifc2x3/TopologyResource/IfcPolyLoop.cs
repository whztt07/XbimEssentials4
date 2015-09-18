// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 03:43:56
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.GeometryResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.TopologyResource
{
	[EntityName("IFCPOLYLOOP", 200)]
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
		[EntityAttributee(0, EntityAttributeState.Mandatory)]
		public ItemSet<IfcCartesianPoint> @Polygon 
		{ 
			get 
			{
				if(Activated) return _polygon;
				
				Model.Activate(this, true);
				Activated = true;
				return _polygon;
			} 
			set
			{
				SetValue( v =>  _polygon = v, _polygon, value,  "Polygon");
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
		/*WR21:	WR21 : SIZEOF(QUERY(Temp <* Polygon | Temp.Dim <> Polygon[1].Dim)) = 0;*/
		}
		#endregion
	}
}