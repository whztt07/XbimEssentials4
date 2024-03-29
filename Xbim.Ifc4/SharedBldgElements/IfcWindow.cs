// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		24.09.2015 10:03:44
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.ProductExtension;
using Xbim.Ifc4.UtilityResource;
using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.GeometricConstraintResource;
using Xbim.Ifc4.RepresentationResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.SharedBldgElements
{
	[IndexedClass]
	[ExpressType("IFCWINDOW", 1144)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcWindow : IfcBuildingElement, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcWindow(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcPositiveLengthMeasure? _overallHeight;
		private IfcPositiveLengthMeasure? _overallWidth;
		private IfcWindowTypeEnum? _predefinedType;
		private IfcWindowTypePartitioningEnum? _partitioningType;
		private IfcLabel? _userDefinedPartitioningType;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure? @OverallHeight 
		{ 
			get 
			{
				if(Activated) return _overallHeight;
				
				Model.Activate(this, true);
				Activated = true;
				return _overallHeight;
			} 
			set
			{
				SetValue( v =>  _overallHeight = v, _overallHeight, value,  "OverallHeight");
			} 
		}
	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure? @OverallWidth 
		{ 
			get 
			{
				if(Activated) return _overallWidth;
				
				Model.Activate(this, true);
				Activated = true;
				return _overallWidth;
			} 
			set
			{
				SetValue( v =>  _overallWidth = v, _overallWidth, value,  "OverallWidth");
			} 
		}
	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcWindowTypeEnum? @PredefinedType 
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
	
		[EntityAttribute(12, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcWindowTypePartitioningEnum? @PartitioningType 
		{ 
			get 
			{
				if(Activated) return _partitioningType;
				
				Model.Activate(this, true);
				Activated = true;
				return _partitioningType;
			} 
			set
			{
				SetValue( v =>  _partitioningType = v, _partitioningType, value,  "PartitioningType");
			} 
		}
	
		[EntityAttribute(13, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel? @UserDefinedPartitioningType 
		{ 
			get 
			{
				if(Activated) return _userDefinedPartitioningType;
				
				Model.Activate(this, true);
				Activated = true;
				return _userDefinedPartitioningType;
			} 
			set
			{
				SetValue( v =>  _userDefinedPartitioningType = v, _userDefinedPartitioningType, value,  "UserDefinedPartitioningType");
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
				case 5: 
				case 6: 
				case 7: 
					base.Parse(propIndex, value); 
					return;
				case 8: 
					_overallHeight = value.RealVal;
					return;
				case 9: 
					_overallWidth = value.RealVal;
					return;
				case 10: 
                    _predefinedType = (IfcWindowTypeEnum) System.Enum.Parse(typeof (IfcWindowTypeEnum), value.EnumVal, true);
					return;
				case 11: 
                    _partitioningType = (IfcWindowTypePartitioningEnum) System.Enum.Parse(typeof (IfcWindowTypePartitioningEnum), value.EnumVal, true);
					return;
				case 12: 
					_userDefinedPartitioningType = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*CorrectStyleAssigned:                             OR ('IFC4.IFCWINDOWTYPE' IN TYPEOF(SELF\IfcObject.IsTypedBy[1].RelatingType));*/
		}
		#endregion
	}
}