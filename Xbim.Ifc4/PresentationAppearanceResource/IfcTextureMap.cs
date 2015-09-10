// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		09/09/2015 04:20:44
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.TopologyResource;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc4.PresentationAppearanceResource
{
	[EntityName("IFCTEXTUREMAP", 709)]
	public  partial class @IfcTextureMap : IfcTextureCoordinate, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTextureMap(IModel model) : base(model) 		{ 
			Model = model; 
			_vertices = new ItemSet<IfcTextureVertex>( model );
		}

		#region Explicit attribute fields
		private ItemSet<IfcTextureVertex> _vertices;
		private IfcFace _mappedTo;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory)]
		public ItemSet<IfcTextureVertex> @Vertices 
		{ 
			get 
			{
				if(Activated) return _vertices;
				
				Model.Activate(this, true);
				Activated = true;
				return _vertices;
			} 
			set
			{
				SetValue( v =>  _vertices = v, _vertices, value,  "Vertices");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Mandatory)]
		public IfcFace @MappedTo 
		{ 
			get 
			{
				if(Activated) return _mappedTo;
				
				Model.Activate(this, true);
				Activated = true;
				return _mappedTo;
			} 
			set
			{
				SetValue( v =>  _mappedTo = v, _mappedTo, value,  "MappedTo");
			} 
		}
	
		#endregion

		#region Inverse attributes

		#endregion

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"Maps",
			"Vertices",
			"MappedTo",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @Maps;
				case 1: 
					return @Vertices;
				case 2: 
					return @MappedTo;
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
				case "Vertices":  
					return @Vertices;
				case "MappedTo":  
					return @MappedTo;
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
					 @Vertices.Add((IfcTextureVertex)value);
					 break;
				case 2:
					 @MappedTo = (IfcFace)value;
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
				case "Vertices":
					 @Vertices.Add((IfcTextureVertex)value);
					 break;
				case "MappedTo":
					 @MappedTo = (IfcFace)value;
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