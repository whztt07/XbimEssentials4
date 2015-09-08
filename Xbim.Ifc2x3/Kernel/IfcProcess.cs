// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 09:16:38
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc2x3.Kernel
{
	[EntityName("IFCPROCESS")]
	public abstract partial class @IfcProcess : IfcObject
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcProcess(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		#endregion
	
		#region Explicit attribute properties
		#endregion

		#region Inverse attributes
		public IEnumerable<IfcRelAssignsToProcess> @OperatesOn 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelAssignsToProcess>(e => e.RelatingProcess == this);
			} 
		}
	
		public IEnumerable<IfcRelSequence> @IsSuccessorFrom 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelSequence>(e => e.RelatedProcess == this);
			} 
		}
	
		public IEnumerable<IfcRelSequence> @IsPredecessorTo 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelSequence>(e => e.RelatingProcess == this);
			} 
		}
	

		#endregion


		#region IPersist implementation
		#endregion

	}
}