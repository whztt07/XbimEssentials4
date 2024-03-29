// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		24.09.2015 10:03:33
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.PresentationResource;
using Xbim.Ifc2x3.GeometryResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.PresentationOrganizationResource
{
	[IndexedClass]
	[ExpressType("IFCLIGHTSOURCEPOSITIONAL", 759)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcLightSourcePositional : IfcLightSource, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcLightSourcePositional(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcCartesianPoint _position;
		private IfcPositiveLengthMeasure _radius;
		private IfcReal _constantAttenuation;
		private IfcReal _distanceAttenuation;
		private IfcReal _quadricAttenuation;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcCartesianPoint @Position 
		{ 
			get 
			{
				if(Activated) return _position;
				
				Model.Activate(this, true);
				Activated = true;
				return _position;
			} 
			set
			{
				SetValue( v =>  _position = v, _position, value,  "Position");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
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
	
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcReal @ConstantAttenuation 
		{ 
			get 
			{
				if(Activated) return _constantAttenuation;
				
				Model.Activate(this, true);
				Activated = true;
				return _constantAttenuation;
			} 
			set
			{
				SetValue( v =>  _constantAttenuation = v, _constantAttenuation, value,  "ConstantAttenuation");
			} 
		}
	
		[EntityAttribute(8, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcReal @DistanceAttenuation 
		{ 
			get 
			{
				if(Activated) return _distanceAttenuation;
				
				Model.Activate(this, true);
				Activated = true;
				return _distanceAttenuation;
			} 
			set
			{
				SetValue( v =>  _distanceAttenuation = v, _distanceAttenuation, value,  "DistanceAttenuation");
			} 
		}
	
		[EntityAttribute(9, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcReal @QuadricAttenuation 
		{ 
			get 
			{
				if(Activated) return _quadricAttenuation;
				
				Model.Activate(this, true);
				Activated = true;
				return _quadricAttenuation;
			} 
			set
			{
				SetValue( v =>  _quadricAttenuation = v, _quadricAttenuation, value,  "QuadricAttenuation");
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
					_position = (IfcCartesianPoint)(value.EntityVal);
					return;
				case 5: 
					_radius = value.RealVal;
					return;
				case 6: 
					_constantAttenuation = value.RealVal;
					return;
				case 7: 
					_distanceAttenuation = value.RealVal;
					return;
				case 8: 
					_quadricAttenuation = value.RealVal;
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