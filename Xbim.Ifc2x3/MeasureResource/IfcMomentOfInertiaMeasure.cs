// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		15.09.2015 07:04:13
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Common;

namespace Xbim.Ifc2x3.MeasureResource
{
	public partial struct IfcMomentOfInertiaMeasure : IfcDerivedMeasureValue, IExpressType
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

        public IfcMomentOfInertiaMeasure(double val)
        {
            _theValue = val;
        }

        public static implicit operator IfcMomentOfInertiaMeasure(double value)
        {
            return new IfcMomentOfInertiaMeasure(value);
        }

        public static implicit operator double(IfcMomentOfInertiaMeasure obj)
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

            return ((IfcMomentOfInertiaMeasure) obj)._theValue == _theValue;
        }

        public static bool operator ==(IfcMomentOfInertiaMeasure obj1, IfcMomentOfInertiaMeasure obj2)
        {
            return Equals(obj1, obj2);
        }

        public static bool operator !=(IfcMomentOfInertiaMeasure obj1, IfcMomentOfInertiaMeasure obj2)
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
