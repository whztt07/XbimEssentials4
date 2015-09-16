// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		16.09.2015 04:23:01
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.Kernel;
using Xbim.Ifc2x3.UtilityResource;
using Xbim.Ifc2x3.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.StructuralAnalysisDomain
{
	[EntityName("IFCSTRUCTURALRESULTGROUP", 532)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcStructuralResultGroup : IfcGroup, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcStructuralResultGroup(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcAnalysisTheoryTypeEnum _theoryType;
		private IfcStructuralLoadGroup _resultForLoadGroup;
		private bool _isLinear;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(5, EntityAttributeState.Mandatory)]
		public IfcAnalysisTheoryTypeEnum @TheoryType 
		{ 
			get 
			{
				if(Activated) return _theoryType;
				
				Model.Activate(this, true);
				Activated = true;
				return _theoryType;
			} 
			set
			{
				SetValue( v =>  _theoryType = v, _theoryType, value,  "TheoryType");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Optional)]
		public IfcStructuralLoadGroup @ResultForLoadGroup 
		{ 
			get 
			{
				if(Activated) return _resultForLoadGroup;
				
				Model.Activate(this, true);
				Activated = true;
				return _resultForLoadGroup;
			} 
			set
			{
				SetValue( v =>  _resultForLoadGroup = v, _resultForLoadGroup, value,  "ResultForLoadGroup");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Mandatory)]
		public bool @IsLinear 
		{ 
			get 
			{
				if(Activated) return _isLinear;
				
				Model.Activate(this, true);
				Activated = true;
				return _isLinear;
			} 
			set
			{
				SetValue( v =>  _isLinear = v, _isLinear, value,  "IsLinear");
			} 
		}
	
		#endregion

		#region Inverse attributes
		public IEnumerable<IfcStructuralAnalysisModel> @ResultGroupFor 
		{ 
			get 
			{
				return Model.Instances.Where<IfcStructuralAnalysisModel>(e => e.HasResults != null &&  e.HasResults.Contains(this));
			} 
		}
	

		#endregion

		#region Index access
		private static readonly List<string> AttributeNames = new List<string>
		{
			"GlobalId",
			"OwnerHistory",
			"Name",
			"Description",
			"ObjectType",
			"TheoryType",
			"ResultForLoadGroup",
			"IsLinear",
		};

		IEnumerable<string> IInstantiableEntity.PropertyNames { get { return AttributeNames; } }

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
					return @ObjectType;
				case 5: 
					return @TheoryType;
				case 6: 
					return @ResultForLoadGroup;
				case 7: 
					return @IsLinear;
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
				case "ObjectType":  
					return @ObjectType;
				case "TheoryType":  
					return @TheoryType;
				case "ResultForLoadGroup":  
					return @ResultForLoadGroup;
				case "IsLinear":  
					return @IsLinear;
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
					 @ObjectType = (IfcLabel?)value;
					 break;
				case 5:
					 if (value != null) @TheoryType = (IfcAnalysisTheoryTypeEnum)value;
					 break;
				case 6:
					 @ResultForLoadGroup = (IfcStructuralLoadGroup)value;
					 break;
				case 7:
					 if (value != null) @IsLinear = (bool)value;
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
				case "ObjectType":
					 @ObjectType = (IfcLabel?)value;
					 break;
				case "TheoryType":
					 if (value != null) @TheoryType = (IfcAnalysisTheoryTypeEnum)value;
					 break;
				case "ResultForLoadGroup":
					 @ResultForLoadGroup = (IfcStructuralLoadGroup)value;
					 break;
				case "IsLinear":
					 if (value != null) @IsLinear = (bool)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
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
				case 2: 
				case 3: 
				case 4: 
					base.Parse(propIndex, value); 
					return;
				case 5: 
                    _theoryType = (IfcAnalysisTheoryTypeEnum) System.Enum.Parse(typeof (IfcAnalysisTheoryTypeEnum), value.EnumVal, true);
					return;
				case 6: 
					_resultForLoadGroup = (IfcStructuralLoadGroup)(value.EntityVal);
					return;
				case 7: 
					_isLinear = value.BooleanVal;
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