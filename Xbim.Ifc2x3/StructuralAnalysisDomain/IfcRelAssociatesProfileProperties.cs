// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.Kernel;
using Xbim.Ifc2x3.UtilityResource;
using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.ProfilePropertyResource;
using Xbim.Ifc2x3.RepresentationResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.StructuralAnalysisDomain
{
	[IndexedClass]
	[ExpressType("IFCRELASSOCIATESPROFILEPROPERTIES", 676)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRelAssociatesProfileProperties : IfcRelAssociates, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelAssociatesProfileProperties(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcProfileProperties _relatingProfileProperties;
		private IfcShapeAspect _profileSectionLocation;
		private IfcOrientationSelect _profileOrientation;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcProfileProperties @RelatingProfileProperties 
		{ 
			get 
			{
				if(Activated) return _relatingProfileProperties;
				
				Model.Activate(this, true);
				Activated = true;
				return _relatingProfileProperties;
			} 
			set
			{
				SetValue( v =>  _relatingProfileProperties = v, _relatingProfileProperties, value,  "RelatingProfileProperties");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcShapeAspect @ProfileSectionLocation 
		{ 
			get 
			{
				if(Activated) return _profileSectionLocation;
				
				Model.Activate(this, true);
				Activated = true;
				return _profileSectionLocation;
			} 
			set
			{
				SetValue( v =>  _profileSectionLocation = v, _profileSectionLocation, value,  "ProfileSectionLocation");
			} 
		}
	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcOrientationSelect @ProfileOrientation 
		{ 
			get 
			{
				if(Activated) return _profileOrientation;
				
				Model.Activate(this, true);
				Activated = true;
				return _profileOrientation;
			} 
			set
			{
				SetValue( v =>  _profileOrientation = v, _profileOrientation, value,  "ProfileOrientation");
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
					base.Parse(propIndex, value); 
					return;
				case 5: 
					_relatingProfileProperties = (IfcProfileProperties)(value.EntityVal);
					return;
				case 6: 
					_profileSectionLocation = (IfcShapeAspect)(value.EntityVal);
					return;
				case 7: 
					_profileOrientation = (IfcOrientationSelect)(value.EntityVal);
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