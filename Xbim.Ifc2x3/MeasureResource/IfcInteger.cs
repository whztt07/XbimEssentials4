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

namespace Xbim.Ifc2x3.MeasureResource
{
	[ExpressType("IFCINTEGER", 362)]
    // ReSharper disable once PartialTypeWithSinglePart
	public partial struct IfcInteger : IfcSimpleValue, IExpressValueType
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

        public IfcInteger(long val)
        {
            _value = val;
        }

		public IfcInteger(string val)
        {
			_value = System.Convert.ToInt64(val);
        }

        public static implicit operator IfcInteger(long value)
        {
            return new IfcInteger(value);
        }

        public static implicit operator long(IfcInteger obj)
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

            return ((IfcInteger) obj)._value == _value;
        }

        public static bool operator ==(IfcInteger obj1, IfcInteger obj2)
        {
            return Equals(obj1, obj2);
        }

        public static bool operator !=(IfcInteger obj1, IfcInteger obj2)
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
