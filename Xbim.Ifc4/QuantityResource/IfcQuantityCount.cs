// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.QuantityResource
{
	[ExpressType("IFCQUANTITYCOUNT", 872)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcQuantityCount : IfcPhysicalSimpleQuantity, IInstantiableEntity, System.Collections.Generic.IEqualityComparer<@IfcQuantityCount>, System.IEquatable<@IfcQuantityCount>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcQuantityCount(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcCountMeasure _countValue;
		private IfcLabel? _formula;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcCountMeasure @CountValue 
		{ 
			get 
			{
				if(Activated) return _countValue;
				
				Model.Activate(this, true);
				Activated = true;
				return _countValue;
			} 
			set
			{
				SetValue( v =>  _countValue = v, _countValue, value,  "CountValue");
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel? @Formula 
		{ 
			get 
			{
				if(Activated) return _formula;
				
				Model.Activate(this, true);
				Activated = true;
				return _formula;
			} 
			set
			{
				SetValue( v =>  _formula = v, _formula, value,  "Formula");
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
					base.Parse(propIndex, value); 
					return;
				case 3: 
					_countValue = value.NumberVal;
					return;
				case 4: 
					_formula = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR21:	WR21 : CountValue >= 0.;*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcQuantityCount other)
	    {
	        return this == other;
	    }


        public static bool operator ==(@IfcQuantityCount left, @IfcQuantityCount right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcQuantityCount left, @IfcQuantityCount right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcQuantityCount x, @IfcQuantityCount y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcQuantityCount obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}