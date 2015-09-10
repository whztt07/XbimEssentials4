// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		09/09/2015 04:20:39
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Common;

namespace Xbim.Ifc4.MeasureResource
{
	public partial struct IfcTorqueMeasure : IfcDerivedMeasureValue, IExpressSelectType
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

        public IfcTorqueMeasure(double val)
        {
            _theValue = val;
        }

        public static implicit operator IfcTorqueMeasure(double value)
        {
            return new IfcTorqueMeasure(value);
        }

        public static implicit operator double(IfcTorqueMeasure obj)
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

            return ((IfcTorqueMeasure) obj)._theValue == _theValue;
        }

        public static bool operator ==(IfcTorqueMeasure obj1, IfcTorqueMeasure obj2)
        {
            return Equals(obj1, obj2);
        }

        public static bool operator !=(IfcTorqueMeasure obj1, IfcTorqueMeasure obj2)
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
