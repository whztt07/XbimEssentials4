// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		15.09.2015 07:04:16
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.MaterialResource;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc2x3.RepresentationResource
{
	[EntityName("IFCMATERIALDEFINITIONREPRESENTATION", 2)]
	public  partial class @IfcMaterialDefinitionRepresentation : IfcProductRepresentation, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcMaterialDefinitionRepresentation(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcMaterial _representedMaterial;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(3, EntityAttributeState.Mandatory)]
		public IfcMaterial @RepresentedMaterial 
		{ 
			get 
			{
				if(Activated) return _representedMaterial;
				
				Model.Activate(this, true);
				Activated = true;
				return _representedMaterial;
			} 
			set
			{
				SetValue( v =>  _representedMaterial = v, _representedMaterial, value,  "RepresentedMaterial");
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
			"Representations",
			"RepresentedMaterial",
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
					return @Representations;
				case 3: 
					return @RepresentedMaterial;
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
				case "Representations":  
					return @Representations;
				case "RepresentedMaterial":  
					return @RepresentedMaterial;
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
					 @Representations.Add((IfcRepresentation)value);
					 break;
				case 3:
					 @RepresentedMaterial = (IfcMaterial)value;
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
				case "Representations":
					 @Representations.Add((IfcRepresentation)value);
					 break;
				case "RepresentedMaterial":
					 @RepresentedMaterial = (IfcMaterial)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion

		#region Where rules
		/*WR11:             )) = 0;*/
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