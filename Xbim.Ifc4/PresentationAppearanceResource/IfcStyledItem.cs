// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		23.09.2015 10:21:52
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.GeometryResource;
using Xbim.Ifc4.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.PresentationAppearanceResource
{
	[IndexedClass]
	[ExpressType("IFCSTYLEDITEM", 1048)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcStyledItem : IfcRepresentationItem, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcStyledItem(IModel model) : base(model) 		{ 
			Model = model; 
			_styles = new ItemSet<IfcStyleAssignmentSelect>( this );
		}

		#region Explicit attribute fields
		private IfcRepresentationItem _item;
		private ItemSet<IfcStyleAssignmentSelect> _styles;
		private IfcLabel? _name;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(1, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
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
	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1)]
		public ItemSet<IfcStyleAssignmentSelect> @Styles 
		{ 
			get 
			{
				if(Activated) return _styles;
				
				Model.Activate(this, true);
				Activated = true;
				return _styles;
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
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



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
					_item = (IfcRepresentationItem)(value.EntityVal);
					return;
				case 1: 
					if (_styles == null) _styles = new ItemSet<IfcStyleAssignmentSelect>( this );
					_styles.InternalAdd((IfcStyleAssignmentSelect)value.EntityVal);
					return;
				case 2: 
					_name = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*ApplicableItem:	ApplicableItem : NOT('IFC4.IFCSTYLEDITEM' IN TYPEOF(Item));*/
		}
		#endregion
	}
}