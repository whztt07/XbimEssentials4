// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		09/09/2015 04:20:33
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.ProductExtension;
using Xbim.Common;

namespace Xbim.Ifc2x3.StructuralElementsDomain
{
	[EntityName("IFCBUILDINGELEMENTCOMPONENT", 221)]
	public abstract partial class @IfcBuildingElementComponent : IfcBuildingElement
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcBuildingElementComponent(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		#endregion
	
		#region Explicit attribute properties
		#endregion

		#region Inverse attributes

		#endregion


		#region IPersist implementation
		#endregion

		public virtual override string WhereRule() 
		{
			return "";
		}
	}
}