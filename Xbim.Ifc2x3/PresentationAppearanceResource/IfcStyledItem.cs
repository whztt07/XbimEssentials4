// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 02:29:15
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.GeometryResource;
using Xbim.Ifc2x3.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc2x3.PresentationAppearanceResource
{
	[EntityName("IFCSTYLEDITEM", 569)]
	public  partial class @IfcStyledItem : IfcRepresentationItem, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcStyledItem(IModel model) : base(model) 		{ 
			Model = model; 
			_styles = new ItemSet<IfcPresentationStyleAssignment>( model );
		}

		#region Explicit attribute fields
		private IfcRepresentationItem _item;
		private ItemSet<IfcPresentationStyleAssignment> _styles;
		private IfcLabel? _name;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(0, EntityAttributeState.Optional)]
		public IfcRepresentationItem @Item 
		{ 
			get 
			{
				if(Activated) return _item;
				
				Model.Activate(this, true);
				Activated = true;
				return _item;
			} 
			set
			{
				SetValue( v =>  _item = v, _item, value,  "Item");
			} 
		}
	
		[EntityAttribute(1, EntityAttributeState.Mandatory)]
		public ItemSet<IfcPresentationStyleAssignment> @Styles 
		{ 
			get 
			{
				if(Activated) return _styles;
				
				Model.Activate(this, true);
				Activated = true;
				return _styles;
			} 
			set
			{
				SetValue( v =>  _styles = v, _styles, value,  "Styles");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Optional)]
		public IfcLabel? @Name 
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

		#endregion

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"Item",
			"Styles",
			"Name",
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

		#region Where rules
		/*WR11:	WR11 : SIZEOF(Styles) = 1;*/
		/*WR12:	WR12 : NOT('IFC2X3.IFCSTYLEDITEM' IN TYPEOF(Item));*/
		#endregion

		#region IPersist implementation
		void IPersist.Set(int propIndex, IPropertyValue value)
		{
            throw new System.NotImplementedException();
		}
		#endregion

	}
}