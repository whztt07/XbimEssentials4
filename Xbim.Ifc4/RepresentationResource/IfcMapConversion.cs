// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		23.09.2015 10:21:51
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.RepresentationResource
{
	[IndexedClass]
	[ExpressType("IFCMAPCONVERSION", 739)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcMapConversion : IfcCoordinateOperation, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcMapConversion(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcLengthMeasure _eastings;
		private IfcLengthMeasure _northings;
		private IfcLengthMeasure _orthogonalHeight;
		private IfcReal? _xAxisAbscissa;
		private IfcReal? _xAxisOrdinate;
		private IfcReal? _scale;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLengthMeasure @Eastings 
		{ 
			get 
			{
				if(Activated) return _eastings;
				
				Model.Activate(this, true);
				Activated = true;
				return _eastings;
			} 
			set
			{
				SetValue( v =>  _eastings = v, _eastings, value,  "Eastings");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLengthMeasure @Northings 
		{ 
			get 
			{
				if(Activated) return _northings;
				
				Model.Activate(this, true);
				Activated = true;
				return _northings;
			} 
			set
			{
				SetValue( v =>  _northings = v, _northings, value,  "Northings");
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLengthMeasure @OrthogonalHeight 
		{ 
			get 
			{
				if(Activated) return _orthogonalHeight;
				
				Model.Activate(this, true);
				Activated = true;
				return _orthogonalHeight;
			} 
			set
			{
				SetValue( v =>  _orthogonalHeight = v, _orthogonalHeight, value,  "OrthogonalHeight");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcReal? @XAxisAbscissa 
		{ 
			get 
			{
				if(Activated) return _xAxisAbscissa;
				
				Model.Activate(this, true);
				Activated = true;
				return _xAxisAbscissa;
			} 
			set
			{
				SetValue( v =>  _xAxisAbscissa = v, _xAxisAbscissa, value,  "XAxisAbscissa");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcReal? @XAxisOrdinate 
		{ 
			get 
			{
				if(Activated) return _xAxisOrdinate;
				
				Model.Activate(this, true);
				Activated = true;
				return _xAxisOrdinate;
			} 
			set
			{
				SetValue( v =>  _xAxisOrdinate = v, _xAxisOrdinate, value,  "XAxisOrdinate");
			} 
		}
	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcReal? @Scale 
		{ 
			get 
			{
				if(Activated) return _scale;
				
				Model.Activate(this, true);
				Activated = true;
				return _scale;
			} 
			set
			{
				SetValue( v =>  _scale = v, _scale, value,  "Scale");
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
					_eastings = value.RealVal;
					return;
				case 3: 
					_northings = value.RealVal;
					return;
				case 4: 
					_orthogonalHeight = value.RealVal;
					return;
				case 5: 
					_xAxisAbscissa = value.RealVal;
					return;
				case 6: 
					_xAxisOrdinate = value.RealVal;
					return;
				case 7: 
					_scale = value.RealVal;
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