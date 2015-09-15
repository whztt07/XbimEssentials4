// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		15.09.2015 07:04:21
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.CobieExpress
{
	[EntityName("TYPE", 15)]
	public  partial class @CobieType : CobieAsset, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal CobieType(IModel model) : base(model) 		{ 
			Model = model; 
			_assemblyOf = new ItemSet<CobieType>( model );
			_jobs = new ItemSet<CobieJob>( model );
		}

		#region Explicit attribute fields
		private CobiePickValue _assetType;
		private CobieContact _manufacturer;
		private string _modelNumber;
		private CobieWarranty _warranty;
		private double? _replacementCost;
		private double? _expectedLife;
		private CobiePickValue _durationUnit;
		private double _nominalLength;
		private double _nominalWidth;
		private double _nominalHeight;
		private string _modelReference;
		private string _shape;
		private string _size;
		private string _color;
		private string _finish;
		private string _grade;
		private string _material;
		private string _constituents;
		private string _features;
		private string _accessibilityPerformance;
		private string _codePerformance;
		private string _sustainabilityPerformance;
		private ItemSet<CobieType> _assemblyOf;
		private ItemSet<CobieJob> _jobs;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(11, EntityAttributeState.Mandatory)]
		public CobiePickValue @AssetType 
		{ 
			get 
			{
				if(Activated) return _assetType;
				
				Model.Activate(this, true);
				Activated = true;
				return _assetType;
			} 
			set
			{
				SetValue( v =>  _assetType = v, _assetType, value,  "AssetType");
			} 
		}
	
		[EntityAttribute(12, EntityAttributeState.Mandatory)]
		public CobieContact @Manufacturer 
		{ 
			get 
			{
				if(Activated) return _manufacturer;
				
				Model.Activate(this, true);
				Activated = true;
				return _manufacturer;
			} 
			set
			{
				SetValue( v =>  _manufacturer = v, _manufacturer, value,  "Manufacturer");
			} 
		}
	
		[EntityAttribute(13, EntityAttributeState.Mandatory)]
		public string @ModelNumber 
		{ 
			get 
			{
				if(Activated) return _modelNumber;
				
				Model.Activate(this, true);
				Activated = true;
				return _modelNumber;
			} 
			set
			{
				SetValue( v =>  _modelNumber = v, _modelNumber, value,  "ModelNumber");
			} 
		}
	
		[EntityAttribute(14, EntityAttributeState.Mandatory)]
		public CobieWarranty @Warranty 
		{ 
			get 
			{
				if(Activated) return _warranty;
				
				Model.Activate(this, true);
				Activated = true;
				return _warranty;
			} 
			set
			{
				SetValue( v =>  _warranty = v, _warranty, value,  "Warranty");
			} 
		}
	
		[EntityAttribute(15, EntityAttributeState.Optional)]
		public double? @ReplacementCost 
		{ 
			get 
			{
				if(Activated) return _replacementCost;
				
				Model.Activate(this, true);
				Activated = true;
				return _replacementCost;
			} 
			set
			{
				SetValue( v =>  _replacementCost = v, _replacementCost, value,  "ReplacementCost");
			} 
		}
	
		[EntityAttribute(16, EntityAttributeState.Optional)]
		public double? @ExpectedLife 
		{ 
			get 
			{
				if(Activated) return _expectedLife;
				
				Model.Activate(this, true);
				Activated = true;
				return _expectedLife;
			} 
			set
			{
				SetValue( v =>  _expectedLife = v, _expectedLife, value,  "ExpectedLife");
			} 
		}
	
		[EntityAttribute(17, EntityAttributeState.Optional)]
		public CobiePickValue @DurationUnit 
		{ 
			get 
			{
				if(Activated) return _durationUnit;
				
				Model.Activate(this, true);
				Activated = true;
				return _durationUnit;
			} 
			set
			{
				SetValue( v =>  _durationUnit = v, _durationUnit, value,  "DurationUnit");
			} 
		}
	
		[EntityAttribute(18, EntityAttributeState.Mandatory)]
		public double @NominalLength 
		{ 
			get 
			{
				if(Activated) return _nominalLength;
				
				Model.Activate(this, true);
				Activated = true;
				return _nominalLength;
			} 
			set
			{
				SetValue( v =>  _nominalLength = v, _nominalLength, value,  "NominalLength");
			} 
		}
	
		[EntityAttribute(19, EntityAttributeState.Mandatory)]
		public double @NominalWidth 
		{ 
			get 
			{
				if(Activated) return _nominalWidth;
				
				Model.Activate(this, true);
				Activated = true;
				return _nominalWidth;
			} 
			set
			{
				SetValue( v =>  _nominalWidth = v, _nominalWidth, value,  "NominalWidth");
			} 
		}
	
		[EntityAttribute(20, EntityAttributeState.Mandatory)]
		public double @NominalHeight 
		{ 
			get 
			{
				if(Activated) return _nominalHeight;
				
				Model.Activate(this, true);
				Activated = true;
				return _nominalHeight;
			} 
			set
			{
				SetValue( v =>  _nominalHeight = v, _nominalHeight, value,  "NominalHeight");
			} 
		}
	
		[EntityAttribute(21, EntityAttributeState.Optional)]
		public string @ModelReference 
		{ 
			get 
			{
				if(Activated) return _modelReference;
				
				Model.Activate(this, true);
				Activated = true;
				return _modelReference;
			} 
			set
			{
				SetValue( v =>  _modelReference = v, _modelReference, value,  "ModelReference");
			} 
		}
	
		[EntityAttribute(22, EntityAttributeState.Optional)]
		public string @Shape 
		{ 
			get 
			{
				if(Activated) return _shape;
				
				Model.Activate(this, true);
				Activated = true;
				return _shape;
			} 
			set
			{
				SetValue( v =>  _shape = v, _shape, value,  "Shape");
			} 
		}
	
		[EntityAttribute(23, EntityAttributeState.Optional)]
		public string @Size 
		{ 
			get 
			{
				if(Activated) return _size;
				
				Model.Activate(this, true);
				Activated = true;
				return _size;
			} 
			set
			{
				SetValue( v =>  _size = v, _size, value,  "Size");
			} 
		}
	
		[EntityAttribute(24, EntityAttributeState.Optional)]
		public string @Color 
		{ 
			get 
			{
				if(Activated) return _color;
				
				Model.Activate(this, true);
				Activated = true;
				return _color;
			} 
			set
			{
				SetValue( v =>  _color = v, _color, value,  "Color");
			} 
		}
	
		[EntityAttribute(25, EntityAttributeState.Optional)]
		public string @Finish 
		{ 
			get 
			{
				if(Activated) return _finish;
				
				Model.Activate(this, true);
				Activated = true;
				return _finish;
			} 
			set
			{
				SetValue( v =>  _finish = v, _finish, value,  "Finish");
			} 
		}
	
		[EntityAttribute(26, EntityAttributeState.Optional)]
		public string @Grade 
		{ 
			get 
			{
				if(Activated) return _grade;
				
				Model.Activate(this, true);
				Activated = true;
				return _grade;
			} 
			set
			{
				SetValue( v =>  _grade = v, _grade, value,  "Grade");
			} 
		}
	
		[EntityAttribute(27, EntityAttributeState.Optional)]
		public string @Material 
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
	
		[EntityAttribute(28, EntityAttributeState.Optional)]
		public string @Constituents 
		{ 
			get 
			{
				if(Activated) return _constituents;
				
				Model.Activate(this, true);
				Activated = true;
				return _constituents;
			} 
			set
			{
				SetValue( v =>  _constituents = v, _constituents, value,  "Constituents");
			} 
		}
	
		[EntityAttribute(29, EntityAttributeState.Optional)]
		public string @Features 
		{ 
			get 
			{
				if(Activated) return _features;
				
				Model.Activate(this, true);
				Activated = true;
				return _features;
			} 
			set
			{
				SetValue( v =>  _features = v, _features, value,  "Features");
			} 
		}
	
		[EntityAttribute(30, EntityAttributeState.Optional)]
		public string @AccessibilityPerformance 
		{ 
			get 
			{
				if(Activated) return _accessibilityPerformance;
				
				Model.Activate(this, true);
				Activated = true;
				return _accessibilityPerformance;
			} 
			set
			{
				SetValue( v =>  _accessibilityPerformance = v, _accessibilityPerformance, value,  "AccessibilityPerformance");
			} 
		}
	
		[EntityAttribute(31, EntityAttributeState.Optional)]
		public string @CodePerformance 
		{ 
			get 
			{
				if(Activated) return _codePerformance;
				
				Model.Activate(this, true);
				Activated = true;
				return _codePerformance;
			} 
			set
			{
				SetValue( v =>  _codePerformance = v, _codePerformance, value,  "CodePerformance");
			} 
		}
	
		[EntityAttribute(32, EntityAttributeState.Optional)]
		public string @SustainabilityPerformance 
		{ 
			get 
			{
				if(Activated) return _sustainabilityPerformance;
				
				Model.Activate(this, true);
				Activated = true;
				return _sustainabilityPerformance;
			} 
			set
			{
				SetValue( v =>  _sustainabilityPerformance = v, _sustainabilityPerformance, value,  "SustainabilityPerformance");
			} 
		}
	
		[EntityAttribute(33, EntityAttributeState.Mandatory)]
		public ItemSet<CobieType> @AssemblyOf 
		{ 
			get 
			{
				if(Activated) return _assemblyOf;
				
				Model.Activate(this, true);
				Activated = true;
				return _assemblyOf;
			} 
			set
			{
				SetValue( v =>  _assemblyOf = v, _assemblyOf, value,  "AssemblyOf");
			} 
		}
	
		[EntityAttribute(34, EntityAttributeState.Mandatory)]
		public ItemSet<CobieJob> @Jobs 
		{ 
			get 
			{
				if(Activated) return _jobs;
				
				Model.Activate(this, true);
				Activated = true;
				return _jobs;
			} 
			set
			{
				SetValue( v =>  _jobs = v, _jobs, value,  "Jobs");
			} 
		}
	
		#endregion

		#region Inverse attributes
		public IEnumerable<CobieComponent> @Components 
		{ 
			get 
			{
				return Model.Instances.Where<CobieComponent>(e => e.Type == this);
			} 
		}
	
		public IEnumerable<CobieSpare> @Spares 
		{ 
			get 
			{
				return Model.Instances.Where<CobieSpare>(e => e.Type == this);
			} 
		}
	

		#endregion

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"Created",
			"ExternalSystem",
			"ExternalObject",
			"ExternalId",
			"LocalId",
			"Name",
			"Description",
			"Category",
			"Impacts",
			"Documents",
			"Attributes",
			"AssetType",
			"Manufacturer",
			"ModelNumber",
			"Warranty",
			"ReplacementCost",
			"ExpectedLife",
			"DurationUnit",
			"NominalLength",
			"NominalWidth",
			"NominalHeight",
			"ModelReference",
			"Shape",
			"Size",
			"Color",
			"Finish",
			"Grade",
			"Material",
			"Constituents",
			"Features",
			"AccessibilityPerformance",
			"CodePerformance",
			"SustainabilityPerformance",
			"AssemblyOf",
			"Jobs",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @Created;
				case 1: 
					return @ExternalSystem;
				case 2: 
					return @ExternalObject;
				case 3: 
					return @ExternalId;
				case 4: 
					return @LocalId;
				case 5: 
					return @Name;
				case 6: 
					return @Description;
				case 7: 
					return @Category;
				case 8: 
					return @Impacts;
				case 9: 
					return @Documents;
				case 10: 
					return @Attributes;
				case 11: 
					return @AssetType;
				case 12: 
					return @Manufacturer;
				case 13: 
					return @ModelNumber;
				case 14: 
					return @Warranty;
				case 15: 
					return @ReplacementCost;
				case 16: 
					return @ExpectedLife;
				case 17: 
					return @DurationUnit;
				case 18: 
					return @NominalLength;
				case 19: 
					return @NominalWidth;
				case 20: 
					return @NominalHeight;
				case 21: 
					return @ModelReference;
				case 22: 
					return @Shape;
				case 23: 
					return @Size;
				case 24: 
					return @Color;
				case 25: 
					return @Finish;
				case 26: 
					return @Grade;
				case 27: 
					return @Material;
				case 28: 
					return @Constituents;
				case 29: 
					return @Features;
				case 30: 
					return @AccessibilityPerformance;
				case 31: 
					return @CodePerformance;
				case 32: 
					return @SustainabilityPerformance;
				case 33: 
					return @AssemblyOf;
				case 34: 
					return @Jobs;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "Created":  
					return @Created;
				case "ExternalSystem":  
					return @ExternalSystem;
				case "ExternalObject":  
					return @ExternalObject;
				case "ExternalId":  
					return @ExternalId;
				case "LocalId":  
					return @LocalId;
				case "Name":  
					return @Name;
				case "Description":  
					return @Description;
				case "Category":  
					return @Category;
				case "Impacts":  
					return @Impacts;
				case "Documents":  
					return @Documents;
				case "Attributes":  
					return @Attributes;
				case "AssetType":  
					return @AssetType;
				case "Manufacturer":  
					return @Manufacturer;
				case "ModelNumber":  
					return @ModelNumber;
				case "Warranty":  
					return @Warranty;
				case "ReplacementCost":  
					return @ReplacementCost;
				case "ExpectedLife":  
					return @ExpectedLife;
				case "DurationUnit":  
					return @DurationUnit;
				case "NominalLength":  
					return @NominalLength;
				case "NominalWidth":  
					return @NominalWidth;
				case "NominalHeight":  
					return @NominalHeight;
				case "ModelReference":  
					return @ModelReference;
				case "Shape":  
					return @Shape;
				case "Size":  
					return @Size;
				case "Color":  
					return @Color;
				case "Finish":  
					return @Finish;
				case "Grade":  
					return @Grade;
				case "Material":  
					return @Material;
				case "Constituents":  
					return @Constituents;
				case "Features":  
					return @Features;
				case "AccessibilityPerformance":  
					return @AccessibilityPerformance;
				case "CodePerformance":  
					return @CodePerformance;
				case "SustainabilityPerformance":  
					return @SustainabilityPerformance;
				case "AssemblyOf":  
					return @AssemblyOf;
				case "Jobs":  
					return @Jobs;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 @Created = (CobieCreatedInfo)value;
					 break;
				case 1:
					 @ExternalSystem = (CobieExternalSystem)value;
					 break;
				case 2:
					 @ExternalObject = (string)value;
					 break;
				case 3:
					 @ExternalId = (string)value;
					 break;
				case 4:
					 if (value != null) @LocalId = (long)value;
					 break;
				case 5:
					 @Name = (string)value;
					 break;
				case 6:
					 @Description = (string)value;
					 break;
				case 7:
					 @Category.Add((CobiePickKeyValue)value);
					 break;
				case 8:
					 @Impacts.Add((CobieImpact)value);
					 break;
				case 9:
					 @Documents.Add((CobieDocument)value);
					 break;
				case 10:
					 @Attributes.Add((CobieAttribute)value);
					 break;
				case 11:
					 @AssetType = (CobiePickValue)value;
					 break;
				case 12:
					 @Manufacturer = (CobieContact)value;
					 break;
				case 13:
					 @ModelNumber = (string)value;
					 break;
				case 14:
					 @Warranty = (CobieWarranty)value;
					 break;
				case 15:
					 @ReplacementCost = (double?)value;
					 break;
				case 16:
					 @ExpectedLife = (double?)value;
					 break;
				case 17:
					 @DurationUnit = (CobiePickValue)value;
					 break;
				case 18:
					 if (value != null) @NominalLength = (double)value;
					 break;
				case 19:
					 if (value != null) @NominalWidth = (double)value;
					 break;
				case 20:
					 if (value != null) @NominalHeight = (double)value;
					 break;
				case 21:
					 @ModelReference = (string)value;
					 break;
				case 22:
					 @Shape = (string)value;
					 break;
				case 23:
					 @Size = (string)value;
					 break;
				case 24:
					 @Color = (string)value;
					 break;
				case 25:
					 @Finish = (string)value;
					 break;
				case 26:
					 @Grade = (string)value;
					 break;
				case 27:
					 @Material = (string)value;
					 break;
				case 28:
					 @Constituents = (string)value;
					 break;
				case 29:
					 @Features = (string)value;
					 break;
				case 30:
					 @AccessibilityPerformance = (string)value;
					 break;
				case 31:
					 @CodePerformance = (string)value;
					 break;
				case 32:
					 @SustainabilityPerformance = (string)value;
					 break;
				case 33:
					 @AssemblyOf.Add((CobieType)value);
					 break;
				case 34:
					 @Jobs.Add((CobieJob)value);
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "Created":
					 @Created = (CobieCreatedInfo)value;
					 break;
				case "ExternalSystem":
					 @ExternalSystem = (CobieExternalSystem)value;
					 break;
				case "ExternalObject":
					 @ExternalObject = (string)value;
					 break;
				case "ExternalId":
					 @ExternalId = (string)value;
					 break;
				case "LocalId":
					 if (value != null) @LocalId = (long)value;
					 break;
				case "Name":
					 @Name = (string)value;
					 break;
				case "Description":
					 @Description = (string)value;
					 break;
				case "Category":
					 @Category.Add((CobiePickKeyValue)value);
					 break;
				case "Impacts":
					 @Impacts.Add((CobieImpact)value);
					 break;
				case "Documents":
					 @Documents.Add((CobieDocument)value);
					 break;
				case "Attributes":
					 @Attributes.Add((CobieAttribute)value);
					 break;
				case "AssetType":
					 @AssetType = (CobiePickValue)value;
					 break;
				case "Manufacturer":
					 @Manufacturer = (CobieContact)value;
					 break;
				case "ModelNumber":
					 @ModelNumber = (string)value;
					 break;
				case "Warranty":
					 @Warranty = (CobieWarranty)value;
					 break;
				case "ReplacementCost":
					 @ReplacementCost = (double?)value;
					 break;
				case "ExpectedLife":
					 @ExpectedLife = (double?)value;
					 break;
				case "DurationUnit":
					 @DurationUnit = (CobiePickValue)value;
					 break;
				case "NominalLength":
					 if (value != null) @NominalLength = (double)value;
					 break;
				case "NominalWidth":
					 if (value != null) @NominalWidth = (double)value;
					 break;
				case "NominalHeight":
					 if (value != null) @NominalHeight = (double)value;
					 break;
				case "ModelReference":
					 @ModelReference = (string)value;
					 break;
				case "Shape":
					 @Shape = (string)value;
					 break;
				case "Size":
					 @Size = (string)value;
					 break;
				case "Color":
					 @Color = (string)value;
					 break;
				case "Finish":
					 @Finish = (string)value;
					 break;
				case "Grade":
					 @Grade = (string)value;
					 break;
				case "Material":
					 @Material = (string)value;
					 break;
				case "Constituents":
					 @Constituents = (string)value;
					 break;
				case "Features":
					 @Features = (string)value;
					 break;
				case "AccessibilityPerformance":
					 @AccessibilityPerformance = (string)value;
					 break;
				case "CodePerformance":
					 @CodePerformance = (string)value;
					 break;
				case "SustainabilityPerformance":
					 @SustainabilityPerformance = (string)value;
					 break;
				case "AssemblyOf":
					 @AssemblyOf.Add((CobieType)value);
					 break;
				case "Jobs":
					 @Jobs.Add((CobieJob)value);
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
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