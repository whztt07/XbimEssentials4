// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 09:16:37
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc2x3.GeometricConstraintResource
{
	[EntityName("IFCCONNECTIONPOINTECCENTRICITY")]
	public  partial class @IfcConnectionPointEccentricity : IfcConnectionPointGeometry, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcConnectionPointEccentricity(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcLengthMeasure? _eccentricityInX;
		private IfcLengthMeasure? _eccentricityInY;
		private IfcLengthMeasure? _eccentricityInZ;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Optional)]
		public IfcLengthMeasure? @EccentricityInX 
		{ 
			get 
			{
				if(IsActivated) return _eccentricityInX;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _eccentricityInX;
			} 
			set
			{
				SetValue( v =>  _eccentricityInX = v, _eccentricityInX, value,  "EccentricityInX");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Optional)]
		public IfcLengthMeasure? @EccentricityInY 
		{ 
			get 
			{
				if(IsActivated) return _eccentricityInY;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _eccentricityInY;
			} 
			set
			{
				SetValue( v =>  _eccentricityInY = v, _eccentricityInY, value,  "EccentricityInY");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Optional)]
		public IfcLengthMeasure? @EccentricityInZ 
		{ 
			get 
			{
				if(IsActivated) return _eccentricityInZ;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _eccentricityInZ;
			} 
			set
			{
				SetValue( v =>  _eccentricityInZ = v, _eccentricityInZ, value,  "EccentricityInZ");
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
			"EccentricityInX",
			"EccentricityInY",
			"EccentricityInZ",
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
				case 2: 
					return @EccentricityInX;
				case 3: 
					return @EccentricityInY;
				case 4: 
					return @EccentricityInZ;
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
				case "EccentricityInX":  
					return @EccentricityInX;
				case "EccentricityInY":  
					return @EccentricityInY;
				case "EccentricityInZ":  
					return @EccentricityInZ;
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
				case 2:
					 @EccentricityInX = (IfcLengthMeasure?)value;
					 break;
				case 3:
					 @EccentricityInY = (IfcLengthMeasure?)value;
					 break;
				case 4:
					 @EccentricityInZ = (IfcLengthMeasure?)value;
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
				case "EccentricityInX":
					 @EccentricityInX = (IfcLengthMeasure?)value;
					 break;
				case "EccentricityInY":
					 @EccentricityInY = (IfcLengthMeasure?)value;
					 break;
				case "EccentricityInZ":
					 @EccentricityInZ = (IfcLengthMeasure?)value;
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