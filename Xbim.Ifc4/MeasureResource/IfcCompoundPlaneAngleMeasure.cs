// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		23.09.2015 10:21:48
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.MeasureResource
{
	[ExpressType("IFCCOMPOUNDPLANEANGLEMEASURE", 10)]
    // ReSharper disable once PartialTypeWithSinglePart
	public partial struct IfcCompoundPlaneAngleMeasure : IfcDerivedMeasureValue, IExpressValueComplexType
	{ 
		private List<long> _value;
        
		public object Value
        {
            get { return _value; }
        }

        public override string ToString()
        {
            return Value != null ? Value.ToString() : typeof(List<long>).Name;
        }

        public IfcCompoundPlaneAngleMeasure(List<long> val)
        {
            _value = val;
        }

        public static implicit operator IfcCompoundPlaneAngleMeasure(List<long> value)
        {
            return new IfcCompoundPlaneAngleMeasure(value);
        }

        public static implicit operator List<long>(IfcCompoundPlaneAngleMeasure obj)
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

            return System.Linq.Enumerable.SequenceEqual(((IfcCompoundPlaneAngleMeasure) obj)._value, _value);
        }

        public static bool operator ==(IfcCompoundPlaneAngleMeasure obj1, IfcCompoundPlaneAngleMeasure obj2)
        {
            return Equals(obj1, obj2);
        }

        public static bool operator !=(IfcCompoundPlaneAngleMeasure obj1, IfcCompoundPlaneAngleMeasure obj2)
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
			if (_value == null)
				_value = new List<long>();
            _value.Add(value.IntegerVal);
            
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
				return typeof(List<long>);
			}
		}
		#endregion

		#region IExpressComplexType implementation
		IEnumerable<object> IExpressValueComplexType.Properties
        {
            get
            {
				if(_value == null) yield break;
	            foreach (var value in _value)
	                yield return value;
            }
        }

		void IExpressValueComplexType.Add(object o)
	    {
			if (_value == null)
				_value = new List<long>();
			 _value.Add((long) o);
	    }
		#endregion

	}
}
