// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		24.09.2015 10:03:34
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
	[IndexedClass]
	[ExpressType("IFCSLIPPAGECONNECTIONCONDITION", 638)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcSlippageConnectionCondition : IfcStructuralConnectionCondition, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcSlippageConnectionCondition(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcLengthMeasure? _slippageX;
		private IfcLengthMeasure? _slippageY;
		private IfcLengthMeasure? _slippageZ;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLengthMeasure? @SlippageX 
		{ 
			get 
			{
				if(Activated) return _slippageX;
				
				Model.Activate(this, true);
				Activated = true;
				return _slippageX;
			} 
			set
			{
				SetValue( v =>  _slippageX = v, _slippageX, value,  "SlippageX");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLengthMeasure? @SlippageY 
		{ 
			get 
			{
				if(Activated) return _slippageY;
				
				Model.Activate(this, true);
				Activated = true;
				return _slippageY;
			} 
			set
			{
				SetValue( v =>  _slippageY = v, _slippageY, value,  "SlippageY");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLengthMeasure? @SlippageZ 
		{ 
			get 
			{
				if(Activated) return _slippageZ;
				
				Model.Activate(this, true);
				Activated = true;
				return _slippageZ;
			} 
			set
			{
				SetValue( v =>  _slippageZ = v, _slippageZ, value,  "SlippageZ");
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
					_slippageX = value.RealVal;
					return;
				case 2: 
					_slippageY = value.RealVal;
					return;
				case 3: 
					_slippageZ = value.RealVal;
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