// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.GeometryResource
{
	[IndexedClass]
	[ExpressType("IFCOFFSETCURVE3D", 67)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcOffsetCurve3D : IfcCurve, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcOffsetCurve3D(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcCurve _basisCurve;
		private IfcLengthMeasure _distance;
		private bool? _selfIntersect;
		private IfcDirection _refDirection;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
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
	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
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
	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
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
	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
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



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
					_basisCurve = (IfcCurve)(value.EntityVal);
					return;
				case 1: 
					_distance = value.RealVal;
					return;
				case 2: 
					_selfIntersect = value.BooleanVal;
					return;
				case 3: 
					_refDirection = (IfcDirection)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR1:	WR1 : BasisCurve.Dim = 3;*/
		}
		#endregion
	}
}