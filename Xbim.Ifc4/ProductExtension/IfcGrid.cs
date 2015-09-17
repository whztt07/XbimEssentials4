// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 03:44:05
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Kernel;
using Xbim.Ifc4.UtilityResource;
using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.GeometricConstraintResource;
using Xbim.Ifc4.RepresentationResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.ProductExtension
{
	[EntityName("IFCGRID", 305)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcGrid : IfcProduct, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcGrid(IModel model) : base(model) 		{ 
			Model = model; 
			_uAxes = new ItemSet<IfcGridAxis>( this );
			_vAxes = new ItemSet<IfcGridAxis>( this );
			_wAxes = new ItemSet<IfcGridAxis>( this );
		}

		#region Explicit attribute fields
		private ItemSet<IfcGridAxis> _uAxes;
		private ItemSet<IfcGridAxis> _vAxes;
		private ItemSet<IfcGridAxis> _wAxes;
		private IfcGridTypeEnum? _predefinedType;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(7, EntityAttributeState.Mandatory)]
		public ItemSet<IfcGridAxis> @UAxes 
		{ 
			get 
			{
				if(Activated) return _uAxes;
				
				Model.Activate(this, true);
				Activated = true;
				return _uAxes;
			} 
			set
			{
				SetValue( v =>  _uAxes = v, _uAxes, value,  "UAxes");
			} 
		}
	
		[EntityAttribute(8, EntityAttributeState.Mandatory)]
		public ItemSet<IfcGridAxis> @VAxes 
		{ 
			get 
			{
				if(Activated) return _vAxes;
				
				Model.Activate(this, true);
				Activated = true;
				return _vAxes;
			} 
			set
			{
				SetValue( v =>  _vAxes = v, _vAxes, value,  "VAxes");
			} 
		}
	
		[EntityAttribute(9, EntityAttributeState.Optional)]
		public ItemSet<IfcGridAxis> @WAxes 
		{ 
			get 
			{
				if(Activated) return _wAxes;
				
				Model.Activate(this, true);
				Activated = true;
				return _wAxes;
			} 
			set
			{
				SetValue( v =>  _wAxes = v, _wAxes, value,  "WAxes");
			} 
		}
	
		[EntityAttribute(10, EntityAttributeState.Optional)]
		public IfcGridTypeEnum? @PredefinedType 
		{ 
			get 
			{
				if(Activated) return _predefinedType;
				
				Model.Activate(this, true);
				Activated = true;
				return _predefinedType;
			} 
			set
			{
				SetValue( v =>  _predefinedType = v, _predefinedType, value,  "PredefinedType");
			} 
		}
	
		#endregion

		#region Inverse attributes
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
					if (_wAxes == null) _wAxes = new ItemSet<IfcGridAxis>( this );
					_wAxes.InternalAdd((IfcGridAxis)value.EntityVal);
					return;
				case 10: 
                    _predefinedType = (IfcGridTypeEnum) System.Enum.Parse(typeof (IfcGridTypeEnum), value.EnumVal, true);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*HasPlacement:	HasPlacement : EXISTS(SELF\IfcProduct.ObjectPlacement);*/
		}
		#endregion
	}
}