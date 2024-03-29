// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		24.09.2015 10:03:44
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.PresentationDefinitionResource;
using Xbim.Ifc4.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.PresentationAppearanceResource
{
	[IndexedClass]
	[ExpressType("IFCTEXTUREVERTEXLIST", 1102)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcTextureVertexList : IfcPresentationItem, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTextureVertexList(IModel model) : base(model) 		{ 
			Model = model; 
			_texCoordsList = new ItemSet<ItemSet<IfcParameterValue>>( this );
		}

		#region Explicit attribute fields
		private ItemSet<ItemSet<IfcParameterValue>> _texCoordsList;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.List, 1, -1)]
		public ItemSet<ItemSet<IfcParameterValue>> @TexCoordsList 
		{ 
			get 
			{
				if(Activated) return _texCoordsList;
				
				Model.Activate(this, true);
				Activated = true;
				return _texCoordsList;
			} 
		}
	
		#endregion



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
					//this is a special case which has to be handled in a partial class which is not generated.
					//ParseTexCoordsList(propIndex, value);
					//return;
					throw new System.NotImplementedException("TexCoordsList in IfcTextureVertexList is a special case of nested lists. It is not implemented for now.");
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