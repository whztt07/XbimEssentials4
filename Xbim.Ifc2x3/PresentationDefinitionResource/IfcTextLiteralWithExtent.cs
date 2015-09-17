// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 10:21:01
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.PresentationResource;
using Xbim.Ifc2x3.GeometryResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.PresentationDefinitionResource
{
	[EntityName("IFCTEXTLITERALWITHEXTENT", 426)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcTextLiteralWithExtent : IfcTextLiteral, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTextLiteralWithExtent(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcPlanarExtent _extent;
		private IfcBoxAlignment _boxAlignment;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(3, EntityAttributeState.Mandatory)]
		public IfcPlanarExtent @Extent 
		{ 
			get 
			{
				if(Activated) return _extent;
				
				Model.Activate(this, true);
				Activated = true;
				return _extent;
			} 
			set
			{
				SetValue( v =>  _extent = v, _extent, value,  "Extent");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Mandatory)]
		public IfcBoxAlignment @BoxAlignment 
		{ 
			get 
			{
				if(Activated) return _boxAlignment;
				
				Model.Activate(this, true);
				Activated = true;
				return _boxAlignment;
			} 
			set
			{
				SetValue( v =>  _boxAlignment = v, _boxAlignment, value,  "BoxAlignment");
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
					base.Parse(propIndex, value); 
					return;
				case 3: 
					_extent = (IfcPlanarExtent)(value.EntityVal);
					return;
				case 4: 
					_boxAlignment = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR31:	WR31 : NOT('IFC2X3.IFCPLANARBOX' IN TYPEOF(Extent));*/
		}
		#endregion
	}
}