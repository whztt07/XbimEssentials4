// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 03:44:06
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.UtilityResource;
using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.GeometricConstraintResource;
using Xbim.Ifc4.RepresentationResource;
using Xbim.Ifc4.ActorResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.ProductExtension
{
	[EntityName("IFCSITE", 593)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcSite : IfcSpatialStructureElement, IInstantiableEntity
	{
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
		[EntityAttributee(9, EntityAttributeState.Optional)]
		public IfcCompoundPlaneAngleMeasure? @RefLatitude 
		{ 
			get 
			{
				if(Activated) return _refLatitude;
				
				Model.Activate(this, true);
				Activated = true;
				return _refLatitude;
			} 
			set
			{
				SetValue( v =>  _refLatitude = v, _refLatitude, value,  "RefLatitude");
			} 
		}
	
		[EntityAttributee(10, EntityAttributeState.Optional)]
		public IfcCompoundPlaneAngleMeasure? @RefLongitude 
		{ 
			get 
			{
				if(Activated) return _refLongitude;
				
				Model.Activate(this, true);
				Activated = true;
				return _refLongitude;
			} 
			set
			{
				SetValue( v =>  _refLongitude = v, _refLongitude, value,  "RefLongitude");
			} 
		}
	
		[EntityAttributee(11, EntityAttributeState.Optional)]
		public IfcLengthMeasure? @RefElevation 
		{ 
			get 
			{
				if(Activated) return _refElevation;
				
				Model.Activate(this, true);
				Activated = true;
				return _refElevation;
			} 
			set
			{
				SetValue( v =>  _refElevation = v, _refElevation, value,  "RefElevation");
			} 
		}
	
		[EntityAttributee(12, EntityAttributeState.Optional)]
		public IfcLabel? @LandTitleNumber 
		{ 
			get 
			{
				if(Activated) return _landTitleNumber;
				
				Model.Activate(this, true);
				Activated = true;
				return _landTitleNumber;
			} 
			set
			{
				SetValue( v =>  _landTitleNumber = v, _landTitleNumber, value,  "LandTitleNumber");
			} 
		}
	
		[EntityAttributee(13, EntityAttributeState.Optional)]
		public IfcPostalAddress @SiteAddress 
		{ 
			get 
			{
				if(Activated) return _siteAddress;
				
				Model.Activate(this, true);
				Activated = true;
				return _siteAddress;
			} 
			set
			{
				SetValue( v =>  _siteAddress = v, _siteAddress, value,  "SiteAddress");
			} 
		}
	
		#endregion

		#region Inverse attributes

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
					if (!_refLatitude.HasValue) _refLatitude = new IfcCompoundPlaneAngleMeasure?();
			        // ReSharper disable once PossibleNullReferenceException
					((IExpressComplexType)_refLatitude).Add(value.IntegerVal);
					return;
				case 10: 
					if (!_refLongitude.HasValue) _refLongitude = new IfcCompoundPlaneAngleMeasure?();
			        // ReSharper disable once PossibleNullReferenceException
					((IExpressComplexType)_refLongitude).Add(value.IntegerVal);
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
	}
}