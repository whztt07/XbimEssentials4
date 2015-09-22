// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		22.09.2015 04:44:14
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.GeometryResource;
using Xbim.Ifc4.TopologyResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.GeometricModelResource
{
	[IndexedClass]
	[ExpressType("IFCSHELLBASEDSURFACEMODEL", 981)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcShellBasedSurfaceModel : IfcGeometricRepresentationItem, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcShellBasedSurfaceModel(IModel model) : base(model) 		{ 
			Model = model; 
			_sbsmBoundary = new ItemSet<IfcShell>( this );
		}

		#region Explicit attribute fields
		private ItemSet<IfcShell> _sbsmBoundary;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1)]
		public ItemSet<IfcShell> @SbsmBoundary 
		{ 
			get 
			{
				if(Activated) return _sbsmBoundary;
				
				Model.Activate(this, true);
				Activated = true;
				return _sbsmBoundary;
			} 
		}
	
		#endregion



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
					if (_sbsmBoundary == null) _sbsmBoundary = new ItemSet<IfcShell>( this );
					_sbsmBoundary.InternalAdd((IfcShell)value.EntityVal);
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