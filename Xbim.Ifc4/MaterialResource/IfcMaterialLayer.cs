// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		09/09/2015 04:20:42
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
	[EntityName("IFCMATERIALLAYER", 356)]
	public  partial class @IfcMaterialLayer : IfcMaterialDefinition, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcMaterialLayer(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcMaterial _material;
		private IfcNonNegativeLengthMeasure _layerThickness;
		private IfcLogical? _isVentilated;
		private IfcLabel? _name;
		private IfcText? _description;
		private IfcLabel? _category;
		private IfcNormalisedRatioMeasure? _priority;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(0, EntityAttributeState.Optional)]
		public IfcMaterial @Material 
		{ 
			get 
			{
				if(Activated) return _material;
				
				Model.Activate(this, true);
				Activated = true;
				return _material;
			} 
			set
			{
				SetValue( v =>  _material = v, _material, value,  "Material");
			} 
		}
	
		[EntityAttribute(1, EntityAttributeState.Mandatory)]
		public IfcNonNegativeLengthMeasure @LayerThickness 
		{ 
			get 
			{
				if(Activated) return _layerThickness;
				
				Model.Activate(this, true);
				Activated = true;
				return _layerThickness;
			} 
			set
			{
				SetValue( v =>  _layerThickness = v, _layerThickness, value,  "LayerThickness");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Optional)]
		public IfcLogical? @IsVentilated 
		{ 
			get 
			{
				if(Activated) return _isVentilated;
				
				Model.Activate(this, true);
				Activated = true;
				return _isVentilated;
			} 
			set
			{
				SetValue( v =>  _isVentilated = v, _isVentilated, value,  "IsVentilated");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Optional)]
		public IfcLabel? @Name 
		{ 
			get 
			{
				if(Activated) return _name;
				
				Model.Activate(this, true);
				Activated = true;
				return _name;
			} 
			set
			{
				SetValue( v =>  _name = v, _name, value,  "Name");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Optional)]
		public IfcText? @Description 
		{ 
			get 
			{
				if(Activated) return _description;
				
				Model.Activate(this, true);
				Activated = true;
				return _description;
			} 
			set
			{
				SetValue( v =>  _description = v, _description, value,  "Description");
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Optional)]
		public IfcLabel? @Category 
		{ 
			get 
			{
				if(Activated) return _category;
				
				Model.Activate(this, true);
				Activated = true;
				return _category;
			} 
			set
			{
				SetValue( v =>  _category = v, _category, value,  "Category");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Optional)]
		public IfcNormalisedRatioMeasure? @Priority 
		{ 
			get 
			{
				if(Activated) return _priority;
				
				Model.Activate(this, true);
				Activated = true;
				return _priority;
			} 
			set
			{
				SetValue( v =>  _priority = v, _priority, value,  "Priority");
			} 
		}
	
		#endregion

		#region Inverse attributes
		public IEnumerable<IfcMaterialLayerSet> @ToMaterialLayerSet 
		{ 
			get 
			{
				return Model.Instances.Where<IfcMaterialLayerSet>(e => e.MaterialLayers != null &&  e.MaterialLayers.Contains(this));
			} 
		}
	

		#endregion

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"Material",
			"LayerThickness",
			"IsVentilated",
			"Name",
			"Description",
			"Category",
			"Priority",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @Material;
				case 1: 
					return @LayerThickness;
				case 2: 
					return @IsVentilated;
				case 3: 
					return @Name;
				case 4: 
					return @Description;
				case 5: 
					return @Category;
				case 6: 
					return @Priority;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "Material":  
					return @Material;
				case "LayerThickness":  
					return @LayerThickness;
				case "IsVentilated":  
					return @IsVentilated;
				case "Name":  
					return @Name;
				case "Description":  
					return @Description;
				case "Category":  
					return @Category;
				case "Priority":  
					return @Priority;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 @Material = (IfcMaterial)value;
					 break;
				case 1:
					 if (value != null) @LayerThickness = (IfcNonNegativeLengthMeasure)value;
					 break;
				case 2:
					 @IsVentilated = (IfcLogical?)value;
					 break;
				case 3:
					 @Name = (IfcLabel?)value;
					 break;
				case 4:
					 @Description = (IfcText?)value;
					 break;
				case 5:
					 @Category = (IfcLabel?)value;
					 break;
				case 6:
					 @Priority = (IfcNormalisedRatioMeasure?)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "Material":
					 @Material = (IfcMaterial)value;
					 break;
				case "LayerThickness":
					 if (value != null) @LayerThickness = (IfcNonNegativeLengthMeasure)value;
					 break;
				case "IsVentilated":
					 @IsVentilated = (IfcLogical?)value;
					 break;
				case "Name":
					 @Name = (IfcLabel?)value;
					 break;
				case "Description":
					 @Description = (IfcText?)value;
					 break;
				case "Category":
					 @Category = (IfcLabel?)value;
					 break;
				case "Priority":
					 @Priority = (IfcNormalisedRatioMeasure?)value;
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

		public  override string WhereRule() 
		{
			return "";
		}
	}
}