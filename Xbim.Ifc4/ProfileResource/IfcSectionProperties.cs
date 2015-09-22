// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		22.09.2015 02:32:08
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.PropertyResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.ProfileResource
{
	[IndexedClass]
	[ExpressType("IFCSECTIONPROPERTIES", 971)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcSectionProperties : IfcPreDefinedProperties, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcSectionProperties(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcSectionTypeEnum _sectionType;
		private IfcProfileDef _startProfile;
		private IfcProfileDef _endProfile;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcSectionTypeEnum @SectionType 
		{ 
			get 
			{
				if(Activated) return _sectionType;
				
				Model.Activate(this, true);
				Activated = true;
				return _sectionType;
			} 
			set
			{
				SetValue( v =>  _sectionType = v, _sectionType, value,  "SectionType");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcProfileDef @StartProfile 
		{ 
			get 
			{
				if(Activated) return _startProfile;
				
				Model.Activate(this, true);
				Activated = true;
				return _startProfile;
			} 
			set
			{
				SetValue( v =>  _startProfile = v, _startProfile, value,  "StartProfile");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcProfileDef @EndProfile 
		{ 
			get 
			{
				if(Activated) return _endProfile;
				
				Model.Activate(this, true);
				Activated = true;
				return _endProfile;
			} 
			set
			{
				SetValue( v =>  _endProfile = v, _endProfile, value,  "EndProfile");
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
                    _sectionType = (IfcSectionTypeEnum) System.Enum.Parse(typeof (IfcSectionTypeEnum), value.EnumVal, true);
					return;
				case 1: 
					_startProfile = (IfcProfileDef)(value.EntityVal);
					return;
				case 2: 
					_endProfile = (IfcProfileDef)(value.EntityVal);
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