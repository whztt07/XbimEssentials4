// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 09:16:41
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Common;

namespace Xbim.Ifc4.UtilityResource
{
	public partial struct IfcGloballyUniqueId : IExpressSelectType
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

        public IfcGloballyUniqueId(string val)
        {
            _theValue = val;
        }

        public static implicit operator IfcGloballyUniqueId(string value)
        {
            return new IfcGloballyUniqueId(value);
        }

        public static implicit operator string(IfcGloballyUniqueId obj)
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

            return ((IfcGloballyUniqueId) obj)._theValue == _theValue;
        }

        public static bool operator ==(IfcGloballyUniqueId obj1, IfcGloballyUniqueId obj2)
        {
            return Equals(obj1, obj2);
        }

        public static bool operator !=(IfcGloballyUniqueId obj1, IfcGloballyUniqueId obj2)
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
