// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 09:16:37
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Common;

namespace Xbim.Ifc2x3.MeasureResource
{
	public partial struct IfcLinearStiffnessMeasure : IfcDerivedMeasureValue, IExpressSelectType
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

        public IfcLinearStiffnessMeasure(float val)
        {
            _theValue = val;
        }

        public static implicit operator IfcLinearStiffnessMeasure(float value)
        {
            return new IfcLinearStiffnessMeasure(value);
        }

        public static implicit operator float(IfcLinearStiffnessMeasure obj)
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

            return ((IfcLinearStiffnessMeasure) obj)._theValue == _theValue;
        }

        public static bool operator ==(IfcLinearStiffnessMeasure obj1, IfcLinearStiffnessMeasure obj2)
        {
            return Equals(obj1, obj2);
        }

        public static bool operator !=(IfcLinearStiffnessMeasure obj1, IfcLinearStiffnessMeasure obj2)
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
