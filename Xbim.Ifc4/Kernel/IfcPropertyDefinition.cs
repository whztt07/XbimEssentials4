// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		21.09.2015 05:11:20
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
	[IndexedClass]
	[ExpressType("IFCPROPERTYDEFINITION", 851)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcPropertyDefinition : IfcRoot, IfcDefinitionSelect
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPropertyDefinition(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		#endregion
	
		#region Explicit attribute properties
		#endregion

		#region Inverse attributes
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcRelDeclares> @HasContext 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelDeclares>(e => e.RelatedDefinitions != null &&  e.RelatedDefinitions.Contains(this));
			} 
		}
	
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcRelAssociates> @HasAssociations 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelAssociates>(e => e.RelatedObjects != null &&  e.RelatedObjects.Contains(this));
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