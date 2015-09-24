// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.ProfileResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.ProfilePropertyResource
{
	[IndexedClass]
	[ExpressType("IFCSTRUCTURALSTEELPROFILEPROPERTIES", 692)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcStructuralSteelProfileProperties : IfcStructuralProfileProperties, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcStructuralSteelProfileProperties(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcAreaMeasure? _shearAreaZ;
		private IfcAreaMeasure? _shearAreaY;
		private IfcPositiveRatioMeasure? _plasticShapeFactorY;
		private IfcPositiveRatioMeasure? _plasticShapeFactorZ;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(24, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcAreaMeasure? @ShearAreaZ 
		{ 
			get 
			{
				if(Activated) return _shearAreaZ;
				
				Model.Activate(this, true);
				Activated = true;
				return _shearAreaZ;
			} 
			set
			{
				SetValue( v =>  _shearAreaZ = v, _shearAreaZ, value,  "ShearAreaZ");
			} 
		}
	
		[EntityAttribute(25, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcAreaMeasure? @ShearAreaY 
		{ 
			get 
			{
				if(Activated) return _shearAreaY;
				
				Model.Activate(this, true);
				Activated = true;
				return _shearAreaY;
			} 
			set
			{
				SetValue( v =>  _shearAreaY = v, _shearAreaY, value,  "ShearAreaY");
			} 
		}
	
		[EntityAttribute(26, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveRatioMeasure? @PlasticShapeFactorY 
		{ 
			get 
			{
				if(Activated) return _plasticShapeFactorY;
				
				Model.Activate(this, true);
				Activated = true;
				return _plasticShapeFactorY;
			} 
			set
			{
				SetValue( v =>  _plasticShapeFactorY = v, _plasticShapeFactorY, value,  "PlasticShapeFactorY");
			} 
		}
	
		[EntityAttribute(27, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveRatioMeasure? @PlasticShapeFactorZ 
		{ 
			get 
			{
				if(Activated) return _plasticShapeFactorZ;
				
				Model.Activate(this, true);
				Activated = true;
				return _plasticShapeFactorZ;
			} 
			set
			{
				SetValue( v =>  _plasticShapeFactorZ = v, _plasticShapeFactorZ, value,  "PlasticShapeFactorZ");
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
				case 12: 
				case 13: 
				case 14: 
				case 15: 
				case 16: 
				case 17: 
				case 18: 
				case 19: 
				case 20: 
				case 21: 
				case 22: 
					base.Parse(propIndex, value); 
					return;
				case 23: 
					_shearAreaZ = value.RealVal;
					return;
				case 24: 
					_shearAreaY = value.RealVal;
					return;
				case 25: 
					_plasticShapeFactorY = value.RealVal;
					return;
				case 26: 
					_plasticShapeFactorZ = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR31:	WR31 : NOT(EXISTS(ShearAreaY)) OR (ShearAreaY >= 0.);*/
		/*WR32:	WR32 : NOT(EXISTS(ShearAreaZ)) OR (ShearAreaZ >= 0.);*/
		}
		#endregion
	}
}