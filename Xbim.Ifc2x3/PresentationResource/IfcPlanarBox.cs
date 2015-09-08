// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 09:16:38
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.GeometryResource;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc2x3.PresentationResource
{
	[EntityName("IFCPLANARBOX")]
	public  partial class @IfcPlanarBox : IfcPlanarExtent, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPlanarBox(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcAxis2Placement _placement;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Mandatory)]
		public IfcAxis2Placement @Placement 
		{ 
			get 
			{
				if(IsActivated) return _placement;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _placement;
			} 
			set
			{
				SetValue( v =>  _placement = v, _placement, value,  "Placement");
			} 
		}
	
		#endregion

		#region Inverse attributes

		#endregion

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"SizeInX",
			"SizeInY",
			"Placement",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @SizeInX;
				case 1: 
					return @SizeInY;
				case 2: 
					return @Placement;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "SizeInX":  
					return @SizeInX;
				case "SizeInY":  
					return @SizeInY;
				case "Placement":  
					return @Placement;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 if (value != null) @SizeInX = (IfcLengthMeasure)value;
					 break;
				case 1:
					 if (value != null) @SizeInY = (IfcLengthMeasure)value;
					 break;
				case 2:
					 @Placement = (IfcAxis2Placement)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "SizeInX":
					 if (value != null) @SizeInX = (IfcLengthMeasure)value;
					 break;
				case "SizeInY":
					 if (value != null) @SizeInY = (IfcLengthMeasure)value;
					 break;
				case "Placement":
					 @Placement = (IfcAxis2Placement)value;
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