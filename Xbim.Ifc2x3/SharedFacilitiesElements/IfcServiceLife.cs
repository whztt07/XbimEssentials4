// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 02:29:15
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.Kernel;
using Xbim.Ifc2x3.UtilityResource;
using Xbim.Ifc2x3.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc2x3.SharedFacilitiesElements
{
	[EntityName("IFCSERVICELIFE", 507)]
	public  partial class @IfcServiceLife : IfcControl, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcServiceLife(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcServiceLifeTypeEnum _serviceLifeType;
		private IfcTimeMeasure _serviceLifeDuration;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(5, EntityAttributeState.Mandatory)]
		public IfcServiceLifeTypeEnum @ServiceLifeType 
		{ 
			get 
			{
				if(Activated) return _serviceLifeType;
				
				Model.Activate(this, true);
				Activated = true;
				return _serviceLifeType;
			} 
			set
			{
				SetValue( v =>  _serviceLifeType = v, _serviceLifeType, value,  "ServiceLifeType");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Mandatory)]
		public IfcTimeMeasure @ServiceLifeDuration 
		{ 
			get 
			{
				if(Activated) return _serviceLifeDuration;
				
				Model.Activate(this, true);
				Activated = true;
				return _serviceLifeDuration;
			} 
			set
			{
				SetValue( v =>  _serviceLifeDuration = v, _serviceLifeDuration, value,  "ServiceLifeDuration");
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
			"ObjectType",
			"ServiceLifeType",
			"ServiceLifeDuration",
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
					return @ObjectType;
				case 5: 
					return @ServiceLifeType;
				case 6: 
					return @ServiceLifeDuration;
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
				case "ObjectType":  
					return @ObjectType;
				case "ServiceLifeType":  
					return @ServiceLifeType;
				case "ServiceLifeDuration":  
					return @ServiceLifeDuration;
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
					 @ObjectType = (IfcLabel?)value;
					 break;
				case 5:
					 if (value != null) @ServiceLifeType = (IfcServiceLifeTypeEnum)value;
					 break;
				case 6:
					 if (value != null) @ServiceLifeDuration = (IfcTimeMeasure)value;
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
				case "ObjectType":
					 @ObjectType = (IfcLabel?)value;
					 break;
				case "ServiceLifeType":
					 if (value != null) @ServiceLifeType = (IfcServiceLifeTypeEnum)value;
					 break;
				case "ServiceLifeDuration":
					 if (value != null) @ServiceLifeDuration = (IfcTimeMeasure)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion


		#region IPersist implementation
		void IPersist.Set(int propIndex, IPropertyValue value)
		{
            throw new System.NotImplementedException();
		}
		#endregion

	}
}