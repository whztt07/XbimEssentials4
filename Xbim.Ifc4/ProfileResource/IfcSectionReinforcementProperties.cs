// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 03:44:06
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.PropertyResource;
using Xbim.Ifc4.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.ProfileResource
{
	[EntityName("IFCSECTIONREINFORCEMENTPROPERTIES", 581)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcSectionReinforcementProperties : IfcPreDefinedProperties, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcSectionReinforcementProperties(IModel model) : base(model) 		{ 
			Model = model; 
			_crossSectionReinforcementDefinitions = new ItemSet<IfcReinforcementBarProperties>( this );
		}

		#region Explicit attribute fields
		private IfcLengthMeasure _longitudinalStartPosition;
		private IfcLengthMeasure _longitudinalEndPosition;
		private IfcLengthMeasure? _transversePosition;
		private IfcReinforcingBarRoleEnum _reinforcementRole;
		private IfcSectionProperties _sectionDefinition;
		private ItemSet<IfcReinforcementBarProperties> _crossSectionReinforcementDefinitions;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttributee(0, EntityAttributeState.Mandatory)]
		public IfcLengthMeasure @LongitudinalStartPosition 
		{ 
			get 
			{
				if(Activated) return _longitudinalStartPosition;
				
				Model.Activate(this, true);
				Activated = true;
				return _longitudinalStartPosition;
			} 
			set
			{
				SetValue( v =>  _longitudinalStartPosition = v, _longitudinalStartPosition, value,  "LongitudinalStartPosition");
			} 
		}
	
		[EntityAttributee(1, EntityAttributeState.Mandatory)]
		public IfcLengthMeasure @LongitudinalEndPosition 
		{ 
			get 
			{
				if(Activated) return _longitudinalEndPosition;
				
				Model.Activate(this, true);
				Activated = true;
				return _longitudinalEndPosition;
			} 
			set
			{
				SetValue( v =>  _longitudinalEndPosition = v, _longitudinalEndPosition, value,  "LongitudinalEndPosition");
			} 
		}
	
		[EntityAttributee(2, EntityAttributeState.Optional)]
		public IfcLengthMeasure? @TransversePosition 
		{ 
			get 
			{
				if(Activated) return _transversePosition;
				
				Model.Activate(this, true);
				Activated = true;
				return _transversePosition;
			} 
			set
			{
				SetValue( v =>  _transversePosition = v, _transversePosition, value,  "TransversePosition");
			} 
		}
	
		[EntityAttributee(3, EntityAttributeState.Mandatory)]
		public IfcReinforcingBarRoleEnum @ReinforcementRole 
		{ 
			get 
			{
				if(Activated) return _reinforcementRole;
				
				Model.Activate(this, true);
				Activated = true;
				return _reinforcementRole;
			} 
			set
			{
				SetValue( v =>  _reinforcementRole = v, _reinforcementRole, value,  "ReinforcementRole");
			} 
		}
	
		[EntityAttributee(4, EntityAttributeState.Mandatory)]
		public IfcSectionProperties @SectionDefinition 
		{ 
			get 
			{
				if(Activated) return _sectionDefinition;
				
				Model.Activate(this, true);
				Activated = true;
				return _sectionDefinition;
			} 
			set
			{
				SetValue( v =>  _sectionDefinition = v, _sectionDefinition, value,  "SectionDefinition");
			} 
		}
	
		[EntityAttributee(5, EntityAttributeState.Mandatory)]
		public ItemSet<IfcReinforcementBarProperties> @CrossSectionReinforcementDefinitions 
		{ 
			get 
			{
				if(Activated) return _crossSectionReinforcementDefinitions;
				
				Model.Activate(this, true);
				Activated = true;
				return _crossSectionReinforcementDefinitions;
			} 
			set
			{
				SetValue( v =>  _crossSectionReinforcementDefinitions = v, _crossSectionReinforcementDefinitions, value,  "CrossSectionReinforcementDefinitions");
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
					_longitudinalStartPosition = value.RealVal;
					return;
				case 1: 
					_longitudinalEndPosition = value.RealVal;
					return;
				case 2: 
					_transversePosition = value.RealVal;
					return;
				case 3: 
                    _reinforcementRole = (IfcReinforcingBarRoleEnum) System.Enum.Parse(typeof (IfcReinforcingBarRoleEnum), value.EnumVal, true);
					return;
				case 4: 
					_sectionDefinition = (IfcSectionProperties)(value.EntityVal);
					return;
				case 5: 
					if (_crossSectionReinforcementDefinitions == null) _crossSectionReinforcementDefinitions = new ItemSet<IfcReinforcementBarProperties>( this );
					_crossSectionReinforcementDefinitions.InternalAdd((IfcReinforcementBarProperties)value.EntityVal);
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