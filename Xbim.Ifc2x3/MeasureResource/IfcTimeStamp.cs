// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 02:29:11
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Common;

namespace Xbim.Ifc2x3.MeasureResource
{
	public partial struct IfcTimeStamp : IfcDerivedMeasureValue, IExpressSelectType
	{ 
		private readonly int _theValue;

        public object Value
        {
            get { return _theValue; }
        }

        public override string ToString()
        {
            return Value != null ? Value.ToString() : typeof(int).Name;
        }

        public IfcTimeStamp(int val)
        {
            _theValue = val;
        }

        public static implicit operator IfcTimeStamp(int value)
        {
            return new IfcTimeStamp(value);
        }

        public static implicit operator int(IfcTimeStamp obj)
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

            return ((IfcTimeStamp) obj)._theValue == _theValue;
        }

        public static bool operator ==(IfcTimeStamp obj1, IfcTimeStamp obj2)
        {
            return Equals(obj1, obj2);
        }

        public static bool operator !=(IfcTimeStamp obj1, IfcTimeStamp obj2)
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
