// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		15.09.2015 07:03:40
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Kernel;
using Xbim.Ifc4.UtilityResource;
using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.GeometricConstraintResource;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc4.ProductExtension
{
	[EntityName("IFCRELINTERFERESELEMENTS", 547)]
	public  partial class @IfcRelInterferesElements : IfcRelConnects, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelInterferesElements(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcElement _relatingElement;
		private IfcElement _relatedElement;
		private IfcConnectionGeometry _interferenceGeometry;
		private IfcIdentifier? _interferenceType;
		private bool? _impliedOrder;
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
		public IfcElement @RelatedElement 
		{ 
			get 
			{
				if(Activated) return _relatedElement;
				
				Model.Activate(this, true);
				Activated = true;
				return _relatedElement;
			} 
			set
			{
				SetValue( v =>  _relatedElement = v, _relatedElement, value,  "RelatedElement");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Optional)]
		public IfcConnectionGeometry @InterferenceGeometry 
		{ 
			get 
			{
				if(Activated) return _interferenceGeometry;
				
				Model.Activate(this, true);
				Activated = true;
				return _interferenceGeometry;
			} 
			set
			{
				SetValue( v =>  _interferenceGeometry = v, _interferenceGeometry, value,  "InterferenceGeometry");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Optional)]
		public IfcIdentifier? @InterferenceType 
		{ 
			get 
			{
				if(Activated) return _interferenceType;
				
				Model.Activate(this, true);
				Activated = true;
				return _interferenceType;
			} 
			set
			{
				SetValue( v =>  _interferenceType = v, _interferenceType, value,  "InterferenceType");
			} 
		}
	
		[EntityAttribute(8, EntityAttributeState.Mandatory)]
		public bool? @ImpliedOrder 
		{ 
			get 
			{
				if(Activated) return _impliedOrder;
				
				Model.Activate(this, true);
				Activated = true;
				return _impliedOrder;
			} 
			set
			{
				SetValue( v =>  _impliedOrder = v, _impliedOrder, value,  "ImpliedOrder");
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
			"RelatedElement",
			"InterferenceGeometry",
			"InterferenceType",
			"ImpliedOrder",
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
					return @RelatedElement;
				case 6: 
					return @InterferenceGeometry;
				case 7: 
					return @InterferenceType;
				case 8: 
					return @ImpliedOrder;
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
				case "RelatedElement":  
					return @RelatedElement;
				case "InterferenceGeometry":  
					return @InterferenceGeometry;
				case "InterferenceType":  
					return @InterferenceType;
				case "ImpliedOrder":  
					return @ImpliedOrder;
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
					 @RelatedElement = (IfcElement)value;
					 break;
				case 6:
					 @InterferenceGeometry = (IfcConnectionGeometry)value;
					 break;
				case 7:
					 @InterferenceType = (IfcIdentifier?)value;
					 break;
				case 8:
					 @ImpliedOrder = (bool?)value;
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
				case "RelatedElement":
					 @RelatedElement = (IfcElement)value;
					 break;
				case "InterferenceGeometry":
					 @InterferenceGeometry = (IfcConnectionGeometry)value;
					 break;
				case "InterferenceType":
					 @InterferenceType = (IfcIdentifier?)value;
					 break;
				case "ImpliedOrder":
					 @ImpliedOrder = (bool?)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion

		#region Where rules
		/*NotSelfReference:	NotSelfReference : RelatingElement :<>: RelatedElement;*/
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