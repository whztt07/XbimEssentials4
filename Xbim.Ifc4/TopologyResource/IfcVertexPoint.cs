// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 02:29:24
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.GeometricConstraintResource;
using Xbim.Ifc4.GeometryResource;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc4.TopologyResource
{
	[EntityName("IFCVERTEXPOINT", 741)]
	public  partial class @IfcVertexPoint : IfcVertex, IfcPointOrVertexPoint, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcVertexPoint(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcPoint _vertexGeometry;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(0, EntityAttributeState.Mandatory)]
		public IfcPoint @VertexGeometry 
		{ 
			get 
			{
				if(Activated) return _vertexGeometry;
				
				Model.Activate(this, true);
				Activated = true;
				return _vertexGeometry;
			} 
			set
			{
				SetValue( v =>  _vertexGeometry = v, _vertexGeometry, value,  "VertexGeometry");
			} 
		}
	
		#endregion

		#region Inverse attributes

		#endregion

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"VertexGeometry",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @VertexGeometry;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "VertexGeometry":  
					return @VertexGeometry;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 @VertexGeometry = (IfcPoint)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "VertexGeometry":
					 @VertexGeometry = (IfcPoint)value;
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