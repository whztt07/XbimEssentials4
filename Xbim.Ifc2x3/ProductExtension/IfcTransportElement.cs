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
	[EntityName("IFCTRANSPORTELEMENT")]
	public  partial class @IfcTransportElement : IfcElement, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTransportElement(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcTransportElementTypeEnum _operationType;
		private IfcMassMeasure? _capacityByWeight;
		private IfcCountMeasure? _capacityByNumber;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(8, EntityAttributeState.Optional)]
		public IfcTransportElementTypeEnum @OperationType 
		{ 
			get 
			{
				if(IsActivated) return _operationType;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _operationType;
			} 
			set
			{
				SetValue( v =>  _operationType = v, _operationType, value,  "OperationType");
			} 
		}
	
		[EntityAttribute(9, EntityAttributeState.Optional)]
		public IfcMassMeasure? @CapacityByWeight 
		{ 
			get 
			{
				if(IsActivated) return _capacityByWeight;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _capacityByWeight;
			} 
			set
			{
				SetValue( v =>  _capacityByWeight = v, _capacityByWeight, value,  "CapacityByWeight");
			} 
		}
	
		[EntityAttribute(10, EntityAttributeState.Optional)]
		public IfcCountMeasure? @CapacityByNumber 
		{ 
			get 
			{
				if(IsActivated) return _capacityByNumber;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _capacityByNumber;
			} 
			set
			{
				SetValue( v =>  _capacityByNumber = v, _capacityByNumber, value,  "CapacityByNumber");
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
			"Tag",
			"OperationType",
			"CapacityByWeight",
			"CapacityByNumber",
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
					return @Tag;
				case 8: 
					return @OperationType;
				case 9: 
					return @CapacityByWeight;
				case 10: 
					return @CapacityByNumber;
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
				case "Tag":  
					return @Tag;
				case "OperationType":  
					return @OperationType;
				case "CapacityByWeight":  
					return @CapacityByWeight;
				case "CapacityByNumber":  
					return @CapacityByNumber;
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
					 @Tag = (IfcIdentifier?)value;
					 break;
				case 8:
					 @OperationType = (IfcTransportElementTypeEnum)value;
					 break;
				case 9:
					 @CapacityByWeight = (IfcMassMeasure?)value;
					 break;
				case 10:
					 @CapacityByNumber = (IfcCountMeasure?)value;
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
				case "Tag":
					 @Tag = (IfcIdentifier?)value;
					 break;
				case "OperationType":
					 @OperationType = (IfcTransportElementTypeEnum)value;
					 break;
				case "CapacityByWeight":
					 @CapacityByWeight = (IfcMassMeasure?)value;
					 break;
				case "CapacityByNumber":
					 @CapacityByNumber = (IfcCountMeasure?)value;
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