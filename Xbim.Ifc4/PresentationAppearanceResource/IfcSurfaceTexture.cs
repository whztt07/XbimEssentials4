// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.PresentationDefinitionResource;
using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.GeometryResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.PresentationAppearanceResource
{
	[ExpressType("IFCSURFACETEXTURE", 1065)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcSurfaceTexture : IfcPresentationItem
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcSurfaceTexture(IModel model) : base(model) 		{ 
			Model = model; 
			_parameter = new OptionalItemSet<IfcIdentifier>( this );
		}

		#region Explicit attribute fields
		private bool _repeatS;
		private bool _repeatT;
		private IfcIdentifier? _mode;
		private IfcCartesianTransformationOperator2D _textureTransform;
		private OptionalItemSet<IfcIdentifier> _parameter;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public bool @RepeatS 
		{ 
			get 
			{
				if(Activated) return _repeatS;
				
				Model.Activate(this, true);
				Activated = true;
				return _repeatS;
			} 
			set
			{
				SetValue( v =>  _repeatS = v, _repeatS, value,  "RepeatS");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public bool @RepeatT 
		{ 
			get 
			{
				if(Activated) return _repeatT;
				
				Model.Activate(this, true);
				Activated = true;
				return _repeatT;
			} 
			set
			{
				SetValue( v =>  _repeatT = v, _repeatT, value,  "RepeatT");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcIdentifier? @Mode 
		{ 
			get 
			{
				if(Activated) return _mode;
				
				Model.Activate(this, true);
				Activated = true;
				return _mode;
			} 
			set
			{
				SetValue( v =>  _mode = v, _mode, value,  "Mode");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcCartesianTransformationOperator2D @TextureTransform 
		{ 
			get 
			{
				if(Activated) return _textureTransform;
				
				Model.Activate(this, true);
				Activated = true;
				return _textureTransform;
			} 
			set
			{
				SetValue( v =>  _textureTransform = v, _textureTransform, value,  "TextureTransform");
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.None, 1, -1)]
		public OptionalItemSet<IfcIdentifier> @Parameter 
		{ 
			get 
			{
				if(Activated) return _parameter;
				
				Model.Activate(this, true);
				Activated = true;
				return _parameter;
			} 
		}
	
		#endregion

		#region Inverse attributes
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcTextureCoordinate> @IsMappedBy 
		{ 
			get 
			{
				return Model.Instances.Where<IfcTextureCoordinate>(e => e.Maps != null &&  e.Maps.Contains(this));
			} 
		}
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcSurfaceStyleWithTextures> @UsedInStyles 
		{ 
			get 
			{
				return Model.Instances.Where<IfcSurfaceStyleWithTextures>(e => e.Textures != null &&  e.Textures.Contains(this));
			} 
		}
		#endregion


		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
					_repeatS = value.BooleanVal;
					return;
				case 1: 
					_repeatT = value.BooleanVal;
					return;
				case 2: 
					_mode = value.StringVal;
					return;
				case 3: 
					_textureTransform = (IfcCartesianTransformationOperator2D)(value.EntityVal);
					return;
				case 4: 
					if (_parameter == null) _parameter = new OptionalItemSet<IfcIdentifier>( this );
					_parameter.InternalAdd(value.StringVal);
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