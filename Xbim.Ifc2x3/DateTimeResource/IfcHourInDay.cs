// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 09:16:37
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Common;

namespace Xbim.Ifc2x3.DateTimeResource
{
	public partial struct IfcHourInDay : IExpressSelectType
	{ 
		private readonly int _theValue;

        public object Value
        {
            get { return _theValue; }
        }

        public override string ToString()
        {
            return Value != null ? Value.ToString() : typeof(int).Name;
        }

        public IfcHourInDay(int val)
        {
            _theValue = val;
        }

        public static implicit operator IfcHourInDay(int value)
        {
            return new IfcHourInDay(value);
        }

        public static implicit operator int(IfcHourInDay obj)
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

            return ((IfcHourInDay) obj)._theValue == _theValue;
        }

        public static bool operator ==(IfcHourInDay obj1, IfcHourInDay obj2)
        {
            return Equals(obj1, obj2);
        }

        public static bool operator !=(IfcHourInDay obj1, IfcHourInDay obj2)
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
