// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 09:16:41
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc4.GeometryResource
{
	[EntityName("IFCCURVEBOUNDEDPLANE")]
	public  partial class @IfcCurveBoundedPlane : IfcBoundedSurface, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcCurveBoundedPlane(IModel model) : base(model) 		{ 
			Model = model; 
			_innerBoundaries = new ItemSet<IfcCurve>( model );
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
				if(IsActivated) return _basisSurface;
				
				Model.Activate(this, true);
				IsActivated = true;
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
				if(IsActivated) return _outerBoundary;
				
				Model.Activate(this, true);
				IsActivated = true;
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
				if(IsActivated) return _innerBoundaries;
				
				Model.Activate(this, true);
				IsActivated = true;
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
		private readonly List<string> _attributeNames = new List<string>
		{
			"BasisSurface",
			"OuterBoundary",
			"InnerBoundaries",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

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
		public void Set(int propIndex, IPropertyValue value)
		{
            throw new System.NotImplementedException();
		}
		#endregion

	}
}