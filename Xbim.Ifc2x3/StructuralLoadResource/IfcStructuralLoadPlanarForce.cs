// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 09:16:39
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc2x3.StructuralLoadResource
{
	[EntityName("IFCSTRUCTURALLOADPLANARFORCE")]
	public  partial class @IfcStructuralLoadPlanarForce : IfcStructuralLoadStatic, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcStructuralLoadPlanarForce(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcPlanarForceMeasure? _planarForceX;
		private IfcPlanarForceMeasure? _planarForceY;
		private IfcPlanarForceMeasure? _planarForceZ;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Optional)]
		public IfcPlanarForceMeasure? @PlanarForceX 
		{ 
			get 
			{
				if(IsActivated) return _planarForceX;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _planarForceX;
			} 
			set
			{
				SetValue( v =>  _planarForceX = v, _planarForceX, value,  "PlanarForceX");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Optional)]
		public IfcPlanarForceMeasure? @PlanarForceY 
		{ 
			get 
			{
				if(IsActivated) return _planarForceY;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _planarForceY;
			} 
			set
			{
				SetValue( v =>  _planarForceY = v, _planarForceY, value,  "PlanarForceY");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Optional)]
		public IfcPlanarForceMeasure? @PlanarForceZ 
		{ 
			get 
			{
				if(IsActivated) return _planarForceZ;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _planarForceZ;
			} 
			set
			{
				SetValue( v =>  _planarForceZ = v, _planarForceZ, value,  "PlanarForceZ");
			} 
		}
	
		#endregion

		#region Inverse attributes

		#endregion

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"Name",
			"PlanarForceX",
			"PlanarForceY",
			"PlanarForceZ",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @Name;
				case 1: 
					return @PlanarForceX;
				case 2: 
					return @PlanarForceY;
				case 3: 
					return @PlanarForceZ;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "Name":  
					return @Name;
				case "PlanarForceX":  
					return @PlanarForceX;
				case "PlanarForceY":  
					return @PlanarForceY;
				case "PlanarForceZ":  
					return @PlanarForceZ;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 @Name = (IfcLabel?)value;
					 break;
				case 1:
					 @PlanarForceX = (IfcPlanarForceMeasure?)value;
					 break;
				case 2:
					 @PlanarForceY = (IfcPlanarForceMeasure?)value;
					 break;
				case 3:
					 @PlanarForceZ = (IfcPlanarForceMeasure?)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "Name":
					 @Name = (IfcLabel?)value;
					 break;
				case "PlanarForceX":
					 @PlanarForceX = (IfcPlanarForceMeasure?)value;
					 break;
				case "PlanarForceY":
					 @PlanarForceY = (IfcPlanarForceMeasure?)value;
					 break;
				case "PlanarForceZ":
					 @PlanarForceZ = (IfcPlanarForceMeasure?)value;
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