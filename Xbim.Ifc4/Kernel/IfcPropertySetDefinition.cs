// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 02:29:23
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc4.Kernel
{
	[EntityName("IFCPROPERTYSETDEFINITION", 467)]
	public abstract partial class @IfcPropertySetDefinition : IfcPropertyDefinition, IfcPropertySetDefinitionSelect
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPropertySetDefinition(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		#endregion
	
		#region Explicit attribute properties
		#endregion

		#region Inverse attributes
		public IEnumerable<IfcTypeObject> @DefinesType 
		{ 
			get 
			{
				return Model.Instances.Where<IfcTypeObject>(e => e.HasPropertySets != null &&  e.HasPropertySets.Contains(this));
			} 
		}
	
		public IEnumerable<IfcRelDefinesByTemplate> @IsDefinedBy 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelDefinesByTemplate>(e => e.RelatedPropertySets != null &&  e.RelatedPropertySets.Contains(this));
			} 
		}
	
		public IEnumerable<IfcRelDefinesByProperties> @DefinesOccurrence 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelDefinesByProperties>(e => e.RelatingPropertyDefinition == this);
			} 
		}
	

		#endregion


		#region IPersist implementation
		#endregion

	}
}