// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		24.09.2015 10:03:44
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.StructuralLoadResource
{
	[IndexedClass]
	[ExpressType("IFCSURFACEREINFORCEMENTAREA", 1058)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcSurfaceReinforcementArea : IfcStructuralLoadOrResult, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcSurfaceReinforcementArea(IModel model) : base(model) 		{ 
			Model = model; 
			_surfaceReinforcement1 = new OptionalItemSet<IfcLengthMeasure>( this );
			_surfaceReinforcement2 = new OptionalItemSet<IfcLengthMeasure>( this );
		}

		#region Explicit attribute fields
		private OptionalItemSet<IfcLengthMeasure> _surfaceReinforcement1;
		private OptionalItemSet<IfcLengthMeasure> _surfaceReinforcement2;
		private IfcRatioMeasure? _shearReinforcement;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.None, 2, 3)]
		public OptionalItemSet<IfcLengthMeasure> @SurfaceReinforcement1 
		{ 
			get 
			{
				if(Activated) return _surfaceReinforcement1;
				
				Model.Activate(this, true);
				Activated = true;
				return _surfaceReinforcement1;
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.None, 2, 3)]
		public OptionalItemSet<IfcLengthMeasure> @SurfaceReinforcement2 
		{ 
			get 
			{
				if(Activated) return _surfaceReinforcement2;
				
				Model.Activate(this, true);
				Activated = true;
				return _surfaceReinforcement2;
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcRatioMeasure? @ShearReinforcement 
		{ 
			get 
			{
				if(Activated) return _shearReinforcement;
				
				Model.Activate(this, true);
				Activated = true;
				return _shearReinforcement;
			} 
			set
			{
				SetValue( v =>  _shearReinforcement = v, _shearReinforcement, value,  "ShearReinforcement");
			} 
		}
	
		#endregion



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
					base.Parse(propIndex, value); 
					return;
				case 1: 
					if (_surfaceReinforcement1 == null) _surfaceReinforcement1 = new OptionalItemSet<IfcLengthMeasure>( this );
					_surfaceReinforcement1.InternalAdd(value.RealVal);
					return;
				case 2: 
					if (_surfaceReinforcement2 == null) _surfaceReinforcement2 = new OptionalItemSet<IfcLengthMeasure>( this );
					_surfaceReinforcement2.InternalAdd(value.RealVal);
					return;
				case 3: 
					_shearReinforcement = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*SurfaceAndOrShearAreaSpecified:	SurfaceAndOrShearAreaSpecified : EXISTS(SurfaceReinforcement1) OR EXISTS(SurfaceReinforcement2) OR EXISTS(ShearReinforcement);*/
		/*NonnegativeArea1:                                       );*/
		/*NonnegativeArea2:                                       );*/
		/*NonnegativeArea3:	NonnegativeArea3 : (NOT EXISTS(ShearReinforcement)) OR (ShearReinforcement >= 0.);*/
		}
		#endregion
	}
}