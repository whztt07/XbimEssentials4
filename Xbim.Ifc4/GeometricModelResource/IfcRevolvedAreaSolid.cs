// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		09/09/2015 04:20:43
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.ProfileResource;
using Xbim.Ifc4.GeometryResource;
using Xbim.Ifc4.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc4.GeometricModelResource
{
	[EntityName("IFCREVOLVEDAREASOLID", 568)]
	public  partial class @IfcRevolvedAreaSolid : IfcSweptAreaSolid, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRevolvedAreaSolid(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcAxis1Placement _axis;
		private IfcPlaneAngleMeasure _angle;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Mandatory)]
		public IfcAxis1Placement @Axis 
		{ 
			get 
			{
				if(Activated) return _axis;
				
				Model.Activate(this, true);
				Activated = true;
				return _axis;
			} 
			set
			{
				SetValue( v =>  _axis = v, _axis, value,  "Axis");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Mandatory)]
		public IfcPlaneAngleMeasure @Angle 
		{ 
			get 
			{
				if(Activated) return _angle;
				
				Model.Activate(this, true);
				Activated = true;
				return _angle;
			} 
			set
			{
				SetValue( v =>  _angle = v, _angle, value,  "Angle");
			} 
		}
	
		#endregion

		#region Inverse attributes

		#endregion

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"SweptArea",
			"Position",
			"Axis",
			"Angle",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @SweptArea;
				case 1: 
					return @Position;
				case 2: 
					return @Axis;
				case 3: 
					return @Angle;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "SweptArea":  
					return @SweptArea;
				case "Position":  
					return @Position;
				case "Axis":  
					return @Axis;
				case "Angle":  
					return @Angle;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 @SweptArea = (IfcProfileDef)value;
					 break;
				case 1:
					 @Position = (IfcAxis2Placement3D)value;
					 break;
				case 2:
					 @Axis = (IfcAxis1Placement)value;
					 break;
				case 3:
					 if (value != null) @Angle = (IfcPlaneAngleMeasure)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "SweptArea":
					 @SweptArea = (IfcProfileDef)value;
					 break;
				case "Position":
					 @Position = (IfcAxis2Placement3D)value;
					 break;
				case "Axis":
					 @Axis = (IfcAxis1Placement)value;
					 break;
				case "Angle":
					 if (value != null) @Angle = (IfcPlaneAngleMeasure)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion

		#region Where rules
		/*AxisStartInXY:	AxisStartInXY : Axis.Location.Coordinates[3] = 0.0;*/
		/*AxisDirectionInXY:	AxisDirectionInXY : Axis.Z.DirectionRatios[3] = 0.0;*/
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