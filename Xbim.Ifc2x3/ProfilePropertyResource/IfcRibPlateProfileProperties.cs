// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		22.09.2015 04:44:06
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
	[ExpressType("IFCRIBPLATEPROFILEPROPERTIES", 763)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRibPlateProfileProperties : IfcProfileProperties, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRibPlateProfileProperties(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcPositiveLengthMeasure? _thickness;
		private IfcPositiveLengthMeasure? _ribHeight;
		private IfcPositiveLengthMeasure? _ribWidth;
		private IfcPositiveLengthMeasure? _ribSpacing;
		private IfcRibPlateDirectionEnum _direction;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure? @Thickness 
		{ 
			get 
			{
				if(Activated) return _thickness;
				
				Model.Activate(this, true);
				Activated = true;
				return _thickness;
			} 
			set
			{
				SetValue( v =>  _thickness = v, _thickness, value,  "Thickness");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure? @RibHeight 
		{ 
			get 
			{
				if(Activated) return _ribHeight;
				
				Model.Activate(this, true);
				Activated = true;
				return _ribHeight;
			} 
			set
			{
				SetValue( v =>  _ribHeight = v, _ribHeight, value,  "RibHeight");
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure? @RibWidth 
		{ 
			get 
			{
				if(Activated) return _ribWidth;
				
				Model.Activate(this, true);
				Activated = true;
				return _ribWidth;
			} 
			set
			{
				SetValue( v =>  _ribWidth = v, _ribWidth, value,  "RibWidth");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure? @RibSpacing 
		{ 
			get 
			{
				if(Activated) return _ribSpacing;
				
				Model.Activate(this, true);
				Activated = true;
				return _ribSpacing;
			} 
			set
			{
				SetValue( v =>  _ribSpacing = v, _ribSpacing, value,  "RibSpacing");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcRibPlateDirectionEnum @Direction 
		{ 
			get 
			{
				if(Activated) return _direction;
				
				Model.Activate(this, true);
				Activated = true;
				return _direction;
			} 
			set
			{
				SetValue( v =>  _direction = v, _direction, value,  "Direction");
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
					_thickness = value.RealVal;
					return;
				case 3: 
					_ribHeight = value.RealVal;
					return;
				case 4: 
					_ribWidth = value.RealVal;
					return;
				case 5: 
					_ribSpacing = value.RealVal;
					return;
				case 6: 
                    _direction = (IfcRibPlateDirectionEnum) System.Enum.Parse(typeof (IfcRibPlateDirectionEnum), value.EnumVal, true);
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