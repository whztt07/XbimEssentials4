// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		09/09/2015 04:20:36
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.ProfileResource;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc2x3.GeometryResource
{
	[EntityName("IFCSURFACEOFREVOLUTION", 109)]
	public  partial class @IfcSurfaceOfRevolution : IfcSweptSurface, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcSurfaceOfRevolution(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcAxis1Placement _axisPosition;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Mandatory)]
		public IfcAxis1Placement @AxisPosition 
		{ 
			get 
			{
				if(Activated) return _axisPosition;
				
				Model.Activate(this, true);
				Activated = true;
				return _axisPosition;
			} 
			set
			{
				SetValue( v =>  _axisPosition = v, _axisPosition, value,  "AxisPosition");
			} 
		}
	
		#endregion

		#region Inverse attributes

		#endregion

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"SweptCurve",
			"Position",
			"AxisPosition",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @SweptCurve;
				case 1: 
					return @Position;
				case 2: 
					return @AxisPosition;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "SweptCurve":  
					return @SweptCurve;
				case "Position":  
					return @Position;
				case "AxisPosition":  
					return @AxisPosition;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 @SweptCurve = (IfcProfileDef)value;
					 break;
				case 1:
					 @Position = (IfcAxis2Placement3D)value;
					 break;
				case 2:
					 @AxisPosition = (IfcAxis1Placement)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "SweptCurve":
					 @SweptCurve = (IfcProfileDef)value;
					 break;
				case "Position":
					 @Position = (IfcAxis2Placement3D)value;
					 break;
				case "AxisPosition":
					 @AxisPosition = (IfcAxis1Placement)value;
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