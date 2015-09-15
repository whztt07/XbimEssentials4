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
	[EntityName("IFCCARTESIANTRANSFORMATIONOPERATOR2DNONUNIFORM", 81)]
	public  partial class @IfcCartesianTransformationOperator2DnonUniform : IfcCartesianTransformationOperator2D, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcCartesianTransformationOperator2DnonUniform(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private double? _scale2;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Optional)]
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
			"Scale2",
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
					return @Scale2;
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
				case "Scale2":  
					return @Scale2;
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
					 @Scale2 = (double?)value;
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
				case "Scale2":
					 @Scale2 = (double?)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion

		#region Where rules
		/*Scale2GreaterZero:	Scale2GreaterZero : Scl2 > 0.0;*/
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