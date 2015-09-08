// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 02:29:22
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.ProfileResource;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc4.MaterialResource
{
	[EntityName("IFCMATERIALPROFILESET", 362)]
	public  partial class @IfcMaterialProfileSet : IfcMaterialDefinition, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcMaterialProfileSet(IModel model) : base(model) 		{ 
			Model = model; 
			_materialProfiles = new ItemSet<IfcMaterialProfile>( model );
		}

		#region Explicit attribute fields
		private IfcLabel? _name;
		private IfcText? _description;
		private ItemSet<IfcMaterialProfile> _materialProfiles;
		private IfcCompositeProfileDef _compositeProfile;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(0, EntityAttributeState.Optional)]
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
	
		[EntityAttribute(1, EntityAttributeState.Optional)]
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
	
		[EntityAttribute(2, EntityAttributeState.Mandatory)]
		public ItemSet<IfcMaterialProfile> @MaterialProfiles 
		{ 
			get 
			{
				if(Activated) return _materialProfiles;
				
				Model.Activate(this, true);
				Activated = true;
				return _materialProfiles;
			} 
			set
			{
				SetValue( v =>  _materialProfiles = v, _materialProfiles, value,  "MaterialProfiles");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Optional)]
		public IfcCompositeProfileDef @CompositeProfile 
		{ 
			get 
			{
				if(Activated) return _compositeProfile;
				
				Model.Activate(this, true);
				Activated = true;
				return _compositeProfile;
			} 
			set
			{
				SetValue( v =>  _compositeProfile = v, _compositeProfile, value,  "CompositeProfile");
			} 
		}
	
		#endregion

		#region Inverse attributes

		#endregion

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"Name",
			"Description",
			"MaterialProfiles",
			"CompositeProfile",
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
					return @MaterialProfiles;
				case 3: 
					return @CompositeProfile;
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
				case "MaterialProfiles":  
					return @MaterialProfiles;
				case "CompositeProfile":  
					return @CompositeProfile;
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
					 @MaterialProfiles.Add((IfcMaterialProfile)value);
					 break;
				case 3:
					 @CompositeProfile = (IfcCompositeProfileDef)value;
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
				case "MaterialProfiles":
					 @MaterialProfiles.Add((IfcMaterialProfile)value);
					 break;
				case "CompositeProfile":
					 @CompositeProfile = (IfcCompositeProfileDef)value;
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