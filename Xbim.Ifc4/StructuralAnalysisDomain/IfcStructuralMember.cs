// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		15.09.2015 07:03:41
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc4.StructuralAnalysisDomain
{
	[EntityName("IFCSTRUCTURALMEMBER", 644)]
	public abstract partial class @IfcStructuralMember : IfcStructuralItem
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcStructuralMember(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		#endregion
	
		#region Explicit attribute properties
		#endregion

		#region Inverse attributes
		public IEnumerable<IfcRelConnectsStructuralMember> @ConnectedBy 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelConnectsStructuralMember>(e => e.RelatingStructuralMember == this);
			} 
		}
	

		#endregion


		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
            throw new System.NotImplementedException();
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		}
		#endregion

		
	}
}