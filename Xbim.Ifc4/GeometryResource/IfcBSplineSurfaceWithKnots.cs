// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 03:44:03
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.GeometryResource
{
	[EntityName("IFCBSPLINESURFACEWITHKNOTS", 36)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcBSplineSurfaceWithKnots : IfcBSplineSurface, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcBSplineSurfaceWithKnots(IModel model) : base(model) 		{ 
			Model = model; 
			_uMultiplicities = new ItemSet<long>( this );
			_vMultiplicities = new ItemSet<long>( this );
			_uKnots = new ItemSet<IfcParameterValue>( this );
			_vKnots = new ItemSet<IfcParameterValue>( this );
		}

		#region Explicit attribute fields
		private ItemSet<long> _uMultiplicities;
		private ItemSet<long> _vMultiplicities;
		private ItemSet<IfcParameterValue> _uKnots;
		private ItemSet<IfcParameterValue> _vKnots;
		private IfcKnotType _knotSpec;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(7, EntityAttributeState.Mandatory)]
		public ItemSet<long> @UMultiplicities 
		{ 
			get 
			{
				if(Activated) return _uMultiplicities;
				
				Model.Activate(this, true);
				Activated = true;
				return _uMultiplicities;
			} 
			set
			{
				SetValue( v =>  _uMultiplicities = v, _uMultiplicities, value,  "UMultiplicities");
			} 
		}
	
		[EntityAttribute(8, EntityAttributeState.Mandatory)]
		public ItemSet<long> @VMultiplicities 
		{ 
			get 
			{
				if(Activated) return _vMultiplicities;
				
				Model.Activate(this, true);
				Activated = true;
				return _vMultiplicities;
			} 
			set
			{
				SetValue( v =>  _vMultiplicities = v, _vMultiplicities, value,  "VMultiplicities");
			} 
		}
	
		[EntityAttribute(9, EntityAttributeState.Mandatory)]
		public ItemSet<IfcParameterValue> @UKnots 
		{ 
			get 
			{
				if(Activated) return _uKnots;
				
				Model.Activate(this, true);
				Activated = true;
				return _uKnots;
			} 
			set
			{
				SetValue( v =>  _uKnots = v, _uKnots, value,  "UKnots");
			} 
		}
	
		[EntityAttribute(10, EntityAttributeState.Mandatory)]
		public ItemSet<IfcParameterValue> @VKnots 
		{ 
			get 
			{
				if(Activated) return _vKnots;
				
				Model.Activate(this, true);
				Activated = true;
				return _vKnots;
			} 
			set
			{
				SetValue( v =>  _vKnots = v, _vKnots, value,  "VKnots");
			} 
		}
	
		[EntityAttribute(11, EntityAttributeState.Mandatory)]
		public IfcKnotType @KnotSpec 
		{ 
			get 
			{
				if(Activated) return _knotSpec;
				
				Model.Activate(this, true);
				Activated = true;
				return _knotSpec;
			} 
			set
			{
				SetValue( v =>  _knotSpec = v, _knotSpec, value,  "KnotSpec");
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
				case 4: 
				case 5: 
				case 6: 
					base.Parse(propIndex, value); 
					return;
				case 7: 
					if (_uMultiplicities == null) _uMultiplicities = new ItemSet<long>( this );
					_uMultiplicities.InternalAdd(value.IntegerVal);
					return;
				case 8: 
					if (_vMultiplicities == null) _vMultiplicities = new ItemSet<long>( this );
					_vMultiplicities.InternalAdd(value.IntegerVal);
					return;
				case 9: 
					if (_uKnots == null) _uKnots = new ItemSet<IfcParameterValue>( this );
					_uKnots.InternalAdd(value.RealVal);
					return;
				case 10: 
					if (_vKnots == null) _vKnots = new ItemSet<IfcParameterValue>( this );
					_vKnots.InternalAdd(value.RealVal);
					return;
				case 11: 
                    _knotSpec = (IfcKnotType) System.Enum.Parse(typeof (IfcKnotType), value.EnumVal, true);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*UDirectionConstraints:                                SELF\IfcBSplineSurface.UUpper, UMultiplicities, UKnots);*/
		/*VDirectionConstraints:                                SELF\IfcBSplineSurface.VUpper, VMultiplicities, VKnots);*/
		/*CorrespondingULists:	CorrespondingULists : SIZEOF(UMultiplicities) = KnotUUpper;*/
		/*CorrespondingVLists:	CorrespondingVLists : SIZEOF(VMultiplicities) = KnotVUpper;*/
		}
		#endregion
	}
}