// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 09:16:37
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc2x3.GeometricConstraintResource
{
	[EntityName("IFCCONNECTIONPOINTGEOMETRY")]
	public  partial class @IfcConnectionPointGeometry : IfcConnectionGeometry, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcConnectionPointGeometry(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcPointOrVertexPoint _pointOnRelatingElement;
		private IfcPointOrVertexPoint _pointOnRelatedElement;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(0, EntityAttributeState.Mandatory)]
		public IfcPointOrVertexPoint @PointOnRelatingElement 
		{ 
			get 
			{
				if(IsActivated) return _pointOnRelatingElement;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _pointOnRelatingElement;
			} 
			set
			{
				SetValue( v =>  _pointOnRelatingElement = v, _pointOnRelatingElement, value,  "PointOnRelatingElement");
			} 
		}
	
		[EntityAttribute(1, EntityAttributeState.Optional)]
		public IfcPointOrVertexPoint @PointOnRelatedElement 
		{ 
			get 
			{
				if(IsActivated) return _pointOnRelatedElement;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _pointOnRelatedElement;
			} 
			set
			{
				SetValue( v =>  _pointOnRelatedElement = v, _pointOnRelatedElement, value,  "PointOnRelatedElement");
			} 
		}
	
		#endregion

		#region Inverse attributes

		#endregion

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"PointOnRelatingElement",
			"PointOnRelatedElement",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @PointOnRelatingElement;
				case 1: 
					return @PointOnRelatedElement;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "PointOnRelatingElement":  
					return @PointOnRelatingElement;
				case "PointOnRelatedElement":  
					return @PointOnRelatedElement;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 @PointOnRelatingElement = (IfcPointOrVertexPoint)value;
					 break;
				case 1:
					 @PointOnRelatedElement = (IfcPointOrVertexPoint)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "PointOnRelatingElement":
					 @PointOnRelatingElement = (IfcPointOrVertexPoint)value;
					 break;
				case "PointOnRelatedElement":
					 @PointOnRelatedElement = (IfcPointOrVertexPoint)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion


		#region IPersist implementation
		public void Set(int propIndex, IPropertyValue value)
		{
            throw new System.NotImplementedException();
		}
		#endregion

	}
}