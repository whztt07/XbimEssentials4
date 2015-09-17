// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 03:44:05
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.MaterialResource
{
	[EntityName("IFCMATERIALPROFILESETUSAGE", 363)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcMaterialProfileSetUsage : IfcMaterialUsageDefinition, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcMaterialProfileSetUsage(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcMaterialProfileSet _forProfileSet;
		private IfcCardinalPointReference? _cardinalPoint;
		private IfcPositiveLengthMeasure? _referenceExtent;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(0, EntityAttributeState.Mandatory)]
		public IfcMaterialProfileSet @ForProfileSet 
		{ 
			get 
			{
				if(Activated) return _forProfileSet;
				
				Model.Activate(this, true);
				Activated = true;
				return _forProfileSet;
			} 
			set
			{
				SetValue( v =>  _forProfileSet = v, _forProfileSet, value,  "ForProfileSet");
			} 
		}
	
		[EntityAttribute(1, EntityAttributeState.Optional)]
		public IfcCardinalPointReference? @CardinalPoint 
		{ 
			get 
			{
				if(Activated) return _cardinalPoint;
				
				Model.Activate(this, true);
				Activated = true;
				return _cardinalPoint;
			} 
			set
			{
				SetValue( v =>  _cardinalPoint = v, _cardinalPoint, value,  "CardinalPoint");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Optional)]
		public IfcPositiveLengthMeasure? @ReferenceExtent 
		{ 
			get 
			{
				if(Activated) return _referenceExtent;
				
				Model.Activate(this, true);
				Activated = true;
				return _referenceExtent;
			} 
			set
			{
				SetValue( v =>  _referenceExtent = v, _referenceExtent, value,  "ReferenceExtent");
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
					_forProfileSet = (IfcMaterialProfileSet)(value.EntityVal);
					return;
				case 1: 
					_cardinalPoint = value.IntegerVal;
					return;
				case 2: 
					_referenceExtent = value.RealVal;
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