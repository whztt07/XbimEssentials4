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
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc2x3.GeometryResource
{
	[EntityName("IFCELLIPSE")]
	public  partial class @IfcEllipse : IfcConic, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcEllipse(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcPositiveLengthMeasure _semiAxis1;
		private IfcPositiveLengthMeasure _semiAxis2;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory)]
		public IfcPositiveLengthMeasure @SemiAxis1 
		{ 
			get 
			{
				if(IsActivated) return _semiAxis1;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _semiAxis1;
			} 
			set
			{
				SetValue( v =>  _semiAxis1 = v, _semiAxis1, value,  "SemiAxis1");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Mandatory)]
		public IfcPositiveLengthMeasure @SemiAxis2 
		{ 
			get 
			{
				if(IsActivated) return _semiAxis2;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _semiAxis2;
			} 
			set
			{
				SetValue( v =>  _semiAxis2 = v, _semiAxis2, value,  "SemiAxis2");
			} 
		}
	
		#endregion

		#region Inverse attributes

		#endregion

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"Position",
			"SemiAxis1",
			"SemiAxis2",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @Position;
				case 1: 
					return @SemiAxis1;
				case 2: 
					return @SemiAxis2;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "Position":  
					return @Position;
				case "SemiAxis1":  
					return @SemiAxis1;
				case "SemiAxis2":  
					return @SemiAxis2;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 @Position = (IfcAxis2Placement)value;
					 break;
				case 1:
					 if (value != null) @SemiAxis1 = (IfcPositiveLengthMeasure)value;
					 break;
				case 2:
					 if (value != null) @SemiAxis2 = (IfcPositiveLengthMeasure)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "Position":
					 @Position = (IfcAxis2Placement)value;
					 break;
				case "SemiAxis1":
					 if (value != null) @SemiAxis1 = (IfcPositiveLengthMeasure)value;
					 break;
				case "SemiAxis2":
					 if (value != null) @SemiAxis2 = (IfcPositiveLengthMeasure)value;
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