// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 09:16:38
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

namespace Xbim.Ifc2x3.StructuralAnalysisDomain
{
	[EntityName("IFCRELASSOCIATESPROFILEPROPERTIES")]
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
		[EntityAttribute(5, EntityAttributeState.Mandatory)]
		public IfcProfileProperties @RelatingProfileProperties 
		{ 
			get 
			{
				if(IsActivated) return _relatingProfileProperties;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _relatingProfileProperties;
			} 
			set
			{
				SetValue( v =>  _relatingProfileProperties = v, _relatingProfileProperties, value,  "RelatingProfileProperties");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Optional)]
		public IfcShapeAspect @ProfileSectionLocation 
		{ 
			get 
			{
				if(IsActivated) return _profileSectionLocation;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _profileSectionLocation;
			} 
			set
			{
				SetValue( v =>  _profileSectionLocation = v, _profileSectionLocation, value,  "ProfileSectionLocation");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Optional)]
		public IfcOrientationSelect @ProfileOrientation 
		{ 
			get 
			{
				if(IsActivated) return _profileOrientation;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _profileOrientation;
			} 
			set
			{
				SetValue( v =>  _profileOrientation = v, _profileOrientation, value,  "ProfileOrientation");
			} 
		}
	
		#endregion

		#region Inverse attributes

		#endregion

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"GlobalId",
			"OwnerHistory",
			"Name",
			"Description",
			"RelatedObjects",
			"RelatingProfileProperties",
			"ProfileSectionLocation",
			"ProfileOrientation",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @GlobalId;
				case 1: 
					return @OwnerHistory;
				case 2: 
					return @Name;
				case 3: 
					return @Description;
				case 4: 
					return @RelatedObjects;
				case 5: 
					return @RelatingProfileProperties;
				case 6: 
					return @ProfileSectionLocation;
				case 7: 
					return @ProfileOrientation;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "GlobalId":  
					return @GlobalId;
				case "OwnerHistory":  
					return @OwnerHistory;
				case "Name":  
					return @Name;
				case "Description":  
					return @Description;
				case "RelatedObjects":  
					return @RelatedObjects;
				case "RelatingProfileProperties":  
					return @RelatingProfileProperties;
				case "ProfileSectionLocation":  
					return @ProfileSectionLocation;
				case "ProfileOrientation":  
					return @ProfileOrientation;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 if (value != null) @GlobalId = (IfcGloballyUniqueId)value;
					 break;
				case 1:
					 @OwnerHistory = (IfcOwnerHistory)value;
					 break;
				case 2:
					 @Name = (IfcLabel?)value;
					 break;
				case 3:
					 @Description = (IfcText?)value;
					 break;
				case 4:
					 @RelatedObjects.Add((IfcRoot)value);
					 break;
				case 5:
					 @RelatingProfileProperties = (IfcProfileProperties)value;
					 break;
				case 6:
					 @ProfileSectionLocation = (IfcShapeAspect)value;
					 break;
				case 7:
					 @ProfileOrientation = (IfcOrientationSelect)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "GlobalId":
					 if (value != null) @GlobalId = (IfcGloballyUniqueId)value;
					 break;
				case "OwnerHistory":
					 @OwnerHistory = (IfcOwnerHistory)value;
					 break;
				case "Name":
					 @Name = (IfcLabel?)value;
					 break;
				case "Description":
					 @Description = (IfcText?)value;
					 break;
				case "RelatedObjects":
					 @RelatedObjects.Add((IfcRoot)value);
					 break;
				case "RelatingProfileProperties":
					 @RelatingProfileProperties = (IfcProfileProperties)value;
					 break;
				case "ProfileSectionLocation":
					 @ProfileSectionLocation = (IfcShapeAspect)value;
					 break;
				case "ProfileOrientation":
					 @ProfileOrientation = (IfcOrientationSelect)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion


		#region IPersist implementation
		public void Set(int propIndex, IPropertyValue value)
		{
            throw new System.NotImplementedException();
		}
		#endregion

	}
}