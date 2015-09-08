// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 09:16:41
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Common;

namespace Xbim.Ifc4.MeasureResource
{
	public partial struct IfcIonConcentrationMeasure : IfcDerivedMeasureValue, IExpressSelectType
	{ 
		private readonly float _theValue;

        public object Value
        {
            get { return _theValue; }
        }

        public override string ToString()
        {
            return Value != null ? Value.ToString() : typeof(float).Name;
        }

        public IfcIonConcentrationMeasure(float val)
        {
            _theValue = val;
        }

        public static implicit operator IfcIonConcentrationMeasure(float value)
        {
            return new IfcIonConcentrationMeasure(value);
        }

        public static implicit operator float(IfcIonConcentrationMeasure obj)
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

            return ((IfcIonConcentrationMeasure) obj)._theValue == _theValue;
        }

        public static bool operator ==(IfcIonConcentrationMeasure obj1, IfcIonConcentrationMeasure obj2)
        {
            return Equals(obj1, obj2);
        }

        public static bool operator !=(IfcIonConcentrationMeasure obj1, IfcIonConcentrationMeasure obj2)
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
