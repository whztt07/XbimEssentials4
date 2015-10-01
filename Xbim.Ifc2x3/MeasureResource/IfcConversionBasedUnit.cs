// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.MeasureResource
{
	[ExpressType("IFCCONVERSIONBASEDUNIT", 92)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcConversionBasedUnit : IfcNamedUnit, IInstantiableEntity, System.Collections.Generic.IEqualityComparer<@IfcConversionBasedUnit>, System.IEquatable<@IfcConversionBasedUnit>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcConversionBasedUnit(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcLabel _name;
		private IfcMeasureWithUnit _conversionFactor;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel @Name 
		{ 
			get 
			{
				if(Activated) return _name;
				
				Model.Activate(this, true);
				Activated = true;
				return _name;
			} 
			set
			{
				SetValue( v =>  _name = v, _name, value,  "Name");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcMeasureWithUnit @ConversionFactor 
		{ 
			get 
			{
				if(Activated) return _conversionFactor;
				
				Model.Activate(this, true);
				Activated = true;
				return _conversionFactor;
			} 
			set
			{
				SetValue( v =>  _conversionFactor = v, _conversionFactor, value,  "ConversionFactor");
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
					_name = value.StringVal;
					return;
				case 3: 
					_conversionFactor = (IfcMeasureWithUnit)(value.EntityVal);
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

		#region Equality comparers and operators
        public bool Equals(@IfcConversionBasedUnit other)
	    {
	        return this == other;
	    }


        public static bool operator ==(@IfcConversionBasedUnit left, @IfcConversionBasedUnit right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcConversionBasedUnit left, @IfcConversionBasedUnit right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcConversionBasedUnit x, @IfcConversionBasedUnit y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcConversionBasedUnit obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}