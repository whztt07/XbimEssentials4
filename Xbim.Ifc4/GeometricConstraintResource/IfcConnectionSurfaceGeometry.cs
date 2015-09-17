// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 03:44:03
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.GeometricConstraintResource
{
	[EntityName("IFCCONNECTIONSURFACEGEOMETRY", 123)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcConnectionSurfaceGeometry : IfcConnectionGeometry, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcConnectionSurfaceGeometry(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcSurfaceOrFaceSurface _surfaceOnRelatingElement;
		private IfcSurfaceOrFaceSurface _surfaceOnRelatedElement;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(0, EntityAttributeState.Mandatory)]
		public IfcSurfaceOrFaceSurface @SurfaceOnRelatingElement 
		{ 
			get 
			{
				if(Activated) return _surfaceOnRelatingElement;
				
				Model.Activate(this, true);
				Activated = true;
				return _surfaceOnRelatingElement;
			} 
			set
			{
				SetValue( v =>  _surfaceOnRelatingElement = v, _surfaceOnRelatingElement, value,  "SurfaceOnRelatingElement");
			} 
		}
	
		[EntityAttribute(1, EntityAttributeState.Optional)]
		public IfcSurfaceOrFaceSurface @SurfaceOnRelatedElement 
		{ 
			get 
			{
				if(Activated) return _surfaceOnRelatedElement;
				
				Model.Activate(this, true);
				Activated = true;
				return _surfaceOnRelatedElement;
			} 
			set
			{
				SetValue( v =>  _surfaceOnRelatedElement = v, _surfaceOnRelatedElement, value,  "SurfaceOnRelatedElement");
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
					_surfaceOnRelatingElement = (IfcSurfaceOrFaceSurface)(value.EntityVal);
					return;
				case 1: 
					_surfaceOnRelatedElement = (IfcSurfaceOrFaceSurface)(value.EntityVal);
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