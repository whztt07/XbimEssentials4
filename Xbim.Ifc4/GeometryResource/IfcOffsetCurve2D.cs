// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		15.09.2015 07:03:39
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
	[EntityName("IFCOFFSETCURVE2D", 388)]
	public  partial class @IfcOffsetCurve2D : IfcCurve, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcOffsetCurve2D(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcCurve _basisCurve;
		private IfcLengthMeasure _distance;
		private bool? _selfIntersect;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(0, EntityAttributeState.Mandatory)]
		public IfcCurve @BasisCurve 
		{ 
			get 
			{
				if(Activated) return _basisCurve;
				
				Model.Activate(this, true);
				Activated = true;
				return _basisCurve;
			} 
			set
			{
				SetValue( v =>  _basisCurve = v, _basisCurve, value,  "BasisCurve");
			} 
		}
	
		[EntityAttribute(1, EntityAttributeState.Mandatory)]
		public IfcLengthMeasure @Distance 
		{ 
			get 
			{
				if(Activated) return _distance;
				
				Model.Activate(this, true);
				Activated = true;
				return _distance;
			} 
			set
			{
				SetValue( v =>  _distance = v, _distance, value,  "Distance");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Mandatory)]
		public bool? @SelfIntersect 
		{ 
			get 
			{
				if(Activated) return _selfIntersect;
				
				Model.Activate(this, true);
				Activated = true;
				return _selfIntersect;
			} 
			set
			{
				SetValue( v =>  _selfIntersect = v, _selfIntersect, value,  "SelfIntersect");
			} 
		}
	
		#endregion

		#region Inverse attributes

		#endregion

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"BasisCurve",
			"Distance",
			"SelfIntersect",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @BasisCurve;
				case 1: 
					return @Distance;
				case 2: 
					return @SelfIntersect;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "BasisCurve":  
					return @BasisCurve;
				case "Distance":  
					return @Distance;
				case "SelfIntersect":  
					return @SelfIntersect;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 @BasisCurve = (IfcCurve)value;
					 break;
				case 1:
					 if (value != null) @Distance = (IfcLengthMeasure)value;
					 break;
				case 2:
					 @SelfIntersect = (bool?)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "BasisCurve":
					 @BasisCurve = (IfcCurve)value;
					 break;
				case "Distance":
					 if (value != null) @Distance = (IfcLengthMeasure)value;
					 break;
				case "SelfIntersect":
					 @SelfIntersect = (bool?)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion

		#region Where rules
		/*DimIs2D:	DimIs2D : BasisCurve.Dim = 2;*/
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