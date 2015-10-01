// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.StructuralAnalysisDomain;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.GeometryResource
{
	[ExpressType("IFCDIRECTION", 344)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcDirection : IfcGeometricRepresentationItem, IfcOrientationSelect, IfcVectorOrDirection, IInstantiableEntity, System.Collections.Generic.IEqualityComparer<@IfcDirection>, System.IEquatable<@IfcDirection>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcDirection(IModel model) : base(model) 		{ 
			Model = model; 
			_directionRatios = new ItemSet<double>( this );
		}

		#region Explicit attribute fields
		private ItemSet<double> _directionRatios;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.None, 2, 3)]
		public ItemSet<double> @DirectionRatios 
		{ 
			get 
			{
				if(Activated) return _directionRatios;
				
				Model.Activate(this, true);
				Activated = true;
				return _directionRatios;
			} 
		}
	
		#endregion



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
					if (_directionRatios == null) _directionRatios = new ItemSet<double>( this );
					_directionRatios.InternalAdd(value.RealVal);
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
        public bool Equals(@IfcDirection other)
	    {
	        return this == other;
	    }


        public static bool operator ==(@IfcDirection left, @IfcDirection right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcDirection left, @IfcDirection right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcDirection x, @IfcDirection y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcDirection obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}