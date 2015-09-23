// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		23.09.2015 10:21:45
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.ProfileResource;
using Xbim.Ifc2x3.GeometryResource;
using Xbim.Ifc2x3.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.GeometricModelResource
{
	[IndexedClass]
	[ExpressType("IFCSURFACECURVESWEPTAREASOLID", 480)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcSurfaceCurveSweptAreaSolid : IfcSweptAreaSolid, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcSurfaceCurveSweptAreaSolid(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcCurve _directrix;
		private IfcParameterValue _startParam;
		private IfcParameterValue _endParam;
		private IfcSurface _referenceSurface;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
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
	
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcSurface @ReferenceSurface 
		{ 
			get 
			{
				if(Activated) return _referenceSurface;
				
				Model.Activate(this, true);
				Activated = true;
				return _referenceSurface;
			} 
			set
			{
				SetValue( v =>  _referenceSurface = v, _referenceSurface, value,  "ReferenceSurface");
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
					_directrix = (IfcCurve)(value.EntityVal);
					return;
				case 3: 
					_startParam = value.RealVal;
					return;
				case 4: 
					_endParam = value.RealVal;
					return;
				case 5: 
					_referenceSurface = (IfcSurface)(value.EntityVal);
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