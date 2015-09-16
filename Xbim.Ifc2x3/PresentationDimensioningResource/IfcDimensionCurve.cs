// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		16.09.2015 10:12:18
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
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.PresentationDimensioningResource
{
	[EntityName("IFCDIMENSIONCURVE", 742)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcDimensionCurve : IfcAnnotationCurveOccurrence, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcDimensionCurve(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		#endregion
	
		#region Explicit attribute properties
		#endregion

		#region Inverse attributes
		public IEnumerable<IfcTerminatorSymbol> @AnnotatedBySymbols 
		{ 
			get 
			{
				return Model.Instances.Where<IfcTerminatorSymbol>(e => e.AnnotatedCurve == this);
			} 
		}
	

		#endregion

		#region Index access
		private static readonly List<string> AttributeNames = new List<string>
		{
			"Item",
			"Styles",
			"Name",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return AttributeNames; } }

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
					base.Parse(propIndex, value); 
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR51:                   >= 1;*/
		/*WR52:                            'IFCTERMINATORSYMBOL.ANNOTATEDCURVE') | (Dct2.Role = IfcDimensionExtentUsage.TARGET))) <= 1);*/
		/*WR53:               = 0;*/
		}
		#endregion

		
	}
}