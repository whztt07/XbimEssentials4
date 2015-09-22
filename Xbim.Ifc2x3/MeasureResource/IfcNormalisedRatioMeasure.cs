// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		22.09.2015 02:31:56
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.PresentationAppearanceResource;

namespace Xbim.Ifc2x3.MeasureResource
{
	[ExpressType("IFCNORMALISEDRATIOMEASURE", 635)]
    // ReSharper disable once PartialTypeWithSinglePart
	public partial struct IfcNormalisedRatioMeasure : IfcColourOrFactor, IfcMeasureValue, IfcSizeSelect, IExpressType
	{ 
		private double _value;
        
		public object Value
        {
            get { return _value; }
        }

        public override string ToString()
        {
            return Value != null ? Value.ToString() : typeof(double).Name;
        }

        public IfcNormalisedRatioMeasure(double val)
        {
            _value = val;
        }

        public static implicit operator IfcNormalisedRatioMeasure(double value)
        {
            return new IfcNormalisedRatioMeasure(value);
        }

        public static implicit operator double(IfcNormalisedRatioMeasure obj)
        {
            return obj._value;
        }


        public override bool Equals(object obj)
        {
			if (obj == null && Value == null)
                return true;

            if (obj == null)
                return false;

            if (GetType() != obj.GetType())
                return false;

            return ((IfcNormalisedRatioMeasure) obj)._value == _value;
        }

        public static bool operator ==(IfcNormalisedRatioMeasure obj1, IfcNormalisedRatioMeasure obj2)
        {
            return Equals(obj1, obj2);
        }

        public static bool operator !=(IfcNormalisedRatioMeasure obj1, IfcNormalisedRatioMeasure obj2)
        {
            return !Equals(obj1, obj2);
        }

        public override int GetHashCode()
        {
            return Value != null ? _value.GetHashCode() : base.GetHashCode();
        }

		#region IPersist implementation
		void IPersist.Parse(int propIndex, IPropertyValue value)
		{
			if (propIndex != 0)
				throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
            _value = value.RealVal;
            
		}

		string IPersist.WhereRule()
		{
            throw new System.NotImplementedException();
		}
		#endregion

		#region IExpressType implementation
        System.Type IExpressType.UnderlyingSystemType { 
			get 
			{
				return typeof(double);
			}
		}
		#endregion


	}
}
