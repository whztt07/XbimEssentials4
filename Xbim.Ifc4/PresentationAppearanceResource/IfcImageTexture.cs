// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		09/09/2015 04:20:41
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.GeometryResource;
using Xbim.Ifc4.ExternalReferenceResource;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc4.PresentationAppearanceResource
{
	[EntityName("IFCIMAGETEXTURE", 315)]
	public  partial class @IfcImageTexture : IfcSurfaceTexture, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcImageTexture(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcURIReference _uRLReference;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(5, EntityAttributeState.Mandatory)]
		public IfcURIReference @URLReference 
		{ 
			get 
			{
				if(Activated) return _uRLReference;
				
				Model.Activate(this, true);
				Activated = true;
				return _uRLReference;
			} 
			set
			{
				SetValue( v =>  _uRLReference = v, _uRLReference, value,  "URLReference");
			} 
		}
	
		#endregion

		#region Inverse attributes

		#endregion

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"RepeatS",
			"RepeatT",
			"Mode",
			"TextureTransform",
			"Parameter",
			"URLReference",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @RepeatS;
				case 1: 
					return @RepeatT;
				case 2: 
					return @Mode;
				case 3: 
					return @TextureTransform;
				case 4: 
					return @Parameter;
				case 5: 
					return @URLReference;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "RepeatS":  
					return @RepeatS;
				case "RepeatT":  
					return @RepeatT;
				case "Mode":  
					return @Mode;
				case "TextureTransform":  
					return @TextureTransform;
				case "Parameter":  
					return @Parameter;
				case "URLReference":  
					return @URLReference;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 if (value != null) @RepeatS = (bool)value;
					 break;
				case 1:
					 if (value != null) @RepeatT = (bool)value;
					 break;
				case 2:
					 @Mode = (IfcIdentifier?)value;
					 break;
				case 3:
					 @TextureTransform = (IfcCartesianTransformationOperator2D)value;
					 break;
				case 4:
					 @Parameter = (ItemSet<IfcIdentifier>)value;
					 break;
				case 5:
					 if (value != null) @URLReference = (IfcURIReference)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "RepeatS":
					 if (value != null) @RepeatS = (bool)value;
					 break;
				case "RepeatT":
					 if (value != null) @RepeatT = (bool)value;
					 break;
				case "Mode":
					 @Mode = (IfcIdentifier?)value;
					 break;
				case "TextureTransform":
					 @TextureTransform = (IfcCartesianTransformationOperator2D)value;
					 break;
				case "Parameter":
					 @Parameter = (ItemSet<IfcIdentifier>)value;
					 break;
				case "URLReference":
					 if (value != null) @URLReference = (IfcURIReference)value;
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