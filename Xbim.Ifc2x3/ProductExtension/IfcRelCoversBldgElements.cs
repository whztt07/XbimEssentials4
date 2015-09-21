// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		21.09.2015 05:11:13
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.Kernel;
using Xbim.Ifc2x3.UtilityResource;
using Xbim.Ifc2x3.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.ProductExtension
{
	[IndexedClass]
	[ExpressType("IFCRELCOVERSBLDGELEMENTS", 24)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRelCoversBldgElements : IfcRelConnects, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelCoversBldgElements(IModel model) : base(model) 		{ 
			Model = model; 
			_relatedCoverings = new ItemSet<IfcCovering>( this );
		}

		#region Explicit attribute fields
		private IfcElement _relatingBuildingElement;
		private ItemSet<IfcCovering> _relatedCoverings;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcElement @RelatingBuildingElement 
		{ 
			get 
			{
				if(Activated) return _relatingBuildingElement;
				
				Model.Activate(this, true);
				Activated = true;
				return _relatingBuildingElement;
			} 
			set
			{
				SetValue( v =>  _relatingBuildingElement = v, _relatingBuildingElement, value,  "RelatingBuildingElement");
			} 
		}
	
		[IndexedProperty]
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1)]
		public ItemSet<IfcCovering> @RelatedCoverings 
		{ 
			get 
			{
				if(Activated) return _relatedCoverings;
				
				Model.Activate(this, true);
				Activated = true;
				return _relatedCoverings;
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
					_relatingBuildingElement = (IfcElement)(value.EntityVal);
					return;
				case 5: 
					if (_relatedCoverings == null) _relatedCoverings = new ItemSet<IfcCovering>( this );
					_relatedCoverings.InternalAdd((IfcCovering)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
			return "";
		}
		#endregion
	}
}