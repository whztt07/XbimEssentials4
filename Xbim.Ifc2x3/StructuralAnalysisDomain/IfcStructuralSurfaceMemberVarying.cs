// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		24.09.2015 10:03:35
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.UtilityResource;
using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.GeometricConstraintResource;
using Xbim.Ifc2x3.RepresentationResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.StructuralAnalysisDomain
{
	[IndexedClass]
	[ExpressType("IFCSTRUCTURALSURFACEMEMBERVARYING", 421)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcStructuralSurfaceMemberVarying : IfcStructuralSurfaceMember, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcStructuralSurfaceMemberVarying(IModel model) : base(model) 		{ 
			Model = model; 
			_subsequentThickness = new ItemSet<IfcPositiveLengthMeasure>( this );
		}

		#region Explicit attribute fields
		private ItemSet<IfcPositiveLengthMeasure> _subsequentThickness;
		private IfcShapeAspect _varyingThicknessLocation;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(10, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.None, 2, -1)]
		public ItemSet<IfcPositiveLengthMeasure> @SubsequentThickness 
		{ 
			get 
			{
				if(Activated) return _subsequentThickness;
				
				Model.Activate(this, true);
				Activated = true;
				return _subsequentThickness;
			} 
		}
	
		[EntityAttribute(11, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcShapeAspect @VaryingThicknessLocation 
		{ 
			get 
			{
				if(Activated) return _varyingThicknessLocation;
				
				Model.Activate(this, true);
				Activated = true;
				return _varyingThicknessLocation;
			} 
			set
			{
				SetValue( v =>  _varyingThicknessLocation = v, _varyingThicknessLocation, value,  "VaryingThicknessLocation");
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
				case 7: 
				case 8: 
					base.Parse(propIndex, value); 
					return;
				case 9: 
					if (_subsequentThickness == null) _subsequentThickness = new ItemSet<IfcPositiveLengthMeasure>( this );
					_subsequentThickness.InternalAdd(value.RealVal);
					return;
				case 10: 
					_varyingThicknessLocation = (IfcShapeAspect)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR61:	WR61 : EXISTS(SELF\IfcStructuralSurfaceMember.Thickness);*/
		/*WR62:               )) = 0;*/
		/*WR63:               )) = 0;*/
		}
		#endregion
	}
}