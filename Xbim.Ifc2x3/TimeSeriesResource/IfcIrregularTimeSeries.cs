// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.DateTimeResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.TimeSeriesResource
{
	[ExpressType("IFCIRREGULARTIMESERIES", 570)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcIrregularTimeSeries : IfcTimeSeries, IInstantiableEntity, System.Collections.Generic.IEqualityComparer<@IfcIrregularTimeSeries>, System.IEquatable<@IfcIrregularTimeSeries>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcIrregularTimeSeries(IModel model) : base(model) 		{ 
			Model = model; 
			_values = new ItemSet<IfcIrregularTimeSeriesValue>( this );
		}

		#region Explicit attribute fields
		private ItemSet<IfcIrregularTimeSeriesValue> _values;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(9, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.Class, 1, -1)]
		public ItemSet<IfcIrregularTimeSeriesValue> @Values 
		{ 
			get 
			{
				if(Activated) return _values;
				
				Model.Activate(this, true);
				Activated = true;
				return _values;
			} 
		}
	
		#endregion



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
				case 3: 
				case 4: 
				case 5: 
				case 6: 
				case 7: 
					base.Parse(propIndex, value); 
					return;
				case 8: 
					if (_values == null) _values = new ItemSet<IfcIrregularTimeSeriesValue>( this );
					_values.InternalAdd((IfcIrregularTimeSeriesValue)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
			return "";
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcIrregularTimeSeries other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcIrregularTimeSeries
            var root = (@IfcIrregularTimeSeries)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcIrregularTimeSeries left, @IfcIrregularTimeSeries right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcIrregularTimeSeries left, @IfcIrregularTimeSeries right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcIrregularTimeSeries x, @IfcIrregularTimeSeries y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcIrregularTimeSeries obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}