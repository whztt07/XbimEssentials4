// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 02:29:24
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.UtilityResource;
using Xbim.Ifc4.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc4.StructuralAnalysisDomain
{
	[EntityName("IFCSTRUCTURALLOADCASE", 632)]
	public  partial class @IfcStructuralLoadCase : IfcStructuralLoadGroup, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcStructuralLoadCase(IModel model) : base(model) 		{ 
			Model = model; 
			_selfWeightCoefficients = new ItemSet<IfcRatioMeasure>( model );
		}

		#region Explicit attribute fields
		private ItemSet<IfcRatioMeasure> _selfWeightCoefficients;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(10, EntityAttributeState.Optional)]
		public ItemSet<IfcRatioMeasure> @SelfWeightCoefficients 
		{ 
			get 
			{
				if(Activated) return _selfWeightCoefficients;
				
				Model.Activate(this, true);
				Activated = true;
				return _selfWeightCoefficients;
			} 
			set
			{
				SetValue( v =>  _selfWeightCoefficients = v, _selfWeightCoefficients, value,  "SelfWeightCoefficients");
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
			"ObjectType",
			"PredefinedType",
			"ActionType",
			"ActionSource",
			"Coefficient",
			"Purpose",
			"SelfWeightCoefficients",
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
					return @ObjectType;
				case 5: 
					return @PredefinedType;
				case 6: 
					return @ActionType;
				case 7: 
					return @ActionSource;
				case 8: 
					return @Coefficient;
				case 9: 
					return @Purpose;
				case 10: 
					return @SelfWeightCoefficients;
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
				case "PredefinedType":  
					return @PredefinedType;
				case "ActionType":  
					return @ActionType;
				case "ActionSource":  
					return @ActionSource;
				case "Coefficient":  
					return @Coefficient;
				case "Purpose":  
					return @Purpose;
				case "SelfWeightCoefficients":  
					return @SelfWeightCoefficients;
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
					 if (value != null) @PredefinedType = (IfcLoadGroupTypeEnum)value;
					 break;
				case 6:
					 if (value != null) @ActionType = (IfcActionTypeEnum)value;
					 break;
				case 7:
					 if (value != null) @ActionSource = (IfcActionSourceTypeEnum)value;
					 break;
				case 8:
					 @Coefficient = (IfcRatioMeasure?)value;
					 break;
				case 9:
					 @Purpose = (IfcLabel?)value;
					 break;
				case 10:
					 @SelfWeightCoefficients = (ItemSet<IfcRatioMeasure>)value;
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
				case "PredefinedType":
					 if (value != null) @PredefinedType = (IfcLoadGroupTypeEnum)value;
					 break;
				case "ActionType":
					 if (value != null) @ActionType = (IfcActionTypeEnum)value;
					 break;
				case "ActionSource":
					 if (value != null) @ActionSource = (IfcActionSourceTypeEnum)value;
					 break;
				case "Coefficient":
					 @Coefficient = (IfcRatioMeasure?)value;
					 break;
				case "Purpose":
					 @Purpose = (IfcLabel?)value;
					 break;
				case "SelfWeightCoefficients":
					 @SelfWeightCoefficients = (ItemSet<IfcRatioMeasure>)value;
					 break;
				default:
					throw new System.IndexOutOfRangeException();
			}
		}
		#endregion

		#region Where rules
		/*IsLoadCasePredefinedType:	IsLoadCasePredefinedType : SELF\IfcStructuralLoadGroup.PredefinedType = IfcLoadGroupTypeEnum.LOAD_CASE;*/
		#endregion

		#region IPersist implementation
		void IPersist.Set(int propIndex, IPropertyValue value)
		{
            throw new System.NotImplementedException();
		}
		#endregion

	}
}