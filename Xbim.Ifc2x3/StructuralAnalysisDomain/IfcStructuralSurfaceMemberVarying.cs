// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		09/09/2015 04:20:36
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

namespace Xbim.Ifc2x3.StructuralAnalysisDomain
{
	[EntityName("IFCSTRUCTURALSURFACEMEMBERVARYING", 421)]
	public  partial class @IfcStructuralSurfaceMemberVarying : IfcStructuralSurfaceMember, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcStructuralSurfaceMemberVarying(IModel model) : base(model) 		{ 
			Model = model; 
			_subsequentThickness = new ItemSet<IfcPositiveLengthMeasure>( model );
		}

		#region Explicit attribute fields
		private ItemSet<IfcPositiveLengthMeasure> _subsequentThickness;
		private IfcShapeAspect _varyingThicknessLocation;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(9, EntityAttributeState.Mandatory)]
		public ItemSet<IfcPositiveLengthMeasure> @SubsequentThickness 
		{ 
			get 
			{
				if(Activated) return _subsequentThickness;
				
				Model.Activate(this, true);
				Activated = true;
				return _subsequentThickness;
			} 
			set
			{
				SetValue( v =>  _subsequentThickness = v, _subsequentThickness, value,  "SubsequentThickness");
			} 
		}
	
		[EntityAttribute(10, EntityAttributeState.Mandatory)]
		public IfcShapeAspect @VaryingThicknessLocation 
		{ 
			get 
			{
				if(Activated) return _varyingThicknessLocation;
				
				Model.Activate(this, true);
				Activated = true;
				return _varyingThicknessLocation;
			} 
			set
			{
				SetValue( v =>  _varyingThicknessLocation = v, _varyingThicknessLocation, value,  "VaryingThicknessLocation");
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
			"PredefinedType",
			"Thickness",
			"SubsequentThickness",
			"VaryingThicknessLocation",
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
					return @PredefinedType;
				case 8: 
					return @Thickness;
				case 9: 
					return @SubsequentThickness;
				case 10: 
					return @VaryingThicknessLocation;
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
				case "PredefinedType":  
					return @PredefinedType;
				case "Thickness":  
					return @Thickness;
				case "SubsequentThickness":  
					return @SubsequentThickness;
				case "VaryingThicknessLocation":  
					return @VaryingThicknessLocation;
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
					 if (value != null) @PredefinedType = (IfcStructuralSurfaceTypeEnum)value;
					 break;
				case 8:
					 @Thickness = (IfcPositiveLengthMeasure?)value;
					 break;
				case 9:
					 @SubsequentThickness = (ItemSet<IfcPositiveLengthMeasure>)value;
					 break;
				case 10:
					 @VaryingThicknessLocation = (IfcShapeAspect)value;
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
				case "PredefinedType":
					 if (value != null) @PredefinedType = (IfcStructuralSurfaceTypeEnum)value;
					 break;
				case "Thickness":
					 @Thickness = (IfcPositiveLengthMeasure?)value;
					 break;
				case "SubsequentThickness":
					 @SubsequentThickness = (ItemSet<IfcPositiveLengthMeasure>)value;
					 break;
				case "VaryingThicknessLocation":
					 @VaryingThicknessLocation = (IfcShapeAspect)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion

		#region Where rules
		/*WR61:	WR61 : EXISTS(SELF\IfcStructuralSurfaceMember.Thickness);*/
		/*WR62:               )) = 0;*/
		/*WR63:               )) = 0;*/
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