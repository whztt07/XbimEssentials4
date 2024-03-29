// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		24.09.2015 10:03:40
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.ExternalReferenceResource;
using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.DateTimeResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.CostResource
{
	[IndexedClass]
	[ExpressType("IFCCURRENCYRELATIONSHIP", 547)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcCurrencyRelationship : IfcResourceLevelRelationship, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcCurrencyRelationship(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcMonetaryUnit _relatingMonetaryUnit;
		private IfcMonetaryUnit _relatedMonetaryUnit;
		private IfcPositiveRatioMeasure _exchangeRate;
		private IfcDateTime? _rateDateTime;
		private IfcLibraryInformation _rateSource;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcMonetaryUnit @RelatingMonetaryUnit 
		{ 
			get 
			{
				if(Activated) return _relatingMonetaryUnit;
				
				Model.Activate(this, true);
				Activated = true;
				return _relatingMonetaryUnit;
			} 
			set
			{
				SetValue( v =>  _relatingMonetaryUnit = v, _relatingMonetaryUnit, value,  "RelatingMonetaryUnit");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcMonetaryUnit @RelatedMonetaryUnit 
		{ 
			get 
			{
				if(Activated) return _relatedMonetaryUnit;
				
				Model.Activate(this, true);
				Activated = true;
				return _relatedMonetaryUnit;
			} 
			set
			{
				SetValue( v =>  _relatedMonetaryUnit = v, _relatedMonetaryUnit, value,  "RelatedMonetaryUnit");
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveRatioMeasure @ExchangeRate 
		{ 
			get 
			{
				if(Activated) return _exchangeRate;
				
				Model.Activate(this, true);
				Activated = true;
				return _exchangeRate;
			} 
			set
			{
				SetValue( v =>  _exchangeRate = v, _exchangeRate, value,  "ExchangeRate");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcDateTime? @RateDateTime 
		{ 
			get 
			{
				if(Activated) return _rateDateTime;
				
				Model.Activate(this, true);
				Activated = true;
				return _rateDateTime;
			} 
			set
			{
				SetValue( v =>  _rateDateTime = v, _rateDateTime, value,  "RateDateTime");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcLibraryInformation @RateSource 
		{ 
			get 
			{
				if(Activated) return _rateSource;
				
				Model.Activate(this, true);
				Activated = true;
				return _rateSource;
			} 
			set
			{
				SetValue( v =>  _rateSource = v, _rateSource, value,  "RateSource");
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
					_relatingMonetaryUnit = (IfcMonetaryUnit)(value.EntityVal);
					return;
				case 3: 
					_relatedMonetaryUnit = (IfcMonetaryUnit)(value.EntityVal);
					return;
				case 4: 
					_exchangeRate = value.RealVal;
					return;
				case 5: 
					_rateDateTime = value.StringVal;
					return;
				case 6: 
					_rateSource = (IfcLibraryInformation)(value.EntityVal);
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