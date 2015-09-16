// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		16.09.2015 04:22:58
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
	[EntityName("IFCCOMPOSITECURVE", 279)]
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

		#region Index access
		private static readonly List<string> AttributeNames = new List<string>
		{
			"Segments",
			"SelfIntersect",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return AttributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @Segments;
				case 1: 
					return @SelfIntersect;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "Segments":  
					return @Segments;
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
					 @Segments.Add((IfcCompositeCurveSegment)value);
					 break;
				case 1:
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
				case "Segments":
					 @Segments.Add((IfcCompositeCurveSegment)value);
					 break;
				case "SelfIntersect":
					 @SelfIntersect = (bool?)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
					if (_segments == null) _segments = new ItemSet<IfcCompositeCurveSegment>( this );
					_segments.Add((IfcCompositeCurveSegment)value.EntityVal);
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
		/*WR41:	WR41 : ((NOT ClosedCurve) AND (SIZEOF(QUERY(Temp <* Segments | Temp.Transition = Discontinuous)) = 1)) OR ((ClosedCurve) AND (SIZEOF(QUERY(Temp <* Segments | Temp.Transition = Discontinuous)) = 0));*/
		/*WR42:	WR42 : SIZEOF( QUERY( Temp <* Segments | Temp.Dim <> Segments[1].Dim)) = 0;*/
		}
		#endregion

		
	}
}