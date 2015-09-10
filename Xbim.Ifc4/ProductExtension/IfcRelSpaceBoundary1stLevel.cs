// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		09/09/2015 04:20:43
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.UtilityResource;
using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.GeometricConstraintResource;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc4.ProductExtension
{
	[EntityName("IFCRELSPACEBOUNDARY1STLEVEL", 554)]
	public  partial class @IfcRelSpaceBoundary1stLevel : IfcRelSpaceBoundary, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelSpaceBoundary1stLevel(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcRelSpaceBoundary1stLevel _parentBoundary;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(9, EntityAttributeState.Optional)]
		public IfcRelSpaceBoundary1stLevel @ParentBoundary 
		{ 
			get 
			{
				if(Activated) return _parentBoundary;
				
				Model.Activate(this, true);
				Activated = true;
				return _parentBoundary;
			} 
			set
			{
				SetValue( v =>  _parentBoundary = v, _parentBoundary, value,  "ParentBoundary");
			} 
		}
	
		#endregion

		#region Inverse attributes
		public IEnumerable<IfcRelSpaceBoundary1stLevel> @InnerBoundaries 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelSpaceBoundary1stLevel>(e => e.ParentBoundary == this);
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
			"RelatingSpace",
			"RelatedBuildingElement",
			"ConnectionGeometry",
			"PhysicalOrVirtualBoundary",
			"InternalOrExternalBoundary",
			"ParentBoundary",
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
					return @RelatingSpace;
				case 5: 
					return @RelatedBuildingElement;
				case 6: 
					return @ConnectionGeometry;
				case 7: 
					return @PhysicalOrVirtualBoundary;
				case 8: 
					return @InternalOrExternalBoundary;
				case 9: 
					return @ParentBoundary;
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
				case "RelatingSpace":  
					return @RelatingSpace;
				case "RelatedBuildingElement":  
					return @RelatedBuildingElement;
				case "ConnectionGeometry":  
					return @ConnectionGeometry;
				case "PhysicalOrVirtualBoundary":  
					return @PhysicalOrVirtualBoundary;
				case "InternalOrExternalBoundary":  
					return @InternalOrExternalBoundary;
				case "ParentBoundary":  
					return @ParentBoundary;
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
					 @RelatingSpace = (IfcSpaceBoundarySelect)value;
					 break;
				case 5:
					 @RelatedBuildingElement = (IfcElement)value;
					 break;
				case 6:
					 @ConnectionGeometry = (IfcConnectionGeometry)value;
					 break;
				case 7:
					 if (value != null) @PhysicalOrVirtualBoundary = (IfcPhysicalOrVirtualEnum)value;
					 break;
				case 8:
					 if (value != null) @InternalOrExternalBoundary = (IfcInternalOrExternalEnum)value;
					 break;
				case 9:
					 @ParentBoundary = (IfcRelSpaceBoundary1stLevel)value;
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
				case "RelatingSpace":
					 @RelatingSpace = (IfcSpaceBoundarySelect)value;
					 break;
				case "RelatedBuildingElement":
					 @RelatedBuildingElement = (IfcElement)value;
					 break;
				case "ConnectionGeometry":
					 @ConnectionGeometry = (IfcConnectionGeometry)value;
					 break;
				case "PhysicalOrVirtualBoundary":
					 if (value != null) @PhysicalOrVirtualBoundary = (IfcPhysicalOrVirtualEnum)value;
					 break;
				case "InternalOrExternalBoundary":
					 if (value != null) @InternalOrExternalBoundary = (IfcInternalOrExternalEnum)value;
					 break;
				case "ParentBoundary":
					 @ParentBoundary = (IfcRelSpaceBoundary1stLevel)value;
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