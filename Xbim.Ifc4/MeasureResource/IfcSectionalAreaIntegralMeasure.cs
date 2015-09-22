// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		22.09.2015 02:32:03
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.MeasureResource
{
	[ExpressType("IFCSECTIONALAREAINTEGRALMEASURE", 93)]
    // ReSharper disable once PartialTypeWithSinglePart
	public partial struct IfcSectionalAreaIntegralMeasure : IfcDerivedMeasureValue, IExpressType
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

        public IfcSectionalAreaIntegralMeasure(double val)
        {
            _value = val;
        }

        public static implicit operator IfcSectionalAreaIntegralMeasure(double value)
        {
            return new IfcSectionalAreaIntegralMeasure(value);
        }

        public static implicit operator double(IfcSectionalAreaIntegralMeasure obj)
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

            return ((IfcSectionalAreaIntegralMeasure) obj)._value == _value;
        }

        public static bool operator ==(IfcSectionalAreaIntegralMeasure obj1, IfcSectionalAreaIntegralMeasure obj2)
        {
            return Equals(obj1, obj2);
        }

        public static bool operator !=(IfcSectionalAreaIntegralMeasure obj1, IfcSectionalAreaIntegralMeasure obj2)
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
        System.Type IExpressType.UnderlyingSystemType { 
			get 
			{
				return typeof(double);
			}
		}
		#endregion


	}
}
