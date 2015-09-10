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
	[EntityName("IFCREPARAMETRISEDCOMPOSITECURVESEGMENT", 558)]
	public  partial class @IfcReparametrisedCompositeCurveSegment : IfcCompositeCurveSegment, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcReparametrisedCompositeCurveSegment(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcParameterValue _paramLength;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(3, EntityAttributeState.Mandatory)]
		public IfcParameterValue @ParamLength 
		{ 
			get 
			{
				if(Activated) return _paramLength;
				
				Model.Activate(this, true);
				Activated = true;
				return _paramLength;
			} 
			set
			{
				SetValue( v =>  _paramLength = v, _paramLength, value,  "ParamLength");
			} 
		}
	
		#endregion

		#region Inverse attributes

		#endregion

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"Transition",
			"SameSense",
			"ParentCurve",
			"ParamLength",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @Transition;
				case 1: 
					return @SameSense;
				case 2: 
					return @ParentCurve;
				case 3: 
					return @ParamLength;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "Transition":  
					return @Transition;
				case "SameSense":  
					return @SameSense;
				case "ParentCurve":  
					return @ParentCurve;
				case "ParamLength":  
					return @ParamLength;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 if (value != null) @Transition = (IfcTransitionCode)value;
					 break;
				case 1:
					 if (value != null) @SameSense = (bool)value;
					 break;
				case 2:
					 @ParentCurve = (IfcCurve)value;
					 break;
				case 3:
					 if (value != null) @ParamLength = (IfcParameterValue)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "Transition":
					 if (value != null) @Transition = (IfcTransitionCode)value;
					 break;
				case "SameSense":
					 if (value != null) @SameSense = (bool)value;
					 break;
				case "ParentCurve":
					 @ParentCurve = (IfcCurve)value;
					 break;
				case "ParamLength":
					 if (value != null) @ParamLength = (IfcParameterValue)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion

		#region Where rules
		/*PositiveLengthParameter:	PositiveLengthParameter : ParamLength > 0.0;*/
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