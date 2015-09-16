// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		16.09.2015 04:23:00
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.GeometryResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.RepresentationResource
{
	[EntityName("IFCSHAPEREPRESENTATION", 664)]
	// ReSharper disable once PartialTypeWithSinglePart
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
		private static readonly List<string> AttributeNames = new List<string>
		{
			"ContextOfItems",
			"RepresentationIdentifier",
			"RepresentationType",
			"Items",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return AttributeNames; } }

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



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
				case 3: 
					base.Parse(propIndex, value); 
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR21:             IN TYPEOF(SELF\IfcRepresentation.ContextOfItems);*/
		/*WR22:             )) = 0;*/
		/*WR23:	WR23 : EXISTS(SELF\IfcRepresentation.RepresentationType);*/
		/*WR24:	WR24 : IfcShapeRepresentationTypes(SELF\IfcRepresentation.RepresentationType, SELF\IfcRepresentation.Items);*/
		}
		#endregion

		
	}
}