// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 03:44:07
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.TopologyResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.PresentationAppearanceResource
{
	[EntityName("IFCTEXTUREMAP", 709)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcTextureMap : IfcTextureCoordinate, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTextureMap(IModel model) : base(model) 		{ 
			Model = model; 
			_vertices = new ItemSet<IfcTextureVertex>( this );
		}

		#region Explicit attribute fields
		private ItemSet<IfcTextureVertex> _vertices;
		private IfcFace _mappedTo;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttributee(1, EntityAttributeState.Mandatory)]
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
	
		[EntityAttributee(2, EntityAttributeState.Mandatory)]
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

		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
					base.Parse(propIndex, value); 
					return;
				case 1: 
					if (_vertices == null) _vertices = new ItemSet<IfcTextureVertex>( this );
					_vertices.InternalAdd((IfcTextureVertex)value.EntityVal);
					return;
				case 2: 
					_mappedTo = (IfcFace)(value.EntityVal);
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