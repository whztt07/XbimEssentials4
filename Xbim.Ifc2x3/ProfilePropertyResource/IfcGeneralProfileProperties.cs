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
	[ExpressType("IFCGENERALPROFILEPROPERTIES", 648)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcGeneralProfileProperties : IfcProfileProperties, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcGeneralProfileProperties(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcMassPerLengthMeasure? _physicalWeight;
		private IfcPositiveLengthMeasure? _perimeter;
		private IfcPositiveLengthMeasure? _minimumPlateThickness;
		private IfcPositiveLengthMeasure? _maximumPlateThickness;
		private IfcAreaMeasure? _crossSectionArea;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcMassPerLengthMeasure? @PhysicalWeight 
		{ 
			get 
			{
				if(Activated) return _physicalWeight;
				
				Model.Activate(this, true);
				Activated = true;
				return _physicalWeight;
			} 
			set
			{
				SetValue( v =>  _physicalWeight = v, _physicalWeight, value,  "PhysicalWeight");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure? @Perimeter 
		{ 
			get 
			{
				if(Activated) return _perimeter;
				
				Model.Activate(this, true);
				Activated = true;
				return _perimeter;
			} 
			set
			{
				SetValue( v =>  _perimeter = v, _perimeter, value,  "Perimeter");
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure? @MinimumPlateThickness 
		{ 
			get 
			{
				if(Activated) return _minimumPlateThickness;
				
				Model.Activate(this, true);
				Activated = true;
				return _minimumPlateThickness;
			} 
			set
			{
				SetValue( v =>  _minimumPlateThickness = v, _minimumPlateThickness, value,  "MinimumPlateThickness");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure? @MaximumPlateThickness 
		{ 
			get 
			{
				if(Activated) return _maximumPlateThickness;
				
				Model.Activate(this, true);
				Activated = true;
				return _maximumPlateThickness;
			} 
			set
			{
				SetValue( v =>  _maximumPlateThickness = v, _maximumPlateThickness, value,  "MaximumPlateThickness");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcAreaMeasure? @CrossSectionArea 
		{ 
			get 
			{
				if(Activated) return _crossSectionArea;
				
				Model.Activate(this, true);
				Activated = true;
				return _crossSectionArea;
			} 
			set
			{
				SetValue( v =>  _crossSectionArea = v, _crossSectionArea, value,  "CrossSectionArea");
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
					base.Parse(propIndex, value); 
					return;
				case 2: 
					_physicalWeight = value.RealVal;
					return;
				case 3: 
					_perimeter = value.RealVal;
					return;
				case 4: 
					_minimumPlateThickness = value.RealVal;
					return;
				case 5: 
					_maximumPlateThickness = value.RealVal;
					return;
				case 6: 
					_crossSectionArea = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR1:	WR1 : NOT(EXISTS(CrossSectionArea)) OR (CrossSectionArea > 0.);*/
		}
		#endregion
	}
}