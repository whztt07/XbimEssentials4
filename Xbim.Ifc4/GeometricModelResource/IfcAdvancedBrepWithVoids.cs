// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.TopologyResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.GeometricModelResource
{
	[ExpressType("IFCADVANCEDBREPWITHVOIDS", 398)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcAdvancedBrepWithVoids : IfcAdvancedBrep, IInstantiableEntity, IEqualityComparer<@IfcAdvancedBrepWithVoids>, IEquatable<@IfcAdvancedBrepWithVoids>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcAdvancedBrepWithVoids(IModel model) : base(model) 		{ 
			Model = model; 
			_voids = new ItemSet<IfcClosedShell>( this );
		}

		#region Explicit attribute fields
		private ItemSet<IfcClosedShell> _voids;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1)]
		public ItemSet<IfcClosedShell> @Voids 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _voids;
				((IPersistEntity)this).Activate(false);
				return _voids;
			} 
		}
	
		#endregion



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
					base.Parse(propIndex, value); 
					return;
				case 1: 
					if (_voids == null) _voids = new ItemSet<IfcClosedShell>( this );
					_voids.InternalAdd((IfcClosedShell)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*VoidsHaveAdvancedFaces:                               )) = 0;*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcAdvancedBrepWithVoids other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcAdvancedBrepWithVoids
            var root = (@IfcAdvancedBrepWithVoids)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcAdvancedBrepWithVoids left, @IfcAdvancedBrepWithVoids right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcAdvancedBrepWithVoids left, @IfcAdvancedBrepWithVoids right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcAdvancedBrepWithVoids x, @IfcAdvancedBrepWithVoids y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcAdvancedBrepWithVoids obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}