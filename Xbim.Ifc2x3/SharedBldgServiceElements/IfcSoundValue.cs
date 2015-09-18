// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 03:43:57
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.Kernel;
using Xbim.Ifc2x3.UtilityResource;
using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.TimeSeriesResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.SharedBldgServiceElements
{
	[EntityName("IFCSOUNDVALUE", 266)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcSoundValue : IfcPropertySetDefinition, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcSoundValue(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcTimeSeries _soundLevelTimeSeries;
		private IfcFrequencyMeasure _frequency;
		private IfcDerivedMeasureValue _soundLevelSingleValue;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttributee(4, EntityAttributeState.Optional)]
		public IfcTimeSeries @SoundLevelTimeSeries 
		{ 
			get 
			{
				if(Activated) return _soundLevelTimeSeries;
				
				Model.Activate(this, true);
				Activated = true;
				return _soundLevelTimeSeries;
			} 
			set
			{
				SetValue( v =>  _soundLevelTimeSeries = v, _soundLevelTimeSeries, value,  "SoundLevelTimeSeries");
			} 
		}
	
		[EntityAttributee(5, EntityAttributeState.Mandatory)]
		public IfcFrequencyMeasure @Frequency 
		{ 
			get 
			{
				if(Activated) return _frequency;
				
				Model.Activate(this, true);
				Activated = true;
				return _frequency;
			} 
			set
			{
				SetValue( v =>  _frequency = v, _frequency, value,  "Frequency");
			} 
		}
	
		[EntityAttributee(6, EntityAttributeState.Optional)]
		public IfcDerivedMeasureValue @SoundLevelSingleValue 
		{ 
			get 
			{
				if(Activated) return _soundLevelSingleValue;
				
				Model.Activate(this, true);
				Activated = true;
				return _soundLevelSingleValue;
			} 
			set
			{
				SetValue( v =>  _soundLevelSingleValue = v, _soundLevelSingleValue, value,  "SoundLevelSingleValue");
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
					base.Parse(propIndex, value); 
					return;
				case 4: 
					_soundLevelTimeSeries = (IfcTimeSeries)(value.EntityVal);
					return;
				case 5: 
					_frequency = value.RealVal;
					return;
				case 6: 
					_soundLevelSingleValue = (IfcDerivedMeasureValue)(value.EntityVal);
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