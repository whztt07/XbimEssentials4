// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		15.09.2015 07:03:35
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Common;

namespace Xbim.Ifc4.MeasureResource
{
	public partial struct IfcIsothermalMoistureCapacityMeasure : IfcDerivedMeasureValue, IExpressType
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

        public IfcIsothermalMoistureCapacityMeasure(double val)
        {
            _theValue = val;
        }

        public static implicit operator IfcIsothermalMoistureCapacityMeasure(double value)
        {
            return new IfcIsothermalMoistureCapacityMeasure(value);
        }

        public static implicit operator double(IfcIsothermalMoistureCapacityMeasure obj)
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

            return ((IfcIsothermalMoistureCapacityMeasure) obj)._theValue == _theValue;
        }

        public static bool operator ==(IfcIsothermalMoistureCapacityMeasure obj1, IfcIsothermalMoistureCapacityMeasure obj2)
        {
            return Equals(obj1, obj2);
        }

        public static bool operator !=(IfcIsothermalMoistureCapacityMeasure obj1, IfcIsothermalMoistureCapacityMeasure obj2)
        {
            return !Equals(obj1, obj2);
        }

        public override int GetHashCode()
        {
            return Value != null ? _theValue.GetHashCode() : base.GetHashCode();
        }

		#region IPersist implementation
		void IPersist.Parse(int propIndex, IPropertyValue value)
		{
            throw new System.NotImplementedException();
		}

		string IPersist.WhereRule()
		{
            throw new System.NotImplementedException();
		}
		#endregion

		#region IExpressType implementation
		string IExpressType.ToPart21 { 
			get 
			{
				throw new System.NotImplementedException();
			}
		}
        System.Type IExpressType.UnderlyingSystemType { 
			get 
			{
				throw new System.NotImplementedException();
			}
		}
		#endregion

	}
}
