// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 09:16:39
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.UtilityResource;
using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.GeometricConstraintResource;
using Xbim.Ifc2x3.RepresentationResource;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc2x3.ProductExtension
{
	[EntityName("IFCSPACE")]
	public  partial class @IfcSpace : IfcSpatialStructureElement, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcSpace(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcInternalOrExternalEnum _interiorOrExteriorSpace;
		private IfcLengthMeasure? _elevationWithFlooring;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(9, EntityAttributeState.Mandatory)]
		public IfcInternalOrExternalEnum @InteriorOrExteriorSpace 
		{ 
			get 
			{
				if(IsActivated) return _interiorOrExteriorSpace;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _interiorOrExteriorSpace;
			} 
			set
			{
				SetValue( v =>  _interiorOrExteriorSpace = v, _interiorOrExteriorSpace, value,  "InteriorOrExteriorSpace");
			} 
		}
	
		[EntityAttribute(10, EntityAttributeState.Optional)]
		public IfcLengthMeasure? @ElevationWithFlooring 
		{ 
			get 
			{
				if(IsActivated) return _elevationWithFlooring;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _elevationWithFlooring;
			} 
			set
			{
				SetValue( v =>  _elevationWithFlooring = v, _elevationWithFlooring, value,  "ElevationWithFlooring");
			} 
		}
	
		#endregion

		#region Inverse attributes
		public IEnumerable<IfcRelCoversSpaces> @HasCoverings 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelCoversSpaces>(e => e.RelatedSpace == this);
			} 
		}
	
		public IEnumerable<IfcRelSpaceBoundary> @BoundedBy 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelSpaceBoundary>(e => e.RelatingSpace == this);
			} 
		}
	

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
			"InteriorOrExteriorSpace",
			"ElevationWithFlooring",
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
					return @InteriorOrExteriorSpace;
				case 10: 
					return @ElevationWithFlooring;
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
				case "InteriorOrExteriorSpace":  
					return @InteriorOrExteriorSpace;
				case "ElevationWithFlooring":  
					return @ElevationWithFlooring;
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
					 if (value != null) @InteriorOrExteriorSpace = (IfcInternalOrExternalEnum)value;
					 break;
				case 10:
					 @ElevationWithFlooring = (IfcLengthMeasure?)value;
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
				case "InteriorOrExteriorSpace":
					 if (value != null) @InteriorOrExteriorSpace = (IfcInternalOrExternalEnum)value;
					 break;
				case "ElevationWithFlooring":
					 @ElevationWithFlooring = (IfcLengthMeasure?)value;
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