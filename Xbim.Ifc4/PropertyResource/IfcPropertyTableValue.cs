// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		24.09.2015 10:03:42
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.PropertyResource
{
	[IndexedClass]
	[ExpressType("IFCPROPERTYTABLEVALUE", 861)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcPropertyTableValue : IfcSimpleProperty, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPropertyTableValue(IModel model) : base(model) 		{ 
			Model = model; 
			_definingValues = new OptionalItemSet<IfcValue>( this );
			_definedValues = new OptionalItemSet<IfcValue>( this );
		}

		#region Explicit attribute fields
		private OptionalItemSet<IfcValue> _definingValues;
		private OptionalItemSet<IfcValue> _definedValues;
		private IfcText? _expression;
		private IfcUnit _definingUnit;
		private IfcUnit _definedUnit;
		private IfcCurveInterpolationEnum? _curveInterpolation;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.Class, 1, -1)]
		public OptionalItemSet<IfcValue> @DefiningValues 
		{ 
			get 
			{
				if(Activated) return _definingValues;
				
				Model.Activate(this, true);
				Activated = true;
				return _definingValues;
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.Class, 1, -1)]
		public OptionalItemSet<IfcValue> @DefinedValues 
		{ 
			get 
			{
				if(Activated) return _definedValues;
				
				Model.Activate(this, true);
				Activated = true;
				return _definedValues;
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcText? @Expression 
		{ 
			get 
			{
				if(Activated) return _expression;
				
				Model.Activate(this, true);
				Activated = true;
				return _expression;
			} 
			set
			{
				SetValue( v =>  _expression = v, _expression, value,  "Expression");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcUnit @DefiningUnit 
		{ 
			get 
			{
				if(Activated) return _definingUnit;
				
				Model.Activate(this, true);
				Activated = true;
				return _definingUnit;
			} 
			set
			{
				SetValue( v =>  _definingUnit = v, _definingUnit, value,  "DefiningUnit");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcUnit @DefinedUnit 
		{ 
			get 
			{
				if(Activated) return _definedUnit;
				
				Model.Activate(this, true);
				Activated = true;
				return _definedUnit;
			} 
			set
			{
				SetValue( v =>  _definedUnit = v, _definedUnit, value,  "DefinedUnit");
			} 
		}
	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcCurveInterpolationEnum? @CurveInterpolation 
		{ 
			get 
			{
				if(Activated) return _curveInterpolation;
				
				Model.Activate(this, true);
				Activated = true;
				return _curveInterpolation;
			} 
			set
			{
				SetValue( v =>  _curveInterpolation = v, _curveInterpolation, value,  "CurveInterpolation");
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
					base.Parse(propIndex, value); 
					return;
				case 2: 
					if (_definingValues == null) _definingValues = new OptionalItemSet<IfcValue>( this );
					_definingValues.InternalAdd((IfcValue)value.EntityVal);
					return;
				case 3: 
					if (_definedValues == null) _definedValues = new OptionalItemSet<IfcValue>( this );
					_definedValues.InternalAdd((IfcValue)value.EntityVal);
					return;
				case 4: 
					_expression = value.StringVal;
					return;
				case 5: 
					_definingUnit = (IfcUnit)(value.EntityVal);
					return;
				case 6: 
					_definedUnit = (IfcUnit)(value.EntityVal);
					return;
				case 7: 
                    _curveInterpolation = (IfcCurveInterpolationEnum) System.Enum.Parse(typeof (IfcCurveInterpolationEnum), value.EnumVal, true);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR21:             OR (SIZEOF(DefiningValues) = SIZEOF(DefinedValues));*/
		/*WR22:             )) = 0);*/
		/*WR23:             )) = 0);*/
		}
		#endregion
	}
}