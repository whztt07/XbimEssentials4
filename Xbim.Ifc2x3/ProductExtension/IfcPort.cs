// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 02:29:14
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.Kernel;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc2x3.ProductExtension
{
	[EntityName("IFCPORT", 369)]
	public abstract partial class @IfcPort : IfcProduct
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPort(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		#endregion
	
		#region Explicit attribute properties
		#endregion

		#region Inverse attributes
		public IEnumerable<IfcRelConnectsPortToElement> @ContainedIn 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelConnectsPortToElement>(e => e.RelatingPort == this);
			} 
		}
	
		public IEnumerable<IfcRelConnectsPorts> @ConnectedFrom 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelConnectsPorts>(e => e.RelatedPort == this);
			} 
		}
	
		public IEnumerable<IfcRelConnectsPorts> @ConnectedTo 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelConnectsPorts>(e => e.RelatingPort == this);
			} 
		}
	

		#endregion


		#region IPersist implementation
		#endregion

	}
}