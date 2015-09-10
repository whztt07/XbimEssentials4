// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		09/09/2015 04:20:43
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.ExternalReferenceResource;
using Xbim.Ifc4.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc4.PropertyResource
{
	[EntityName("IFCPROPERTYDEPENDENCYRELATIONSHIP", 461)]
	public  partial class @IfcPropertyDependencyRelationship : IfcResourceLevelRelationship, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPropertyDependencyRelationship(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcProperty _dependingProperty;
		private IfcProperty _dependantProperty;
		private IfcText? _expression;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Mandatory)]
		public IfcProperty @DependingProperty 
		{ 
			get 
			{
				if(Activated) return _dependingProperty;
				
				Model.Activate(this, true);
				Activated = true;
				return _dependingProperty;
			} 
			set
			{
				SetValue( v =>  _dependingProperty = v, _dependingProperty, value,  "DependingProperty");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Mandatory)]
		public IfcProperty @DependantProperty 
		{ 
			get 
			{
				if(Activated) return _dependantProperty;
				
				Model.Activate(this, true);
				Activated = true;
				return _dependantProperty;
			} 
			set
			{
				SetValue( v =>  _dependantProperty = v, _dependantProperty, value,  "DependantProperty");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Optional)]
		public IfcText? @Expression 
		{ 
			get 
			{
				if(Activated) return _expression;
				
				Model.Activate(this, true);
				Activated = true;
				return _expression;
			} 
			set
			{
				SetValue( v =>  _expression = v, _expression, value,  "Expression");
			} 
		}
	
		#endregion

		#region Inverse attributes

		#endregion

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"Name",
			"Description",
			"DependingProperty",
			"DependantProperty",
			"Expression",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @Name;
				case 1: 
					return @Description;
				case 2: 
					return @DependingProperty;
				case 3: 
					return @DependantProperty;
				case 4: 
					return @Expression;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "Name":  
					return @Name;
				case "Description":  
					return @Description;
				case "DependingProperty":  
					return @DependingProperty;
				case "DependantProperty":  
					return @DependantProperty;
				case "Expression":  
					return @Expression;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 @Name = (IfcLabel?)value;
					 break;
				case 1:
					 @Description = (IfcText?)value;
					 break;
				case 2:
					 @DependingProperty = (IfcProperty)value;
					 break;
				case 3:
					 @DependantProperty = (IfcProperty)value;
					 break;
				case 4:
					 @Expression = (IfcText?)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "Name":
					 @Name = (IfcLabel?)value;
					 break;
				case "Description":
					 @Description = (IfcText?)value;
					 break;
				case "DependingProperty":
					 @DependingProperty = (IfcProperty)value;
					 break;
				case "DependantProperty":
					 @DependantProperty = (IfcProperty)value;
					 break;
				case "Expression":
					 @Expression = (IfcText?)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion

		#region Where rules
		/*NoSelfReference:	NoSelfReference : DependingProperty :<>: DependantProperty;*/
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