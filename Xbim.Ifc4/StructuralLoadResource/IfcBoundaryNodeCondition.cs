// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 10:21:06
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
	[EntityName("IFCBOUNDARYNODECONDITION", 50)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcBoundaryNodeCondition : IfcBoundaryCondition, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcBoundaryNodeCondition(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcTranslationalStiffnessSelect _translationalStiffnessX;
		private IfcTranslationalStiffnessSelect _translationalStiffnessY;
		private IfcTranslationalStiffnessSelect _translationalStiffnessZ;
		private IfcRotationalStiffnessSelect _rotationalStiffnessX;
		private IfcRotationalStiffnessSelect _rotationalStiffnessY;
		private IfcRotationalStiffnessSelect _rotationalStiffnessZ;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Optional)]
		public IfcTranslationalStiffnessSelect @TranslationalStiffnessX 
		{ 
			get 
			{
				if(Activated) return _translationalStiffnessX;
				
				Model.Activate(this, true);
				Activated = true;
				return _translationalStiffnessX;
			} 
			set
			{
				SetValue( v =>  _translationalStiffnessX = v, _translationalStiffnessX, value,  "TranslationalStiffnessX");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Optional)]
		public IfcTranslationalStiffnessSelect @TranslationalStiffnessY 
		{ 
			get 
			{
				if(Activated) return _translationalStiffnessY;
				
				Model.Activate(this, true);
				Activated = true;
				return _translationalStiffnessY;
			} 
			set
			{
				SetValue( v =>  _translationalStiffnessY = v, _translationalStiffnessY, value,  "TranslationalStiffnessY");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Optional)]
		public IfcTranslationalStiffnessSelect @TranslationalStiffnessZ 
		{ 
			get 
			{
				if(Activated) return _translationalStiffnessZ;
				
				Model.Activate(this, true);
				Activated = true;
				return _translationalStiffnessZ;
			} 
			set
			{
				SetValue( v =>  _translationalStiffnessZ = v, _translationalStiffnessZ, value,  "TranslationalStiffnessZ");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Optional)]
		public IfcRotationalStiffnessSelect @RotationalStiffnessX 
		{ 
			get 
			{
				if(Activated) return _rotationalStiffnessX;
				
				Model.Activate(this, true);
				Activated = true;
				return _rotationalStiffnessX;
			} 
			set
			{
				SetValue( v =>  _rotationalStiffnessX = v, _rotationalStiffnessX, value,  "RotationalStiffnessX");
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Optional)]
		public IfcRotationalStiffnessSelect @RotationalStiffnessY 
		{ 
			get 
			{
				if(Activated) return _rotationalStiffnessY;
				
				Model.Activate(this, true);
				Activated = true;
				return _rotationalStiffnessY;
			} 
			set
			{
				SetValue( v =>  _rotationalStiffnessY = v, _rotationalStiffnessY, value,  "RotationalStiffnessY");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Optional)]
		public IfcRotationalStiffnessSelect @RotationalStiffnessZ 
		{ 
			get 
			{
				if(Activated) return _rotationalStiffnessZ;
				
				Model.Activate(this, true);
				Activated = true;
				return _rotationalStiffnessZ;
			} 
			set
			{
				SetValue( v =>  _rotationalStiffnessZ = v, _rotationalStiffnessZ, value,  "RotationalStiffnessZ");
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
					_translationalStiffnessX = (IfcTranslationalStiffnessSelect)(value.EntityVal);
					return;
				case 2: 
					_translationalStiffnessY = (IfcTranslationalStiffnessSelect)(value.EntityVal);
					return;
				case 3: 
					_translationalStiffnessZ = (IfcTranslationalStiffnessSelect)(value.EntityVal);
					return;
				case 4: 
					_rotationalStiffnessX = (IfcRotationalStiffnessSelect)(value.EntityVal);
					return;
				case 5: 
					_rotationalStiffnessY = (IfcRotationalStiffnessSelect)(value.EntityVal);
					return;
				case 6: 
					_rotationalStiffnessZ = (IfcRotationalStiffnessSelect)(value.EntityVal);
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