// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 10:21:00
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.Kernel;
using Xbim.Ifc2x3.UtilityResource;
using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.StructuralLoadResource;
using Xbim.Ifc2x3.GeometryResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.StructuralAnalysisDomain
{
	[EntityName("IFCRELCONNECTSSTRUCTURALMEMBER", 321)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRelConnectsStructuralMember : IfcRelConnects, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelConnectsStructuralMember(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcStructuralMember _relatingStructuralMember;
		private IfcStructuralConnection _relatedStructuralConnection;
		private IfcBoundaryCondition _appliedCondition;
		private IfcStructuralConnectionCondition _additionalConditions;
		private IfcLengthMeasure? _supportedLength;
		private IfcAxis2Placement3D _conditionCoordinateSystem;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Mandatory)]
		public IfcStructuralMember @RelatingStructuralMember 
		{ 
			get 
			{
				if(Activated) return _relatingStructuralMember;
				
				Model.Activate(this, true);
				Activated = true;
				return _relatingStructuralMember;
			} 
			set
			{
				SetValue( v =>  _relatingStructuralMember = v, _relatingStructuralMember, value,  "RelatingStructuralMember");
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Mandatory)]
		public IfcStructuralConnection @RelatedStructuralConnection 
		{ 
			get 
			{
				if(Activated) return _relatedStructuralConnection;
				
				Model.Activate(this, true);
				Activated = true;
				return _relatedStructuralConnection;
			} 
			set
			{
				SetValue( v =>  _relatedStructuralConnection = v, _relatedStructuralConnection, value,  "RelatedStructuralConnection");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Optional)]
		public IfcBoundaryCondition @AppliedCondition 
		{ 
			get 
			{
				if(Activated) return _appliedCondition;
				
				Model.Activate(this, true);
				Activated = true;
				return _appliedCondition;
			} 
			set
			{
				SetValue( v =>  _appliedCondition = v, _appliedCondition, value,  "AppliedCondition");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Optional)]
		public IfcStructuralConnectionCondition @AdditionalConditions 
		{ 
			get 
			{
				if(Activated) return _additionalConditions;
				
				Model.Activate(this, true);
				Activated = true;
				return _additionalConditions;
			} 
			set
			{
				SetValue( v =>  _additionalConditions = v, _additionalConditions, value,  "AdditionalConditions");
			} 
		}
	
		[EntityAttribute(8, EntityAttributeState.Optional)]
		public IfcLengthMeasure? @SupportedLength 
		{ 
			get 
			{
				if(Activated) return _supportedLength;
				
				Model.Activate(this, true);
				Activated = true;
				return _supportedLength;
			} 
			set
			{
				SetValue( v =>  _supportedLength = v, _supportedLength, value,  "SupportedLength");
			} 
		}
	
		[EntityAttribute(9, EntityAttributeState.Optional)]
		public IfcAxis2Placement3D @ConditionCoordinateSystem 
		{ 
			get 
			{
				if(Activated) return _conditionCoordinateSystem;
				
				Model.Activate(this, true);
				Activated = true;
				return _conditionCoordinateSystem;
			} 
			set
			{
				SetValue( v =>  _conditionCoordinateSystem = v, _conditionCoordinateSystem, value,  "ConditionCoordinateSystem");
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
				case 2: 
				case 3: 
					base.Parse(propIndex, value); 
					return;
				case 4: 
					_relatingStructuralMember = (IfcStructuralMember)(value.EntityVal);
					return;
				case 5: 
					_relatedStructuralConnection = (IfcStructuralConnection)(value.EntityVal);
					return;
				case 6: 
					_appliedCondition = (IfcBoundaryCondition)(value.EntityVal);
					return;
				case 7: 
					_additionalConditions = (IfcStructuralConnectionCondition)(value.EntityVal);
					return;
				case 8: 
					_supportedLength = value.RealVal;
					return;
				case 9: 
					_conditionCoordinateSystem = (IfcAxis2Placement3D)(value.EntityVal);
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