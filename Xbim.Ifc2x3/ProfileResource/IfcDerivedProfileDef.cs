// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 10:20:58
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.GeometryResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.ProfileResource
{
	[EntityName("IFCDERIVEDPROFILEDEF", 390)]
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
		[EntityAttribute(2, EntityAttributeState.Mandatory)]
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
	
		[EntityAttribute(3, EntityAttributeState.Mandatory)]
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
	
		[EntityAttribute(4, EntityAttributeState.Optional)]
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

		#region Inverse attributes

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
		/*WR1:	WR1 : SELF\IfcProfileDef.ProfileType = ParentProfile.ProfileType;*/
		}
		#endregion
	}
}