// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		09/09/2015 04:20:39
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Common;

namespace Xbim.Ifc4.MeasureResource
{
	public partial struct IfcLabel : IfcSimpleValue, IExpressSelectType
	{ 
		private readonly string _theValue;

        public object Value
        {
            get { return _theValue; }
        }

        public override string ToString()
        {
            return Value != null ? Value.ToString() : typeof(string).Name;
        }

        public IfcLabel(string val)
        {
            _theValue = val;
        }

        public static implicit operator IfcLabel(string value)
        {
            return new IfcLabel(value);
        }

        public static implicit operator string(IfcLabel obj)
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

            return ((IfcLabel) obj)._theValue == _theValue;
        }

        public static bool operator ==(IfcLabel obj1, IfcLabel obj2)
        {
            return Equals(obj1, obj2);
        }

        public static bool operator !=(IfcLabel obj1, IfcLabel obj2)
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
