// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 02:29:19
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Common;

namespace Xbim.Ifc4.Kernel
{
	public partial struct IfcPropertySetDefinitionSet : IfcPropertySetDefinitionSelect, IExpressSelectType
	{ 
		private readonly ItemSet<IfcPropertySetDefinition> _theValue;

        public object Value
        {
            get { return _theValue; }
        }

        public override string ToString()
        {
            return Value != null ? Value.ToString() : typeof(ItemSet<IfcPropertySetDefinition>).Name;
        }

        public IfcPropertySetDefinitionSet(ItemSet<IfcPropertySetDefinition> val)
        {
            _theValue = val;
        }

        public static implicit operator IfcPropertySetDefinitionSet(ItemSet<IfcPropertySetDefinition> value)
        {
            return new IfcPropertySetDefinitionSet(value);
        }

        public static implicit operator ItemSet<IfcPropertySetDefinition>(IfcPropertySetDefinitionSet obj)
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

            return ((IfcPropertySetDefinitionSet) obj)._theValue == _theValue;
        }

        public static bool operator ==(IfcPropertySetDefinitionSet obj1, IfcPropertySetDefinitionSet obj2)
        {
            return Equals(obj1, obj2);
        }

        public static bool operator !=(IfcPropertySetDefinitionSet obj1, IfcPropertySetDefinitionSet obj2)
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
