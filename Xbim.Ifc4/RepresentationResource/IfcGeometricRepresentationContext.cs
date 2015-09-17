// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 03:44:04
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.GeometryResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.RepresentationResource
{
	[EntityName("IFCGEOMETRICREPRESENTATIONCONTEXT", 301)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcGeometricRepresentationContext : IfcRepresentationContext, IfcCoordinateReferenceSystemSelect, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcGeometricRepresentationContext(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcDimensionCount _coordinateSpaceDimension;
		private double? _precision;
		private IfcAxis2Placement _worldCoordinateSystem;
		private IfcDirection _trueNorth;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Mandatory)]
		public IfcDimensionCount @CoordinateSpaceDimension 
		{ 
			get 
			{
				if(Activated) return _coordinateSpaceDimension;
				
				Model.Activate(this, true);
				Activated = true;
				return _coordinateSpaceDimension;
			} 
			set
			{
				SetValue( v =>  _coordinateSpaceDimension = v, _coordinateSpaceDimension, value,  "CoordinateSpaceDimension");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Optional)]
		public double? @Precision 
		{ 
			get 
			{
				if(Activated) return _precision;
				
				Model.Activate(this, true);
				Activated = true;
				return _precision;
			} 
			set
			{
				SetValue( v =>  _precision = v, _precision, value,  "Precision");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Mandatory)]
		public IfcAxis2Placement @WorldCoordinateSystem 
		{ 
			get 
			{
				if(Activated) return _worldCoordinateSystem;
				
				Model.Activate(this, true);
				Activated = true;
				return _worldCoordinateSystem;
			} 
			set
			{
				SetValue( v =>  _worldCoordinateSystem = v, _worldCoordinateSystem, value,  "WorldCoordinateSystem");
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Optional)]
		public IfcDirection @TrueNorth 
		{ 
			get 
			{
				if(Activated) return _trueNorth;
				
				Model.Activate(this, true);
				Activated = true;
				return _trueNorth;
			} 
			set
			{
				SetValue( v =>  _trueNorth = v, _trueNorth, value,  "TrueNorth");
			} 
		}
	
		#endregion

		#region Inverse attributes
		public IEnumerable<IfcGeometricRepresentationSubContext> @HasSubContexts 
		{ 
			get 
			{
				return Model.Instances.Where<IfcGeometricRepresentationSubContext>(e => e.ParentContext == this);
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
					_coordinateSpaceDimension = value.IntegerVal;
					return;
				case 3: 
					_precision = value.RealVal;
					return;
				case 4: 
					_worldCoordinateSystem = (IfcAxis2Placement)(value.EntityVal);
					return;
				case 5: 
					_trueNorth = (IfcDirection)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR11:	WR11 : NOT(EXISTS(TrueNorth)) OR (HIINDEX(TrueNorth.DirectionRatios) = 2);*/
		}
		#endregion
	}
}