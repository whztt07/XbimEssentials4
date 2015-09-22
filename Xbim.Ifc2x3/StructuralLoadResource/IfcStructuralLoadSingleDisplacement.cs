// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		22.09.2015 02:31:59
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.StructuralLoadResource
{
	[IndexedClass]
	[ExpressType("IFCSTRUCTURALLOADSINGLEDISPLACEMENT", 289)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcStructuralLoadSingleDisplacement : IfcStructuralLoadStatic, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcStructuralLoadSingleDisplacement(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcLengthMeasure? _displacementX;
		private IfcLengthMeasure? _displacementY;
		private IfcLengthMeasure? _displacementZ;
		private IfcPlaneAngleMeasure? _rotationalDisplacementRX;
		private IfcPlaneAngleMeasure? _rotationalDisplacementRY;
		private IfcPlaneAngleMeasure? _rotationalDisplacementRZ;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLengthMeasure? @DisplacementX 
		{ 
			get 
			{
				if(Activated) return _displacementX;
				
				Model.Activate(this, true);
				Activated = true;
				return _displacementX;
			} 
			set
			{
				SetValue( v =>  _displacementX = v, _displacementX, value,  "DisplacementX");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLengthMeasure? @DisplacementY 
		{ 
			get 
			{
				if(Activated) return _displacementY;
				
				Model.Activate(this, true);
				Activated = true;
				return _displacementY;
			} 
			set
			{
				SetValue( v =>  _displacementY = v, _displacementY, value,  "DisplacementY");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLengthMeasure? @DisplacementZ 
		{ 
			get 
			{
				if(Activated) return _displacementZ;
				
				Model.Activate(this, true);
				Activated = true;
				return _displacementZ;
			} 
			set
			{
				SetValue( v =>  _displacementZ = v, _displacementZ, value,  "DisplacementZ");
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPlaneAngleMeasure? @RotationalDisplacementRX 
		{ 
			get 
			{
				if(Activated) return _rotationalDisplacementRX;
				
				Model.Activate(this, true);
				Activated = true;
				return _rotationalDisplacementRX;
			} 
			set
			{
				SetValue( v =>  _rotationalDisplacementRX = v, _rotationalDisplacementRX, value,  "RotationalDisplacementRX");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPlaneAngleMeasure? @RotationalDisplacementRY 
		{ 
			get 
			{
				if(Activated) return _rotationalDisplacementRY;
				
				Model.Activate(this, true);
				Activated = true;
				return _rotationalDisplacementRY;
			} 
			set
			{
				SetValue( v =>  _rotationalDisplacementRY = v, _rotationalDisplacementRY, value,  "RotationalDisplacementRY");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPlaneAngleMeasure? @RotationalDisplacementRZ 
		{ 
			get 
			{
				if(Activated) return _rotationalDisplacementRZ;
				
				Model.Activate(this, true);
				Activated = true;
				return _rotationalDisplacementRZ;
			} 
			set
			{
				SetValue( v =>  _rotationalDisplacementRZ = v, _rotationalDisplacementRZ, value,  "RotationalDisplacementRZ");
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
					base.Parse(propIndex, value); 
					return;
				case 1: 
					_displacementX = value.RealVal;
					return;
				case 2: 
					_displacementY = value.RealVal;
					return;
				case 3: 
					_displacementZ = value.RealVal;
					return;
				case 4: 
					_rotationalDisplacementRX = value.RealVal;
					return;
				case 5: 
					_rotationalDisplacementRY = value.RealVal;
					return;
				case 6: 
					_rotationalDisplacementRZ = value.RealVal;
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