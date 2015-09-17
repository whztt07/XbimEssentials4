// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 10:20:57
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.GeometryResource;
using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.RepresentationResource;
using Xbim.Ifc2x3.PresentationAppearanceResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.PresentationDefinitionResource
{
	[EntityName("IFCANNOTATIONFILLAREAOCCURRENCE", 544)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcAnnotationFillAreaOccurrence : IfcAnnotationOccurrence, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcAnnotationFillAreaOccurrence(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcPoint _fillStyleTarget;
		private IfcGlobalOrLocalEnum? _globalOrLocal;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(3, EntityAttributeState.Optional)]
		public IfcPoint @FillStyleTarget 
		{ 
			get 
			{
				if(Activated) return _fillStyleTarget;
				
				Model.Activate(this, true);
				Activated = true;
				return _fillStyleTarget;
			} 
			set
			{
				SetValue( v =>  _fillStyleTarget = v, _fillStyleTarget, value,  "FillStyleTarget");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Optional)]
		public IfcGlobalOrLocalEnum? @GlobalOrLocal 
		{ 
			get 
			{
				if(Activated) return _globalOrLocal;
				
				Model.Activate(this, true);
				Activated = true;
				return _globalOrLocal;
			} 
			set
			{
				SetValue( v =>  _globalOrLocal = v, _globalOrLocal, value,  "GlobalOrLocal");
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
					_fillStyleTarget = (IfcPoint)(value.EntityVal);
					return;
				case 4: 
                    _globalOrLocal = (IfcGlobalOrLocalEnum) System.Enum.Parse(typeof (IfcGlobalOrLocalEnum), value.EnumVal, true);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR31:             ('IFC2X3.IFCANNOTATIONFILLAREA' IN TYPEOF (SELF\IfcStyledItem.Item));*/
		}
		#endregion
	}
}