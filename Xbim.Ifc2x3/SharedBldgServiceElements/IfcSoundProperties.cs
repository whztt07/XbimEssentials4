// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.Kernel;
using Xbim.Ifc2x3.UtilityResource;
using Xbim.Ifc2x3.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.SharedBldgServiceElements
{
	[ExpressType("IFCSOUNDPROPERTIES", 474)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcSoundProperties : IfcPropertySetDefinition, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcSoundProperties(IModel model) : base(model) 		{ 
			Model = model; 
			_soundValues = new ItemSet<IfcSoundValue>( this );
		}

		#region Explicit attribute fields
		private IfcBoolean _isAttenuating;
		private IfcSoundScaleEnum? _soundScale;
		private ItemSet<IfcSoundValue> _soundValues;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcBoolean @IsAttenuating 
		{ 
			get 
			{
				if(Activated) return _isAttenuating;
				
				Model.Activate(this, true);
				Activated = true;
				return _isAttenuating;
			} 
			set
			{
				SetValue( v =>  _isAttenuating = v, _isAttenuating, value,  "IsAttenuating");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcSoundScaleEnum? @SoundScale 
		{ 
			get 
			{
				if(Activated) return _soundScale;
				
				Model.Activate(this, true);
				Activated = true;
				return _soundScale;
			} 
			set
			{
				SetValue( v =>  _soundScale = v, _soundScale, value,  "SoundScale");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.Class, 1, 8)]
		public ItemSet<IfcSoundValue> @SoundValues 
		{ 
			get 
			{
				if(Activated) return _soundValues;
				
				Model.Activate(this, true);
				Activated = true;
				return _soundValues;
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
					base.Parse(propIndex, value); 
					return;
				case 4: 
					_isAttenuating = value.BooleanVal;
					return;
				case 5: 
                    _soundScale = (IfcSoundScaleEnum) System.Enum.Parse(typeof (IfcSoundScaleEnum), value.EnumVal, true);
					return;
				case 6: 
					if (_soundValues == null) _soundValues = new ItemSet<IfcSoundValue>( this );
					_soundValues.InternalAdd((IfcSoundValue)value.EntityVal);
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