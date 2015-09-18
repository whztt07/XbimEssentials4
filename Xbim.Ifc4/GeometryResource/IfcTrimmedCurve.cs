// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 03:44:07
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.GeometryResource
{
	[EntityName("IFCTRIMMEDCURVE", 723)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcTrimmedCurve : IfcBoundedCurve, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTrimmedCurve(IModel model) : base(model) 		{ 
			Model = model; 
			_trim1 = new ItemSet<IfcTrimmingSelect>( this );
			_trim2 = new ItemSet<IfcTrimmingSelect>( this );
		}

		#region Explicit attribute fields
		private IfcCurve _basisCurve;
		private ItemSet<IfcTrimmingSelect> _trim1;
		private ItemSet<IfcTrimmingSelect> _trim2;
		private bool _senseAgreement;
		private IfcTrimmingPreference _masterRepresentation;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttributee(0, EntityAttributeState.Mandatory)]
		public IfcCurve @BasisCurve 
		{ 
			get 
			{
				if(Activated) return _basisCurve;
				
				Model.Activate(this, true);
				Activated = true;
				return _basisCurve;
			} 
			set
			{
				SetValue( v =>  _basisCurve = v, _basisCurve, value,  "BasisCurve");
			} 
		}
	
		[EntityAttributee(1, EntityAttributeState.Mandatory)]
		public ItemSet<IfcTrimmingSelect> @Trim1 
		{ 
			get 
			{
				if(Activated) return _trim1;
				
				Model.Activate(this, true);
				Activated = true;
				return _trim1;
			} 
			set
			{
				SetValue( v =>  _trim1 = v, _trim1, value,  "Trim1");
			} 
		}
	
		[EntityAttributee(2, EntityAttributeState.Mandatory)]
		public ItemSet<IfcTrimmingSelect> @Trim2 
		{ 
			get 
			{
				if(Activated) return _trim2;
				
				Model.Activate(this, true);
				Activated = true;
				return _trim2;
			} 
			set
			{
				SetValue( v =>  _trim2 = v, _trim2, value,  "Trim2");
			} 
		}
	
		[EntityAttributee(3, EntityAttributeState.Mandatory)]
		public bool @SenseAgreement 
		{ 
			get 
			{
				if(Activated) return _senseAgreement;
				
				Model.Activate(this, true);
				Activated = true;
				return _senseAgreement;
			} 
			set
			{
				SetValue( v =>  _senseAgreement = v, _senseAgreement, value,  "SenseAgreement");
			} 
		}
	
		[EntityAttributee(4, EntityAttributeState.Mandatory)]
		public IfcTrimmingPreference @MasterRepresentation 
		{ 
			get 
			{
				if(Activated) return _masterRepresentation;
				
				Model.Activate(this, true);
				Activated = true;
				return _masterRepresentation;
			} 
			set
			{
				SetValue( v =>  _masterRepresentation = v, _masterRepresentation, value,  "MasterRepresentation");
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
					_basisCurve = (IfcCurve)(value.EntityVal);
					return;
				case 1: 
					if (_trim1 == null) _trim1 = new ItemSet<IfcTrimmingSelect>( this );
					_trim1.InternalAdd((IfcTrimmingSelect)value.EntityVal);
					return;
				case 2: 
					if (_trim2 == null) _trim2 = new ItemSet<IfcTrimmingSelect>( this );
					_trim2.InternalAdd((IfcTrimmingSelect)value.EntityVal);
					return;
				case 3: 
					_senseAgreement = value.BooleanVal;
					return;
				case 4: 
                    _masterRepresentation = (IfcTrimmingPreference) System.Enum.Parse(typeof (IfcTrimmingPreference), value.EnumVal, true);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*Trim1ValuesConsistent:	Trim1ValuesConsistent : (HIINDEX(Trim1) = 1) OR (TYPEOF(Trim1[1]) <> TYPEOF(Trim1[2]));*/
		/*Trim2ValuesConsistent:	Trim2ValuesConsistent : (HIINDEX(Trim2) = 1) OR (TYPEOF(Trim2[1]) <> TYPEOF(Trim2[2]));*/
		/*NoTrimOfBoundedCurves:	NoTrimOfBoundedCurves : NOT('IFC4.IFCBOUNDEDCURVE' IN TYPEOF(BasisCurve));*/
		}
		#endregion
	}
}