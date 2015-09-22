// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		22.09.2015 02:31:57
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.GeometryResource
{
	[IndexedClass]
	[ExpressType("IFCCOMPOSITECURVESEGMENT", 460)]
	// ReSharper disable once PartialTypeWithSinglePart
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
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
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
	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
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
	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
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
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcCompositeCurve> @UsingCurves 
		{ 
			get 
			{
				return Model.Instances.Where<IfcCompositeCurve>(e => e.Segments != null &&  e.Segments.Contains(this));
			} 
		}
	

		#endregion

		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
                    _transition = (IfcTransitionCode) System.Enum.Parse(typeof (IfcTransitionCode), value.EnumVal, true);
					return;
				case 1: 
					_sameSense = value.BooleanVal;
					return;
				case 2: 
					_parentCurve = (IfcCurve)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR1:	WR1 : ('IFC2X3.IFCBOUNDEDCURVE' IN TYPEOF(ParentCurve));*/
		}
		#endregion
	}
}