// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		15.09.2015 07:04:14
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc2x3.GeometryResource
{
	[EntityName("IFCAXIS2PLACEMENT3D", 448)]
	public  partial class @IfcAxis2Placement3D : IfcPlacement, IfcAxis2Placement, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcAxis2Placement3D(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcDirection _axis;
		private IfcDirection _refDirection;
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
	
		[EntityAttribute(2, EntityAttributeState.Optional)]
		public IfcDirection @RefDirection 
		{ 
			get 
			{
				if(Activated) return _refDirection;
				
				Model.Activate(this, true);
				Activated = true;
				return _refDirection;
			} 
			set
			{
				SetValue( v =>  _refDirection = v, _refDirection, value,  "RefDirection");
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
			"RefDirection",
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
				case 2: 
					return @RefDirection;
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
				case "RefDirection":  
					return @RefDirection;
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
				case 2:
					 @RefDirection = (IfcDirection)value;
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
				case "RefDirection":
					 @RefDirection = (IfcDirection)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion

		#region Where rules
		/*WR1:	WR1 : SELF\IfcPlacement.Location.Dim = 3;*/
		/*WR2:	WR2 : (NOT (EXISTS (Axis))) OR (Axis.Dim = 3);*/
		/*WR3:	WR3 : (NOT (EXISTS (RefDirection))) OR (RefDirection.Dim = 3);*/
		/*WR4:	WR4 : (NOT (EXISTS (Axis))) OR (NOT (EXISTS (RefDirection))) OR (IfcCrossProduct(Axis,RefDirection).Magnitude > 0.0);*/
		/*WR5:	WR5 : NOT ((EXISTS (Axis)) XOR (EXISTS (RefDirection)));*/
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