// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 02:29:20
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.ExternalReferenceResource;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc4.MeasureResource
{
	[EntityName("IFCCONTEXTDEPENDENTUNIT", 135)]
	public  partial class @IfcContextDependentUnit : IfcNamedUnit, IfcResourceObjectSelect, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcContextDependentUnit(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcLabel _name;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Mandatory)]
		public IfcLabel @Name 
		{ 
			get 
			{
				if(Activated) return _name;
				
				Model.Activate(this, true);
				Activated = true;
				return _name;
			} 
			set
			{
				SetValue( v =>  _name = v, _name, value,  "Name");
			} 
		}
	
		#endregion

		#region Inverse attributes
		public IEnumerable<IfcExternalReferenceRelationship> @HasExternalReference 
		{ 
			get 
			{
				return Model.Instances.Where<IfcExternalReferenceRelationship>(e => e.RelatedResourceObjects != null &&  e.RelatedResourceObjects.Contains(this));
			} 
		}
	

		#endregion

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"Dimensions",
			"UnitType",
			"Name",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @Dimensions;
				case 1: 
					return @UnitType;
				case 2: 
					return @Name;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "Dimensions":  
					return @Dimensions;
				case "UnitType":  
					return @UnitType;
				case "Name":  
					return @Name;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 @Dimensions = (IfcDimensionalExponents)value;
					 break;
				case 1:
					 if (value != null) @UnitType = (IfcUnitEnum)value;
					 break;
				case 2:
					 if (value != null) @Name = (IfcLabel)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "Dimensions":
					 @Dimensions = (IfcDimensionalExponents)value;
					 break;
				case "UnitType":
					 if (value != null) @UnitType = (IfcUnitEnum)value;
					 break;
				case "Name":
					 if (value != null) @Name = (IfcLabel)value;
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