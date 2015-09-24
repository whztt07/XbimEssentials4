// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
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
	[ExpressType("IFCRECTANGULARTRIMMEDSURFACE", 653)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRectangularTrimmedSurface : IfcBoundedSurface, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRectangularTrimmedSurface(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcSurface _basisSurface;
		private IfcParameterValue _u1;
		private IfcParameterValue _v1;
		private IfcParameterValue _u2;
		private IfcParameterValue _v2;
		private bool _usense;
		private bool _vsense;
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
		public IfcParameterValue @U1 
		{ 
			get 
			{
				if(Activated) return _u1;
				
				Model.Activate(this, true);
				Activated = true;
				return _u1;
			} 
			set
			{
				SetValue( v =>  _u1 = v, _u1, value,  "U1");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcParameterValue @V1 
		{ 
			get 
			{
				if(Activated) return _v1;
				
				Model.Activate(this, true);
				Activated = true;
				return _v1;
			} 
			set
			{
				SetValue( v =>  _v1 = v, _v1, value,  "V1");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcParameterValue @U2 
		{ 
			get 
			{
				if(Activated) return _u2;
				
				Model.Activate(this, true);
				Activated = true;
				return _u2;
			} 
			set
			{
				SetValue( v =>  _u2 = v, _u2, value,  "U2");
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcParameterValue @V2 
		{ 
			get 
			{
				if(Activated) return _v2;
				
				Model.Activate(this, true);
				Activated = true;
				return _v2;
			} 
			set
			{
				SetValue( v =>  _v2 = v, _v2, value,  "V2");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public bool @Usense 
		{ 
			get 
			{
				if(Activated) return _usense;
				
				Model.Activate(this, true);
				Activated = true;
				return _usense;
			} 
			set
			{
				SetValue( v =>  _usense = v, _usense, value,  "Usense");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public bool @Vsense 
		{ 
			get 
			{
				if(Activated) return _vsense;
				
				Model.Activate(this, true);
				Activated = true;
				return _vsense;
			} 
			set
			{
				SetValue( v =>  _vsense = v, _vsense, value,  "Vsense");
			} 
		}
	
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
					_u1 = value.RealVal;
					return;
				case 2: 
					_v1 = value.RealVal;
					return;
				case 3: 
					_u2 = value.RealVal;
					return;
				case 4: 
					_v2 = value.RealVal;
					return;
				case 5: 
					_usense = value.BooleanVal;
					return;
				case 6: 
					_vsense = value.BooleanVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR1:	WR1 : U1 <> U2;*/
		/*WR2:	WR2 : V1 <> V2;*/
		/*WR3:                     (Usense = (U2 > U1));*/
		/*WR4:	WR4 : Vsense = (V2 > V1);*/
		}
		#endregion
	}
}