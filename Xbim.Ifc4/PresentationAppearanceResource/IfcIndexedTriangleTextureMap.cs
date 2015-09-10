// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		09/09/2015 04:20:42
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.GeometricModelResource;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc4.PresentationAppearanceResource
{
	[EntityName("IFCINDEXEDTRIANGLETEXTUREMAP", 318)]
	public  partial class @IfcIndexedTriangleTextureMap : IfcIndexedTextureMap, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcIndexedTriangleTextureMap(IModel model) : base(model) 		{ 
			Model = model; 
			_texCoordIndex = new ItemSet<ItemSet<long>>( model );
		}

		#region Explicit attribute fields
		private ItemSet<ItemSet<long>> _texCoordIndex;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(3, EntityAttributeState.Optional)]
		public ItemSet<ItemSet<long>> @TexCoordIndex 
		{ 
			get 
			{
				if(Activated) return _texCoordIndex;
				
				Model.Activate(this, true);
				Activated = true;
				return _texCoordIndex;
			} 
			set
			{
				SetValue( v =>  _texCoordIndex = v, _texCoordIndex, value,  "TexCoordIndex");
			} 
		}
	
		#endregion

		#region Inverse attributes

		#endregion

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"Maps",
			"MappedTo",
			"TexCoords",
			"TexCoordIndex",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @Maps;
				case 1: 
					return @MappedTo;
				case 2: 
					return @TexCoords;
				case 3: 
					return @TexCoordIndex;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "Maps":  
					return @Maps;
				case "MappedTo":  
					return @MappedTo;
				case "TexCoords":  
					return @TexCoords;
				case "TexCoordIndex":  
					return @TexCoordIndex;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 @Maps.Add((IfcSurfaceTexture)value);
					 break;
				case 1:
					 @MappedTo = (IfcTessellatedFaceSet)value;
					 break;
				case 2:
					 @TexCoords = (IfcTextureVertexList)value;
					 break;
				case 3:
					 @TexCoordIndex = (ItemSet<ItemSet<long>>)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "Maps":
					 @Maps.Add((IfcSurfaceTexture)value);
					 break;
				case "MappedTo":
					 @MappedTo = (IfcTessellatedFaceSet)value;
					 break;
				case "TexCoords":
					 @TexCoords = (IfcTextureVertexList)value;
					 break;
				case "TexCoordIndex":
					 @TexCoordIndex = (ItemSet<ItemSet<long>>)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion


		#region IPersist implementation
		void IPersist.Set(int propIndex, IPropertyValue value)
		{
            throw new System.NotImplementedException();
		}
		#endregion

		public  override string WhereRule() 
		{
			return "";
		}
	}
}