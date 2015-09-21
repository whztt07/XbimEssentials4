// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		21.09.2015 05:11:12
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.Kernel;
using Xbim.Ifc2x3.UtilityResource;
using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.GeometricConstraintResource;
using Xbim.Ifc2x3.RepresentationResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.ProductExtension
{
	[IndexedClass]
	[ExpressType("IFCGRID", 564)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcGrid : IfcProduct, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcGrid(IModel model) : base(model) 		{ 
			Model = model; 
			_uAxes = new ItemSet<IfcGridAxis>( this );
			_vAxes = new ItemSet<IfcGridAxis>( this );
			_wAxes = new OptionalItemSet<IfcGridAxis>( this );
		}

		#region Explicit attribute fields
		private ItemSet<IfcGridAxis> _uAxes;
		private ItemSet<IfcGridAxis> _vAxes;
		private OptionalItemSet<IfcGridAxis> _wAxes;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(8, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.Class, 1, -1)]
		public ItemSet<IfcGridAxis> @UAxes 
		{ 
			get 
			{
				if(Activated) return _uAxes;
				
				Model.Activate(this, true);
				Activated = true;
				return _uAxes;
			} 
		}
	
		[IndexedProperty]
		[EntityAttribute(9, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.Class, 1, -1)]
		public ItemSet<IfcGridAxis> @VAxes 
		{ 
			get 
			{
				if(Activated) return _vAxes;
				
				Model.Activate(this, true);
				Activated = true;
				return _vAxes;
			} 
		}
	
		[IndexedProperty]
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.Class, 1, -1)]
		public OptionalItemSet<IfcGridAxis> @WAxes 
		{ 
			get 
			{
				if(Activated) return _wAxes;
				
				Model.Activate(this, true);
				Activated = true;
				return _wAxes;
			} 
		}
	
		#endregion

		#region Inverse attributes
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcRelContainedInSpatialStructure> @ContainedInStructure 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelContainedInSpatialStructure>(e => e.RelatedElements != null &&  e.RelatedElements.Contains(this));
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
				case 4: 
				case 5: 
				case 6: 
					base.Parse(propIndex, value); 
					return;
				case 7: 
					if (_uAxes == null) _uAxes = new ItemSet<IfcGridAxis>( this );
					_uAxes.InternalAdd((IfcGridAxis)value.EntityVal);
					return;
				case 8: 
					if (_vAxes == null) _vAxes = new ItemSet<IfcGridAxis>( this );
					_vAxes.InternalAdd((IfcGridAxis)value.EntityVal);
					return;
				case 9: 
					if (_wAxes == null) _wAxes = new OptionalItemSet<IfcGridAxis>( this );
					_wAxes.InternalAdd((IfcGridAxis)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR41:	WR41 : EXISTS(SELF\IfcProduct.ObjectPlacement);*/
		}
		#endregion
	}
}