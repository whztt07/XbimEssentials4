// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		16.09.2015 04:22:59
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
	[EntityName("IFCCURVEBOUNDEDPLANE", 334)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcCurveBoundedPlane : IfcBoundedSurface, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcCurveBoundedPlane(IModel model) : base(model) 		{ 
			Model = model; 
			_innerBoundaries = new ItemSet<IfcCurve>( this );
		}

		#region Explicit attribute fields
		private IfcPlane _basisSurface;
		private IfcCurve _outerBoundary;
		private ItemSet<IfcCurve> _innerBoundaries;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(0, EntityAttributeState.Mandatory)]
		public IfcPlane @BasisSurface 
		{ 
			get 
			{
				if(Activated) return _basisSurface;
				
				Model.Activate(this, true);
				Activated = true;
				return _basisSurface;
			} 
			set
			{
				SetValue( v =>  _basisSurface = v, _basisSurface, value,  "BasisSurface");
			} 
		}
	
		[EntityAttribute(1, EntityAttributeState.Mandatory)]
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
	
		[EntityAttribute(2, EntityAttributeState.Mandatory)]
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

		#region Index access
		private static readonly List<string> AttributeNames = new List<string>
		{
			"BasisSurface",
			"OuterBoundary",
			"InnerBoundaries",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return AttributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @BasisSurface;
				case 1: 
					return @OuterBoundary;
				case 2: 
					return @InnerBoundaries;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "BasisSurface":  
					return @BasisSurface;
				case "OuterBoundary":  
					return @OuterBoundary;
				case "InnerBoundaries":  
					return @InnerBoundaries;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 @BasisSurface = (IfcPlane)value;
					 break;
				case 1:
					 @OuterBoundary = (IfcCurve)value;
					 break;
				case 2:
					 @InnerBoundaries.Add((IfcCurve)value);
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "BasisSurface":
					 @BasisSurface = (IfcPlane)value;
					 break;
				case "OuterBoundary":
					 @OuterBoundary = (IfcCurve)value;
					 break;
				case "InnerBoundaries":
					 @InnerBoundaries.Add((IfcCurve)value);
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
					_basisSurface = (IfcPlane)(value.EntityVal);
					return;
				case 1: 
					_outerBoundary = (IfcCurve)(value.EntityVal);
					return;
				case 2: 
					if (_innerBoundaries == null) _innerBoundaries = new ItemSet<IfcCurve>( this );
					_innerBoundaries.Add((IfcCurve)value.EntityVal);
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