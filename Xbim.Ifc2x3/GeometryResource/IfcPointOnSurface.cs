// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		22.09.2015 02:31:58
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.GeometryResource
{
	[IndexedClass]
	[ExpressType("IFCPOINTONSURFACE", 65)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcPointOnSurface : IfcPoint, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPointOnSurface(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcSurface _basisSurface;
		private IfcParameterValue _pointParameterU;
		private IfcParameterValue _pointParameterV;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcSurface @BasisSurface 
		{ 
			get 
			{
				if(Activated) return _basisSurface;
				
				Model.Activate(this, true);
				Activated = true;
				return _basisSurface;
			} 
			set
			{
				SetValue( v =>  _basisSurface = v, _basisSurface, value,  "BasisSurface");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcParameterValue @PointParameterU 
		{ 
			get 
			{
				if(Activated) return _pointParameterU;
				
				Model.Activate(this, true);
				Activated = true;
				return _pointParameterU;
			} 
			set
			{
				SetValue( v =>  _pointParameterU = v, _pointParameterU, value,  "PointParameterU");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcParameterValue @PointParameterV 
		{ 
			get 
			{
				if(Activated) return _pointParameterV;
				
				Model.Activate(this, true);
				Activated = true;
				return _pointParameterV;
			} 
			set
			{
				SetValue( v =>  _pointParameterV = v, _pointParameterV, value,  "PointParameterV");
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
					_basisSurface = (IfcSurface)(value.EntityVal);
					return;
				case 1: 
					_pointParameterU = value.RealVal;
					return;
				case 2: 
					_pointParameterV = value.RealVal;
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