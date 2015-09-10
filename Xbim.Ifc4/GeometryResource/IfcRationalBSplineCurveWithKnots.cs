// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		09/09/2015 04:20:43
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc4.GeometryResource
{
	[EntityName("IFCRATIONALBSPLINECURVEWITHKNOTS", 493)]
	public  partial class @IfcRationalBSplineCurveWithKnots : IfcBSplineCurveWithKnots, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRationalBSplineCurveWithKnots(IModel model) : base(model) 		{ 
			Model = model; 
			_weightsData = new ItemSet<double>( model );
		}

		#region Explicit attribute fields
		private ItemSet<double> _weightsData;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(8, EntityAttributeState.Mandatory)]
		public ItemSet<double> @WeightsData 
		{ 
			get 
			{
				if(Activated) return _weightsData;
				
				Model.Activate(this, true);
				Activated = true;
				return _weightsData;
			} 
			set
			{
				SetValue( v =>  _weightsData = v, _weightsData, value,  "WeightsData");
			} 
		}
	
		#endregion

		#region Inverse attributes

		#endregion

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"Degree",
			"ControlPointsList",
			"CurveForm",
			"ClosedCurve",
			"SelfIntersect",
			"KnotMultiplicities",
			"Knots",
			"KnotSpec",
			"WeightsData",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @Degree;
				case 1: 
					return @ControlPointsList;
				case 2: 
					return @CurveForm;
				case 3: 
					return @ClosedCurve;
				case 4: 
					return @SelfIntersect;
				case 5: 
					return @KnotMultiplicities;
				case 6: 
					return @Knots;
				case 7: 
					return @KnotSpec;
				case 8: 
					return @WeightsData;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "Degree":  
					return @Degree;
				case "ControlPointsList":  
					return @ControlPointsList;
				case "CurveForm":  
					return @CurveForm;
				case "ClosedCurve":  
					return @ClosedCurve;
				case "SelfIntersect":  
					return @SelfIntersect;
				case "KnotMultiplicities":  
					return @KnotMultiplicities;
				case "Knots":  
					return @Knots;
				case "KnotSpec":  
					return @KnotSpec;
				case "WeightsData":  
					return @WeightsData;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 if (value != null) @Degree = (long)value;
					 break;
				case 1:
					 @ControlPointsList.Add((IfcCartesianPoint)value);
					 break;
				case 2:
					 if (value != null) @CurveForm = (IfcBSplineCurveForm)value;
					 break;
				case 3:
					 @ClosedCurve = (bool?)value;
					 break;
				case 4:
					 @SelfIntersect = (bool?)value;
					 break;
				case 5:
					 @KnotMultiplicities.Add((long)value);
					 break;
				case 6:
					 @Knots = (ItemSet<IfcParameterValue>)value;
					 break;
				case 7:
					 if (value != null) @KnotSpec = (IfcKnotType)value;
					 break;
				case 8:
					 @WeightsData.Add((double)value);
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "Degree":
					 if (value != null) @Degree = (long)value;
					 break;
				case "ControlPointsList":
					 @ControlPointsList.Add((IfcCartesianPoint)value);
					 break;
				case "CurveForm":
					 if (value != null) @CurveForm = (IfcBSplineCurveForm)value;
					 break;
				case "ClosedCurve":
					 @ClosedCurve = (bool?)value;
					 break;
				case "SelfIntersect":
					 @SelfIntersect = (bool?)value;
					 break;
				case "KnotMultiplicities":
					 @KnotMultiplicities.Add((long)value);
					 break;
				case "Knots":
					 @Knots = (ItemSet<IfcParameterValue>)value;
					 break;
				case "KnotSpec":
					 if (value != null) @KnotSpec = (IfcKnotType)value;
					 break;
				case "WeightsData":
					 @WeightsData.Add((double)value);
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion

		#region Where rules
		/*SameNumOfWeightsAndPoints:	SameNumOfWeightsAndPoints : SIZEOF(WeightsData) = SIZEOF(SELF\IfcBSplineCurve.ControlPointsList);*/
		/*WeightsGreaterZero:	WeightsGreaterZero : IfcCurveWeightsPositive(SELF);*/
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