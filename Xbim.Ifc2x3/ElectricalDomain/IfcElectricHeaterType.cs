// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		16.09.2015 04:22:59
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.SharedBldgServiceElements;
using Xbim.Ifc2x3.UtilityResource;
using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.Kernel;
using Xbim.Ifc2x3.GeometryResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.ElectricalDomain
{
	[EntityName("IFCELECTRICHEATERTYPE", 190)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcElectricHeaterType : IfcFlowTerminalType, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcElectricHeaterType(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcElectricHeaterTypeEnum _predefinedType;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(9, EntityAttributeState.Mandatory)]
		public IfcElectricHeaterTypeEnum @PredefinedType 
		{ 
			get 
			{
				if(Activated) return _predefinedType;
				
				Model.Activate(this, true);
				Activated = true;
				return _predefinedType;
			} 
			set
			{
				SetValue( v =>  _predefinedType = v, _predefinedType, value,  "PredefinedType");
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
			"ApplicableOccurrence",
			"HasPropertySets",
			"RepresentationMaps",
			"Tag",
			"ElementType",
			"PredefinedType",
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
					return @ApplicableOccurrence;
				case 5: 
					return @HasPropertySets;
				case 6: 
					return @RepresentationMaps;
				case 7: 
					return @Tag;
				case 8: 
					return @ElementType;
				case 9: 
					return @PredefinedType;
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
				case "ApplicableOccurrence":  
					return @ApplicableOccurrence;
				case "HasPropertySets":  
					return @HasPropertySets;
				case "RepresentationMaps":  
					return @RepresentationMaps;
				case "Tag":  
					return @Tag;
				case "ElementType":  
					return @ElementType;
				case "PredefinedType":  
					return @PredefinedType;
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
					 @ApplicableOccurrence = (IfcLabel?)value;
					 break;
				case 5:
					 @HasPropertySets.Add((IfcPropertySetDefinition)value);
					 break;
				case 6:
					 @RepresentationMaps.Add((IfcRepresentationMap)value);
					 break;
				case 7:
					 @Tag = (IfcLabel?)value;
					 break;
				case 8:
					 @ElementType = (IfcLabel?)value;
					 break;
				case 9:
					 if (value != null) @PredefinedType = (IfcElectricHeaterTypeEnum)value;
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
				case "ApplicableOccurrence":
					 @ApplicableOccurrence = (IfcLabel?)value;
					 break;
				case "HasPropertySets":
					 @HasPropertySets.Add((IfcPropertySetDefinition)value);
					 break;
				case "RepresentationMaps":
					 @RepresentationMaps.Add((IfcRepresentationMap)value);
					 break;
				case "Tag":
					 @Tag = (IfcLabel?)value;
					 break;
				case "ElementType":
					 @ElementType = (IfcLabel?)value;
					 break;
				case "PredefinedType":
					 if (value != null) @PredefinedType = (IfcElectricHeaterTypeEnum)value;
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
					base.Parse(propIndex, value); 
					return;
				case 9: 
                    _predefinedType = (IfcElectricHeaterTypeEnum) System.Enum.Parse(typeof (IfcElectricHeaterTypeEnum), value.EnumVal, true);
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