// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 10:21:10
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Kernel;
using Xbim.Ifc4.UtilityResource;
using Xbim.Ifc4.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.ProductExtension
{
	[EntityName("IFCRELCONTAINEDINSPATIALSTRUCTURE", 535)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRelContainedInSpatialStructure : IfcRelConnects, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelContainedInSpatialStructure(IModel model) : base(model) 		{ 
			Model = model; 
			_relatedElements = new ItemSet<IfcProduct>( this );
		}

		#region Explicit attribute fields
		private ItemSet<IfcProduct> _relatedElements;
		private IfcSpatialElement _relatingStructure;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Mandatory)]
		public ItemSet<IfcProduct> @RelatedElements 
		{ 
			get 
			{
				if(Activated) return _relatedElements;
				
				Model.Activate(this, true);
				Activated = true;
				return _relatedElements;
			} 
			set
			{
				SetValue( v =>  _relatedElements = v, _relatedElements, value,  "RelatedElements");
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Mandatory)]
		public IfcSpatialElement @RelatingStructure 
		{ 
			get 
			{
				if(Activated) return _relatingStructure;
				
				Model.Activate(this, true);
				Activated = true;
				return _relatingStructure;
			} 
			set
			{
				SetValue( v =>  _relatingStructure = v, _relatingStructure, value,  "RelatingStructure");
			} 
		}
	
		#endregion

		#region Inverse attributes

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
				case 4: 
					if (_relatedElements == null) _relatedElements = new ItemSet<IfcProduct>( this );
					_relatedElements.InternalAdd((IfcProduct)value.EntityVal);
					return;
				case 5: 
					_relatingStructure = (IfcSpatialElement)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR31:	WR31 : SIZEOF(QUERY(temp <* RelatedElements | 'IFC4.IFCSPATIALSTRUCTUREELEMENT' IN TYPEOF(temp))) = 0;*/
		}
		#endregion
	}
}