// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		24.09.2015 10:03:40
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.GeometryResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.ProfileResource
{
	[IndexedClass]
	[ExpressType("IFCDERIVEDPROFILEDEF", 560)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcDerivedProfileDef : IfcProfileDef, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcDerivedProfileDef(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcProfileDef _parentProfile;
		private IfcCartesianTransformationOperator2D _operator;
		private IfcLabel? _label;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcProfileDef @ParentProfile 
		{ 
			get 
			{
				if(Activated) return _parentProfile;
				
				Model.Activate(this, true);
				Activated = true;
				return _parentProfile;
			} 
			set
			{
				SetValue( v =>  _parentProfile = v, _parentProfile, value,  "ParentProfile");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcCartesianTransformationOperator2D @Operator 
		{ 
			get 
			{
				if(Activated) return _operator;
				
				Model.Activate(this, true);
				Activated = true;
				return _operator;
			} 
			set
			{
				SetValue( v =>  _operator = v, _operator, value,  "Operator");
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel? @Label 
		{ 
			get 
			{
				if(Activated) return _label;
				
				Model.Activate(this, true);
				Activated = true;
				return _label;
			} 
			set
			{
				SetValue( v =>  _label = v, _label, value,  "Label");
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
					_parentProfile = (IfcProfileDef)(value.EntityVal);
					return;
				case 3: 
					_operator = (IfcCartesianTransformationOperator2D)(value.EntityVal);
					return;
				case 4: 
					_label = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*InvariantProfileType:	InvariantProfileType : SELF\IfcProfileDef.ProfileType = ParentProfile.ProfileType;*/
		}
		#endregion
	}
}