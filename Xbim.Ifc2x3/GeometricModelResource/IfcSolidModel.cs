// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		24.09.2015 10:03:34
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.GeometryResource;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.GeometricModelResource
{
	[IndexedClass]
	[ExpressType("IFCSOLIDMODEL", 150)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcSolidModel : IfcGeometricRepresentationItem, IfcBooleanOperand
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcSolidModel(IModel model) : base(model) 		{ 
			Model = model; 
		}




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