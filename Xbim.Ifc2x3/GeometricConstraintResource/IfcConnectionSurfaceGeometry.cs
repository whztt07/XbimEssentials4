// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.GeometricConstraintResource
{
	[IndexedClass]
	[ExpressType("IFCCONNECTIONSURFACEGEOMETRY", 69)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcConnectionSurfaceGeometry : IfcConnectionGeometry, IInstantiableEntity, System.Collections.Generic.IEqualityComparer<@IfcConnectionSurfaceGeometry>, System.IEquatable<@IfcConnectionSurfaceGeometry>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcConnectionSurfaceGeometry(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcSurfaceOrFaceSurface _surfaceOnRelatingElement;
		private IfcSurfaceOrFaceSurface _surfaceOnRelatedElement;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcSurfaceOrFaceSurface @SurfaceOnRelatingElement 
		{ 
			get 
			{
				if(Activated) return _surfaceOnRelatingElement;
				
				Model.Activate(this, true);
				Activated = true;
				return _surfaceOnRelatingElement;
			} 
			set
			{
				SetValue( v =>  _surfaceOnRelatingElement = v, _surfaceOnRelatingElement, value,  "SurfaceOnRelatingElement");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcSurfaceOrFaceSurface @SurfaceOnRelatedElement 
		{ 
			get 
			{
				if(Activated) return _surfaceOnRelatedElement;
				
				Model.Activate(this, true);
				Activated = true;
				return _surfaceOnRelatedElement;
			} 
			set
			{
				SetValue( v =>  _surfaceOnRelatedElement = v, _surfaceOnRelatedElement, value,  "SurfaceOnRelatedElement");
			} 
		}
	
		#endregion



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
					_surfaceOnRelatingElement = (IfcSurfaceOrFaceSurface)(value.EntityVal);
					return;
				case 1: 
					_surfaceOnRelatedElement = (IfcSurfaceOrFaceSurface)(value.EntityVal);
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
        public bool Equals(@IfcConnectionSurfaceGeometry other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcConnectionSurfaceGeometry
            var root = (@IfcConnectionSurfaceGeometry)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcConnectionSurfaceGeometry left, @IfcConnectionSurfaceGeometry right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcConnectionSurfaceGeometry left, @IfcConnectionSurfaceGeometry right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcConnectionSurfaceGeometry x, @IfcConnectionSurfaceGeometry y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcConnectionSurfaceGeometry obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}