// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 10:21:06
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.GeometricConstraintResource;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.GeometryResource
{
	[EntityName("IFCBOUNDEDCURVE", 52)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcBoundedCurve : IfcCurve, IfcCurveOrEdgeCurve
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcBoundedCurve(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		#endregion
	
		#region Explicit attribute properties
		#endregion

		#region Inverse attributes

		#endregion

		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
			//there are no attributes defined for this entity
            throw new System.IndexOutOfRangeException("There are no attributes defined for this entity");
		}
		
		public  override string WhereRule() 
		{
			return "";
		}
		#endregion
	}
}