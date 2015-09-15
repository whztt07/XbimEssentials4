// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		15.09.2015 07:04:19
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.ProductExtension;
using Xbim.Ifc2x3.UtilityResource;
using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.GeometryResource;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc2x3.StructuralAnalysisDomain
{
	[EntityName("IFCSTRUCTURALANALYSISMODEL", 230)]
	public  partial class @IfcStructuralAnalysisModel : IfcSystem, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcStructuralAnalysisModel(IModel model) : base(model) 		{ 
			Model = model; 
			_loadedBy = new ItemSet<IfcStructuralLoadGroup>( model );
			_hasResults = new ItemSet<IfcStructuralResultGroup>( model );
		}

		#region Explicit attribute fields
		private IfcAnalysisModelTypeEnum _predefinedType;
		private IfcAxis2Placement3D _orientationOf2DPlane;
		private ItemSet<IfcStructuralLoadGroup> _loadedBy;
		private ItemSet<IfcStructuralResultGroup> _hasResults;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(5, EntityAttributeState.Mandatory)]
		public IfcAnalysisModelTypeEnum @PredefinedType 
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
	
		[EntityAttribute(6, EntityAttributeState.Optional)]
		public IfcAxis2Placement3D @OrientationOf2DPlane 
		{ 
			get 
			{
				if(Activated) return _orientationOf2DPlane;
				
				Model.Activate(this, true);
				Activated = true;
				return _orientationOf2DPlane;
			} 
			set
			{
				SetValue( v =>  _orientationOf2DPlane = v, _orientationOf2DPlane, value,  "OrientationOf2DPlane");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Optional)]
		public ItemSet<IfcStructuralLoadGroup> @LoadedBy 
		{ 
			get 
			{
				if(Activated) return _loadedBy;
				
				Model.Activate(this, true);
				Activated = true;
				return _loadedBy;
			} 
			set
			{
				SetValue( v =>  _loadedBy = v, _loadedBy, value,  "LoadedBy");
			} 
		}
	
		[EntityAttribute(8, EntityAttributeState.Optional)]
		public ItemSet<IfcStructuralResultGroup> @HasResults 
		{ 
			get 
			{
				if(Activated) return _hasResults;
				
				Model.Activate(this, true);
				Activated = true;
				return _hasResults;
			} 
			set
			{
				SetValue( v =>  _hasResults = v, _hasResults, value,  "HasResults");
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
			"PredefinedType",
			"OrientationOf2DPlane",
			"LoadedBy",
			"HasResults",
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
					return @PredefinedType;
				case 6: 
					return @OrientationOf2DPlane;
				case 7: 
					return @LoadedBy;
				case 8: 
					return @HasResults;
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
				case "PredefinedType":  
					return @PredefinedType;
				case "OrientationOf2DPlane":  
					return @OrientationOf2DPlane;
				case "LoadedBy":  
					return @LoadedBy;
				case "HasResults":  
					return @HasResults;
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
					 if (value != null) @PredefinedType = (IfcAnalysisModelTypeEnum)value;
					 break;
				case 6:
					 @OrientationOf2DPlane = (IfcAxis2Placement3D)value;
					 break;
				case 7:
					 @LoadedBy.Add((IfcStructuralLoadGroup)value);
					 break;
				case 8:
					 @HasResults.Add((IfcStructuralResultGroup)value);
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
				case "PredefinedType":
					 if (value != null) @PredefinedType = (IfcAnalysisModelTypeEnum)value;
					 break;
				case "OrientationOf2DPlane":
					 @OrientationOf2DPlane = (IfcAxis2Placement3D)value;
					 break;
				case "LoadedBy":
					 @LoadedBy.Add((IfcStructuralLoadGroup)value);
					 break;
				case "HasResults":
					 @HasResults.Add((IfcStructuralResultGroup)value);
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