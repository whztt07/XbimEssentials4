// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		22.09.2015 02:32:00
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.GeometryResource;
using Xbim.Ifc2x3.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.GeometricModelResource
{
	[IndexedClass]
	[ExpressType("IFCSWEPTDISKSOLID", 547)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcSweptDiskSolid : IfcSolidModel, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcSweptDiskSolid(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcCurve _directrix;
		private IfcPositiveLengthMeasure _radius;
		private IfcPositiveLengthMeasure? _innerRadius;
		private IfcParameterValue _startParam;
		private IfcParameterValue _endParam;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcCurve @Directrix 
		{ 
			get 
			{
				if(Activated) return _directrix;
				
				Model.Activate(this, true);
				Activated = true;
				return _directrix;
			} 
			set
			{
				SetValue( v =>  _directrix = v, _directrix, value,  "Directrix");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure @Radius 
		{ 
			get 
			{
				if(Activated) return _radius;
				
				Model.Activate(this, true);
				Activated = true;
				return _radius;
			} 
			set
			{
				SetValue( v =>  _radius = v, _radius, value,  "Radius");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure? @InnerRadius 
		{ 
			get 
			{
				if(Activated) return _innerRadius;
				
				Model.Activate(this, true);
				Activated = true;
				return _innerRadius;
			} 
			set
			{
				SetValue( v =>  _innerRadius = v, _innerRadius, value,  "InnerRadius");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcParameterValue @StartParam 
		{ 
			get 
			{
				if(Activated) return _startParam;
				
				Model.Activate(this, true);
				Activated = true;
				return _startParam;
			} 
			set
			{
				SetValue( v =>  _startParam = v, _startParam, value,  "StartParam");
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcParameterValue @EndParam 
		{ 
			get 
			{
				if(Activated) return _endParam;
				
				Model.Activate(this, true);
				Activated = true;
				return _endParam;
			} 
			set
			{
				SetValue( v =>  _endParam = v, _endParam, value,  "EndParam");
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
					_directrix = (IfcCurve)(value.EntityVal);
					return;
				case 1: 
					_radius = value.RealVal;
					return;
				case 2: 
					_innerRadius = value.RealVal;
					return;
				case 3: 
					_startParam = value.RealVal;
					return;
				case 4: 
					_endParam = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR1:	WR1 : Directrix.Dim = 3;*/
		/*WR2:	WR2 : (NOT EXISTS(InnerRadius)) OR (Radius > InnerRadius);*/
		}
		#endregion
	}
}