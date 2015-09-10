// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		09/09/2015 04:20:37
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.PresentationDefinitionResource;
using Xbim.Ifc2x3.GeometryResource;
using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.PresentationAppearanceResource;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc2x3.PresentationDimensioningResource
{
	[EntityName("IFCTERMINATORSYMBOL", 743)]
	public  partial class @IfcTerminatorSymbol : IfcAnnotationSymbolOccurrence, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTerminatorSymbol(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcAnnotationCurveOccurrence _annotatedCurve;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(3, EntityAttributeState.Mandatory)]
		public IfcAnnotationCurveOccurrence @AnnotatedCurve 
		{ 
			get 
			{
				if(Activated) return _annotatedCurve;
				
				Model.Activate(this, true);
				Activated = true;
				return _annotatedCurve;
			} 
			set
			{
				SetValue( v =>  _annotatedCurve = v, _annotatedCurve, value,  "AnnotatedCurve");
			} 
		}
	
		#endregion

		#region Inverse attributes

		#endregion

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"Item",
			"Styles",
			"Name",
			"AnnotatedCurve",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @Item;
				case 1: 
					return @Styles;
				case 2: 
					return @Name;
				case 3: 
					return @AnnotatedCurve;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "Item":  
					return @Item;
				case "Styles":  
					return @Styles;
				case "Name":  
					return @Name;
				case "AnnotatedCurve":  
					return @AnnotatedCurve;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 @Item = (IfcRepresentationItem)value;
					 break;
				case 1:
					 @Styles.Add((IfcPresentationStyleAssignment)value);
					 break;
				case 2:
					 @Name = (IfcLabel?)value;
					 break;
				case 3:
					 @AnnotatedCurve = (IfcAnnotationCurveOccurrence)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "Item":
					 @Item = (IfcRepresentationItem)value;
					 break;
				case "Styles":
					 @Styles.Add((IfcPresentationStyleAssignment)value);
					 break;
				case "Name":
					 @Name = (IfcLabel?)value;
					 break;
				case "AnnotatedCurve":
					 @AnnotatedCurve = (IfcAnnotationCurveOccurrence)value;
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