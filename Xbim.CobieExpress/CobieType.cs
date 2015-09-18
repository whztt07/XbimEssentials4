// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 03:44:09
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.CobieExpress
{
	[EntityName("TYPE", 15)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @CobieType : CobieAsset, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal CobieType(IModel model) : base(model) 		{ 
			Model = model; 
			_assemblyOf = new ItemSet<CobieType>( this );
			_jobs = new ItemSet<CobieJob>( this );
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
		[EntityAttributee(11, EntityAttributeState.Mandatory)]
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
	
		[EntityAttributee(12, EntityAttributeState.Mandatory)]
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
	
		[EntityAttributee(13, EntityAttributeState.Mandatory)]
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
	
		[EntityAttributee(14, EntityAttributeState.Mandatory)]
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
	
		[EntityAttributee(15, EntityAttributeState.Optional)]
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
	
		[EntityAttributee(16, EntityAttributeState.Optional)]
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
	
		[EntityAttributee(17, EntityAttributeState.Optional)]
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
	
		[EntityAttributee(18, EntityAttributeState.Mandatory)]
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
	
		[EntityAttributee(19, EntityAttributeState.Mandatory)]
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
	
		[EntityAttributee(20, EntityAttributeState.Mandatory)]
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
	
		[EntityAttributee(21, EntityAttributeState.Optional)]
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
	
		[EntityAttributee(22, EntityAttributeState.Optional)]
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
	
		[EntityAttributee(23, EntityAttributeState.Optional)]
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
	
		[EntityAttributee(24, EntityAttributeState.Optional)]
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
	
		[EntityAttributee(25, EntityAttributeState.Optional)]
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
	
		[EntityAttributee(26, EntityAttributeState.Optional)]
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
	
		[EntityAttributee(27, EntityAttributeState.Optional)]
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
	
		[EntityAttributee(28, EntityAttributeState.Optional)]
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
	
		[EntityAttributee(29, EntityAttributeState.Optional)]
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
	
		[EntityAttributee(30, EntityAttributeState.Optional)]
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
	
		[EntityAttributee(31, EntityAttributeState.Optional)]
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
	
		[EntityAttributee(32, EntityAttributeState.Optional)]
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
	
		[EntityAttributee(33, EntityAttributeState.Mandatory)]
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
	
		[EntityAttributee(34, EntityAttributeState.Mandatory)]
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

		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
				case 3: 
				case 4: 
				case 5: 
				case 6: 
				case 7: 
				case 8: 
				case 9: 
				case 10: 
					base.Parse(propIndex, value); 
					return;
				case 11: 
					_assetType = (CobiePickValue)(value.EntityVal);
					return;
				case 12: 
					_manufacturer = (CobieContact)(value.EntityVal);
					return;
				case 13: 
					_modelNumber = value.StringVal;
					return;
				case 14: 
					_warranty = (CobieWarranty)(value.EntityVal);
					return;
				case 15: 
					_replacementCost = value.RealVal;
					return;
				case 16: 
					_expectedLife = value.RealVal;
					return;
				case 17: 
					_durationUnit = (CobiePickValue)(value.EntityVal);
					return;
				case 18: 
					_nominalLength = value.RealVal;
					return;
				case 19: 
					_nominalWidth = value.RealVal;
					return;
				case 20: 
					_nominalHeight = value.RealVal;
					return;
				case 21: 
					_modelReference = value.StringVal;
					return;
				case 22: 
					_shape = value.StringVal;
					return;
				case 23: 
					_size = value.StringVal;
					return;
				case 24: 
					_color = value.StringVal;
					return;
				case 25: 
					_finish = value.StringVal;
					return;
				case 26: 
					_grade = value.StringVal;
					return;
				case 27: 
					_material = value.StringVal;
					return;
				case 28: 
					_constituents = value.StringVal;
					return;
				case 29: 
					_features = value.StringVal;
					return;
				case 30: 
					_accessibilityPerformance = value.StringVal;
					return;
				case 31: 
					_codePerformance = value.StringVal;
					return;
				case 32: 
					_sustainabilityPerformance = value.StringVal;
					return;
				case 33: 
					if (_assemblyOf == null) _assemblyOf = new ItemSet<CobieType>( this );
					_assemblyOf.InternalAdd((CobieType)value.EntityVal);
					return;
				case 34: 
					if (_jobs == null) _jobs = new ItemSet<CobieJob>( this );
					_jobs.InternalAdd((CobieJob)value.EntityVal);
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