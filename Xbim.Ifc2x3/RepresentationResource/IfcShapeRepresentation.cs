// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 02:29:15
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.GeometryResource;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc2x3.RepresentationResource
{
	[EntityName("IFCSHAPEREPRESENTATION", 511)]
	public  partial class @IfcShapeRepresentation : IfcShapeModel, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcShapeRepresentation(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		#endregion
	
		#region Explicit attribute properties
		#endregion

		#region Inverse attributes

		#endregion

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"ContextOfItems",
			"RepresentationIdentifier",
			"RepresentationType",
			"Items",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @ContextOfItems;
				case 1: 
					return @RepresentationIdentifier;
				case 2: 
					return @RepresentationType;
				case 3: 
					return @Items;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "ContextOfItems":  
					return @ContextOfItems;
				case "RepresentationIdentifier":  
					return @RepresentationIdentifier;
				case "RepresentationType":  
					return @RepresentationType;
				case "Items":  
					return @Items;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 @ContextOfItems = (IfcRepresentationContext)value;
					 break;
				case 1:
					 @RepresentationIdentifier = (IfcLabel?)value;
					 break;
				case 2:
					 @RepresentationType = (IfcLabel?)value;
					 break;
				case 3:
					 @Items.Add((IfcRepresentationItem)value);
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "ContextOfItems":
					 @ContextOfItems = (IfcRepresentationContext)value;
					 break;
				case "RepresentationIdentifier":
					 @RepresentationIdentifier = (IfcLabel?)value;
					 break;
				case "RepresentationType":
					 @RepresentationType = (IfcLabel?)value;
					 break;
				case "Items":
					 @Items.Add((IfcRepresentationItem)value);
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion

		#region Where rules
		/*WR21:             IN TYPEOF(SELF\IfcRepresentation.ContextOfItems);*/
		/*WR22:             )) = 0;*/
		/*WR23:	WR23 : EXISTS(SELF\IfcRepresentation.RepresentationType);*/
		/*WR24:	WR24 : IfcShapeRepresentationTypes(SELF\IfcRepresentation.RepresentationType, SELF\IfcRepresentation.Items);*/
		#endregion

		#region IPersist implementation
		void IPersist.Set(int propIndex, IPropertyValue value)
		{
            throw new System.NotImplementedException();
		}
		#endregion

	}
}