// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.PropertyResource
{
	[ExpressType("IFCPROPERTYTABLEVALUE", 557)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcPropertyTableValue : IfcSimpleProperty, IInstantiableEntity, System.Collections.Generic.IEqualityComparer<@IfcPropertyTableValue>, System.IEquatable<@IfcPropertyTableValue>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPropertyTableValue(IModel model) : base(model) 		{ 
			Model = model; 
			_definingValues = new ItemSet<IfcValue>( this );
			_definedValues = new ItemSet<IfcValue>( this );
		}

		#region Explicit attribute fields
		private ItemSet<IfcValue> _definingValues;
		private ItemSet<IfcValue> _definedValues;
		private IfcText? _expression;
		private IfcUnit _definingUnit;
		private IfcUnit _definedUnit;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.Class, 1, -1)]
		public ItemSet<IfcValue> @DefiningValues 
		{ 
			get 
			{
				if(Activated) return _definingValues;
				
				Model.Activate(this, true);
				Activated = true;
				return _definingValues;
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.Class, 1, -1)]
		public ItemSet<IfcValue> @DefinedValues 
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
					if (_definingValues == null) _definingValues = new ItemSet<IfcValue>( this );
					_definingValues.InternalAdd((IfcValue)value.EntityVal);
					return;
				case 3: 
					if (_definedValues == null) _definedValues = new ItemSet<IfcValue>( this );
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
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR1:	WR1 : SIZEOF(DefiningValues) = SIZEOF(DefinedValues);*/
		/*WR2:	WR2 : SIZEOF(QUERY(temp <* SELF.DefiningValues | TYPEOF(temp) <> TYPEOF(SELF.DefiningValues[1])))=0;*/
		/*WR3:	WR3 : SIZEOF(QUERY(temp <* SELF.DefinedValues | TYPEOF(temp) <> TYPEOF(SELF.DefinedValues[1])))=0;*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcPropertyTableValue other)
	    {
	        return this == other;
	    }


        public static bool operator ==(@IfcPropertyTableValue left, @IfcPropertyTableValue right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcPropertyTableValue left, @IfcPropertyTableValue right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcPropertyTableValue x, @IfcPropertyTableValue y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcPropertyTableValue obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}