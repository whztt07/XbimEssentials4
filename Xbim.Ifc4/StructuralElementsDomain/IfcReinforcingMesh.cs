// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		15.09.2015 07:03:40
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.UtilityResource;
using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.GeometricConstraintResource;
using Xbim.Ifc4.RepresentationResource;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc4.StructuralElementsDomain
{
	[EntityName("IFCREINFORCINGMESH", 508)]
	public  partial class @IfcReinforcingMesh : IfcReinforcingElement, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcReinforcingMesh(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcPositiveLengthMeasure? _meshLength;
		private IfcPositiveLengthMeasure? _meshWidth;
		private IfcPositiveLengthMeasure? _longitudinalBarNominalDiameter;
		private IfcPositiveLengthMeasure? _transverseBarNominalDiameter;
		private IfcAreaMeasure? _longitudinalBarCrossSectionArea;
		private IfcAreaMeasure? _transverseBarCrossSectionArea;
		private IfcPositiveLengthMeasure? _longitudinalBarSpacing;
		private IfcPositiveLengthMeasure? _transverseBarSpacing;
		private IfcReinforcingMeshTypeEnum? _predefinedType;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(9, EntityAttributeState.Optional)]
		public IfcPositiveLengthMeasure? @MeshLength 
		{ 
			get 
			{
				if(Activated) return _meshLength;
				
				Model.Activate(this, true);
				Activated = true;
				return _meshLength;
			} 
			set
			{
				SetValue( v =>  _meshLength = v, _meshLength, value,  "MeshLength");
			} 
		}
	
		[EntityAttribute(10, EntityAttributeState.Optional)]
		public IfcPositiveLengthMeasure? @MeshWidth 
		{ 
			get 
			{
				if(Activated) return _meshWidth;
				
				Model.Activate(this, true);
				Activated = true;
				return _meshWidth;
			} 
			set
			{
				SetValue( v =>  _meshWidth = v, _meshWidth, value,  "MeshWidth");
			} 
		}
	
		[EntityAttribute(11, EntityAttributeState.Optional)]
		public IfcPositiveLengthMeasure? @LongitudinalBarNominalDiameter 
		{ 
			get 
			{
				if(Activated) return _longitudinalBarNominalDiameter;
				
				Model.Activate(this, true);
				Activated = true;
				return _longitudinalBarNominalDiameter;
			} 
			set
			{
				SetValue( v =>  _longitudinalBarNominalDiameter = v, _longitudinalBarNominalDiameter, value,  "LongitudinalBarNominalDiameter");
			} 
		}
	
		[EntityAttribute(12, EntityAttributeState.Optional)]
		public IfcPositiveLengthMeasure? @TransverseBarNominalDiameter 
		{ 
			get 
			{
				if(Activated) return _transverseBarNominalDiameter;
				
				Model.Activate(this, true);
				Activated = true;
				return _transverseBarNominalDiameter;
			} 
			set
			{
				SetValue( v =>  _transverseBarNominalDiameter = v, _transverseBarNominalDiameter, value,  "TransverseBarNominalDiameter");
			} 
		}
	
		[EntityAttribute(13, EntityAttributeState.Optional)]
		public IfcAreaMeasure? @LongitudinalBarCrossSectionArea 
		{ 
			get 
			{
				if(Activated) return _longitudinalBarCrossSectionArea;
				
				Model.Activate(this, true);
				Activated = true;
				return _longitudinalBarCrossSectionArea;
			} 
			set
			{
				SetValue( v =>  _longitudinalBarCrossSectionArea = v, _longitudinalBarCrossSectionArea, value,  "LongitudinalBarCrossSectionArea");
			} 
		}
	
		[EntityAttribute(14, EntityAttributeState.Optional)]
		public IfcAreaMeasure? @TransverseBarCrossSectionArea 
		{ 
			get 
			{
				if(Activated) return _transverseBarCrossSectionArea;
				
				Model.Activate(this, true);
				Activated = true;
				return _transverseBarCrossSectionArea;
			} 
			set
			{
				SetValue( v =>  _transverseBarCrossSectionArea = v, _transverseBarCrossSectionArea, value,  "TransverseBarCrossSectionArea");
			} 
		}
	
		[EntityAttribute(15, EntityAttributeState.Optional)]
		public IfcPositiveLengthMeasure? @LongitudinalBarSpacing 
		{ 
			get 
			{
				if(Activated) return _longitudinalBarSpacing;
				
				Model.Activate(this, true);
				Activated = true;
				return _longitudinalBarSpacing;
			} 
			set
			{
				SetValue( v =>  _longitudinalBarSpacing = v, _longitudinalBarSpacing, value,  "LongitudinalBarSpacing");
			} 
		}
	
		[EntityAttribute(16, EntityAttributeState.Optional)]
		public IfcPositiveLengthMeasure? @TransverseBarSpacing 
		{ 
			get 
			{
				if(Activated) return _transverseBarSpacing;
				
				Model.Activate(this, true);
				Activated = true;
				return _transverseBarSpacing;
			} 
			set
			{
				SetValue( v =>  _transverseBarSpacing = v, _transverseBarSpacing, value,  "TransverseBarSpacing");
			} 
		}
	
		[EntityAttribute(17, EntityAttributeState.Optional)]
		public IfcReinforcingMeshTypeEnum? @PredefinedType 
		{ 
			get 
			{
				if(Activated) return _predefinedType;
				
				Model.Activate(this, true);
				Activated = true;
				return _predefinedType;
			} 
			set
			{
				SetValue( v =>  _predefinedType = v, _predefinedType, value,  "PredefinedType");
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
			"SteelGrade",
			"MeshLength",
			"MeshWidth",
			"LongitudinalBarNominalDiameter",
			"TransverseBarNominalDiameter",
			"LongitudinalBarCrossSectionArea",
			"TransverseBarCrossSectionArea",
			"LongitudinalBarSpacing",
			"TransverseBarSpacing",
			"PredefinedType",
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
					return @SteelGrade;
				case 9: 
					return @MeshLength;
				case 10: 
					return @MeshWidth;
				case 11: 
					return @LongitudinalBarNominalDiameter;
				case 12: 
					return @TransverseBarNominalDiameter;
				case 13: 
					return @LongitudinalBarCrossSectionArea;
				case 14: 
					return @TransverseBarCrossSectionArea;
				case 15: 
					return @LongitudinalBarSpacing;
				case 16: 
					return @TransverseBarSpacing;
				case 17: 
					return @PredefinedType;
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
				case "SteelGrade":  
					return @SteelGrade;
				case "MeshLength":  
					return @MeshLength;
				case "MeshWidth":  
					return @MeshWidth;
				case "LongitudinalBarNominalDiameter":  
					return @LongitudinalBarNominalDiameter;
				case "TransverseBarNominalDiameter":  
					return @TransverseBarNominalDiameter;
				case "LongitudinalBarCrossSectionArea":  
					return @LongitudinalBarCrossSectionArea;
				case "TransverseBarCrossSectionArea":  
					return @TransverseBarCrossSectionArea;
				case "LongitudinalBarSpacing":  
					return @LongitudinalBarSpacing;
				case "TransverseBarSpacing":  
					return @TransverseBarSpacing;
				case "PredefinedType":  
					return @PredefinedType;
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
					 @SteelGrade = (IfcLabel?)value;
					 break;
				case 9:
					 @MeshLength = (IfcPositiveLengthMeasure?)value;
					 break;
				case 10:
					 @MeshWidth = (IfcPositiveLengthMeasure?)value;
					 break;
				case 11:
					 @LongitudinalBarNominalDiameter = (IfcPositiveLengthMeasure?)value;
					 break;
				case 12:
					 @TransverseBarNominalDiameter = (IfcPositiveLengthMeasure?)value;
					 break;
				case 13:
					 @LongitudinalBarCrossSectionArea = (IfcAreaMeasure?)value;
					 break;
				case 14:
					 @TransverseBarCrossSectionArea = (IfcAreaMeasure?)value;
					 break;
				case 15:
					 @LongitudinalBarSpacing = (IfcPositiveLengthMeasure?)value;
					 break;
				case 16:
					 @TransverseBarSpacing = (IfcPositiveLengthMeasure?)value;
					 break;
				case 17:
					 @PredefinedType = (IfcReinforcingMeshTypeEnum?)value;
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
				case "SteelGrade":
					 @SteelGrade = (IfcLabel?)value;
					 break;
				case "MeshLength":
					 @MeshLength = (IfcPositiveLengthMeasure?)value;
					 break;
				case "MeshWidth":
					 @MeshWidth = (IfcPositiveLengthMeasure?)value;
					 break;
				case "LongitudinalBarNominalDiameter":
					 @LongitudinalBarNominalDiameter = (IfcPositiveLengthMeasure?)value;
					 break;
				case "TransverseBarNominalDiameter":
					 @TransverseBarNominalDiameter = (IfcPositiveLengthMeasure?)value;
					 break;
				case "LongitudinalBarCrossSectionArea":
					 @LongitudinalBarCrossSectionArea = (IfcAreaMeasure?)value;
					 break;
				case "TransverseBarCrossSectionArea":
					 @TransverseBarCrossSectionArea = (IfcAreaMeasure?)value;
					 break;
				case "LongitudinalBarSpacing":
					 @LongitudinalBarSpacing = (IfcPositiveLengthMeasure?)value;
					 break;
				case "TransverseBarSpacing":
					 @TransverseBarSpacing = (IfcPositiveLengthMeasure?)value;
					 break;
				case "PredefinedType":
					 @PredefinedType = (IfcReinforcingMeshTypeEnum?)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion

		#region Where rules
		/*CorrectPredefinedType:                              ((PredefinedType = IfcReinforcingMeshTypeEnum.USERDEFINED) AND EXISTS(SELF\IfcObject.ObjectType));*/
		/*CorrectTypeAssigned:                              ('IFC4.IFCREINFORCINGMESHTYPE' IN TYPEOF(SELF\IfcObject.IsTypedBy[1].RelatingType));*/
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