// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		15.09.2015 07:04:18
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.Kernel;
using Xbim.Ifc2x3.UtilityResource;
using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.ConstraintResource;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc2x3.ControlExtension
{
	[EntityName("IFCRELASSOCIATESCONSTRAINT", 711)]
	public  partial class @IfcRelAssociatesConstraint : IfcRelAssociates, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelAssociatesConstraint(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcLabel _intent;
		private IfcConstraint _relatingConstraint;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(5, EntityAttributeState.Mandatory)]
		public IfcLabel @Intent 
		{ 
			get 
			{
				if(Activated) return _intent;
				
				Model.Activate(this, true);
				Activated = true;
				return _intent;
			} 
			set
			{
				SetValue( v =>  _intent = v, _intent, value,  "Intent");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Mandatory)]
		public IfcConstraint @RelatingConstraint 
		{ 
			get 
			{
				if(Activated) return _relatingConstraint;
				
				Model.Activate(this, true);
				Activated = true;
				return _relatingConstraint;
			} 
			set
			{
				SetValue( v =>  _relatingConstraint = v, _relatingConstraint, value,  "RelatingConstraint");
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
			"Intent",
			"RelatingConstraint",
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
					return @Intent;
				case 6: 
					return @RelatingConstraint;
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
				case "Intent":  
					return @Intent;
				case "RelatingConstraint":  
					return @RelatingConstraint;
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
					 if (value != null) @Intent = (IfcLabel)value;
					 break;
				case 6:
					 @RelatingConstraint = (IfcConstraint)value;
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
				case "Intent":
					 if (value != null) @Intent = (IfcLabel)value;
					 break;
				case "RelatingConstraint":
					 @RelatingConstraint = (IfcConstraint)value;
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