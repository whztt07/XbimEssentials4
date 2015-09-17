// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 10:21:10
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.StructuralLoadResource
{
	[EntityName("IFCSTRUCTURALLOADPLANARFORCE", 637)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcStructuralLoadPlanarForce : IfcStructuralLoadStatic, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcStructuralLoadPlanarForce(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcPlanarForceMeasure? _planarForceX;
		private IfcPlanarForceMeasure? _planarForceY;
		private IfcPlanarForceMeasure? _planarForceZ;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Optional)]
		public IfcPlanarForceMeasure? @PlanarForceX 
		{ 
			get 
			{
				if(Activated) return _planarForceX;
				
				Model.Activate(this, true);
				Activated = true;
				return _planarForceX;
			} 
			set
			{
				SetValue( v =>  _planarForceX = v, _planarForceX, value,  "PlanarForceX");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Optional)]
		public IfcPlanarForceMeasure? @PlanarForceY 
		{ 
			get 
			{
				if(Activated) return _planarForceY;
				
				Model.Activate(this, true);
				Activated = true;
				return _planarForceY;
			} 
			set
			{
				SetValue( v =>  _planarForceY = v, _planarForceY, value,  "PlanarForceY");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Optional)]
		public IfcPlanarForceMeasure? @PlanarForceZ 
		{ 
			get 
			{
				if(Activated) return _planarForceZ;
				
				Model.Activate(this, true);
				Activated = true;
				return _planarForceZ;
			} 
			set
			{
				SetValue( v =>  _planarForceZ = v, _planarForceZ, value,  "PlanarForceZ");
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
					base.Parse(propIndex, value); 
					return;
				case 1: 
					_planarForceX = value.RealVal;
					return;
				case 2: 
					_planarForceY = value.RealVal;
					return;
				case 3: 
					_planarForceZ = value.RealVal;
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