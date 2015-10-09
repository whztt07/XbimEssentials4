// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.MeasureResource
{
	[ExpressType("IFCMODULUSOFELASTICITYMEASURE", 63)]
    // ReSharper disable once PartialTypeWithSinglePart
	public partial struct IfcModulusOfElasticityMeasure : IfcDerivedMeasureValue, IExpressValueType, System.IEquatable<double>
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

        public IfcModulusOfElasticityMeasure(double val)
        {
            _value = val;
        }

		public IfcModulusOfElasticityMeasure(string val)
        {
			_value = System.Convert.ToDouble(val, System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));
        }

        public static implicit operator IfcModulusOfElasticityMeasure(double value)
        {
            return new IfcModulusOfElasticityMeasure(value);
        }

        public static implicit operator double(IfcModulusOfElasticityMeasure obj)
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

            return ((IfcModulusOfElasticityMeasure) obj)._value == _value;
        }

		public bool Equals(double other)
	    {
	        return this == other;
	    }

        public static bool operator ==(IfcModulusOfElasticityMeasure obj1, IfcModulusOfElasticityMeasure obj2)
        {
            return Equals(obj1, obj2);
        }

        public static bool operator !=(IfcModulusOfElasticityMeasure obj1, IfcModulusOfElasticityMeasure obj2)
        {
            return !Equals(obj1, obj2);
        }

        public override int GetHashCode()
        {
            return Value != null ? _value.GetHashCode() : base.GetHashCode();
        }

		#region IPersist implementation
		void IPersist.Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
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

		#region IExpressValueType implementation
        System.Type IExpressValueType.UnderlyingSystemType { 
			get 
			{
				return typeof(double);
			}
		}
		#endregion


	}
}
