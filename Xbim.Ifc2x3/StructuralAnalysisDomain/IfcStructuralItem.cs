// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 02:29:15
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.Kernel;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc2x3.StructuralAnalysisDomain
{
	[EntityName("IFCSTRUCTURALITEM", 541)]
	public abstract partial class @IfcStructuralItem : IfcProduct, IfcStructuralActivityAssignmentSelect
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcStructuralItem(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		#endregion
	
		#region Explicit attribute properties
		#endregion

		#region Inverse attributes
		public IEnumerable<IfcRelConnectsStructuralActivity> @AssignedStructuralActivity 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelConnectsStructuralActivity>(e => e.RelatingElement == this);
			} 
		}
	

		#endregion


		#region IPersist implementation
		#endregion

	}
}