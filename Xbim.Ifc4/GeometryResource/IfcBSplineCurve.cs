// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 10:21:06
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.GeometryResource
{
	[EntityName("IFCBSPLINECURVE", 33)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcBSplineCurve : IfcBoundedCurve
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcBSplineCurve(IModel model) : base(model) 		{ 
			Model = model; 
			_controlPointsList = new ItemSet<IfcCartesianPoint>( this );
		}

		#region Explicit attribute fields
		private long _degree;
		private ItemSet<IfcCartesianPoint> _controlPointsList;
		private IfcBSplineCurveForm _curveForm;
		private bool? _closedCurve;
		private bool? _selfIntersect;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(0, EntityAttributeState.Mandatory)]
		public long @Degree 
		{ 
			get 
			{
				if(Activated) return _degree;
				
				Model.Activate(this, true);
				Activated = true;
				return _degree;
			} 
			set
			{
				SetValue( v =>  _degree = v, _degree, value,  "Degree");
			} 
		}
	
		[EntityAttribute(1, EntityAttributeState.Mandatory)]
		public ItemSet<IfcCartesianPoint> @ControlPointsList 
		{ 
			get 
			{
				if(Activated) return _controlPointsList;
				
				Model.Activate(this, true);
				Activated = true;
				return _controlPointsList;
			} 
			set
			{
				SetValue( v =>  _controlPointsList = v, _controlPointsList, value,  "ControlPointsList");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Mandatory)]
		public IfcBSplineCurveForm @CurveForm 
		{ 
			get 
			{
				if(Activated) return _curveForm;
				
				Model.Activate(this, true);
				Activated = true;
				return _curveForm;
			} 
			set
			{
				SetValue( v =>  _curveForm = v, _curveForm, value,  "CurveForm");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Mandatory)]
		public bool? @ClosedCurve 
		{ 
			get 
			{
				if(Activated) return _closedCurve;
				
				Model.Activate(this, true);
				Activated = true;
				return _closedCurve;
			} 
			set
			{
				SetValue( v =>  _closedCurve = v, _closedCurve, value,  "ClosedCurve");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Mandatory)]
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

		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
					_degree = value.IntegerVal;
					return;
				case 1: 
					if (_controlPointsList == null) _controlPointsList = new ItemSet<IfcCartesianPoint>( this );
					_controlPointsList.InternalAdd((IfcCartesianPoint)value.EntityVal);
					return;
				case 2: 
                    _curveForm = (IfcBSplineCurveForm) System.Enum.Parse(typeof (IfcBSplineCurveForm), value.EnumVal, true);
					return;
				case 3: 
					_closedCurve = value.BooleanVal;
					return;
				case 4: 
					_selfIntersect = value.BooleanVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*SameDim:                = 0;*/
		}
		#endregion
	}
}