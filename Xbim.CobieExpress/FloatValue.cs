// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		09/09/2015 04:20:46
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Common;

namespace Xbim.CobieExpress
{
	public partial struct FloatValue : AttributeValue, IExpressSelectType
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

        public FloatValue(double val)
        {
            _theValue = val;
        }

        public static implicit operator FloatValue(double value)
        {
            return new FloatValue(value);
        }

        public static implicit operator double(FloatValue obj)
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

            return ((FloatValue) obj)._theValue == _theValue;
        }

        public static bool operator ==(FloatValue obj1, FloatValue obj2)
        {
            return Equals(obj1, obj2);
        }

        public static bool operator !=(FloatValue obj1, FloatValue obj2)
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
