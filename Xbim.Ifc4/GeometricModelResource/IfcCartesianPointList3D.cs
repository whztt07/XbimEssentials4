// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.GeometricModelResource
{
	[ExpressType("IFCCARTESIANPOINTLIST3D", 469)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcCartesianPointList3D : IfcCartesianPointList, IInstantiableEntity, IEqualityComparer<@IfcCartesianPointList3D>, IEquatable<@IfcCartesianPointList3D>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcCartesianPointList3D(IModel model) : base(model) 		{ 
			Model = model; 
			_coordList = new ItemSet<ItemSet<IfcLengthMeasure>>( this );
		}

		#region Explicit attribute fields
		private ItemSet<ItemSet<IfcLengthMeasure>> _coordList;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.List, 1, -1)]
		public ItemSet<ItemSet<IfcLengthMeasure>> @CoordList 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _coordList;
				((IPersistEntity)this).Activate(false);
				return _coordList;
			} 
		}
	
		#endregion



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
					//this is a special case which has to be handled in a partial class which is not generated.
					//ParseCoordList(propIndex, value);
					//return;
					throw new System.NotImplementedException("CoordList in IfcCartesianPointList3D is a special case of nested lists. It is not implemented for now.");
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
        public bool Equals(@IfcCartesianPointList3D other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcCartesianPointList3D
            var root = (@IfcCartesianPointList3D)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcCartesianPointList3D left, @IfcCartesianPointList3D right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcCartesianPointList3D left, @IfcCartesianPointList3D right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcCartesianPointList3D x, @IfcCartesianPointList3D y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcCartesianPointList3D obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}