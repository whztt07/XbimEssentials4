// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
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
	[ExpressType("IFCMATERIALPROFILESET", 753)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcMaterialProfileSet : IfcMaterialDefinition, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcMaterialProfileSet(IModel model) : base(model) 		{ 
			Model = model; 
			_materialProfiles = new ItemSet<IfcMaterialProfile>( this );
		}

		#region Explicit attribute fields
		private IfcLabel? _name;
		private IfcText? _description;
		private ItemSet<IfcMaterialProfile> _materialProfiles;
		private IfcCompositeProfileDef _compositeProfile;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
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
	
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
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
	
		[IndexedProperty]
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.Class, 1, -1)]
		public ItemSet<IfcMaterialProfile> @MaterialProfiles 
		{ 
			get 
			{
				if(Activated) return _materialProfiles;
				
				Model.Activate(this, true);
				Activated = true;
				return _materialProfiles;
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
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
					if (_materialProfiles == null) _materialProfiles = new ItemSet<IfcMaterialProfile>( this );
					_materialProfiles.InternalAdd((IfcMaterialProfile)value.EntityVal);
					return;
				case 3: 
					_compositeProfile = (IfcCompositeProfileDef)(value.EntityVal);
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