// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		23.09.2015 10:21:49
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.MeasureResource
{
	[ExpressType("IFCVOLUMETRICFLOWRATEMEASURE", 123)]
    // ReSharper disable once PartialTypeWithSinglePart
	public partial struct IfcVolumetricFlowRateMeasure : IfcDerivedMeasureValue, IExpressValueType
	{ 
		private double _value;
        
		public object Value
        {
            get { return _value; }
        }

        public override string ToString()
        {
            return Value != null ? Value.ToString() : typeof(double).Name;
        }

        public IfcVolumetricFlowRateMeasure(double val)
        {
            _value = val;
        }

        public static implicit operator IfcVolumetricFlowRateMeasure(double value)
        {
            return new IfcVolumetricFlowRateMeasure(value);
        }

        public static implicit operator double(IfcVolumetricFlowRateMeasure obj)
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

            return ((IfcVolumetricFlowRateMeasure) obj)._value == _value;
        }

        public static bool operator ==(IfcVolumetricFlowRateMeasure obj1, IfcVolumetricFlowRateMeasure obj2)
        {
            return Equals(obj1, obj2);
        }

        public static bool operator !=(IfcVolumetricFlowRateMeasure obj1, IfcVolumetricFlowRateMeasure obj2)
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
            _value = value.RealVal;
            
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
				return typeof(double);
			}
		}
		#endregion


	}
}
