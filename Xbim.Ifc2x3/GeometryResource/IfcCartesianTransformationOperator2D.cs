// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		09/09/2015 04:20:34
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc2x3.GeometryResource
{
	[EntityName("IFCCARTESIANTRANSFORMATIONOPERATOR2D", 145)]
	public  partial class @IfcCartesianTransformationOperator2D : IfcCartesianTransformationOperator, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcCartesianTransformationOperator2D(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		#endregion
	
		#region Explicit attribute properties
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
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion

		#region Where rules
		/*WR1:	WR1 : SELF\IfcCartesianTransformationOperator.Dim = 2;*/
		/*WR2:            (SELF\IfcCartesianTransformationOperator.Axis1.Dim = 2);*/
		/*WR3:            (SELF\IfcCartesianTransformationOperator.Axis2.Dim = 2);*/
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