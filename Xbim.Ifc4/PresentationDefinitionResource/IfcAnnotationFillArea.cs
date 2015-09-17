// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 10:21:06
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.GeometryResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.PresentationDefinitionResource
{
	[EntityName("IFCANNOTATIONFILLAREA", 18)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcAnnotationFillArea : IfcGeometricRepresentationItem, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcAnnotationFillArea(IModel model) : base(model) 		{ 
			Model = model; 
			_innerBoundaries = new ItemSet<IfcCurve>( this );
		}

		#region Explicit attribute fields
		private IfcCurve _outerBoundary;
		private ItemSet<IfcCurve> _innerBoundaries;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(0, EntityAttributeState.Mandatory)]
		public IfcCurve @OuterBoundary 
		{ 
			get 
			{
				if(Activated) return _outerBoundary;
				
				Model.Activate(this, true);
				Activated = true;
				return _outerBoundary;
			} 
			set
			{
				SetValue( v =>  _outerBoundary = v, _outerBoundary, value,  "OuterBoundary");
			} 
		}
	
		[EntityAttribute(1, EntityAttributeState.Optional)]
		public ItemSet<IfcCurve> @InnerBoundaries 
		{ 
			get 
			{
				if(Activated) return _innerBoundaries;
				
				Model.Activate(this, true);
				Activated = true;
				return _innerBoundaries;
			} 
			set
			{
				SetValue( v =>  _innerBoundaries = v, _innerBoundaries, value,  "InnerBoundaries");
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
					_outerBoundary = (IfcCurve)(value.EntityVal);
					return;
				case 1: 
					if (_innerBoundaries == null) _innerBoundaries = new ItemSet<IfcCurve>( this );
					_innerBoundaries.InternalAdd((IfcCurve)value.EntityVal);
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