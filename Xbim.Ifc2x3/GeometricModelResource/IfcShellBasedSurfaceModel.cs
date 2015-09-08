// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 02:29:15
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.GeometryResource;
using Xbim.Ifc2x3.TopologyResource;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc2x3.GeometricModelResource
{
	[EntityName("IFCSHELLBASEDSURFACEMODEL", 512)]
	public  partial class @IfcShellBasedSurfaceModel : IfcGeometricRepresentationItem, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcShellBasedSurfaceModel(IModel model) : base(model) 		{ 
			Model = model; 
			_sbsmBoundary = new ItemSet<IfcShell>( model );
		}

		#region Explicit attribute fields
		private ItemSet<IfcShell> _sbsmBoundary;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(0, EntityAttributeState.Mandatory)]
		public ItemSet<IfcShell> @SbsmBoundary 
		{ 
			get 
			{
				if(Activated) return _sbsmBoundary;
				
				Model.Activate(this, true);
				Activated = true;
				return _sbsmBoundary;
			} 
			set
			{
				SetValue( v =>  _sbsmBoundary = v, _sbsmBoundary, value,  "SbsmBoundary");
			} 
		}
	
		#endregion

		#region Inverse attributes

		#endregion

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"SbsmBoundary",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @SbsmBoundary;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "SbsmBoundary":  
					return @SbsmBoundary;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 @SbsmBoundary.Add((IfcShell)value);
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "SbsmBoundary":
					 @SbsmBoundary.Add((IfcShell)value);
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

	}
}