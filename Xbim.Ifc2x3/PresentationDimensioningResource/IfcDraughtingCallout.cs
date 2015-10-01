// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.GeometryResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.PresentationDimensioningResource
{
	[ExpressType("IFCDRAUGHTINGCALLOUT", 222)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcDraughtingCallout : IfcGeometricRepresentationItem, IInstantiableEntity, System.Collections.Generic.IEqualityComparer<@IfcDraughtingCallout>, System.IEquatable<@IfcDraughtingCallout>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcDraughtingCallout(IModel model) : base(model) 		{ 
			Model = model; 
			_contents = new ItemSet<IfcDraughtingCalloutElement>( this );
		}

		#region Explicit attribute fields
		private ItemSet<IfcDraughtingCalloutElement> _contents;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1)]
		public ItemSet<IfcDraughtingCalloutElement> @Contents 
		{ 
			get 
			{
				if(Activated) return _contents;
				
				Model.Activate(this, true);
				Activated = true;
				return _contents;
			} 
		}
	
		#endregion

		#region Inverse attributes
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcDraughtingCalloutRelationship> @IsRelatedFromCallout 
		{ 
			get 
			{
				return Model.Instances.Where<IfcDraughtingCalloutRelationship>(e => e.RelatedDraughtingCallout == this);
			} 
		}
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcDraughtingCalloutRelationship> @IsRelatedToCallout 
		{ 
			get 
			{
				return Model.Instances.Where<IfcDraughtingCalloutRelationship>(e => e.RelatingDraughtingCallout == this);
			} 
		}
		#endregion


		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
					if (_contents == null) _contents = new ItemSet<IfcDraughtingCalloutElement>( this );
					_contents.InternalAdd((IfcDraughtingCalloutElement)value.EntityVal);
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
        public bool Equals(@IfcDraughtingCallout other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcDraughtingCallout
            var root = (@IfcDraughtingCallout)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcDraughtingCallout left, @IfcDraughtingCallout right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcDraughtingCallout left, @IfcDraughtingCallout right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcDraughtingCallout x, @IfcDraughtingCallout y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcDraughtingCallout obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}