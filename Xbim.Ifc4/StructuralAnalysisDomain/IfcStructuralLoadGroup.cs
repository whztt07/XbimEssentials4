// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		22.09.2015 02:32:08
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Kernel;
using Xbim.Ifc4.UtilityResource;
using Xbim.Ifc4.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.StructuralAnalysisDomain
{
	[IndexedClass]
	[ExpressType("IFCSTRUCTURALLOADGROUP", 1025)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcStructuralLoadGroup : IfcGroup, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcStructuralLoadGroup(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcLoadGroupTypeEnum _predefinedType;
		private IfcActionTypeEnum _actionType;
		private IfcActionSourceTypeEnum _actionSource;
		private IfcRatioMeasure? _coefficient;
		private IfcLabel? _purpose;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcLoadGroupTypeEnum @PredefinedType 
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
	
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcActionTypeEnum @ActionType 
		{ 
			get 
			{
				if(Activated) return _actionType;
				
				Model.Activate(this, true);
				Activated = true;
				return _actionType;
			} 
			set
			{
				SetValue( v =>  _actionType = v, _actionType, value,  "ActionType");
			} 
		}
	
		[EntityAttribute(8, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcActionSourceTypeEnum @ActionSource 
		{ 
			get 
			{
				if(Activated) return _actionSource;
				
				Model.Activate(this, true);
				Activated = true;
				return _actionSource;
			} 
			set
			{
				SetValue( v =>  _actionSource = v, _actionSource, value,  "ActionSource");
			} 
		}
	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcRatioMeasure? @Coefficient 
		{ 
			get 
			{
				if(Activated) return _coefficient;
				
				Model.Activate(this, true);
				Activated = true;
				return _coefficient;
			} 
			set
			{
				SetValue( v =>  _coefficient = v, _coefficient, value,  "Coefficient");
			} 
		}
	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel? @Purpose 
		{ 
			get 
			{
				if(Activated) return _purpose;
				
				Model.Activate(this, true);
				Activated = true;
				return _purpose;
			} 
			set
			{
				SetValue( v =>  _purpose = v, _purpose, value,  "Purpose");
			} 
		}
	
		#endregion

		#region Inverse attributes
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcStructuralResultGroup> @SourceOfResultGroup 
		{ 
			get 
			{
				return Model.Instances.Where<IfcStructuralResultGroup>(e => e.ResultForLoadGroup == this);
			} 
		}
	
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcStructuralAnalysisModel> @LoadGroupFor 
		{ 
			get 
			{
				return Model.Instances.Where<IfcStructuralAnalysisModel>(e => e.LoadedBy != null &&  e.LoadedBy.Contains(this));
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
                    _predefinedType = (IfcLoadGroupTypeEnum) System.Enum.Parse(typeof (IfcLoadGroupTypeEnum), value.EnumVal, true);
					return;
				case 6: 
                    _actionType = (IfcActionTypeEnum) System.Enum.Parse(typeof (IfcActionTypeEnum), value.EnumVal, true);
					return;
				case 7: 
                    _actionSource = (IfcActionSourceTypeEnum) System.Enum.Parse(typeof (IfcActionSourceTypeEnum), value.EnumVal, true);
					return;
				case 8: 
					_coefficient = value.RealVal;
					return;
				case 9: 
					_purpose = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*HasObjectType:                      ) OR EXISTS(SELF\IfcObject.ObjectType);*/
		}
		#endregion
	}
}