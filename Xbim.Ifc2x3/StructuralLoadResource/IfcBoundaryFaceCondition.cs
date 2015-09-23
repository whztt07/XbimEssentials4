// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		23.09.2015 10:21:43
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
	[ExpressType("IFCBOUNDARYFACECONDITION", 674)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcBoundaryFaceCondition : IfcBoundaryCondition, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcBoundaryFaceCondition(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcModulusOfSubgradeReactionMeasure? _linearStiffnessByAreaX;
		private IfcModulusOfSubgradeReactionMeasure? _linearStiffnessByAreaY;
		private IfcModulusOfSubgradeReactionMeasure? _linearStiffnessByAreaZ;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcModulusOfSubgradeReactionMeasure? @LinearStiffnessByAreaX 
		{ 
			get 
			{
				if(Activated) return _linearStiffnessByAreaX;
				
				Model.Activate(this, true);
				Activated = true;
				return _linearStiffnessByAreaX;
			} 
			set
			{
				SetValue( v =>  _linearStiffnessByAreaX = v, _linearStiffnessByAreaX, value,  "LinearStiffnessByAreaX");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcModulusOfSubgradeReactionMeasure? @LinearStiffnessByAreaY 
		{ 
			get 
			{
				if(Activated) return _linearStiffnessByAreaY;
				
				Model.Activate(this, true);
				Activated = true;
				return _linearStiffnessByAreaY;
			} 
			set
			{
				SetValue( v =>  _linearStiffnessByAreaY = v, _linearStiffnessByAreaY, value,  "LinearStiffnessByAreaY");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcModulusOfSubgradeReactionMeasure? @LinearStiffnessByAreaZ 
		{ 
			get 
			{
				if(Activated) return _linearStiffnessByAreaZ;
				
				Model.Activate(this, true);
				Activated = true;
				return _linearStiffnessByAreaZ;
			} 
			set
			{
				SetValue( v =>  _linearStiffnessByAreaZ = v, _linearStiffnessByAreaZ, value,  "LinearStiffnessByAreaZ");
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
					_linearStiffnessByAreaX = value.RealVal;
					return;
				case 2: 
					_linearStiffnessByAreaY = value.RealVal;
					return;
				case 3: 
					_linearStiffnessByAreaZ = value.RealVal;
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