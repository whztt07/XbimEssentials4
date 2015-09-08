// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 09:16:42
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.UtilityResource;
using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.ActorResource;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc4.Kernel
{
	[EntityName("IFCRELASSIGNSTOACTOR")]
	public  partial class @IfcRelAssignsToActor : IfcRelAssigns, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelAssignsToActor(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcActor _relatingActor;
		private IfcActorRole _actingRole;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(6, EntityAttributeState.Mandatory)]
		public IfcActor @RelatingActor 
		{ 
			get 
			{
				if(IsActivated) return _relatingActor;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _relatingActor;
			} 
			set
			{
				SetValue( v =>  _relatingActor = v, _relatingActor, value,  "RelatingActor");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Optional)]
		public IfcActorRole @ActingRole 
		{ 
			get 
			{
				if(IsActivated) return _actingRole;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _actingRole;
			} 
			set
			{
				SetValue( v =>  _actingRole = v, _actingRole, value,  "ActingRole");
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
			"RelatedObjectsType",
			"RelatingActor",
			"ActingRole",
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
					return @RelatedObjectsType;
				case 6: 
					return @RelatingActor;
				case 7: 
					return @ActingRole;
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
				case "RelatedObjectsType":  
					return @RelatedObjectsType;
				case "RelatingActor":  
					return @RelatingActor;
				case "ActingRole":  
					return @ActingRole;
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
					 @RelatedObjects.Add((IfcObjectDefinition)value);
					 break;
				case 5:
					 @RelatedObjectsType = (IfcObjectTypeEnum)value;
					 break;
				case 6:
					 @RelatingActor = (IfcActor)value;
					 break;
				case 7:
					 @ActingRole = (IfcActorRole)value;
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
					 @RelatedObjects.Add((IfcObjectDefinition)value);
					 break;
				case "RelatedObjectsType":
					 @RelatedObjectsType = (IfcObjectTypeEnum)value;
					 break;
				case "RelatingActor":
					 @RelatingActor = (IfcActor)value;
					 break;
				case "ActingRole":
					 @ActingRole = (IfcActorRole)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion

		#region Where rules
		/*NoSelfReference:	NoSelfReference : SIZEOF(QUERY(Temp <* SELF\IfcRelAssigns.RelatedObjects | RelatingActor :=: Temp)) = 0;*/
		#endregion

		#region IPersist implementation
		public void Set(int propIndex, IPropertyValue value)
		{
            throw new System.NotImplementedException();
		}
		#endregion

	}
}