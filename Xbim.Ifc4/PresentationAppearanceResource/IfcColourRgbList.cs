// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		15.09.2015 07:03:37
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.PresentationDefinitionResource;
using Xbim.Ifc4.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc4.PresentationAppearanceResource
{
	[EntityName("IFCCOLOURRGBLIST", 100)]
	public  partial class @IfcColourRgbList : IfcPresentationItem, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcColourRgbList(IModel model) : base(model) 		{ 
			Model = model; 
			_colourList = new ItemSet<ItemSet<IfcNormalisedRatioMeasure>>( model );
		}

		#region Explicit attribute fields
		private ItemSet<ItemSet<IfcNormalisedRatioMeasure>> _colourList;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(0, EntityAttributeState.Mandatory)]
		public ItemSet<ItemSet<IfcNormalisedRatioMeasure>> @ColourList 
		{ 
			get 
			{
				if(Activated) return _colourList;
				
				Model.Activate(this, true);
				Activated = true;
				return _colourList;
			} 
			set
			{
				SetValue( v =>  _colourList = v, _colourList, value,  "ColourList");
			} 
		}
	
		#endregion

		#region Inverse attributes

		#endregion

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"ColourList",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @ColourList;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "ColourList":  
					return @ColourList;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 @ColourList = (ItemSet<ItemSet<IfcNormalisedRatioMeasure>>)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "ColourList":
					 @ColourList = (ItemSet<ItemSet<IfcNormalisedRatioMeasure>>)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
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