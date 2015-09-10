// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		09/09/2015 04:20:36
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.UtilityResource;
using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.PropertyResource;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc2x3.Kernel
{
	[EntityName("IFCRELOVERRIDESPROPERTIES", 248)]
	public  partial class @IfcRelOverridesProperties : IfcRelDefinesByProperties, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelOverridesProperties(IModel model) : base(model) 		{ 
			Model = model; 
			_overridingProperties = new ItemSet<IfcProperty>( model );
		}

		#region Explicit attribute fields
		private ItemSet<IfcProperty> _overridingProperties;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(6, EntityAttributeState.Mandatory)]
		public ItemSet<IfcProperty> @OverridingProperties 
		{ 
			get 
			{
				if(Activated) return _overridingProperties;
				
				Model.Activate(this, true);
				Activated = true;
				return _overridingProperties;
			} 
			set
			{
				SetValue( v =>  _overridingProperties = v, _overridingProperties, value,  "OverridingProperties");
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
			"RelatingPropertyDefinition",
			"OverridingProperties",
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
					return @RelatingPropertyDefinition;
				case 6: 
					return @OverridingProperties;
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
				case "RelatingPropertyDefinition":  
					return @RelatingPropertyDefinition;
				case "OverridingProperties":  
					return @OverridingProperties;
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
					 @RelatedObjects.Add((IfcObject)value);
					 break;
				case 5:
					 @RelatingPropertyDefinition = (IfcPropertySetDefinition)value;
					 break;
				case 6:
					 @OverridingProperties.Add((IfcProperty)value);
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
					 @RelatedObjects.Add((IfcObject)value);
					 break;
				case "RelatingPropertyDefinition":
					 @RelatingPropertyDefinition = (IfcPropertySetDefinition)value;
					 break;
				case "OverridingProperties":
					 @OverridingProperties.Add((IfcProperty)value);
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion

		#region Where rules
		/*WR1:	WR1 : SIZEOF(SELF\IfcRelDefines.RelatedObjects) = 1;*/
		#endregion

		#region IPersist implementation
		void IPersist.Set(int propIndex, IPropertyValue value)
		{
            throw new System.NotImplementedException();
		}
		#endregion

		public  override string WhereRule() 
		{
			return "";
		}
	}
}