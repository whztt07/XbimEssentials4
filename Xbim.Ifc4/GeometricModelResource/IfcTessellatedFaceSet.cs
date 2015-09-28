// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.PresentationAppearanceResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.GeometricModelResource
{
	[ExpressType("IFCTESSELLATEDFACESET", 1090)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcTessellatedFaceSet : IfcTessellatedItem
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTessellatedFaceSet(IModel model) : base(model) 		{ 
			Model = model; 
			_normals = new OptionalItemSet<ItemSet<IfcParameterValue>>( this );
		}

		#region Explicit attribute fields
		private IfcCartesianPointList3D _coordinates;
		private OptionalItemSet<ItemSet<IfcParameterValue>> _normals;
		private bool? _closed;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
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
	
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.List, 1, -1)]
		public OptionalItemSet<ItemSet<IfcParameterValue>> @Normals 
		{ 
			get 
			{
				if(Activated) return _normals;
				
				Model.Activate(this, true);
				Activated = true;
				return _normals;
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
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
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcIndexedColourMap> @HasColours 
		{ 
			get 
			{
				return Model.Instances.Where<IfcIndexedColourMap>(e => e.MappedTo == this);
			} 
		}
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
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
			switch (propIndex)
			{
				case 0: 
					_coordinates = (IfcCartesianPointList3D)(value.EntityVal);
					return;
				case 1: 
					//this is a special case which has to be handled in a partial class which is not generated.
					//ParseNormals(propIndex, value);
					//return;
					throw new System.NotImplementedException("Normals in IfcTessellatedFaceSet is a special case of nested lists. It is not implemented for now.");
				case 2: 
					_closed = value.BooleanVal;
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