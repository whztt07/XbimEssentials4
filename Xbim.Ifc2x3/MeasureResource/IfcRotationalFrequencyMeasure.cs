// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		09/09/2015 04:20:33
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Common;

namespace Xbim.Ifc2x3.MeasureResource
{
	public partial struct IfcRotationalFrequencyMeasure : IfcDerivedMeasureValue, IExpressSelectType
	{ 
		private readonly double _theValue;

        public object Value
        {
            get { return _theValue; }
        }

        public override string ToString()
        {
            return Value != null ? Value.ToString() : typeof(double).Name;
        }

        public IfcRotationalFrequencyMeasure(double val)
        {
            _theValue = val;
        }

        public static implicit operator IfcRotationalFrequencyMeasure(double value)
        {
            return new IfcRotationalFrequencyMeasure(value);
        }

        public static implicit operator double(IfcRotationalFrequencyMeasure obj)
        {
            return obj._theValue;
        }


        public override bool Equals(object obj)
        {
			if (obj == null && Value == null)
                return true;

            if (obj == null)
                return false;

            if (GetType() != obj.GetType())
                return false;

            return ((IfcRotationalFrequencyMeasure) obj)._theValue == _theValue;
        }

        public static bool operator ==(IfcRotationalFrequencyMeasure obj1, IfcRotationalFrequencyMeasure obj2)
        {
            return Equals(obj1, obj2);
        }

        public static bool operator !=(IfcRotationalFrequencyMeasure obj1, IfcRotationalFrequencyMeasure obj2)
        {
            return !Equals(obj1, obj2);
        }

        public override int GetHashCode()
        {
            return Value != null ? _theValue.GetHashCode() : base.GetHashCode();
        }

		#region IPersist implementation
		
		void IPersist.Set(int propIndex, IPropertyValue value)
		{
            throw new System.NotImplementedException();
		}

		#endregion
	}
}
