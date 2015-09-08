// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 09:16:42
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc4.MaterialResource
{
	[EntityName("IFCMATERIALCONSTITUENT")]
	public  partial class @IfcMaterialConstituent : IfcMaterialDefinition, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcMaterialConstituent(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcLabel? _name;
		private IfcText? _description;
		private IfcMaterial _material;
		private IfcNormalisedRatioMeasure? _fraction;
		private IfcLabel? _category;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(0, EntityAttributeState.Optional)]
		public IfcLabel? @Name 
		{ 
			get 
			{
				if(IsActivated) return _name;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _name;
			} 
			set
			{
				SetValue( v =>  _name = v, _name, value,  "Name");
			} 
		}
	
		[EntityAttribute(1, EntityAttributeState.Optional)]
		public IfcText? @Description 
		{ 
			get 
			{
				if(IsActivated) return _description;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _description;
			} 
			set
			{
				SetValue( v =>  _description = v, _description, value,  "Description");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Mandatory)]
		public IfcMaterial @Material 
		{ 
			get 
			{
				if(IsActivated) return _material;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _material;
			} 
			set
			{
				SetValue( v =>  _material = v, _material, value,  "Material");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Optional)]
		public IfcNormalisedRatioMeasure? @Fraction 
		{ 
			get 
			{
				if(IsActivated) return _fraction;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _fraction;
			} 
			set
			{
				SetValue( v =>  _fraction = v, _fraction, value,  "Fraction");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Optional)]
		public IfcLabel? @Category 
		{ 
			get 
			{
				if(IsActivated) return _category;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _category;
			} 
			set
			{
				SetValue( v =>  _category = v, _category, value,  "Category");
			} 
		}
	
		#endregion

		#region Inverse attributes
		public IEnumerable<IfcMaterialConstituentSet> @ToMaterialConstituentSet 
		{ 
			get 
			{
				return Model.Instances.Where<IfcMaterialConstituentSet>(e => e.MaterialConstituents != null &&  e.MaterialConstituents.Contains(this));
			} 
		}
	

		#endregion

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"Name",
			"Description",
			"Material",
			"Fraction",
			"Category",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @Name;
				case 1: 
					return @Description;
				case 2: 
					return @Material;
				case 3: 
					return @Fraction;
				case 4: 
					return @Category;
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
				case "Description":  
					return @Description;
				case "Material":  
					return @Material;
				case "Fraction":  
					return @Fraction;
				case "Category":  
					return @Category;
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
					 @Description = (IfcText?)value;
					 break;
				case 2:
					 @Material = (IfcMaterial)value;
					 break;
				case 3:
					 @Fraction = (IfcNormalisedRatioMeasure?)value;
					 break;
				case 4:
					 @Category = (IfcLabel?)value;
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
				case "Description":
					 @Description = (IfcText?)value;
					 break;
				case "Material":
					 @Material = (IfcMaterial)value;
					 break;
				case "Fraction":
					 @Fraction = (IfcNormalisedRatioMeasure?)value;
					 break;
				case "Category":
					 @Category = (IfcLabel?)value;
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