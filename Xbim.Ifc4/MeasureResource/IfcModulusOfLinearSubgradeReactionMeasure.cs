// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 02:29:18
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Common;
using Xbim.Ifc4.StructuralLoadResource;

namespace Xbim.Ifc4.MeasureResource
{
	public partial struct IfcModulusOfLinearSubgradeReactionMeasure : IfcDerivedMeasureValue, IfcModulusOfTranslationalSubgradeReactionSelect, IExpressSelectType
	{ 
		private readonly float _theValue;

        public object Value
        {
            get { return _theValue; }
        }

        public override string ToString()
        {
            return Value != null ? Value.ToString() : typeof(float).Name;
        }

        public IfcModulusOfLinearSubgradeReactionMeasure(float val)
        {
            _theValue = val;
        }

        public static implicit operator IfcModulusOfLinearSubgradeReactionMeasure(float value)
        {
            return new IfcModulusOfLinearSubgradeReactionMeasure(value);
        }

        public static implicit operator float(IfcModulusOfLinearSubgradeReactionMeasure obj)
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

            return ((IfcModulusOfLinearSubgradeReactionMeasure) obj)._theValue == _theValue;
        }

        public static bool operator ==(IfcModulusOfLinearSubgradeReactionMeasure obj1, IfcModulusOfLinearSubgradeReactionMeasure obj2)
        {
            return Equals(obj1, obj2);
        }

        public static bool operator !=(IfcModulusOfLinearSubgradeReactionMeasure obj1, IfcModulusOfLinearSubgradeReactionMeasure obj2)
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
