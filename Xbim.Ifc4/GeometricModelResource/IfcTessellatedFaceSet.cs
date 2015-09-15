// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		15.09.2015 07:03:42
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.PresentationAppearanceResource;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc4.GeometricModelResource
{
	[EntityName("IFCTESSELLATEDFACESET", 699)]
	public abstract partial class @IfcTessellatedFaceSet : IfcTessellatedItem
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTessellatedFaceSet(IModel model) : base(model) 		{ 
			Model = model; 
			_normals = new ItemSet<ItemSet<IfcParameterValue>>( model );
		}

		#region Explicit attribute fields
		private IfcCartesianPointList3D _coordinates;
		private ItemSet<ItemSet<IfcParameterValue>> _normals;
		private bool? _closed;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(0, EntityAttributeState.Mandatory)]
		public IfcCartesianPointList3D @Coordinates 
		{ 
			get 
			{
				if(Activated) return _coordinates;
				
				Model.Activate(this, true);
				Activated = true;
				return _coordinates;
			} 
			set
			{
				SetValue( v =>  _coordinates = v, _coordinates, value,  "Coordinates");
			} 
		}
	
		[EntityAttribute(1, EntityAttributeState.Optional)]
		public ItemSet<ItemSet<IfcParameterValue>> @Normals 
		{ 
			get 
			{
				if(Activated) return _normals;
				
				Model.Activate(this, true);
				Activated = true;
				return _normals;
			} 
			set
			{
				SetValue( v =>  _normals = v, _normals, value,  "Normals");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Optional)]
		public bool? @Closed 
		{ 
			get 
			{
				if(Activated) return _closed;
				
				Model.Activate(this, true);
				Activated = true;
				return _closed;
			} 
			set
			{
				SetValue( v =>  _closed = v, _closed, value,  "Closed");
			} 
		}
	
		#endregion

		#region Inverse attributes
		public IEnumerable<IfcIndexedColourMap> @HasColours 
		{ 
			get 
			{
				return Model.Instances.Where<IfcIndexedColourMap>(e => e.MappedTo == this);
			} 
		}
	
		public IEnumerable<IfcIndexedTextureMap> @HasTextures 
		{ 
			get 
			{
				return Model.Instances.Where<IfcIndexedTextureMap>(e => e.MappedTo == this);
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