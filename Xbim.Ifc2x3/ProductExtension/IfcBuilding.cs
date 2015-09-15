// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		15.09.2015 07:04:14
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.UtilityResource;
using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.GeometricConstraintResource;
using Xbim.Ifc2x3.RepresentationResource;
using Xbim.Ifc2x3.ActorResource;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc2x3.ProductExtension
{
	[EntityName("IFCBUILDING", 169)]
	public  partial class @IfcBuilding : IfcSpatialStructureElement, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcBuilding(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcLengthMeasure? _elevationOfRefHeight;
		private IfcLengthMeasure? _elevationOfTerrain;
		private IfcPostalAddress _buildingAddress;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(9, EntityAttributeState.Optional)]
		public IfcLengthMeasure? @ElevationOfRefHeight 
		{ 
			get 
			{
				if(Activated) return _elevationOfRefHeight;
				
				Model.Activate(this, true);
				Activated = true;
				return _elevationOfRefHeight;
			} 
			set
			{
				SetValue( v =>  _elevationOfRefHeight = v, _elevationOfRefHeight, value,  "ElevationOfRefHeight");
			} 
		}
	
		[EntityAttribute(10, EntityAttributeState.Optional)]
		public IfcLengthMeasure? @ElevationOfTerrain 
		{ 
			get 
			{
				if(Activated) return _elevationOfTerrain;
				
				Model.Activate(this, true);
				Activated = true;
				return _elevationOfTerrain;
			} 
			set
			{
				SetValue( v =>  _elevationOfTerrain = v, _elevationOfTerrain, value,  "ElevationOfTerrain");
			} 
		}
	
		[EntityAttribute(11, EntityAttributeState.Optional)]
		public IfcPostalAddress @BuildingAddress 
		{ 
			get 
			{
				if(Activated) return _buildingAddress;
				
				Model.Activate(this, true);
				Activated = true;
				return _buildingAddress;
			} 
			set
			{
				SetValue( v =>  _buildingAddress = v, _buildingAddress, value,  "BuildingAddress");
			} 
		}
	
		#endregion

		#region Inverse attributes

		#endregion

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"GlobalId",
			"OwnerHistory",
			"Name",
			"Description",
			"ObjectType",
			"ObjectPlacement",
			"Representation",
			"LongName",
			"CompositionType",
			"ElevationOfRefHeight",
			"ElevationOfTerrain",
			"BuildingAddress",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @GlobalId;
				case 1: 
					return @OwnerHistory;
				case 2: 
					return @Name;
				case 3: 
					return @Description;
				case 4: 
					return @ObjectType;
				case 5: 
					return @ObjectPlacement;
				case 6: 
					return @Representation;
				case 7: 
					return @LongName;
				case 8: 
					return @CompositionType;
				case 9: 
					return @ElevationOfRefHeight;
				case 10: 
					return @ElevationOfTerrain;
				case 11: 
					return @BuildingAddress;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "GlobalId":  
					return @GlobalId;
				case "OwnerHistory":  
					return @OwnerHistory;
				case "Name":  
					return @Name;
				case "Description":  
					return @Description;
				case "ObjectType":  
					return @ObjectType;
				case "ObjectPlacement":  
					return @ObjectPlacement;
				case "Representation":  
					return @Representation;
				case "LongName":  
					return @LongName;
				case "CompositionType":  
					return @CompositionType;
				case "ElevationOfRefHeight":  
					return @ElevationOfRefHeight;
				case "ElevationOfTerrain":  
					return @ElevationOfTerrain;
				case "BuildingAddress":  
					return @BuildingAddress;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 if (value != null) @GlobalId = (IfcGloballyUniqueId)value;
					 break;
				case 1:
					 @OwnerHistory = (IfcOwnerHistory)value;
					 break;
				case 2:
					 @Name = (IfcLabel?)value;
					 break;
				case 3:
					 @Description = (IfcText?)value;
					 break;
				case 4:
					 @ObjectType = (IfcLabel?)value;
					 break;
				case 5:
					 @ObjectPlacement = (IfcObjectPlacement)value;
					 break;
				case 6:
					 @Representation = (IfcProductRepresentation)value;
					 break;
				case 7:
					 @LongName = (IfcLabel?)value;
					 break;
				case 8:
					 if (value != null) @CompositionType = (IfcElementCompositionEnum)value;
					 break;
				case 9:
					 @ElevationOfRefHeight = (IfcLengthMeasure?)value;
					 break;
				case 10:
					 @ElevationOfTerrain = (IfcLengthMeasure?)value;
					 break;
				case 11:
					 @BuildingAddress = (IfcPostalAddress)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "GlobalId":
					 if (value != null) @GlobalId = (IfcGloballyUniqueId)value;
					 break;
				case "OwnerHistory":
					 @OwnerHistory = (IfcOwnerHistory)value;
					 break;
				case "Name":
					 @Name = (IfcLabel?)value;
					 break;
				case "Description":
					 @Description = (IfcText?)value;
					 break;
				case "ObjectType":
					 @ObjectType = (IfcLabel?)value;
					 break;
				case "ObjectPlacement":
					 @ObjectPlacement = (IfcObjectPlacement)value;
					 break;
				case "Representation":
					 @Representation = (IfcProductRepresentation)value;
					 break;
				case "LongName":
					 @LongName = (IfcLabel?)value;
					 break;
				case "CompositionType":
					 if (value != null) @CompositionType = (IfcElementCompositionEnum)value;
					 break;
				case "ElevationOfRefHeight":
					 @ElevationOfRefHeight = (IfcLengthMeasure?)value;
					 break;
				case "ElevationOfTerrain":
					 @ElevationOfTerrain = (IfcLengthMeasure?)value;
					 break;
				case "BuildingAddress":
					 @BuildingAddress = (IfcPostalAddress)value;
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