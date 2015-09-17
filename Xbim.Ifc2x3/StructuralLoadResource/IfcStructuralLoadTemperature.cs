// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 10:21:01
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.StructuralLoadResource
{
	[EntityName("IFCSTRUCTURALLOADTEMPERATURE", 36)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcStructuralLoadTemperature : IfcStructuralLoadStatic, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcStructuralLoadTemperature(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcThermodynamicTemperatureMeasure? _deltaT_Constant;
		private IfcThermodynamicTemperatureMeasure? _deltaT_Y;
		private IfcThermodynamicTemperatureMeasure? _deltaT_Z;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Optional)]
		public IfcThermodynamicTemperatureMeasure? @DeltaT_Constant 
		{ 
			get 
			{
				if(Activated) return _deltaT_Constant;
				
				Model.Activate(this, true);
				Activated = true;
				return _deltaT_Constant;
			} 
			set
			{
				SetValue( v =>  _deltaT_Constant = v, _deltaT_Constant, value,  "DeltaT_Constant");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Optional)]
		public IfcThermodynamicTemperatureMeasure? @DeltaT_Y 
		{ 
			get 
			{
				if(Activated) return _deltaT_Y;
				
				Model.Activate(this, true);
				Activated = true;
				return _deltaT_Y;
			} 
			set
			{
				SetValue( v =>  _deltaT_Y = v, _deltaT_Y, value,  "DeltaT_Y");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Optional)]
		public IfcThermodynamicTemperatureMeasure? @DeltaT_Z 
		{ 
			get 
			{
				if(Activated) return _deltaT_Z;
				
				Model.Activate(this, true);
				Activated = true;
				return _deltaT_Z;
			} 
			set
			{
				SetValue( v =>  _deltaT_Z = v, _deltaT_Z, value,  "DeltaT_Z");
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
					_deltaT_Constant = value.RealVal;
					return;
				case 2: 
					_deltaT_Y = value.RealVal;
					return;
				case 3: 
					_deltaT_Z = value.RealVal;
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