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

namespace Xbim.Ifc4.GeometryResource
{
	[EntityName("IFCCOMPOSITECURVE", 109)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcCompositeCurve : IfcBoundedCurve, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcCompositeCurve(IModel model) : base(model) 		{ 
			Model = model; 
			_segments = new ItemSet<IfcCompositeCurveSegment>( this );
		}

		#region Explicit attribute fields
		private ItemSet<IfcCompositeCurveSegment> _segments;
		private bool? _selfIntersect;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(0, EntityAttributeState.Mandatory)]
		public ItemSet<IfcCompositeCurveSegment> @Segments 
		{ 
			get 
			{
				if(Activated) return _segments;
				
				Model.Activate(this, true);
				Activated = true;
				return _segments;
			} 
			set
			{
				SetValue( v =>  _segments = v, _segments, value,  "Segments");
			} 
		}
	
		[EntityAttribute(1, EntityAttributeState.Mandatory)]
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
					if (_segments == null) _segments = new ItemSet<IfcCompositeCurveSegment>( this );
					_segments.InternalAdd((IfcCompositeCurveSegment)value.EntityVal);
					return;
				case 1: 
					_selfIntersect = value.BooleanVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*CurveContinuous:	CurveContinuous : ((NOT ClosedCurve) AND (SIZEOF(QUERY(Temp <* Segments | Temp.Transition = Discontinuous)) = 1)) OR ((ClosedCurve) AND (SIZEOF(QUERY(Temp <* Segments | Temp.Transition = Discontinuous)) = 0));*/
		/*SameDim:	SameDim : SIZEOF( QUERY( Temp <* Segments | Temp.Dim <> Segments[1].Dim)) = 0;*/
		}
		#endregion
	}
}