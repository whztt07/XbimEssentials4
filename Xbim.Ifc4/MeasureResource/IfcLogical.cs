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
	public partial struct IfcLogical : IfcSimpleValue, IExpressSelectType
	{ 
		private readonly bool? _theValue;

        public object Value
        {
            get { return _theValue; }
        }

        public override string ToString()
        {
            return Value != null ? Value.ToString() : typeof(bool?).Name;
        }

        public IfcLogical(bool? val)
        {
            _theValue = val;
        }

        public static implicit operator IfcLogical(bool? value)
        {
            return new IfcLogical(value);
        }

        public static implicit operator bool?(IfcLogical obj)
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

            return ((IfcLogical) obj)._theValue == _theValue;
        }

        public static bool operator ==(IfcLogical obj1, IfcLogical obj2)
        {
            return Equals(obj1, obj2);
        }

        public static bool operator !=(IfcLogical obj1, IfcLogical obj2)
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
