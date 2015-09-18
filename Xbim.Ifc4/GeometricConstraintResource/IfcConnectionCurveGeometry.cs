// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 03:44:03
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.GeometricConstraintResource
{
	[EntityName("IFCCONNECTIONCURVEGEOMETRY", 119)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcConnectionCurveGeometry : IfcConnectionGeometry, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcConnectionCurveGeometry(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcCurveOrEdgeCurve _curveOnRelatingElement;
		private IfcCurveOrEdgeCurve _curveOnRelatedElement;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttributee(0, EntityAttributeState.Mandatory)]
		public IfcCurveOrEdgeCurve @CurveOnRelatingElement 
		{ 
			get 
			{
				if(Activated) return _curveOnRelatingElement;
				
				Model.Activate(this, true);
				Activated = true;
				return _curveOnRelatingElement;
			} 
			set
			{
				SetValue( v =>  _curveOnRelatingElement = v, _curveOnRelatingElement, value,  "CurveOnRelatingElement");
			} 
		}
	
		[EntityAttributee(1, EntityAttributeState.Optional)]
		public IfcCurveOrEdgeCurve @CurveOnRelatedElement 
		{ 
			get 
			{
				if(Activated) return _curveOnRelatedElement;
				
				Model.Activate(this, true);
				Activated = true;
				return _curveOnRelatedElement;
			} 
			set
			{
				SetValue( v =>  _curveOnRelatedElement = v, _curveOnRelatedElement, value,  "CurveOnRelatedElement");
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
					_curveOnRelatingElement = (IfcCurveOrEdgeCurve)(value.EntityVal);
					return;
				case 1: 
					_curveOnRelatedElement = (IfcCurveOrEdgeCurve)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
			return "";
		}
		#endregion
	}
}