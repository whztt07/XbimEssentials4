// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		15.09.2015 07:03:42
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.PresentationAppearanceResource;
using Xbim.Ifc4.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc4.GeometryResource
{
	[EntityName("IFCVECTOR", 738)]
	public  partial class @IfcVector : IfcGeometricRepresentationItem, IfcHatchLineDistanceSelect, IfcVectorOrDirection, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcVector(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcDirection _orientation;
		private IfcLengthMeasure _magnitude;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(0, EntityAttributeState.Mandatory)]
		public IfcDirection @Orientation 
		{ 
			get 
			{
				if(Activated) return _orientation;
				
				Model.Activate(this, true);
				Activated = true;
				return _orientation;
			} 
			set
			{
				SetValue( v =>  _orientation = v, _orientation, value,  "Orientation");
			} 
		}
	
		[EntityAttribute(1, EntityAttributeState.Mandatory)]
		public IfcLengthMeasure @Magnitude 
		{ 
			get 
			{
				if(Activated) return _magnitude;
				
				Model.Activate(this, true);
				Activated = true;
				return _magnitude;
			} 
			set
			{
				SetValue( v =>  _magnitude = v, _magnitude, value,  "Magnitude");
			} 
		}
	
		#endregion

		#region Inverse attributes

		#endregion

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"Orientation",
			"Magnitude",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @Orientation;
				case 1: 
					return @Magnitude;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "Orientation":  
					return @Orientation;
				case "Magnitude":  
					return @Magnitude;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 @Orientation = (IfcDirection)value;
					 break;
				case 1:
					 if (value != null) @Magnitude = (IfcLengthMeasure)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "Orientation":
					 @Orientation = (IfcDirection)value;
					 break;
				case "Magnitude":
					 if (value != null) @Magnitude = (IfcLengthMeasure)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion

		#region Where rules
		/*MagGreaterOrEqualZero:	MagGreaterOrEqualZero : Magnitude >= 0.0;*/
		#endregion

		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
            throw new System.NotImplementedException();
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		}
		#endregion

		
	}
}