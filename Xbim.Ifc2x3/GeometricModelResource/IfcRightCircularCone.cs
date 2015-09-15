// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		15.09.2015 07:04:18
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
	[EntityName("IFCRIGHTCIRCULARCONE", 703)]
	public  partial class @IfcRightCircularCone : IfcCsgPrimitive3D, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRightCircularCone(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcPositiveLengthMeasure _height;
		private IfcPositiveLengthMeasure _bottomRadius;
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
		public IfcPositiveLengthMeasure @BottomRadius 
		{ 
			get 
			{
				if(Activated) return _bottomRadius;
				
				Model.Activate(this, true);
				Activated = true;
				return _bottomRadius;
			} 
			set
			{
				SetValue( v =>  _bottomRadius = v, _bottomRadius, value,  "BottomRadius");
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
			"BottomRadius",
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
					return @BottomRadius;
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
				case "BottomRadius":  
					return @BottomRadius;
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
					 if (value != null) @BottomRadius = (IfcPositiveLengthMeasure)value;
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
				case "BottomRadius":
					 if (value != null) @BottomRadius = (IfcPositiveLengthMeasure)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion


		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
            throw new System.NotImplementedException();
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		}
		#endregion

		
	}
}