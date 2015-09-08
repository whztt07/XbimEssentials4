// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 02:29:14
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

namespace Xbim.Ifc2x3.StructuralAnalysisDomain
{
	[EntityName("IFCRELCONNECTSSTRUCTURALMEMBER", 462)]
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

		#region Index access
		private readonly List<string> _attributeNames = new List<string>
		{
			"GlobalId",
			"OwnerHistory",
			"Name",
			"Description",
			"RelatingStructuralMember",
			"RelatedStructuralConnection",
			"AppliedCondition",
			"AdditionalConditions",
			"SupportedLength",
			"ConditionCoordinateSystem",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return _attributeNames; } }

		object IInstantiableEntity.GetValue(int index)
		{
			switch(index)
			{
				case 0: 
					return @GlobalId;
				case 1: 
					return @OwnerHistory;
				case 2: 
					return @Name;
				case 3: 
					return @Description;
				case 4: 
					return @RelatingStructuralMember;
				case 5: 
					return @RelatedStructuralConnection;
				case 6: 
					return @AppliedCondition;
				case 7: 
					return @AdditionalConditions;
				case 8: 
					return @SupportedLength;
				case 9: 
					return @ConditionCoordinateSystem;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		object IInstantiableEntity.GetValue(string name)
		{
			switch(name)
			{
				case "GlobalId":  
					return @GlobalId;
				case "OwnerHistory":  
					return @OwnerHistory;
				case "Name":  
					return @Name;
				case "Description":  
					return @Description;
				case "RelatingStructuralMember":  
					return @RelatingStructuralMember;
				case "RelatedStructuralConnection":  
					return @RelatedStructuralConnection;
				case "AppliedCondition":  
					return @AppliedCondition;
				case "AdditionalConditions":  
					return @AdditionalConditions;
				case "SupportedLength":  
					return @SupportedLength;
				case "ConditionCoordinateSystem":  
					return @ConditionCoordinateSystem;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(int index, object value)
		{
			switch(index)
			{
				case 0:
					 if (value != null) @GlobalId = (IfcGloballyUniqueId)value;
					 break;
				case 1:
					 @OwnerHistory = (IfcOwnerHistory)value;
					 break;
				case 2:
					 @Name = (IfcLabel?)value;
					 break;
				case 3:
					 @Description = (IfcText?)value;
					 break;
				case 4:
					 @RelatingStructuralMember = (IfcStructuralMember)value;
					 break;
				case 5:
					 @RelatedStructuralConnection = (IfcStructuralConnection)value;
					 break;
				case 6:
					 @AppliedCondition = (IfcBoundaryCondition)value;
					 break;
				case 7:
					 @AdditionalConditions = (IfcStructuralConnectionCondition)value;
					 break;
				case 8:
					 @SupportedLength = (IfcLengthMeasure?)value;
					 break;
				case 9:
					 @ConditionCoordinateSystem = (IfcAxis2Placement3D)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}

		void IInstantiableEntity.SetValue(string propName, object value)
		{
			switch(propName)
			{
				case "GlobalId":
					 if (value != null) @GlobalId = (IfcGloballyUniqueId)value;
					 break;
				case "OwnerHistory":
					 @OwnerHistory = (IfcOwnerHistory)value;
					 break;
				case "Name":
					 @Name = (IfcLabel?)value;
					 break;
				case "Description":
					 @Description = (IfcText?)value;
					 break;
				case "RelatingStructuralMember":
					 @RelatingStructuralMember = (IfcStructuralMember)value;
					 break;
				case "RelatedStructuralConnection":
					 @RelatedStructuralConnection = (IfcStructuralConnection)value;
					 break;
				case "AppliedCondition":
					 @AppliedCondition = (IfcBoundaryCondition)value;
					 break;
				case "AdditionalConditions":
					 @AdditionalConditions = (IfcStructuralConnectionCondition)value;
					 break;
				case "SupportedLength":
					 @SupportedLength = (IfcLengthMeasure?)value;
					 break;
				case "ConditionCoordinateSystem":
					 @ConditionCoordinateSystem = (IfcAxis2Placement3D)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion


		#region IPersist implementation
		void IPersist.Set(int propIndex, IPropertyValue value)
		{
            throw new System.NotImplementedException();
		}
		#endregion

	}
}