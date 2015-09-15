// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		15.09.2015 07:03:37
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc4.GeometryResource
{
	[EntityName("IFCCARTESIANTRANSFORMATIONOPERATOR3DNONUNIFORM", 83)]
	public  partial class @IfcCartesianTransformationOperator3DnonUniform : IfcCartesianTransformationOperator3D, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcCartesianTransformationOperator3DnonUniform(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private double? _scale2;
		private double? _scale3;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(5, EntityAttributeState.Optional)]
		public double? @Scale2 
		{ 
			get 
			{
				if(Activated) return _scale2;
				
				Model.Activate(this, true);
				Activated = true;
				return _scale2;
			} 
			set
			{
				SetValue( v =>  _scale2 = v, _scale2, value,  "Scale2");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Optional)]
		public double? @Scale3 
		{ 
			get 
			{
				if(Activated) return _scale3;
				
				Model.Activate(this, true);
				Activated = true;
				return _scale3;
			} 
			set
			{
				SetValue( v =>  _scale3 = v, _scale3, value,  "Scale3");
			} 
		}
	
		#endregion

		#region Inverse attributes

		#endregion

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"Axis1",
			"Axis2",
			"LocalOrigin",
			"Scale",
			"Axis3",
			"Scale2",
			"Scale3",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @Axis1;
				case 1: 
					return @Axis2;
				case 2: 
					return @LocalOrigin;
				case 3: 
					return @Scale;
				case 4: 
					return @Axis3;
				case 5: 
					return @Scale2;
				case 6: 
					return @Scale3;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "Axis1":  
					return @Axis1;
				case "Axis2":  
					return @Axis2;
				case "LocalOrigin":  
					return @LocalOrigin;
				case "Scale":  
					return @Scale;
				case "Axis3":  
					return @Axis3;
				case "Scale2":  
					return @Scale2;
				case "Scale3":  
					return @Scale3;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 @Axis1 = (IfcDirection)value;
					 break;
				case 1:
					 @Axis2 = (IfcDirection)value;
					 break;
				case 2:
					 @LocalOrigin = (IfcCartesianPoint)value;
					 break;
				case 3:
					 @Scale = (double?)value;
					 break;
				case 4:
					 @Axis3 = (IfcDirection)value;
					 break;
				case 5:
					 @Scale2 = (double?)value;
					 break;
				case 6:
					 @Scale3 = (double?)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "Axis1":
					 @Axis1 = (IfcDirection)value;
					 break;
				case "Axis2":
					 @Axis2 = (IfcDirection)value;
					 break;
				case "LocalOrigin":
					 @LocalOrigin = (IfcCartesianPoint)value;
					 break;
				case "Scale":
					 @Scale = (double?)value;
					 break;
				case "Axis3":
					 @Axis3 = (IfcDirection)value;
					 break;
				case "Scale2":
					 @Scale2 = (double?)value;
					 break;
				case "Scale3":
					 @Scale3 = (double?)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion

		#region Where rules
		/*Scale2GreaterZero:	Scale2GreaterZero : Scl2 > 0.0;*/
		/*Scale3GreaterZero:	Scale3GreaterZero : Scl3 > 0.0;*/
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