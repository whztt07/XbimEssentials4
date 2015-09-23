// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		23.09.2015 10:21:42
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.ConstraintResource;

namespace Xbim.Ifc2x3.MeasureResource
{
	[ExpressType("IFCTEXT", 537)]
    // ReSharper disable once PartialTypeWithSinglePart
	public partial struct IfcText : IfcMetricValueSelect, IfcSimpleValue, IExpressValueType
	{ 
		private string _value;
        
		public object Value
        {
            get { return _value; }
        }

        public override string ToString()
        {
            return Value != null ? Value.ToString() : typeof(string).Name;
        }

        public IfcText(string val)
        {
            _value = val;
        }

        public static implicit operator IfcText(string value)
        {
            return new IfcText(value);
        }

        public static implicit operator string(IfcText obj)
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

            return ((IfcText) obj)._value == _value;
        }

        public static bool operator ==(IfcText obj1, IfcText obj2)
        {
            return Equals(obj1, obj2);
        }

        public static bool operator !=(IfcText obj1, IfcText obj2)
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
            _value = value.StringVal;
            
		}

		string IPersist.WhereRule()
		{
            throw new System.NotImplementedException();
		}
		#endregion

		#region IExpressType implementation
        System.Type IExpressValueType.UnderlyingSystemType { 
			get 
			{
				return typeof(string);
			}
		}
		#endregion


	}
}
