// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		21.09.2015 05:11:19
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Kernel;
using Xbim.Ifc4.UtilityResource;
using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.GeometryResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.ArchitectureDomain
{
	[IndexedClass]
	[ExpressType("IFCDOORSTYLE", 585)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcDoorStyle : IfcTypeProduct, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcDoorStyle(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcDoorStyleOperationEnum _operationType;
		private IfcDoorStyleConstructionEnum _constructionType;
		private bool _parameterTakesPrecedence;
		private bool _sizeable;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(9, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcDoorStyleOperationEnum @OperationType 
		{ 
			get 
			{
				if(Activated) return _operationType;
				
				Model.Activate(this, true);
				Activated = true;
				return _operationType;
			} 
			set
			{
				SetValue( v =>  _operationType = v, _operationType, value,  "OperationType");
			} 
		}
	
		[EntityAttribute(10, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcDoorStyleConstructionEnum @ConstructionType 
		{ 
			get 
			{
				if(Activated) return _constructionType;
				
				Model.Activate(this, true);
				Activated = true;
				return _constructionType;
			} 
			set
			{
				SetValue( v =>  _constructionType = v, _constructionType, value,  "ConstructionType");
			} 
		}
	
		[EntityAttribute(11, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public bool @ParameterTakesPrecedence 
		{ 
			get 
			{
				if(Activated) return _parameterTakesPrecedence;
				
				Model.Activate(this, true);
				Activated = true;
				return _parameterTakesPrecedence;
			} 
			set
			{
				SetValue( v =>  _parameterTakesPrecedence = v, _parameterTakesPrecedence, value,  "ParameterTakesPrecedence");
			} 
		}
	
		[EntityAttribute(12, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public bool @Sizeable 
		{ 
			get 
			{
				if(Activated) return _sizeable;
				
				Model.Activate(this, true);
				Activated = true;
				return _sizeable;
			} 
			set
			{
				SetValue( v =>  _sizeable = v, _sizeable, value,  "Sizeable");
			} 
		}
	
		#endregion

		#region Inverse attributes

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
                    _operationType = (IfcDoorStyleOperationEnum) System.Enum.Parse(typeof (IfcDoorStyleOperationEnum), value.EnumVal, true);
					return;
				case 9: 
                    _constructionType = (IfcDoorStyleConstructionEnum) System.Enum.Parse(typeof (IfcDoorStyleConstructionEnum), value.EnumVal, true);
					return;
				case 10: 
					_parameterTakesPrecedence = value.BooleanVal;
					return;
				case 11: 
					_sizeable = value.BooleanVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
			return "";
		}
		#endregion
	}
}