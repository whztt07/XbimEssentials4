// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 02:29:12
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.PresentationAppearanceResource;
using Xbim.Ifc2x3.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc2x3.PresentationResource
{
	[EntityName("IFCCOLOURRGB", 86)]
	public  partial class @IfcColourRgb : IfcColourSpecification, IfcColourOrFactor, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcColourRgb(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcNormalisedRatioMeasure _red;
		private IfcNormalisedRatioMeasure _green;
		private IfcNormalisedRatioMeasure _blue;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory)]
		public IfcNormalisedRatioMeasure @Red 
		{ 
			get 
			{
				if(Activated) return _red;
				
				Model.Activate(this, true);
				Activated = true;
				return _red;
			} 
			set
			{
				SetValue( v =>  _red = v, _red, value,  "Red");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Mandatory)]
		public IfcNormalisedRatioMeasure @Green 
		{ 
			get 
			{
				if(Activated) return _green;
				
				Model.Activate(this, true);
				Activated = true;
				return _green;
			} 
			set
			{
				SetValue( v =>  _green = v, _green, value,  "Green");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Mandatory)]
		public IfcNormalisedRatioMeasure @Blue 
		{ 
			get 
			{
				if(Activated) return _blue;
				
				Model.Activate(this, true);
				Activated = true;
				return _blue;
			} 
			set
			{
				SetValue( v =>  _blue = v, _blue, value,  "Blue");
			} 
		}
	
		#endregion

		#region Inverse attributes

		#endregion

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"Name",
			"Red",
			"Green",
			"Blue",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @Name;
				case 1: 
					return @Red;
				case 2: 
					return @Green;
				case 3: 
					return @Blue;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "Name":  
					return @Name;
				case "Red":  
					return @Red;
				case "Green":  
					return @Green;
				case "Blue":  
					return @Blue;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 @Name = (IfcLabel?)value;
					 break;
				case 1:
					 if (value != null) @Red = (IfcNormalisedRatioMeasure)value;
					 break;
				case 2:
					 if (value != null) @Green = (IfcNormalisedRatioMeasure)value;
					 break;
				case 3:
					 if (value != null) @Blue = (IfcNormalisedRatioMeasure)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "Name":
					 @Name = (IfcLabel?)value;
					 break;
				case "Red":
					 if (value != null) @Red = (IfcNormalisedRatioMeasure)value;
					 break;
				case "Green":
					 if (value != null) @Green = (IfcNormalisedRatioMeasure)value;
					 break;
				case "Blue":
					 if (value != null) @Blue = (IfcNormalisedRatioMeasure)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion


		#region IPersist implementation
		void IPersist.Set(int propIndex, IPropertyValue value)
		{
            throw new System.NotImplementedException();
		}
		#endregion

	}
}