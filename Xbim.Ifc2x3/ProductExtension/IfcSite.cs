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
using Xbim.Ifc2x3.ActorResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.ProductExtension
{
	[ExpressType("IFCSITE", 349)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcSite : IfcSpatialStructureElement, IInstantiableEntity, IEqualityComparer<@IfcSite>, IEquatable<@IfcSite>
	{
		public static int LoadDepth = 1;

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcSite(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcCompoundPlaneAngleMeasure? _refLatitude;
		private IfcCompoundPlaneAngleMeasure? _refLongitude;
		private IfcLengthMeasure? _refElevation;
		private IfcLabel? _landTitleNumber;
		private IfcPostalAddress _siteAddress;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcCompoundPlaneAngleMeasure? @RefLatitude 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _refLatitude;
				((IPersistEntity)this).Activate(false);
				return _refLatitude;
			} 
			set
			{
				SetValue( v =>  _refLatitude = v, _refLatitude, value,  "RefLatitude");
			} 
		}
	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcCompoundPlaneAngleMeasure? @RefLongitude 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _refLongitude;
				((IPersistEntity)this).Activate(false);
				return _refLongitude;
			} 
			set
			{
				SetValue( v =>  _refLongitude = v, _refLongitude, value,  "RefLongitude");
			} 
		}
	
		[EntityAttribute(12, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLengthMeasure? @RefElevation 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _refElevation;
				((IPersistEntity)this).Activate(false);
				return _refElevation;
			} 
			set
			{
				SetValue( v =>  _refElevation = v, _refElevation, value,  "RefElevation");
			} 
		}
	
		[EntityAttribute(13, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel? @LandTitleNumber 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _landTitleNumber;
				((IPersistEntity)this).Activate(false);
				return _landTitleNumber;
			} 
			set
			{
				SetValue( v =>  _landTitleNumber = v, _landTitleNumber, value,  "LandTitleNumber");
			} 
		}
	
		[EntityAttribute(14, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcPostalAddress @SiteAddress 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _siteAddress;
				((IPersistEntity)this).Activate(false);
				return _siteAddress;
			} 
			set
			{
				SetValue( v =>  _siteAddress = v, _siteAddress, value,  "SiteAddress");
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
					if (!_refLatitude.HasValue) _refLatitude = new IfcCompoundPlaneAngleMeasure();
			        var refLatitude = _refLatitude.Value;
					IfcCompoundPlaneAngleMeasure.Add(ref refLatitude, value.IntegerVal);
					_refLatitude = refLatitude;
					return;
				case 10: 
					if (!_refLongitude.HasValue) _refLongitude = new IfcCompoundPlaneAngleMeasure();
			        var refLongitude = _refLongitude.Value;
					IfcCompoundPlaneAngleMeasure.Add(ref refLongitude, value.IntegerVal);
					_refLongitude = refLongitude;
					return;
				case 11: 
					_refElevation = value.RealVal;
					return;
				case 12: 
					_landTitleNumber = value.StringVal;
					return;
				case 13: 
					_siteAddress = (IfcPostalAddress)(value.EntityVal);
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
        public bool Equals(@IfcSite other)
	    {
	        return this == other;
	    }


        public static bool operator ==(@IfcSite left, @IfcSite right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcSite left, @IfcSite right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcSite x, @IfcSite y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcSite obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}