// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 02:29:19
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc4.GeometryResource
{
	[EntityName("IFCAXIS1PLACEMENT", 30)]
	public  partial class @IfcAxis1Placement : IfcPlacement, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcAxis1Placement(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcDirection _axis;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Optional)]
		public IfcDirection @Axis 
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
	
		#endregion

		#region Inverse attributes

		#endregion

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"Location",
			"Axis",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @Location;
				case 1: 
					return @Axis;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "Location":  
					return @Location;
				case "Axis":  
					return @Axis;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 @Location = (IfcCartesianPoint)value;
					 break;
				case 1:
					 @Axis = (IfcDirection)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "Location":
					 @Location = (IfcCartesianPoint)value;
					 break;
				case "Axis":
					 @Axis = (IfcDirection)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion

		#region Where rules
		/*AxisIs3D:	AxisIs3D : (NOT (EXISTS (Axis))) OR (Axis.Dim = 3);*/
		/*LocationIs3D:	LocationIs3D : SELF\IfcPlacement.Location.Dim = 3;*/
		#endregion

		#region IPersist implementation
		void IPersist.Set(int propIndex, IPropertyValue value)
		{
            throw new System.NotImplementedException();
		}
		#endregion

	}
}