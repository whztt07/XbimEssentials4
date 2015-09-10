// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		09/09/2015 04:20:36
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.GeometryResource;
using Xbim.Ifc2x3.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc2x3.GeometricModelResource
{
	[EntityName("IFCRIGHTCIRCULARCYLINDER", 704)]
	public  partial class @IfcRightCircularCylinder : IfcCsgPrimitive3D, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRightCircularCylinder(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcPositiveLengthMeasure _height;
		private IfcPositiveLengthMeasure _radius;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory)]
		public IfcPositiveLengthMeasure @Height 
		{ 
			get 
			{
				if(Activated) return _height;
				
				Model.Activate(this, true);
				Activated = true;
				return _height;
			} 
			set
			{
				SetValue( v =>  _height = v, _height, value,  "Height");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Mandatory)]
		public IfcPositiveLengthMeasure @Radius 
		{ 
			get 
			{
				if(Activated) return _radius;
				
				Model.Activate(this, true);
				Activated = true;
				return _radius;
			} 
			set
			{
				SetValue( v =>  _radius = v, _radius, value,  "Radius");
			} 
		}
	
		#endregion

		#region Inverse attributes

		#endregion

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"Position",
			"Height",
			"Radius",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @Position;
				case 1: 
					return @Height;
				case 2: 
					return @Radius;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "Position":  
					return @Position;
				case "Height":  
					return @Height;
				case "Radius":  
					return @Radius;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 @Position = (IfcAxis2Placement3D)value;
					 break;
				case 1:
					 if (value != null) @Height = (IfcPositiveLengthMeasure)value;
					 break;
				case 2:
					 if (value != null) @Radius = (IfcPositiveLengthMeasure)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "Position":
					 @Position = (IfcAxis2Placement3D)value;
					 break;
				case "Height":
					 if (value != null) @Height = (IfcPositiveLengthMeasure)value;
					 break;
				case "Radius":
					 if (value != null) @Radius = (IfcPositiveLengthMeasure)value;
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