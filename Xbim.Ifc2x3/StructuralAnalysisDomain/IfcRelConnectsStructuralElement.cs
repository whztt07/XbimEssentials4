// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		09/09/2015 04:20:36
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.Kernel;
using Xbim.Ifc2x3.UtilityResource;
using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.ProductExtension;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc2x3.StructuralAnalysisDomain
{
	[EntityName("IFCRELCONNECTSSTRUCTURALELEMENT", 413)]
	public  partial class @IfcRelConnectsStructuralElement : IfcRelConnects, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelConnectsStructuralElement(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcElement _relatingElement;
		private IfcStructuralMember _relatedStructuralMember;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Mandatory)]
		public IfcElement @RelatingElement 
		{ 
			get 
			{
				if(Activated) return _relatingElement;
				
				Model.Activate(this, true);
				Activated = true;
				return _relatingElement;
			} 
			set
			{
				SetValue( v =>  _relatingElement = v, _relatingElement, value,  "RelatingElement");
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Mandatory)]
		public IfcStructuralMember @RelatedStructuralMember 
		{ 
			get 
			{
				if(Activated) return _relatedStructuralMember;
				
				Model.Activate(this, true);
				Activated = true;
				return _relatedStructuralMember;
			} 
			set
			{
				SetValue( v =>  _relatedStructuralMember = v, _relatedStructuralMember, value,  "RelatedStructuralMember");
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
			"RelatingElement",
			"RelatedStructuralMember",
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
					return @RelatingElement;
				case 5: 
					return @RelatedStructuralMember;
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
				case "RelatingElement":  
					return @RelatingElement;
				case "RelatedStructuralMember":  
					return @RelatedStructuralMember;
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
					 @RelatingElement = (IfcElement)value;
					 break;
				case 5:
					 @RelatedStructuralMember = (IfcStructuralMember)value;
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
				case "RelatingElement":
					 @RelatingElement = (IfcElement)value;
					 break;
				case "RelatedStructuralMember":
					 @RelatedStructuralMember = (IfcStructuralMember)value;
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

		public  override string WhereRule() 
		{
			return "";
		}
	}
}