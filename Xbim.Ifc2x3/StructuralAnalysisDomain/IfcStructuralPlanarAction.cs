// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 03:43:57
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.UtilityResource;
using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.GeometricConstraintResource;
using Xbim.Ifc2x3.RepresentationResource;
using Xbim.Ifc2x3.StructuralLoadResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.StructuralAnalysisDomain
{
	[EntityName("IFCSTRUCTURALPLANARACTION", 39)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcStructuralPlanarAction : IfcStructuralAction, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcStructuralPlanarAction(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcProjectedOrTrueLengthEnum _projectedOrTrue;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(11, EntityAttributeState.Mandatory)]
		public IfcProjectedOrTrueLengthEnum @ProjectedOrTrue 
		{ 
			get 
			{
				if(Activated) return _projectedOrTrue;
				
				Model.Activate(this, true);
				Activated = true;
				return _projectedOrTrue;
			} 
			set
			{
				SetValue( v =>  _projectedOrTrue = v, _projectedOrTrue, value,  "ProjectedOrTrue");
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
				case 4: 
				case 5: 
				case 6: 
				case 7: 
				case 8: 
				case 9: 
				case 10: 
					base.Parse(propIndex, value); 
					return;
				case 11: 
                    _projectedOrTrue = (IfcProjectedOrTrueLengthEnum) System.Enum.Parse(typeof (IfcProjectedOrTrueLengthEnum), value.EnumVal, true);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR61:             * TYPEOF(SELF\IfcStructuralActivity.AppliedLoad)) = 1;*/
		}
		#endregion
	}
}