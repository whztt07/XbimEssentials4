// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 03:44:06
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.Kernel
{
	[EntityName("IFCPROPERTYTEMPLATE", 471)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcPropertyTemplate : IfcPropertyTemplateDefinition
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPropertyTemplate(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		#endregion
	
		#region Explicit attribute properties
		#endregion

		#region Inverse attributes
		public IEnumerable<IfcComplexPropertyTemplate> @PartOfComplexTemplate 
		{ 
			get 
			{
				return Model.Instances.Where<IfcComplexPropertyTemplate>(e => e.HasPropertyTemplates != null &&  e.HasPropertyTemplates.Contains(this));
			} 
		}
	
		public IEnumerable<IfcPropertySetTemplate> @PartOfPsetTemplate 
		{ 
			get 
			{
				return Model.Instances.Where<IfcPropertySetTemplate>(e => e.HasPropertyTemplates != null &&  e.HasPropertyTemplates.Contains(this));
			} 
		}
	

		#endregion

		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
				case 3: 
					base.Parse(propIndex, value); 
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
			return "";
		}
		#endregion
	}
}