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

namespace Xbim.Ifc2x3.StructuralLoadResource
{
	[ExpressType("IFCBOUNDARYEDGECONDITION", 319)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcBoundaryEdgeCondition : IfcBoundaryCondition, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcBoundaryEdgeCondition(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcModulusOfLinearSubgradeReactionMeasure? _linearStiffnessByLengthX;
		private IfcModulusOfLinearSubgradeReactionMeasure? _linearStiffnessByLengthY;
		private IfcModulusOfLinearSubgradeReactionMeasure? _linearStiffnessByLengthZ;
		private IfcModulusOfRotationalSubgradeReactionMeasure? _rotationalStiffnessByLengthX;
		private IfcModulusOfRotationalSubgradeReactionMeasure? _rotationalStiffnessByLengthY;
		private IfcModulusOfRotationalSubgradeReactionMeasure? _rotationalStiffnessByLengthZ;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcModulusOfLinearSubgradeReactionMeasure? @LinearStiffnessByLengthX 
		{ 
			get 
			{
				if(Activated) return _linearStiffnessByLengthX;
				
				Model.Activate(this, true);
				Activated = true;
				return _linearStiffnessByLengthX;
			} 
			set
			{
				SetValue( v =>  _linearStiffnessByLengthX = v, _linearStiffnessByLengthX, value,  "LinearStiffnessByLengthX");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcModulusOfLinearSubgradeReactionMeasure? @LinearStiffnessByLengthY 
		{ 
			get 
			{
				if(Activated) return _linearStiffnessByLengthY;
				
				Model.Activate(this, true);
				Activated = true;
				return _linearStiffnessByLengthY;
			} 
			set
			{
				SetValue( v =>  _linearStiffnessByLengthY = v, _linearStiffnessByLengthY, value,  "LinearStiffnessByLengthY");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcModulusOfLinearSubgradeReactionMeasure? @LinearStiffnessByLengthZ 
		{ 
			get 
			{
				if(Activated) return _linearStiffnessByLengthZ;
				
				Model.Activate(this, true);
				Activated = true;
				return _linearStiffnessByLengthZ;
			} 
			set
			{
				SetValue( v =>  _linearStiffnessByLengthZ = v, _linearStiffnessByLengthZ, value,  "LinearStiffnessByLengthZ");
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcModulusOfRotationalSubgradeReactionMeasure? @RotationalStiffnessByLengthX 
		{ 
			get 
			{
				if(Activated) return _rotationalStiffnessByLengthX;
				
				Model.Activate(this, true);
				Activated = true;
				return _rotationalStiffnessByLengthX;
			} 
			set
			{
				SetValue( v =>  _rotationalStiffnessByLengthX = v, _rotationalStiffnessByLengthX, value,  "RotationalStiffnessByLengthX");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcModulusOfRotationalSubgradeReactionMeasure? @RotationalStiffnessByLengthY 
		{ 
			get 
			{
				if(Activated) return _rotationalStiffnessByLengthY;
				
				Model.Activate(this, true);
				Activated = true;
				return _rotationalStiffnessByLengthY;
			} 
			set
			{
				SetValue( v =>  _rotationalStiffnessByLengthY = v, _rotationalStiffnessByLengthY, value,  "RotationalStiffnessByLengthY");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcModulusOfRotationalSubgradeReactionMeasure? @RotationalStiffnessByLengthZ 
		{ 
			get 
			{
				if(Activated) return _rotationalStiffnessByLengthZ;
				
				Model.Activate(this, true);
				Activated = true;
				return _rotationalStiffnessByLengthZ;
			} 
			set
			{
				SetValue( v =>  _rotationalStiffnessByLengthZ = v, _rotationalStiffnessByLengthZ, value,  "RotationalStiffnessByLengthZ");
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
					_linearStiffnessByLengthX = value.RealVal;
					return;
				case 2: 
					_linearStiffnessByLengthY = value.RealVal;
					return;
				case 3: 
					_linearStiffnessByLengthZ = value.RealVal;
					return;
				case 4: 
					_rotationalStiffnessByLengthX = value.RealVal;
					return;
				case 5: 
					_rotationalStiffnessByLengthY = value.RealVal;
					return;
				case 6: 
					_rotationalStiffnessByLengthZ = value.RealVal;
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