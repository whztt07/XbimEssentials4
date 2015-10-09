// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.UtilityResource;
using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.GeometricConstraintResource;
using Xbim.Ifc2x3.RepresentationResource;
using Xbim.Ifc2x3.StructuralLoadResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.StructuralAnalysisDomain
{
	[ExpressType("IFCSTRUCTURALLINEARACTIONVARYING", 464)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcStructuralLinearActionVarying : IfcStructuralLinearAction, IInstantiableEntity, IEqualityComparer<@IfcStructuralLinearActionVarying>, IEquatable<@IfcStructuralLinearActionVarying>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcStructuralLinearActionVarying(IModel model) : base(model) 		{ 
			Model = model; 
			_subsequentAppliedLoads = new ItemSet<IfcStructuralLoad>( this, 0 );
		}

		#region Explicit attribute fields
		private IfcShapeAspect _varyingAppliedLoadLocation;
		private ItemSet<IfcStructuralLoad> _subsequentAppliedLoads;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(13, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcShapeAspect @VaryingAppliedLoadLocation 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _varyingAppliedLoadLocation;
				((IPersistEntity)this).Activate(false);
				return _varyingAppliedLoadLocation;
			} 
			set
			{
				SetValue( v =>  _varyingAppliedLoadLocation = v, _varyingAppliedLoadLocation, value,  "VaryingAppliedLoadLocation");
			} 
		}
	
		[EntityAttribute(14, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.Class, 1, -1)]
		public ItemSet<IfcStructuralLoad> @SubsequentAppliedLoads 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _subsequentAppliedLoads;
				((IPersistEntity)this).Activate(false);
				return _subsequentAppliedLoads;
			} 
		}
	
		#endregion



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
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
				case 8: 
				case 9: 
				case 10: 
				case 11: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 12: 
					_varyingAppliedLoadLocation = (IfcShapeAspect)(value.EntityVal);
					return;
				case 13: 
					if (_subsequentAppliedLoads == null) _subsequentAppliedLoads = new ItemSet<IfcStructuralLoad>( this );
					_subsequentAppliedLoads.InternalAdd((IfcStructuralLoad)value.EntityVal);
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
        public bool Equals(@IfcStructuralLinearActionVarying other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcStructuralLinearActionVarying
            var root = (@IfcStructuralLinearActionVarying)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcStructuralLinearActionVarying left, @IfcStructuralLinearActionVarying right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcStructuralLinearActionVarying left, @IfcStructuralLinearActionVarying right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcStructuralLinearActionVarying x, @IfcStructuralLinearActionVarying y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcStructuralLinearActionVarying obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}