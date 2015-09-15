// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		15.09.2015 07:03:40
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.UtilityResource;
using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.GeometricConstraintResource;
using Xbim.Ifc4.RepresentationResource;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc4.Kernel
{
	[EntityName("IFCPROXY", 477)]
	public  partial class @IfcProxy : IfcProduct, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcProxy(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcObjectTypeEnum _proxyType;
		private IfcLabel? _tag;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(7, EntityAttributeState.Mandatory)]
		public IfcObjectTypeEnum @ProxyType 
		{ 
			get 
			{
				if(Activated) return _proxyType;
				
				Model.Activate(this, true);
				Activated = true;
				return _proxyType;
			} 
			set
			{
				SetValue( v =>  _proxyType = v, _proxyType, value,  "ProxyType");
			} 
		}
	
		[EntityAttribute(8, EntityAttributeState.Optional)]
		public IfcLabel? @Tag 
		{ 
			get 
			{
				if(Activated) return _tag;
				
				Model.Activate(this, true);
				Activated = true;
				return _tag;
			} 
			set
			{
				SetValue( v =>  _tag = v, _tag, value,  "Tag");
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
			"ObjectPlacement",
			"Representation",
			"ProxyType",
			"Tag",
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
					return @ObjectPlacement;
				case 6: 
					return @Representation;
				case 7: 
					return @ProxyType;
				case 8: 
					return @Tag;
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
				case "ObjectPlacement":  
					return @ObjectPlacement;
				case "Representation":  
					return @Representation;
				case "ProxyType":  
					return @ProxyType;
				case "Tag":  
					return @Tag;
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
					 @ObjectPlacement = (IfcObjectPlacement)value;
					 break;
				case 6:
					 @Representation = (IfcProductRepresentation)value;
					 break;
				case 7:
					 if (value != null) @ProxyType = (IfcObjectTypeEnum)value;
					 break;
				case 8:
					 @Tag = (IfcLabel?)value;
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
				case "ObjectPlacement":
					 @ObjectPlacement = (IfcObjectPlacement)value;
					 break;
				case "Representation":
					 @Representation = (IfcProductRepresentation)value;
					 break;
				case "ProxyType":
					 if (value != null) @ProxyType = (IfcObjectTypeEnum)value;
					 break;
				case "Tag":
					 @Tag = (IfcLabel?)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion

		#region Where rules
		/*WR1:	WR1 : EXISTS(SELF\IfcRoot.Name);*/
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