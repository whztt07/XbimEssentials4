// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
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
	[ExpressType("IFCSTRUCTURALPLANARACTIONVARYING", 357)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcStructuralPlanarActionVarying : IfcStructuralPlanarAction, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcStructuralPlanarActionVarying(IModel model) : base(model) 		{ 
			Model = model; 
			_subsequentAppliedLoads = new ItemSet<IfcStructuralLoad>( this );
		}

		#region Explicit attribute fields
		private IfcShapeAspect _varyingAppliedLoadLocation;
		private ItemSet<IfcStructuralLoad> _subsequentAppliedLoads;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(13, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcShapeAspect @VaryingAppliedLoadLocation 
		{ 
			get 
			{
				if(Activated) return _varyingAppliedLoadLocation;
				
				Model.Activate(this, true);
				Activated = true;
				return _varyingAppliedLoadLocation;
			} 
			set
			{
				SetValue( v =>  _varyingAppliedLoadLocation = v, _varyingAppliedLoadLocation, value,  "VaryingAppliedLoadLocation");
			} 
		}
	
		[EntityAttribute(14, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.Class, 2, -1)]
		public ItemSet<IfcStructuralLoad> @SubsequentAppliedLoads 
		{ 
			get 
			{
				if(Activated) return _subsequentAppliedLoads;
				
				Model.Activate(this, true);
				Activated = true;
				return _subsequentAppliedLoads;
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
				case 9: 
				case 10: 
				case 11: 
					base.Parse(propIndex, value); 
					return;
				case 12: 
					_varyingAppliedLoadLocation = (IfcShapeAspect)(value.EntityVal);
					return;
				case 13: 
					if (_subsequentAppliedLoads == null) _subsequentAppliedLoads = new ItemSet<IfcStructuralLoad>( this );
					_subsequentAppliedLoads.InternalAdd((IfcStructuralLoad)value.EntityVal);
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