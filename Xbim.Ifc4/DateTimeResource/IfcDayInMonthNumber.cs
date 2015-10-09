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

namespace Xbim.Ifc4.DateTimeResource
{
	[ExpressType("IFCDAYINMONTHNUMBER", 16)]
    // ReSharper disable once PartialTypeWithSinglePart
	public partial struct IfcDayInMonthNumber : IExpressValueType, System.IEquatable<long>
	{ 
		private long _value;
        
		public object Value
        {
            get { return _value; }
        }

        public override string ToString()
        {
            return Value != null ? Value.ToString() : typeof(long).Name;
        }

        public IfcDayInMonthNumber(long val)
        {
            _value = val;
        }

		public IfcDayInMonthNumber(string val)
        {
			_value = System.Convert.ToInt64(val);
        }

        public static implicit operator IfcDayInMonthNumber(long value)
        {
            return new IfcDayInMonthNumber(value);
        }

        public static implicit operator long(IfcDayInMonthNumber obj)
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

            return ((IfcDayInMonthNumber) obj)._value == _value;
        }

		public bool Equals(long other)
	    {
	        return this == other;
	    }

        public static bool operator ==(IfcDayInMonthNumber obj1, IfcDayInMonthNumber obj2)
        {
            return Equals(obj1, obj2);
        }

        public static bool operator !=(IfcDayInMonthNumber obj1, IfcDayInMonthNumber obj2)
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
            _value = value.IntegerVal;
            
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
				return typeof(long);
			}
		}
		#endregion


	}
}
