// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		22.09.2015 02:32:08
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.PresentationDefinitionResource;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.PresentationAppearanceResource
{
	[IndexedClass]
	[ExpressType("IFCTEXTURECOORDINATE", 1098)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcTextureCoordinate : IfcPresentationItem
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTextureCoordinate(IModel model) : base(model) 		{ 
			Model = model; 
			_maps = new ItemSet<IfcSurfaceTexture>( this );
		}

		#region Explicit attribute fields
		private ItemSet<IfcSurfaceTexture> _maps;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.Class, 1, -1)]
		public ItemSet<IfcSurfaceTexture> @Maps 
		{ 
			get 
			{
				if(Activated) return _maps;
				
				Model.Activate(this, true);
				Activated = true;
				return _maps;
			} 
		}
	
		#endregion

		#region Inverse attributes

		#endregion

		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
					if (_maps == null) _maps = new ItemSet<IfcSurfaceTexture>( this );
					_maps.InternalAdd((IfcSurfaceTexture)value.EntityVal);
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