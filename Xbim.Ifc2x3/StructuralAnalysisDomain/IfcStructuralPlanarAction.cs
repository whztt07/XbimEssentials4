// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		16.09.2015 04:23:01
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.UtilityResource;
using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.GeometricConstraintResource;
using Xbim.Ifc2x3.RepresentationResource;
using Xbim.Ifc2x3.StructuralLoadResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.StructuralAnalysisDomain
{
	[EntityName("IFCSTRUCTURALPLANARACTION", 39)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcStructuralPlanarAction : IfcStructuralAction, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcStructuralPlanarAction(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcProjectedOrTrueLengthEnum _projectedOrTrue;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(11, EntityAttributeState.Mandatory)]
		public IfcProjectedOrTrueLengthEnum @ProjectedOrTrue 
		{ 
			get 
			{
				if(Activated) return _projectedOrTrue;
				
				Model.Activate(this, true);
				Activated = true;
				return _projectedOrTrue;
			} 
			set
			{
				SetValue( v =>  _projectedOrTrue = v, _projectedOrTrue, value,  "ProjectedOrTrue");
			} 
		}
	
		#endregion

		#region Inverse attributes

		#endregion

		#region Index access
		private static readonly List<string> AttributeNames = new List<string>
		{
			"GlobalId",
			"OwnerHistory",
			"Name",
			"Description",
			"ObjectType",
			"ObjectPlacement",
			"Representation",
			"AppliedLoad",
			"GlobalOrLocal",
			"DestabilizingLoad",
			"CausedBy",
			"ProjectedOrTrue",
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
					return @ObjectPlacement;
				case 6: 
					return @Representation;
				case 7: 
					return @AppliedLoad;
				case 8: 
					return @GlobalOrLocal;
				case 9: 
					return @DestabilizingLoad;
				case 10: 
					return @CausedBy;
				case 11: 
					return @ProjectedOrTrue;
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
				case "ObjectPlacement":  
					return @ObjectPlacement;
				case "Representation":  
					return @Representation;
				case "AppliedLoad":  
					return @AppliedLoad;
				case "GlobalOrLocal":  
					return @GlobalOrLocal;
				case "DestabilizingLoad":  
					return @DestabilizingLoad;
				case "CausedBy":  
					return @CausedBy;
				case "ProjectedOrTrue":  
					return @ProjectedOrTrue;
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
					 @ObjectPlacement = (IfcObjectPlacement)value;
					 break;
				case 6:
					 @Representation = (IfcProductRepresentation)value;
					 break;
				case 7:
					 @AppliedLoad = (IfcStructuralLoad)value;
					 break;
				case 8:
					 if (value != null) @GlobalOrLocal = (IfcGlobalOrLocalEnum)value;
					 break;
				case 9:
					 if (value != null) @DestabilizingLoad = (bool)value;
					 break;
				case 10:
					 @CausedBy = (IfcStructuralReaction)value;
					 break;
				case 11:
					 if (value != null) @ProjectedOrTrue = (IfcProjectedOrTrueLengthEnum)value;
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
				case "ObjectPlacement":
					 @ObjectPlacement = (IfcObjectPlacement)value;
					 break;
				case "Representation":
					 @Representation = (IfcProductRepresentation)value;
					 break;
				case "AppliedLoad":
					 @AppliedLoad = (IfcStructuralLoad)value;
					 break;
				case "GlobalOrLocal":
					 if (value != null) @GlobalOrLocal = (IfcGlobalOrLocalEnum)value;
					 break;
				case "DestabilizingLoad":
					 if (value != null) @DestabilizingLoad = (bool)value;
					 break;
				case "CausedBy":
					 @CausedBy = (IfcStructuralReaction)value;
					 break;
				case "ProjectedOrTrue":
					 if (value != null) @ProjectedOrTrue = (IfcProjectedOrTrueLengthEnum)value;
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
				case 5: 
				case 6: 
				case 7: 
				case 8: 
				case 9: 
				case 10: 
					base.Parse(propIndex, value); 
					return;
				case 11: 
                    _projectedOrTrue = (IfcProjectedOrTrueLengthEnum) System.Enum.Parse(typeof (IfcProjectedOrTrueLengthEnum), value.EnumVal, true);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR61:             * TYPEOF(SELF\IfcStructuralActivity.AppliedLoad)) = 1;*/
		}
		#endregion

		
	}
}