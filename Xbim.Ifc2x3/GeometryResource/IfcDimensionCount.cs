// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		09/09/2015 04:20:33
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Common;

namespace Xbim.Ifc2x3.GeometryResource
{
	public partial struct IfcDimensionCount : IExpressSelectType
	{ 
		private readonly long _theValue;

        public object Value
        {
            get { return _theValue; }
        }

        public override string ToString()
        {
            return Value != null ? Value.ToString() : typeof(long).Name;
        }

        public IfcDimensionCount(long val)
        {
            _theValue = val;
        }

        public static implicit operator IfcDimensionCount(long value)
        {
            return new IfcDimensionCount(value);
        }

        public static implicit operator long(IfcDimensionCount obj)
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

            return ((IfcDimensionCount) obj)._theValue == _theValue;
        }

        public static bool operator ==(IfcDimensionCount obj1, IfcDimensionCount obj2)
        {
            return Equals(obj1, obj2);
        }

        public static bool operator !=(IfcDimensionCount obj1, IfcDimensionCount obj2)
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
