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
	public partial struct IfcSoundPowerMeasure : IfcDerivedMeasureValue, IExpressSelectType
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

        public IfcSoundPowerMeasure(double val)
        {
            _theValue = val;
        }

        public static implicit operator IfcSoundPowerMeasure(double value)
        {
            return new IfcSoundPowerMeasure(value);
        }

        public static implicit operator double(IfcSoundPowerMeasure obj)
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

            return ((IfcSoundPowerMeasure) obj)._theValue == _theValue;
        }

        public static bool operator ==(IfcSoundPowerMeasure obj1, IfcSoundPowerMeasure obj2)
        {
            return Equals(obj1, obj2);
        }

        public static bool operator !=(IfcSoundPowerMeasure obj1, IfcSoundPowerMeasure obj2)
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
