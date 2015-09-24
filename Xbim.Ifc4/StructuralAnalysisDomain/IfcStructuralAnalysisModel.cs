// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		24.09.2015 10:03:43
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.ProductExtension;
using Xbim.Ifc4.UtilityResource;
using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.GeometryResource;
using Xbim.Ifc4.GeometricConstraintResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.StructuralAnalysisDomain
{
	[IndexedClass]
	[ExpressType("IFCSTRUCTURALANALYSISMODEL", 1012)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcStructuralAnalysisModel : IfcSystem, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcStructuralAnalysisModel(IModel model) : base(model) 		{ 
			Model = model; 
			_loadedBy = new OptionalItemSet<IfcStructuralLoadGroup>( this );
			_hasResults = new OptionalItemSet<IfcStructuralResultGroup>( this );
		}

		#region Explicit attribute fields
		private IfcAnalysisModelTypeEnum _predefinedType;
		private IfcAxis2Placement3D _orientationOf2DPlane;
		private OptionalItemSet<IfcStructuralLoadGroup> _loadedBy;
		private OptionalItemSet<IfcStructuralResultGroup> _hasResults;
		private IfcObjectPlacement _sharedPlacement;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
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
	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
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
	
		[IndexedProperty]
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1)]
		public OptionalItemSet<IfcStructuralLoadGroup> @LoadedBy 
		{ 
			get 
			{
				if(Activated) return _loadedBy;
				
				Model.Activate(this, true);
				Activated = true;
				return _loadedBy;
			} 
		}
	
		[IndexedProperty]
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1)]
		public OptionalItemSet<IfcStructuralResultGroup> @HasResults 
		{ 
			get 
			{
				if(Activated) return _hasResults;
				
				Model.Activate(this, true);
				Activated = true;
				return _hasResults;
			} 
		}
	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcObjectPlacement @SharedPlacement 
		{ 
			get 
			{
				if(Activated) return _sharedPlacement;
				
				Model.Activate(this, true);
				Activated = true;
				return _sharedPlacement;
			} 
			set
			{
				SetValue( v =>  _sharedPlacement = v, _sharedPlacement, value,  "SharedPlacement");
			} 
		}
	
		#endregion



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
				case 3: 
				case 4: 
					base.Parse(propIndex, value); 
					return;
				case 5: 
                    _predefinedType = (IfcAnalysisModelTypeEnum) System.Enum.Parse(typeof (IfcAnalysisModelTypeEnum), value.EnumVal, true);
					return;
				case 6: 
					_orientationOf2DPlane = (IfcAxis2Placement3D)(value.EntityVal);
					return;
				case 7: 
					if (_loadedBy == null) _loadedBy = new OptionalItemSet<IfcStructuralLoadGroup>( this );
					_loadedBy.InternalAdd((IfcStructuralLoadGroup)value.EntityVal);
					return;
				case 8: 
					if (_hasResults == null) _hasResults = new OptionalItemSet<IfcStructuralResultGroup>( this );
					_hasResults.InternalAdd((IfcStructuralResultGroup)value.EntityVal);
					return;
				case 9: 
					_sharedPlacement = (IfcObjectPlacement)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*HasObjectType:	HasObjectType : (PredefinedType <> IfcAnalysisModelTypeEnum.USERDEFINED) OR EXISTS(SELF\IfcObject.ObjectType);*/
		}
		#endregion
	}
}