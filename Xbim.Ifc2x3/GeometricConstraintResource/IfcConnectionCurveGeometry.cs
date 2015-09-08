// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 02:29:12
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc2x3.GeometricConstraintResource
{
	[EntityName("IFCCONNECTIONCURVEGEOMETRY", 100)]
	public  partial class @IfcConnectionCurveGeometry : IfcConnectionGeometry, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcConnectionCurveGeometry(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcCurveOrEdgeCurve _curveOnRelatingElement;
		private IfcCurveOrEdgeCurve _curveOnRelatedElement;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(0, EntityAttributeState.Mandatory)]
		public IfcCurveOrEdgeCurve @CurveOnRelatingElement 
		{ 
			get 
			{
				if(Activated) return _curveOnRelatingElement;
				
				Model.Activate(this, true);
				Activated = true;
				return _curveOnRelatingElement;
			} 
			set
			{
				SetValue( v =>  _curveOnRelatingElement = v, _curveOnRelatingElement, value,  "CurveOnRelatingElement");
			} 
		}
	
		[EntityAttribute(1, EntityAttributeState.Optional)]
		public IfcCurveOrEdgeCurve @CurveOnRelatedElement 
		{ 
			get 
			{
				if(Activated) return _curveOnRelatedElement;
				
				Model.Activate(this, true);
				Activated = true;
				return _curveOnRelatedElement;
			} 
			set
			{
				SetValue( v =>  _curveOnRelatedElement = v, _curveOnRelatedElement, value,  "CurveOnRelatedElement");
			} 
		}
	
		#endregion

		#region Inverse attributes

		#endregion

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"CurveOnRelatingElement",
			"CurveOnRelatedElement",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @CurveOnRelatingElement;
				case 1: 
					return @CurveOnRelatedElement;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "CurveOnRelatingElement":  
					return @CurveOnRelatingElement;
				case "CurveOnRelatedElement":  
					return @CurveOnRelatedElement;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 @CurveOnRelatingElement = (IfcCurveOrEdgeCurve)value;
					 break;
				case 1:
					 @CurveOnRelatedElement = (IfcCurveOrEdgeCurve)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "CurveOnRelatingElement":
					 @CurveOnRelatingElement = (IfcCurveOrEdgeCurve)value;
					 break;
				case "CurveOnRelatedElement":
					 @CurveOnRelatedElement = (IfcCurveOrEdgeCurve)value;
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