// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		22.09.2015 04:44:04
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.GeometricConstraintResource;
using Xbim.Ifc2x3.GeometryResource;
using Xbim.Ifc2x3.TopologyResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.GeometricModelResource
{
	[IndexedClass]
	[ExpressType("IFCFACEBASEDSURFACEMODEL", 438)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcFaceBasedSurfaceModel : IfcGeometricRepresentationItem, IfcSurfaceOrFaceSurface, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcFaceBasedSurfaceModel(IModel model) : base(model) 		{ 
			Model = model; 
			_fbsmFaces = new ItemSet<IfcConnectedFaceSet>( this );
		}

		#region Explicit attribute fields
		private ItemSet<IfcConnectedFaceSet> _fbsmFaces;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1)]
		public ItemSet<IfcConnectedFaceSet> @FbsmFaces 
		{ 
			get 
			{
				if(Activated) return _fbsmFaces;
				
				Model.Activate(this, true);
				Activated = true;
				return _fbsmFaces;
			} 
		}
	
		#endregion



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
					if (_fbsmFaces == null) _fbsmFaces = new ItemSet<IfcConnectedFaceSet>( this );
					_fbsmFaces.InternalAdd((IfcConnectedFaceSet)value.EntityVal);
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