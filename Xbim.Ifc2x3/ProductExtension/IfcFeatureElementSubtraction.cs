// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		09/09/2015 04:20:34
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc2x3.ProductExtension
{
	[EntityName("IFCFEATUREELEMENTSUBTRACTION", 499)]
	public abstract partial class @IfcFeatureElementSubtraction : IfcFeatureElement
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcFeatureElementSubtraction(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		#endregion
	
		#region Explicit attribute properties
		#endregion

		#region Inverse attributes
		public IEnumerable<IfcRelVoidsElement> @VoidsElements 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelVoidsElement>(e => e.RelatedOpeningElement == this);
			} 
		}
	

		#endregion


		#region IPersist implementation
		#endregion

		public virtual override string WhereRule() 
		{
			return "";
		}
	}
}