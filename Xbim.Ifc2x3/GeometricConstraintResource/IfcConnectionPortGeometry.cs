// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		24.09.2015 10:03:32
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.GeometryResource;
using Xbim.Ifc2x3.ProfileResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.GeometricConstraintResource
{
	[IndexedClass]
	[ExpressType("IFCCONNECTIONPORTGEOMETRY", 713)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcConnectionPortGeometry : IfcConnectionGeometry, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcConnectionPortGeometry(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcAxis2Placement _locationAtRelatingElement;
		private IfcAxis2Placement _locationAtRelatedElement;
		private IfcProfileDef _profileOfPort;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcAxis2Placement @LocationAtRelatingElement 
		{ 
			get 
			{
				if(Activated) return _locationAtRelatingElement;
				
				Model.Activate(this, true);
				Activated = true;
				return _locationAtRelatingElement;
			} 
			set
			{
				SetValue( v =>  _locationAtRelatingElement = v, _locationAtRelatingElement, value,  "LocationAtRelatingElement");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcAxis2Placement @LocationAtRelatedElement 
		{ 
			get 
			{
				if(Activated) return _locationAtRelatedElement;
				
				Model.Activate(this, true);
				Activated = true;
				return _locationAtRelatedElement;
			} 
			set
			{
				SetValue( v =>  _locationAtRelatedElement = v, _locationAtRelatedElement, value,  "LocationAtRelatedElement");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcProfileDef @ProfileOfPort 
		{ 
			get 
			{
				if(Activated) return _profileOfPort;
				
				Model.Activate(this, true);
				Activated = true;
				return _profileOfPort;
			} 
			set
			{
				SetValue( v =>  _profileOfPort = v, _profileOfPort, value,  "ProfileOfPort");
			} 
		}
	
		#endregion



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
					_locationAtRelatingElement = (IfcAxis2Placement)(value.EntityVal);
					return;
				case 1: 
					_locationAtRelatedElement = (IfcAxis2Placement)(value.EntityVal);
					return;
				case 2: 
					_profileOfPort = (IfcProfileDef)(value.EntityVal);
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