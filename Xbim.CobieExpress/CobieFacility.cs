// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		09/09/2015 04:20:46
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.CobieExpress
{
	[EntityName("FACILITY", 9)]
	public  partial class @CobieFacility : CobieAsset, SpatialDivision, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal CobieFacility(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private CobiePickValue _linearUnits;
		private CobiePickValue _areaUnits;
		private CobiePickValue _volumeUnits;
		private CobiePickValue _currencyUnit;
		private string _areaMeasurement;
		private CobieProject _project;
		private CobieSite _site;
		private CobiePhase _phase;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(11, EntityAttributeState.Mandatory)]
		public CobiePickValue @LinearUnits 
		{ 
			get 
			{
				if(Activated) return _linearUnits;
				
				Model.Activate(this, true);
				Activated = true;
				return _linearUnits;
			} 
			set
			{
				SetValue( v =>  _linearUnits = v, _linearUnits, value,  "LinearUnits");
			} 
		}
	
		[EntityAttribute(12, EntityAttributeState.Mandatory)]
		public CobiePickValue @AreaUnits 
		{ 
			get 
			{
				if(Activated) return _areaUnits;
				
				Model.Activate(this, true);
				Activated = true;
				return _areaUnits;
			} 
			set
			{
				SetValue( v =>  _areaUnits = v, _areaUnits, value,  "AreaUnits");
			} 
		}
	
		[EntityAttribute(13, EntityAttributeState.Mandatory)]
		public CobiePickValue @VolumeUnits 
		{ 
			get 
			{
				if(Activated) return _volumeUnits;
				
				Model.Activate(this, true);
				Activated = true;
				return _volumeUnits;
			} 
			set
			{
				SetValue( v =>  _volumeUnits = v, _volumeUnits, value,  "VolumeUnits");
			} 
		}
	
		[EntityAttribute(14, EntityAttributeState.Mandatory)]
		public CobiePickValue @CurrencyUnit 
		{ 
			get 
			{
				if(Activated) return _currencyUnit;
				
				Model.Activate(this, true);
				Activated = true;
				return _currencyUnit;
			} 
			set
			{
				SetValue( v =>  _currencyUnit = v, _currencyUnit, value,  "CurrencyUnit");
			} 
		}
	
		[EntityAttribute(15, EntityAttributeState.Mandatory)]
		public string @AreaMeasurement 
		{ 
			get 
			{
				if(Activated) return _areaMeasurement;
				
				Model.Activate(this, true);
				Activated = true;
				return _areaMeasurement;
			} 
			set
			{
				SetValue( v =>  _areaMeasurement = v, _areaMeasurement, value,  "AreaMeasurement");
			} 
		}
	
		[EntityAttribute(16, EntityAttributeState.Mandatory)]
		public CobieProject @Project 
		{ 
			get 
			{
				if(Activated) return _project;
				
				Model.Activate(this, true);
				Activated = true;
				return _project;
			} 
			set
			{
				SetValue( v =>  _project = v, _project, value,  "Project");
			} 
		}
	
		[EntityAttribute(17, EntityAttributeState.Mandatory)]
		public CobieSite @Site 
		{ 
			get 
			{
				if(Activated) return _site;
				
				Model.Activate(this, true);
				Activated = true;
				return _site;
			} 
			set
			{
				SetValue( v =>  _site = v, _site, value,  "Site");
			} 
		}
	
		[EntityAttribute(18, EntityAttributeState.Optional)]
		public CobiePhase @Phase 
		{ 
			get 
			{
				if(Activated) return _phase;
				
				Model.Activate(this, true);
				Activated = true;
				return _phase;
			} 
			set
			{
				SetValue( v =>  _phase = v, _phase, value,  "Phase");
			} 
		}
	
		#endregion

		#region Inverse attributes
		public IEnumerable<CobieFloor> @Floors 
		{ 
			get 
			{
				return Model.Instances.Where<CobieFloor>(e => e.Facility == this);
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
			"LinearUnits",
			"AreaUnits",
			"VolumeUnits",
			"CurrencyUnit",
			"AreaMeasurement",
			"Project",
			"Site",
			"Phase",
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
					return @LinearUnits;
				case 12: 
					return @AreaUnits;
				case 13: 
					return @VolumeUnits;
				case 14: 
					return @CurrencyUnit;
				case 15: 
					return @AreaMeasurement;
				case 16: 
					return @Project;
				case 17: 
					return @Site;
				case 18: 
					return @Phase;
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
				case "LinearUnits":  
					return @LinearUnits;
				case "AreaUnits":  
					return @AreaUnits;
				case "VolumeUnits":  
					return @VolumeUnits;
				case "CurrencyUnit":  
					return @CurrencyUnit;
				case "AreaMeasurement":  
					return @AreaMeasurement;
				case "Project":  
					return @Project;
				case "Site":  
					return @Site;
				case "Phase":  
					return @Phase;
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
					 @LinearUnits = (CobiePickValue)value;
					 break;
				case 12:
					 @AreaUnits = (CobiePickValue)value;
					 break;
				case 13:
					 @VolumeUnits = (CobiePickValue)value;
					 break;
				case 14:
					 @CurrencyUnit = (CobiePickValue)value;
					 break;
				case 15:
					 @AreaMeasurement = (string)value;
					 break;
				case 16:
					 @Project = (CobieProject)value;
					 break;
				case 17:
					 @Site = (CobieSite)value;
					 break;
				case 18:
					 @Phase = (CobiePhase)value;
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
				case "LinearUnits":
					 @LinearUnits = (CobiePickValue)value;
					 break;
				case "AreaUnits":
					 @AreaUnits = (CobiePickValue)value;
					 break;
				case "VolumeUnits":
					 @VolumeUnits = (CobiePickValue)value;
					 break;
				case "CurrencyUnit":
					 @CurrencyUnit = (CobiePickValue)value;
					 break;
				case "AreaMeasurement":
					 @AreaMeasurement = (string)value;
					 break;
				case "Project":
					 @Project = (CobieProject)value;
					 break;
				case "Site":
					 @Site = (CobieSite)value;
					 break;
				case "Phase":
					 @Phase = (CobiePhase)value;
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