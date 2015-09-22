// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		22.09.2015 04:44:15
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
	[IndexedClass]
	[ExpressType("IFCSTRUCTURALLOADTEMPERATURE", 1034)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcStructuralLoadTemperature : IfcStructuralLoadStatic, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcStructuralLoadTemperature(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcThermodynamicTemperatureMeasure? _deltaTConstant;
		private IfcThermodynamicTemperatureMeasure? _deltaTY;
		private IfcThermodynamicTemperatureMeasure? _deltaTZ;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcThermodynamicTemperatureMeasure? @DeltaTConstant 
		{ 
			get 
			{
				if(Activated) return _deltaTConstant;
				
				Model.Activate(this, true);
				Activated = true;
				return _deltaTConstant;
			} 
			set
			{
				SetValue( v =>  _deltaTConstant = v, _deltaTConstant, value,  "DeltaTConstant");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcThermodynamicTemperatureMeasure? @DeltaTY 
		{ 
			get 
			{
				if(Activated) return _deltaTY;
				
				Model.Activate(this, true);
				Activated = true;
				return _deltaTY;
			} 
			set
			{
				SetValue( v =>  _deltaTY = v, _deltaTY, value,  "DeltaTY");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcThermodynamicTemperatureMeasure? @DeltaTZ 
		{ 
			get 
			{
				if(Activated) return _deltaTZ;
				
				Model.Activate(this, true);
				Activated = true;
				return _deltaTZ;
			} 
			set
			{
				SetValue( v =>  _deltaTZ = v, _deltaTZ, value,  "DeltaTZ");
			} 
		}
	
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
					_deltaTConstant = value.RealVal;
					return;
				case 2: 
					_deltaTY = value.RealVal;
					return;
				case 3: 
					_deltaTZ = value.RealVal;
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