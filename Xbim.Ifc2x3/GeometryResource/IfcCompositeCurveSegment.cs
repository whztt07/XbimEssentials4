// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		15.09.2015 07:04:15
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc2x3.GeometryResource
{
	[EntityName("IFCCOMPOSITECURVESEGMENT", 460)]
	public  partial class @IfcCompositeCurveSegment : IfcGeometricRepresentationItem, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcCompositeCurveSegment(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcTransitionCode _transition;
		private bool _sameSense;
		private IfcCurve _parentCurve;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(0, EntityAttributeState.Mandatory)]
		public IfcTransitionCode @Transition 
		{ 
			get 
			{
				if(Activated) return _transition;
				
				Model.Activate(this, true);
				Activated = true;
				return _transition;
			} 
			set
			{
				SetValue( v =>  _transition = v, _transition, value,  "Transition");
			} 
		}
	
		[EntityAttribute(1, EntityAttributeState.Mandatory)]
		public bool @SameSense 
		{ 
			get 
			{
				if(Activated) return _sameSense;
				
				Model.Activate(this, true);
				Activated = true;
				return _sameSense;
			} 
			set
			{
				SetValue( v =>  _sameSense = v, _sameSense, value,  "SameSense");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Mandatory)]
		public IfcCurve @ParentCurve 
		{ 
			get 
			{
				if(Activated) return _parentCurve;
				
				Model.Activate(this, true);
				Activated = true;
				return _parentCurve;
			} 
			set
			{
				SetValue( v =>  _parentCurve = v, _parentCurve, value,  "ParentCurve");
			} 
		}
	
		#endregion

		#region Inverse attributes
		public IEnumerable<IfcCompositeCurve> @UsingCurves 
		{ 
			get 
			{
				return Model.Instances.Where<IfcCompositeCurve>(e => e.Segments != null &&  e.Segments.Contains(this));
			} 
		}
	

		#endregion

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"Transition",
			"SameSense",
			"ParentCurve",
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
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion

		#region Where rules
		/*WR1:	WR1 : ('IFC2X3.IFCBOUNDEDCURVE' IN TYPEOF(ParentCurve));*/
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