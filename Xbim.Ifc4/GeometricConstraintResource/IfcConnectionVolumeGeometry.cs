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

namespace Xbim.Ifc4.GeometricConstraintResource
{
	[ExpressType("IFCCONNECTIONVOLUMEGEOMETRY", 515)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcConnectionVolumeGeometry : IfcConnectionGeometry, IInstantiableEntity, System.Collections.Generic.IEqualityComparer<@IfcConnectionVolumeGeometry>, System.IEquatable<@IfcConnectionVolumeGeometry>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcConnectionVolumeGeometry(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcSolidOrShell _volumeOnRelatingElement;
		private IfcSolidOrShell _volumeOnRelatedElement;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcSolidOrShell @VolumeOnRelatingElement 
		{ 
			get 
			{
				if(Activated) return _volumeOnRelatingElement;
				
				Model.Activate(this, true);
				Activated = true;
				return _volumeOnRelatingElement;
			} 
			set
			{
				SetValue( v =>  _volumeOnRelatingElement = v, _volumeOnRelatingElement, value,  "VolumeOnRelatingElement");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcSolidOrShell @VolumeOnRelatedElement 
		{ 
			get 
			{
				if(Activated) return _volumeOnRelatedElement;
				
				Model.Activate(this, true);
				Activated = true;
				return _volumeOnRelatedElement;
			} 
			set
			{
				SetValue( v =>  _volumeOnRelatedElement = v, _volumeOnRelatedElement, value,  "VolumeOnRelatedElement");
			} 
		}
	
		#endregion



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
					_volumeOnRelatingElement = (IfcSolidOrShell)(value.EntityVal);
					return;
				case 1: 
					_volumeOnRelatedElement = (IfcSolidOrShell)(value.EntityVal);
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
        public bool Equals(@IfcConnectionVolumeGeometry other)
	    {
	        return this == other;
	    }


        public static bool operator ==(@IfcConnectionVolumeGeometry left, @IfcConnectionVolumeGeometry right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcConnectionVolumeGeometry left, @IfcConnectionVolumeGeometry right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcConnectionVolumeGeometry x, @IfcConnectionVolumeGeometry y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcConnectionVolumeGeometry obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}