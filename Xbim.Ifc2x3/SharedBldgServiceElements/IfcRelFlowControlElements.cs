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
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc2x3.SharedBldgServiceElements
{
	[EntityName("IFCRELFLOWCONTROLELEMENTS")]
	public  partial class @IfcRelFlowControlElements : IfcRelConnects, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelFlowControlElements(IModel model) : base(model) 		{ 
			Model = model; 
			_relatedControlElements = new ItemSet<IfcDistributionControlElement>( model );
		}

		#region Explicit attribute fields
		private ItemSet<IfcDistributionControlElement> _relatedControlElements;
		private IfcDistributionFlowElement _relatingFlowElement;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Mandatory)]
		public ItemSet<IfcDistributionControlElement> @RelatedControlElements 
		{ 
			get 
			{
				if(IsActivated) return _relatedControlElements;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _relatedControlElements;
			} 
			set
			{
				SetValue( v =>  _relatedControlElements = v, _relatedControlElements, value,  "RelatedControlElements");
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Mandatory)]
		public IfcDistributionFlowElement @RelatingFlowElement 
		{ 
			get 
			{
				if(IsActivated) return _relatingFlowElement;
				
				Model.Activate(this, true);
				IsActivated = true;
				return _relatingFlowElement;
			} 
			set
			{
				SetValue( v =>  _relatingFlowElement = v, _relatingFlowElement, value,  "RelatingFlowElement");
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
			"RelatedControlElements",
			"RelatingFlowElement",
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
					return @RelatedControlElements;
				case 5: 
					return @RelatingFlowElement;
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
				case "RelatedControlElements":  
					return @RelatedControlElements;
				case "RelatingFlowElement":  
					return @RelatingFlowElement;
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
					 @RelatedControlElements.Add((IfcDistributionControlElement)value);
					 break;
				case 5:
					 @RelatingFlowElement = (IfcDistributionFlowElement)value;
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
				case "RelatedControlElements":
					 @RelatedControlElements.Add((IfcDistributionControlElement)value);
					 break;
				case "RelatingFlowElement":
					 @RelatingFlowElement = (IfcDistributionFlowElement)value;
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