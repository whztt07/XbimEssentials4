// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		15.09.2015 07:03:38
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc4.ProductExtension
{
	[EntityName("IFCFEATUREELEMENTADDITION", 264)]
	public abstract partial class @IfcFeatureElementAddition : IfcFeatureElement
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcFeatureElementAddition(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		#endregion
	
		#region Explicit attribute properties
		#endregion

		#region Inverse attributes
		public IEnumerable<IfcRelProjectsElement> @ProjectsElements 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelProjectsElement>(e => e.RelatedFeatureElement == this);
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