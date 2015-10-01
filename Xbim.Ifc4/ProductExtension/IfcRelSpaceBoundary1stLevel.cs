// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.UtilityResource;
using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.GeometricConstraintResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.ProductExtension
{
	[ExpressType("IFCRELSPACEBOUNDARY1STLEVEL", 945)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRelSpaceBoundary1stLevel : IfcRelSpaceBoundary, IInstantiableEntity, System.Collections.Generic.IEqualityComparer<@IfcRelSpaceBoundary1stLevel>, System.IEquatable<@IfcRelSpaceBoundary1stLevel>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelSpaceBoundary1stLevel(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcRelSpaceBoundary1stLevel _parentBoundary;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcRelSpaceBoundary1stLevel @ParentBoundary 
		{ 
			get 
			{
				if(Activated) return _parentBoundary;
				
				Model.Activate(this, true);
				Activated = true;
				return _parentBoundary;
			} 
			set
			{
				SetValue( v =>  _parentBoundary = v, _parentBoundary, value,  "ParentBoundary");
			} 
		}
	
		#endregion

		#region Inverse attributes
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcRelSpaceBoundary1stLevel> @InnerBoundaries 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelSpaceBoundary1stLevel>(e => e.ParentBoundary == this);
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
				case 8: 
					base.Parse(propIndex, value); 
					return;
				case 9: 
					_parentBoundary = (IfcRelSpaceBoundary1stLevel)(value.EntityVal);
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
        public bool Equals(@IfcRelSpaceBoundary1stLevel other)
	    {
	        return this == other;
	    }


        public static bool operator ==(@IfcRelSpaceBoundary1stLevel left, @IfcRelSpaceBoundary1stLevel right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcRelSpaceBoundary1stLevel left, @IfcRelSpaceBoundary1stLevel right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcRelSpaceBoundary1stLevel x, @IfcRelSpaceBoundary1stLevel y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcRelSpaceBoundary1stLevel obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}