// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		15.09.2015 07:04:15
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.GeometryResource;
using Xbim.Ifc2x3.ProfileResource;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc2x3.GeometricConstraintResource
{
	[EntityName("IFCCONNECTIONPORTGEOMETRY", 713)]
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
		[EntityAttribute(0, EntityAttributeState.Mandatory)]
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
	
		[EntityAttribute(1, EntityAttributeState.Optional)]
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
	
		[EntityAttribute(2, EntityAttributeState.Mandatory)]
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

		#region Inverse attributes

		#endregion

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"LocationAtRelatingElement",
			"LocationAtRelatedElement",
			"ProfileOfPort",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @LocationAtRelatingElement;
				case 1: 
					return @LocationAtRelatedElement;
				case 2: 
					return @ProfileOfPort;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "LocationAtRelatingElement":  
					return @LocationAtRelatingElement;
				case "LocationAtRelatedElement":  
					return @LocationAtRelatedElement;
				case "ProfileOfPort":  
					return @ProfileOfPort;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 @LocationAtRelatingElement = (IfcAxis2Placement)value;
					 break;
				case 1:
					 @LocationAtRelatedElement = (IfcAxis2Placement)value;
					 break;
				case 2:
					 @ProfileOfPort = (IfcProfileDef)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "LocationAtRelatingElement":
					 @LocationAtRelatingElement = (IfcAxis2Placement)value;
					 break;
				case "LocationAtRelatedElement":
					 @LocationAtRelatedElement = (IfcAxis2Placement)value;
					 break;
				case "ProfileOfPort":
					 @ProfileOfPort = (IfcProfileDef)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion


		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
            throw new System.NotImplementedException();
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		}
		#endregion

		
	}
}