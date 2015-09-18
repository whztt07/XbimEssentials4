// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 03:44:05
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.ProfileResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.MaterialResource
{
	[EntityName("IFCMATERIALPROFILE", 361)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcMaterialProfile : IfcMaterialDefinition, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcMaterialProfile(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcLabel? _name;
		private IfcText? _description;
		private IfcMaterial _material;
		private IfcProfileDef _profile;
		private IfcNormalisedRatioMeasure? _priority;
		private IfcLabel? _category;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttributee(0, EntityAttributeState.Optional)]
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
	
		[EntityAttributee(1, EntityAttributeState.Optional)]
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
	
		[EntityAttributee(2, EntityAttributeState.Optional)]
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
	
		[EntityAttributee(3, EntityAttributeState.Mandatory)]
		public IfcProfileDef @Profile 
		{ 
			get 
			{
				if(Activated) return _profile;
				
				Model.Activate(this, true);
				Activated = true;
				return _profile;
			} 
			set
			{
				SetValue( v =>  _profile = v, _profile, value,  "Profile");
			} 
		}
	
		[EntityAttributee(4, EntityAttributeState.Optional)]
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
	
		[EntityAttributee(5, EntityAttributeState.Optional)]
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
	
		#endregion

		#region Inverse attributes
		public IEnumerable<IfcMaterialProfileSet> @ToMaterialProfileSet 
		{ 
			get 
			{
				return Model.Instances.Where<IfcMaterialProfileSet>(e => e.MaterialProfiles != null &&  e.MaterialProfiles.Contains(this));
			} 
		}
	

		#endregion

		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
					_name = value.StringVal;
					return;
				case 1: 
					_description = value.StringVal;
					return;
				case 2: 
					_material = (IfcMaterial)(value.EntityVal);
					return;
				case 3: 
					_profile = (IfcProfileDef)(value.EntityVal);
					return;
				case 4: 
					_priority = value.RealVal;
					return;
				case 5: 
					_category = value.StringVal;
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